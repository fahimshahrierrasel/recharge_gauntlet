using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using RechargeGauntlet.ATCMD;
using RechargeGauntlet.Modem;

namespace RechargeGauntlet.CustomUI
{
    public partial class ModemLoading : Form
    {
        private List<OperatorModemInfo> _operatorModemInfos;
        private List<OperatorModemPort> _operatorModemPorts;
        private int _dataReceived = 0;

        public ModemLoading()
        {
            InitializeComponent();
            _operatorModemInfos = new List<OperatorModemInfo>();
        }

        private void ModemLoading_Load(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            MSProgressBar.MarqueeAnimationSpeed = 25;
        }

        private int CheckOperatorModemPorts()
        {
            _operatorModemPorts = ModemPortAllocation.GetOperatorModemPorts();

            foreach (var omp in _operatorModemPorts.ToList())
            {
                SerialPort serialPort = new SerialPort
                {
                    PortName = omp.ComPort,
                    BaudRate = 115200,
                    StopBits = StopBits.One,
                    DataBits = 8,
                    Parity = Parity.None,
                    Handshake = Handshake.RequestToSend
                };
                serialPort.DataReceived += ModemPortDataReceived;
                serialPort.ErrorReceived += ModemErrorReceived;

                try
                {
                    serialPort.Open();
                    var command = Ussdcmd.PrepareCommand(omp.OperatorName.ToLower(), UssdType.CheckNumber);

                    serialPort.Write(command);

                    while (serialPort.BytesToRead < 0)
                    {
                        
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            while (_dataReceived != _operatorModemPorts.Count)
            {
                
            }
            return 1;
        }

        private void ModemErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            var sp = sender as SerialPort;
            if (sp == null) return;
            Console.WriteLine($@"Error Received at port {sp.PortName}");
            _dataReceived++;
        }

        private void ModemPortDataReceived(object sender, SerialDataReceivedEventArgs args)
        {
            Thread.Sleep(2000);
            var searchResultRegex = new Regex("MSISDN");
            var mobileNumberRegex = new Regex("[0-9]{11,}");
            var sp = (SerialPort)sender;

            try
            {
                while (sp.BytesToRead > 0)
                {
                    var message = sp.ReadExisting();
                    
                    Console.WriteLine(message);
                    if (searchResultRegex.IsMatch(message))
                    {
                        var tempMobileNumb = mobileNumberRegex.Match(message).Value;
                        var mobileNumber = tempMobileNumb.Substring(tempMobileNumb.Length - 11);
                        var operatorName = GetOperatorName(sp.PortName);
                        _operatorModemInfos.Add(new OperatorModemInfo(operatorName, sp.PortName, mobileNumber));
                    }
                    _dataReceived++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                sp.Close();
            }
        }

        private void ModemLoading_Shown(object sender, EventArgs e)
        {
            ModemBackgroundWorker.RunWorkerAsync();
        }

        private void ModemBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var bw = sender as BackgroundWorker;
            e.Result = CheckOperatorModemPorts();
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void ModemBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(@"Something went wrong!!!");
            }
            else if (e.Cancelled)
            {
                MessageBox.Show(@"Something went wrong!!!");
            }
            else
            {
                Hide();
                var rechargeForm = new RechargeForm(_operatorModemInfos);
                rechargeForm.Closed += (s, args) => this.Close();
                rechargeForm.Show();
            }
        }

        private string GetOperatorName(string portName)
        {
            var operatorName = "";
            foreach (var operatorModemPort in _operatorModemPorts)
            {
                if (operatorModemPort.ComPort != portName) continue;
                operatorName = operatorModemPort.OperatorName;
                break;
            }
            return operatorName;
        }
    }
}