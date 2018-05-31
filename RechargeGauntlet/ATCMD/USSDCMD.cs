using System.Text.RegularExpressions;

namespace RechargeGauntlet.ATCMD
{
    public enum UssdType
    {
        CheckNumber
    }
    public static class Ussdcmd
    {
        private static readonly Regex CheckNumberRegex = new Regex("USSD");
        private const string CheckNumber = "AT+CUSD=1,\"USSD\",15\r";

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
                numberCommand = CheckNumberRegex.Replace(CheckNumber, Properties.Resources.MNAirtel);
            else if (operatorName == "banglalink")
                numberCommand = CheckNumberRegex.Replace(CheckNumber, Properties.Resources.MNBanglalink);
            else if (operatorName == "grameenphone")
                numberCommand = CheckNumberRegex.Replace(CheckNumber, Properties.Resources.MNGrameenphone);
            else if (operatorName == "robi")
                numberCommand = CheckNumberRegex.Replace(CheckNumber, Properties.Resources.MNRobi);
            else if (operatorName == "teletalk")
                numberCommand = CheckNumberRegex.Replace(CheckNumber, Properties.Resources.MNTeletalk);

            return numberCommand;
        }
    }
}
