using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RechargeGauntlet.ATCMD;
using RechargeGauntlet.Modem;

namespace RechargeGauntlet.CustomUI
{
    public partial class ModemLoading : Form
    {
        private List<OperatorModemInfo> _operatorModemInfos;
        private OperatorModemPort _currentOMP;
        public ModemLoading()
        {
            InitializeComponent();
            _operatorModemInfos = new List<OperatorModemInfo>();
        }

        private void ModemLoading_Load(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            MSProgressBar.MarqueeAnimationSpeed = 25;
        }

        private void CheckOperatorModemPorts()
        {
            List<OperatorModemPort> allModemPorts = ModemPortAllocation.GetOperatorModemPorts();
            foreach (var omp in allModemPorts)
            {
                _currentOMP = omp;
                SerialPort serialPort = new SerialPort
                {
                    PortName = _currentOMP.ComPort,
                    BaudRate = 115200,
                    StopBits = StopBits.One,
                    DataBits = 8,
                    Parity = Parity.None,
                    Handshake = Handshake.RequestToSend
                };
                serialPort.DataReceived += ModemPortDataReceived;
                serialPort.Open();
                try
                {
                    var command = Ussdcmd.PrepareCommand(_currentOMP.OperatorName.ToLower(), UssdType.CheckNumber);
                    serialPort.BaseStream.Flush();
                    serialPort.Write(command);
                    serialPort.BaseStream.Flush();
                    Thread.Sleep(2000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private static void ModemPortDataReceived(object sender, SerialDataReceivedEventArgs args)
        {
            var searchResultRegex = new Regex("MSISDN");
            var mobileNumberRegex = new Regex("[0-9]{11,}");
            var sp = (SerialPort) sender;
            try
            {
                while (sp.BytesToRead > 0)
                {
                    var message = sp.ReadExisting();
                    if (searchResultRegex.IsMatch(message))
                    {
                        var tempMobileNumb = mobileNumberRegex.Match(message).Value;
                        var mobileNumber = tempMobileNumb.Substring(tempMobileNumb.Length - 11);

                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                sp.Close();
                sp.Dispose();
            }
        }
    }
}
