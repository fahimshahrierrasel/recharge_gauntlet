using System.Text.RegularExpressions;

namespace RechargeGauntlet.ATCMD
{
    public enum UssdType
    {
        CheckNumber,
        Recharge
    }
    public static class Ussdcmd
    {
        private static readonly Regex UssdRegex = new Regex("USSD");
        private const string UssdCmd = "AT+CUSD=1,\"USSD\",15\r";

        public static string PrepareCommand(string operatorName, UssdType ussdType)
        {
            string command = null;

            switch (ussdType)
            {
                case UssdType.CheckNumber:
                    command = MobileNumberCommand(operatorName);
                    break;
            }

            return command;
        }

        private static string MobileNumberCommand(string operatorName)
        {
            string numberCommand = null;

            if (operatorName == "airtel")
                numberCommand = UssdRegex.Replace(UssdCmd, Properties.Resources.MNAirtel);
            else if (operatorName == "banglalink")
                numberCommand = UssdRegex.Replace(UssdCmd, Properties.Resources.MNBanglalink);
            else if (operatorName == "grameenphone")
                numberCommand = UssdRegex.Replace(UssdCmd, Properties.Resources.MNGrameenphone);
            else if (operatorName == "robi")
                numberCommand = UssdRegex.Replace(UssdCmd, Properties.Resources.MNRobi);
            else if (operatorName == "teletalk")
                numberCommand = UssdRegex.Replace(UssdCmd, Properties.Resources.MNTeletalk);

            return numberCommand;
        }

        private static string RechargeUssdString(string operatorName, string mobileNumber, double amount, string pin)
        {
            string rechargeUssd = null;
            if(operatorName == "GrameenPhone")
            {
                rechargeUssd = RechargeCMD.GRAMEENPHONE;
            }

            return rechargeUssd;
        }
    }
}
