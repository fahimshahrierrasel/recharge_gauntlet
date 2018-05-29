using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;

namespace RechargeGauntlet.Modem
{
    class SerialModem
    {

        /// <summary>
        /// Get all the ports name of connected modem in the machine both POTS Modem and USB Modem
        /// </summary>
        /// <returns>List of all modem port name</returns>
        public static List<string> GetAllModemPorts()
        {
            List<string> pOTSModems = _GetPOTSModem();
            List<string> allComPorts = _GetAllCOMPorts();
            return allComPorts.Union(pOTSModems).ToList();
        }

        /// <summary>
        /// Get all the ports name of the Connected POTS Modem 
        /// </summary>
        /// <returns></returns>
        private static List<string> _GetPOTSModem()
        {
            List<string> portsList = new List<string>();

            ManagementObjectSearcher modemSearcher =
                new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_POTSModem");

            try
            {
                foreach (ManagementBaseObject mbo in modemSearcher.Get())
                {
                    if (mbo["Status"].Equals("OK"))
                    {
                        portsList.Add(mbo["AttachedTo"].ToString());
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return portsList;
        }

        private static List<string> _GetAllCOMPorts()
        {
            List<string> portList = new List<string>();
            String[] allPorts = SerialPort.GetPortNames();

            foreach (string port in allPorts)
            {
                portList.Add(port);
            }
            return allPorts;
        }
    }
}
