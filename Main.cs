using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VRTimer.UDT;

namespace VRTimer
{
    public partial class Main : Form
    {
        private const int CS_DROPSHADOW = 0x00020000;

        private Timer tmMainWatch;
        public static UDT.udtFeeOption udtFeeOption;
        public static udtStatistics udtStatistics;
        public Main()
        {
            InitializeComponent();
            Init();
            InitEvent();
        }

        private void Init()
        {
            tmMainWatch = new Timer();
            tmMainWatch.Tick += WatchTick;
            tmMainWatch.Interval = 1000;
            tmMainWatch.Start();
            udtStatistics = new udtStatistics();

            tbHalf.Text = Properties.Settings.Default.Half.ToString();
            tbHour.Text = Properties.Settings.Default.Hour.ToString();
            tbPay.Text = Properties.Settings.Default.Min.ToString();

            // 내부 저장소에서 udtStatistics 불러오기
            udtStatistics.totalFee = Properties.Settings.Default.TotalUsedFee;
            udtStatistics.totalUsedTime = Properties.Settings.Default.TotalUsedTime;
            udtStatistics.totalNumOfUses = Properties.Settings.Default.TotalUsedCount;

            ucStatistics.AddData(udtStatistics);

            try
            {
                udtFeeOption = new UDT.udtFeeOption(int.Parse(tbPay.Text), int.Parse(tbHalf.Text), int.Parse(tbHour.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(Properties.Resources.InputPayErrorMessage.ToString());
            }
            ucChangeableTimer1.SetSerialNoText(Properties.Resources.HMD1);
            ucChangeableTimer1.SetSerialNoTooltipText(Properties.Resources.HMD1ToolTip);
            ucChangeableTimer2.SetSerialNoText(Properties.Resources.HMD2);
            ucChangeableTimer2.SetSerialNoTooltipText(Properties.Resources.HMD2ToolTip);
            ucChangeableTimer3.SetSerialNoText(Properties.Resources.HMD3);
            ucChangeableTimer3.SetSerialNoTooltipText(Properties.Resources.HMD3ToolTip);
            ucChangeableTimer4.SetSerialNoText(Properties.Resources.HMD4);
            ucChangeableTimer4.SetSerialNoTooltipText(Properties.Resources.HMD4ToolTip);

        }

        private void InitEvent()
        {
            tbPay.TextChanged += TbPay_TextChanged;
            tbHalf.TextChanged += TbHalf_TextChanged;
            tbHour.TextChanged += TbaHour_TextChanged;
            ucChangeableTimer1.eTimerCheck += eTimerCheck;
            ucChangeableTimer2.eTimerCheck += eTimerCheck;
            ucChangeableTimer3.eTimerCheck += eTimerCheck;
            ucChangeableTimer4.eTimerCheck += eTimerCheck;
        }

        private void eTimerCheck(object sender, EventArgs e, udtFeeData data)
        {
            if ("TIMER".Equals(data.controlInfo))
            {
                // 시간을 어떻게 계산해야 될까...
                // 머리가 안돌아가네
                // 오재영 때문이야 ㅡㅡ
                if (int.Parse(data.usedTime) > 30)
                {
                    // 초과시간 계산 해야될수도있음
                    udtStatistics.totalFee += udtFeeOption.HourlyRateHour;
                    udtStatistics.totalUsedTime += 60;
                }
                else
                {
                    udtStatistics.totalFee += udtFeeOption.HourlyRateHalf;
                    udtStatistics.totalUsedTime += 30;
                }
            }
            else
            {
                udtStatistics.totalFee += int.Parse(data.usedFee);
                udtStatistics.totalUsedTime += int.Parse(data.usedTime);
            }

            udtStatistics.totalNumOfUses++;

            ucStatistics.AddData(udtStatistics);
        }

        /// <summary>
        /// 요금 입력 받을 때 마다 발생
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbPay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                udtFeeOption.FixedRate = int.Parse(tbPay.Text);
                Properties.Settings.Default.Min = int.Parse(tbPay.Text);
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                tbPay.Text = "0";
                MessageBox.Show(Properties.Resources.InputPayErrorMessage.ToString() + "\n" + ex.Message.ToString());
            }
        }

        /// <summary>
        /// 시간 입력 받을 때 마다 발생(30분)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbHalf_TextChanged(object sender, EventArgs e)
        {
            try
            {
                udtFeeOption.HourlyRateHalf = int.Parse(tbHalf.Text);
                Properties.Settings.Default.Half = int.Parse(tbHalf.Text);
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                tbHalf.Text = "0";
                MessageBox.Show(Properties.Resources.InputPayErrorMessage.ToString());
            }
        }

        /// <summary>
        /// 시간 입력 받을 떄 마다 발생(60분)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbaHour_TextChanged(object sender, EventArgs e)
        {
            try
            {
                udtFeeOption.HourlyRateHour = int.Parse(tbHour.Text);
                Properties.Settings.Default.Hour = int.Parse(tbHour.Text);
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                tbHour.Text = "0";
                MessageBox.Show(Properties.Resources.InputPayErrorMessage.ToString());
            }
        }

        /// <summary>
        /// 시계 타이머 틱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WatchTick(object sender, EventArgs e)
        {
            lbTime.Text = System.DateTime.Now.ToString(Properties.Resources.WatchForm.ToString());
        }

        /// <summary>
        /// 종료 버튼 이벤트(맨 오른쪽 위에 있는거)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            // 요금 체크 타이머가 하나라도 돌아간다면 종료 안됨
            if (ucChangeableTimer1.isRunning || ucChangeableTimer2.isRunning || ucChangeableTimer3.isRunning || ucChangeableTimer4.isRunning)
            {
                MessageBox.Show(Properties.Resources.RunningCheck.ToString());
            }
            else
            {
                // 완벽하게 죽여버리기.
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        /// <summary>
        /// 인포 폼 호출 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInfo_Click(object sender, EventArgs e)
        {
            // 정보 폼 호출
            FormInfo formInfo = new FormInfo();
            formInfo.Show();
        }

        /// <summary>
        /// 프로그램 종료 시 클로즈 한다.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            // 타이머 종료
            tmMainWatch.Stop();
            base.OnClosed(e);
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                if (ucChangeableTimer1.isRunning || ucChangeableTimer2.isRunning || ucChangeableTimer3.isRunning || ucChangeableTimer4.isRunning)
                {
                    MessageBox.Show(Properties.Resources.RunningCheck.ToString());
                    e.Handled = true;
                }
            }
        }
        Point mPoint = new Point();
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표를 저장한다.
                mPoint.X = e.X;
                mPoint.Y = e.Y;
            }
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표와 저장된 마우스 좌표의 차이만큼 이동 시킨다.
                this.Location = new Point(this.Location.X + (e.X - mPoint.X)

                , this.Location.Y + (e.Y - mPoint.Y));
            }
        }

        /// <summary>
        /// 그림자 넣기
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
    }
}
