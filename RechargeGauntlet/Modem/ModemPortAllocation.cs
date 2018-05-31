using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace RechargeGauntlet.Modem
{
    class ModemPortAllocation
    {
        private static List<OperatorModemPort> _operatorModemPorts;

        /// <summary>
        /// Initialize the all the ports in SerialPort for getting the Operator name
        /// and their modem port.
        /// </summary>
        private static void InitializeOperatorModemPorts()
        {
            List<string> availablePorts = SerialModem.GetAllModemPorts();

            foreach (string port in availablePorts)
            {
                SerialPort serialPort = new SerialPort
                {
                    PortName = port,
                    BaudRate = 115200,
                    StopBits = StopBits.One,
                    DataBits = 8,
                    Parity = Parity.None,
                    Handshake = Handshake.RequestToSend
                };
                serialPort.DataReceived += PortOnReceivedData;
                serialPort.Open();
                try
                {
                    serialPort.BaseStream.Flush();
                    serialPort.Write("AT+COPS?\r");
                    serialPort.BaseStream.Flush();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        // SerialPort DataReceivedHandler it will filter ther operatort name from the out put of the AT Command
        private static void PortOnReceivedData(object sender, SerialDataReceivedEventArgs e)
        {
            var operatorNameRegex = new Regex("\"([A-Za-z])+\"");
            SerialPort sp = (SerialPort) sender;
            try
            {
                while (sp.BytesToRead > 0)
                {
                    string message = sp.ReadExisting();
                    if (Regex.IsMatch(message, @"OK"))
                    {
                        string operatorName = operatorNameRegex.Match(message).Value.Replace("\"", string.Empty);
                        _operatorModemPorts.Add(new OperatorModemPort(operatorName, sp.PortName));
                    }
                }
            }
            catch (TimeoutException te)
            {
                Console.WriteLine(te);
            }
            finally
            {
                sp.Close();
                sp.Dispose();
            }
        }

        /// <summary>
        /// Get All the operator and the modem ports number
        /// </summary>
        /// <returns>Returns OperatorName and the Port Number where the modem are connected.</returns>
        public static List<OperatorModemPort> GetOperatorModemPorts()
        {
            _operatorModemPorts = new List<OperatorModemPort>();
            _operatorModemPorts.Clear();
            InitializeOperatorModemPorts();
            return _operatorModemPorts;
        }
    }
}