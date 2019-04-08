using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VRTimer
{
    public partial class ucChangeableTimer : UserControl
    {
        public bool isRunning = false;

        public event EventDataHandler eTimerCheck;
        public ucChangeableTimer()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            //timer_Calc.eStart
            timer_fixed.eStartBtn += TimerStartBtnEvent;
            timer_fixed.eTempDataBridge += Timer_eTempDataBridge;
            timer_Calc.eStartBtn += TimerStartBtnEvent;
            timer_Calc.eTempDataBridge += Timer_eTempDataBridge;
        }

        private void Timer_eTempDataBridge(object sender, EventArgs e, UDT.udtFeeData data)
        {
            eTimerCheck(sender, e, data);
        }

        private void TimerStartBtnEvent(object sender, EventArgs e)
        {
            if (((iTalk.iTalk_Button_2)sender).Text.Equals(Properties.Resources.Start.ToString()))
            {
                cbChangeTimer.Enabled = true;
                isRunning = false;
            }
            else
            {
                cbChangeTimer.Enabled = false;
                isRunning = true;
            }
        }

        private void CbChangeTimer_CheckedChanged(object sender)
        {
            //체크되면 뒷면, 해제하면 앞면
            if (cbChangeTimer.Checked == true)
            {
                timer_Calc.Visible = true;
                timer_fixed.Visible = false;
            }
            else if (cbChangeTimer.Checked == false)
            {
                timer_Calc.Visible = false;
                timer_fixed.Visible = true;
            }
        }

        public void SetSerialNoText(string serialNo)
        {
            lbSerialNo.Text = serialNo;
        }

        public void SetSerialNoTooltipText(string tooltipText)
        {
            toolTip1.ToolTipTitle = "SerialNo";
            toolTip1.SetToolTip(this.lbSerialNo, tooltipText);
        }

        private void LbSerialNo_MouseHover(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
        }
    }
}
