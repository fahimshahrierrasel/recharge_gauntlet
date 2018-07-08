using System.Text.RegularExpressions;

namespace RechargeGauntlet.ATCMD
{
    public static class Ussdcmd
    {
        private static readonly Regex UssdRegex = new Regex("USSD");
        private const string UssdCmd = "AT+CUSD=1,\"USSD\",15\r";
       
        public static string MobileNumberCommand(string operatorName)
        {
            string numberCommand = null;
            switch (operatorName.ToLower())
            {
                case "airtel":
                    numberCommand = UssdRegex.Replace(UssdCmd, Properties.Resources.MNAirtel);
                    break;
                case "banglalink":
                    numberCommand = UssdRegex.Replace(UssdCmd, Properties.Resources.MNBanglalink);
                    break;
                case "grameenphone":
                    numberCommand = UssdRegex.Replace(UssdCmd, Properties.Resources.MNGrameenphone);
                    break;
                case "robi":
                    numberCommand = UssdRegex.Replace(UssdCmd, Properties.Resources.MNRobi);
                    break;
                case "teletalk":
                    numberCommand = UssdRegex.Replace(UssdCmd, Properties.Resources.MNTeletalk);
                    break;
            }

            return numberCommand;
        }

        public static string RechargeCommand(string operatorName, string mobileNumber, double amount, string pin)
        {
            string rechargeCommand = null;
            switch (operatorName.ToLower())
            {
                case "grameenphone":
                    rechargeCommand = RechargeCMD.GRAMEENPHONE;
                    break;
                case "robi":
                    rechargeCommand = RechargeCMD.ROBI;
                    break;
                case "airtel":
                    rechargeCommand = RechargeCMD.AIRTEL;
                    break;
                case "teletalk":
                    rechargeCommand = RechargeCMD.TELETALK;
                    break;
            }
            if(!string.IsNullOrEmpty(rechargeCommand))
            {
                rechargeCommand.Replace(RechargeCMD.NUM, mobileNumber);
                rechargeCommand.Replace(RechargeCMD.TK, amount.ToString());
                rechargeCommand.Replace(RechargeCMD.PIN, pin);
            }

            return rechargeCommand;
        }


    }
}
