using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VRTimer
{
    public partial class FormInit : Form
    {
        public event EventHandler ePasswordOk;
        string mPassword = "test";

        public FormInit()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            tbRatePersent.Text = Properties.Settings.Default.ProfitRate.ToString();
            CalcRate();
        }

        private void CalcRate()
        {
            try
            {
                if(int.Parse(tbRatePersent.Text) != 0)
                {
                    lbYourRate.Text = (Properties.Settings.Default.TotalUsedFee * (int.Parse(tbRatePersent.Text)/100.0)).ToString();
                    lbMyRate.Text = (Properties.Settings.Default.TotalUsedFee * ((100 - int.Parse(tbRatePersent.Text))/100.0)).ToString();
                }
                else
                {
                    MessageBox.Show("0으로는 나눌 수 없습니다.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnInitOk_Click(object sender, EventArgs e)
        {
            ePasswordOk(sender, e);
        }


        private void FormInit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnInitOk_Click(null, null);
            }
        }

        private void BtnPasswordCheck_Click(object sender, EventArgs e)
        {
            if (mPassword.Equals(tbPassword.Text.ToString()))
            {
                tbRatePersent.Enabled = true;
                btnRateOK.Enabled = true;
                btnInitOk.Enabled = true;
                return;
            }
            else
            {
                MessageBox.Show("비밀번호가 일치 하지 않습니다.");
            }
        }

        private void BtnRateOK_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.ProfitRate = int.Parse(tbRatePersent.Text);
            }
            catch (Exception ex)
            {
                tbRatePersent.Text = Properties.Settings.Default.ProfitRate.ToString();
                MessageBox.Show("이윤률이 저장되지 않았습니다. 현재 이윤률 : " + Properties.Settings.Default.ProfitRate.ToString() + "\n" + ex.Message);
            }
            finally
            {
                Properties.Settings.Default.Save();
                CalcRate();
            }
        }
    }
}
