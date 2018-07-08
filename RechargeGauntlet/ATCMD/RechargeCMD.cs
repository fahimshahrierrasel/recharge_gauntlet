namespace RechargeGauntlet.ATCMD
{
    public static class RechargeCMD
    {
        /*
        * GP
        * *222*Number*tk*0*Pin#
        * Banglalink
        * *555*Number*Tk*Pin# (Then Press 0 >> 1)
        * Robi
        * *999*Number*Tk*Pin#
        * Airtel
        * *999*Number*Tk*Pin#
        * Teletalk
        * *250*Number*Tk*Pin#
        */
        public const string NUM = "NUM";
        public const string TK = "TK";
        public const string PIN = "PIN";

        public static string TELETALK = $"*250*{NUM}*{TK}*{PIN}#";
        public static string AIRTEL = $"*999*{NUM}*{TK}*{PIN}#";
        public static string ROBI = $"*999*{NUM}*{TK}*{PIN}#";
        public static string GRAMEENPHONE = $"*222*{NUM}*{TK}*0*{PIN}#";  
    }
}
