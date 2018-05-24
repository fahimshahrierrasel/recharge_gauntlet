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
}
