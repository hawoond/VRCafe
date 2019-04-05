using System;
using System.Media;
using System.Windows.Forms;
using VRTimer.UDT;

namespace VRTimer
{
    public delegate void EventHandler(object sender, EventArgs e);
    public delegate void EventDataHandler(object sender, EventArgs e, udtFeeData data);
    public partial class ucTimer : UserControl
    {
        private int nMaxTime = 0;
        private int nDelayTime = 0;

        public event EventHandler eStartBtn;
        public event EventDataHandler eTempDataBridge;
        private SoundPlayer Player = new SoundPlayer();

        private udtFeeData udtFeeData = new udtFeeData();

        public ucTimer()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            tbTime.Text = "30";
            btnStart.Text = Properties.Resources.Start.ToString();
            lbStartTime.Text = "00:00";
            tbExcessTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            tbTime.Enabled = true;
            ProgressbarInit();

            btnStart.Click += BtnStart_Click;
            timerVR.Tick += TimerVR_Tick;
            timerVR.Interval = 1000;
            this.pbxTimerState.Image = global::VRTimer.Properties.Resources.GrayCircle;
        }

        public void ProgressbarInit()
        {
            //pbTimer.Step = 1;
            //pbTimer.Minimum = 0;
            //pbTimer.Value = 0;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (null != tbTime.Text && 0 < tbTime.Text.Length && !"0".Equals(tbTime.Text))
            {
                if (Properties.Resources.End.ToString().Equals(btnStart.Text))
                {
                    this.Player.Stop();
                    btnStart.Text = Properties.Resources.Start.ToString();
                    
                    tbTime.Enabled = true;
                    if (null != timerVR)
                    {
                        timerVR.Stop();
                    }
                    ProgressbarInit();
                    nDelayTime = 0;
                    this.BackColor = System.Drawing.Color.Transparent;
                    this.pbxTimerState.Image = global::VRTimer.Properties.Resources.GrayCircle;

                    udtFeeData = new udtFeeData();

                    udtFeeData.controlInfo = "TIMER";
                    udtFeeData.usedFee = lbTime.Text;
                    udtFeeData.usedTime = tbTime.Text;

                    eTempDataBridge(sender, e, udtFeeData);
                    eStartBtn(sender, e);
                    
                    return;
                }
                else
                {
                    tbExcessTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
                    this.pbxTimerState.Image = global::VRTimer.Properties.Resources.GreenCircle;
                    btnStart.Text = Properties.Resources.End.ToString();
                    tbTime.Enabled = false;
                    string sStartTime = DateTime.Now.ToString(Properties.Resources.StartTimeForm.ToString());
                    lbStartTime.Text = sStartTime;

                    //lbTime.Text = "30";
                    try
                    {
                        nMaxTime = int.Parse(tbTime.Text.ToString()) * 60;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Properties.Resources.InputPayErrorMessage.ToString());
                        return;
                    }
                }

            }
            else
            {
                MessageBox.Show(Properties.Resources.MinimumTimeErrorMessage.ToString());
                return;
            }

            //pbTimer.Maximum = nMaxTime;

            timerVR.Start();
            eStartBtn(sender, e);
        }

        private void TimerVR_Tick(object sender, EventArgs e)
        {
            nDelayTime++;
            lbTime.Text = (nDelayTime / 60).ToString();
         
            if (nMaxTime <= nDelayTime)
            {
                tbExcessTime.Text = ((nDelayTime / 60)- int.Parse(tbTime.Text)).ToString();
                tbExcessTime.ForeColor = System.Drawing.Color.Red;

                if (nMaxTime == nDelayTime)
                {
                    // 리소스에서 사운드 가져와서 재생
                    this.Player.Stream = Properties.Resources.AlarmSound;
                    this.Player.PlayLooping();
                }

                if (nDelayTime % 2 == 1)
                {
                    this.pbxTimerState.Image = global::VRTimer.Properties.Resources.BlueCircle;
                }
                else
                {
                    this.pbxTimerState.Image = global::VRTimer.Properties.Resources.RedCircle;
                }
            }
        }
    }
}
