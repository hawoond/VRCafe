using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VRTimer.UDT;

namespace VRTimer
{
   
    public partial class ucTimerCalc : UserControl
    {
        private int nMaxTime = 0;
        private int nDelayTime = 0;

        private int mFee;

        public event EventHandler eStartBtn;
        public event EventDataHandler eTempDataBridge;

        private udtFeeData udtFeeData = new udtFeeData();

        public ucTimerCalc()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            btnStart.Text = Properties.Resources.Start.ToString();
            lbStartTime.Text = "00:00";
            lbRunning.Visible = false;

            this.pbxTimerState.Image = Properties.Resources.GrayCircle;

            btnStart.Click += BtnStart_Click;
            timerVR.Tick += TimerVR_Tick;
            timerVR.Interval = 1000;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            mFee = Main.udtFeeOption.FixedRate;
            
            if (null != mFee && 0 < mFee)
            {
                if (Properties.Resources.End.ToString().Equals(btnStart.Text))
                {
                    lbRunning.Visible = false;
                    btnStart.Text = Properties.Resources.Start.ToString();
                    this.pbxTimerState.Image = Properties.Resources.GrayCircle;
                    if (null != timerVR)
                    {
                        timerVR.Stop();
                    }

                    udtFeeData.controlInfo = "TIMER_CALC";
                    udtFeeData.usedFee = lbPay.Text;
                    udtFeeData.usedTime = lbTime.Text;

                    // 데이터 넘기기 이벤트
                    eTempDataBridge(sender, e, udtFeeData);

                    // 상위 유저 컨트롤에 버튼 클릭 이벤트 발생 시키기
                    eStartBtn(sender, e);
                    this.BackColor = System.Drawing.Color.Transparent;
                    return;
                }
                else
                {
                    // 시작 눌렀을 때
                    lbRunning.Visible = true;
                    nDelayTime = 0;
                    btnStart.Text = Properties.Resources.End.ToString();
                    this.pbxTimerState.Image = Properties.Resources.GreenCircle;
                    //lbTime.Text = "30";
                    string sStartTime = DateTime.Now.ToString("HH:mm");
                    lbStartTime.Text = sStartTime;
                    try
                    {
                        nMaxTime = mFee * 60;
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
                MessageBox.Show(Properties.Resources.InputPayErrorMessage.ToString());
                return;
            }

            timerVR.Start();
            eStartBtn(sender, e);
        }

        private void TimerVR_Tick(object sender, EventArgs e)
        {
            nDelayTime++;

            lbTime.Text = (nDelayTime / 60).ToString();

            lbPay.Text = ((nDelayTime / 60)* mFee).ToString();
        }
    }
}
