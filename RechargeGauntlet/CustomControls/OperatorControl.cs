using RechargeGauntlet.ATCMD;
using System;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RechargeGauntlet.CustomControls
{
    public partial class OperatorControl : UserControl
    {
        private SerialPort _serialPort;
        private readonly string _portNumber;
        public string OperatorName { get; }
        private readonly string _operatorName;
        private readonly string _mobileNumber;

        public OperatorControl(string portNumber, string operatorName, string mobileNumber)
        {
            _portNumber = portNumber;
            _operatorName = operatorName;
            _mobileNumber = mobileNumber;
            OperatorName = operatorName;
            InitializeComponent();
        }

        private void OperatorControl_Load(object sender, EventArgs e)
        {
            InitializeModemSerialPort(_portNumber);
            QueryForNetworkStrength();
            SetOperatorLogo(_operatorName);
            LabelMobileNumber.Text = _mobileNumber;
        }

        private void InitializeModemSerialPort(string port)
        {
            _serialPort = new SerialPort
            {
                PortName = port,
                BaudRate = 115200,
                StopBits = StopBits.One,
                DataBits = 8,
                Parity = Parity.None,
                Handshake = Handshake.RequestToSend
            };
            _serialPort.DataReceived += ModemDataReceived;
            _serialPort.Open();
        }

        private void ModemDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var sp = (SerialPort)sender;
            try
            {
                while (sp.BytesToRead > 0)
                {
                    var message = sp.ReadExisting();
                    if (!string.IsNullOrEmpty(message))
                    {
                        ReceivedDataAnalyzer(message);
                    }
                }
            }
            catch (TimeoutException te)
            {
                Console.WriteLine(te);
            }
        }

        private void ReceivedDataAnalyzer(string message)
        {
            if (Regex.IsMatch(message, "OK"))
            {
                if (Regex.IsMatch(message, @"ZRSSI"))
                {
                    SetNetworkBar(message);
                }
            }
        }

        private void SetNetworkBar(string message)
        {
            /*
             * strength < -110 is 0 bar
             * -110 >= strength > -95 is 1 bar
             * -95 >= strength > -85 is 2 bar
             * -85 >= strength > -70 is 3 bar
             * -70 >= strength > -60 is 4 bar
             * -60 >= strength is 5 bar
            */
            var actulResult = Regex.Replace(message, @"\+|AT|ZRSSI|:|OK|\s+", string.Empty);
            string[] results = actulResult.Split(',');
            var networkStrength = 120;
            if (short.TryParse(results[0], out var ns))
            {
                networkStrength = Math.Abs(ns);
            }

            if (networkStrength > 110)
            {
                PictureSignalBar.Image = Properties.Resources.sigbar0;
            }
            else if (networkStrength > 95 && networkStrength <= 110)
            {
                PictureSignalBar.Image = Properties.Resources.sigbar1;
            }
            else if (networkStrength > 85 && networkStrength <= 95)
            {
                PictureSignalBar.Image = Properties.Resources.sigbar2;
            }
            else if (networkStrength > 70 && networkStrength <= 85)
            {
                PictureSignalBar.Image = Properties.Resources.sigbar3;
            }
            else if (networkStrength > 40 && networkStrength <= 70)
            {
                PictureSignalBar.Image = Properties.Resources.sigbar4;
            }
            else
            {
                PictureSignalBar.Image = Properties.Resources.sigbar5;
            }
        }

        public void SetOperatorLogo(string operatorName)
        {
            switch (operatorName)
            {
                case "Grameenphone":
                    PirtureOperatorLogo.Image = Properties.Resources.gp;
                    break;
                case "Banglalink":
                    PirtureOperatorLogo.Image = Properties.Resources.banglalink;
                    break;
                case "Robi":
                    PirtureOperatorLogo.Image = Properties.Resources.robi;
                    break;
                case "Airtel":
                    PirtureOperatorLogo.Image = Properties.Resources.airtel;
                    break;
                case "Teletalk":
                    PirtureOperatorLogo.Image = Properties.Resources.teletalk;
                    break;
            }
        }

        public void QueryForNetworkStrength()
        {
            try
            {
                _serialPort.BaseStream.Flush();
                _serialPort.Write("AT+ZRSSI\r");
                _serialPort.BaseStream.Flush();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void RechargeMoney(string mobileNumber, double amount, int times)
        {
            Console.WriteLine( Ussdcmd.RechargeCommand(_operatorName, mobileNumber, amount, "1234"));
        }
    }
}
