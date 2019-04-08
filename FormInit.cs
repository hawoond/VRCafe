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
          //  btnInitOk.Click += BtnInitOk_Click;
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
                tbRatePersent.Text = "0";
                MessageBox.Show(Properties.Resources.InputPayErrorMessage.ToString());
            }
        }
    }
}
