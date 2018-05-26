using System;
using System.Collections.Generic;
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
            List<string> ports = new List<string>();
            ports.AddRange(GetPOTSModem());
            return ports;
        }

        /// <summary>
        /// Get all the ports name of the Connected POTS Modem 
        /// </summary>
        /// <returns></returns>
        private static List<string> GetPOTSModem()
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
    }
}
