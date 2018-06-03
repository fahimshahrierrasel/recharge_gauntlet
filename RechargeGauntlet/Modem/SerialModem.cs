using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;

namespace RechargeGauntlet.Modem
{
    internal class SerialModem
    {

        /// <summary>
        /// Get all the ports name of connected modem in the machine both POTS Modem and USB Modem
        /// </summary>
        /// <returns>List of all modem port name</returns>
        public static List<string> GetAllModemPorts()
        {
            var potsModem = _GetPOTSModem();
            var allComPorts = _GetAllCOMPorts();
            return allComPorts.Union(potsModem).ToList();
        }

        /// <summary>
        /// Get all the ports name of the Connected POTS Modem 
        /// </summary>
        /// <returns>List of POTS modem Ports</returns>
        private static List<string> _GetPOTSModem()
        {
            List<string> portList = new List<string>();

            ManagementObjectSearcher modemSearcher =
                new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_POTSModem");

            try
            {
                foreach (ManagementBaseObject mbo in modemSearcher.Get())
                {
                    if (mbo["Status"].Equals("OK"))
                    {
                        portList.Add(mbo["AttachedTo"].ToString());
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return portList;
        }

        /// <summary>
        /// Get All the COM ports of the system
        /// </summary>
        /// <returns>List of Ports</returns>
        private static List<string> _GetAllCOMPorts()
        {
            var allPorts = SerialPort.GetPortNames();

            return allPorts.ToList();
        }
    }
}
