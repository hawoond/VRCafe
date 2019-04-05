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
    public partial class ucStatistics : UserControl
    {
        FormInit formInit = new FormInit();
        int nClickCount = 0;
        public ucStatistics()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            formInit.ePasswordOk += FormInit_ePasswordOk;
        }

        public bool AddData(UDT.udtStatistics feeData)
        {
            //try
            //{
            //    Main.udtStatistics.totalFee = nFee;
            //    Main.udtStatistics.totalUsedTime = nUsedTime;
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(Properties.Resources.CalcFeeError.ToString());
            //    return false;
            //}
            SetData(feeData.totalFee, feeData.totalUsedTime, feeData.totalNumOfUses);
            return true; ;
        }

        /// <summary>
        /// 요금 관련 데이터 저장 함수
        /// </summary>
        /// <param name="nTotalFee">총 사용 요금</param>
        /// <param name="nTotalUserTime">총 사용 시간</param>
        private void SetData(int nTotalFee, int nTotalUserTime, int nNumOfUses)
        {
            // 이윤율 7:3

            tbTotlaFee.Text = nTotalFee.ToString();
            tbTotlaHour.Text = nTotalUserTime.ToString();
            tbNumOfUses.Text = nNumOfUses.ToString();

            Properties.Settings.Default.TotalUsedFee = nTotalFee;
            Properties.Settings.Default.TotalUsedTime = nTotalUserTime;
            Properties.Settings.Default.TotalUsedCount = nNumOfUses;
            Properties.Settings.Default.Save();

            int nCalcPay = nTotalFee * Properties.Settings.Default.ProfitRate / 100;
            int nCalcProfit = nTotalFee * (100 - Properties.Settings.Default.ProfitRate) / 100;
            tbProfitFee.Text = nCalcProfit.ToString();
            tbPayment.Text = nCalcPay.ToString();
        }

        private void ITalk_Label9_Click(object sender, EventArgs e)
        {
            nClickCount++;
            if (nClickCount == 10)
            {
                nClickCount = 0;

                formInit = new FormInit();
                formInit.ePasswordOk += FormInit_ePasswordOk;
                formInit.Show();
            }
        }

        private void FormInit_ePasswordOk(object sender, EventArgs e)
        {
            Properties.Settings.Default.TotalUsedFee = 0;
            Properties.Settings.Default.TotalUsedTime = 0;
            Properties.Settings.Default.TotalUsedCount = 0;
            Properties.Settings.Default.Save();

            Main.udtStatistics = new UDT.udtStatistics();

            SetData(0, 0, 0);
        }
    }


}
