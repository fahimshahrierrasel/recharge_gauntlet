namespace RechargeGauntlet.Modem
{
    public struct OperatorModemPort
    {
        public string OperatorName, ComPort;

        public OperatorModemPort(string operatorName, string comPort)
        {
            OperatorName = operatorName;
            ComPort = comPort;
        }
    }

    public struct OperatorModemInfo
    {
        public string OperatorName, ComPort, MobileNumber;

        public OperatorModemInfo(string operatorName, string comPort, string mobileNumber)
        {
            OperatorName = operatorName;
            ComPort = comPort;
            MobileNumber = mobileNumber;
        }

        public OperatorModemInfo(OperatorModemPort omp, string mobileNumber)
        {
            OperatorName = omp.OperatorName;
            ComPort = omp.ComPort;
            MobileNumber = mobileNumber;
        }
    }
}
