namespace VRTimer
{
    partial class FormInit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnInitOk = new System.Windows.Forms.Button();
            this.btnPasswordCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRatePersent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRateOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMyRate = new System.Windows.Forms.Label();
            this.lbYourRate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAlarm = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.No;
            this.tbPassword.Location = new System.Drawing.Point(13, 25);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '♥';
            this.tbPassword.Size = new System.Drawing.Size(153, 21);
            this.tbPassword.TabIndex = 0;
            // 
            // btnInitOk
            // 
            this.btnInitOk.Enabled = false;
            this.btnInitOk.Location = new System.Drawing.Point(95, 181);
            this.btnInitOk.Name = "btnInitOk";
            this.btnInitOk.Size = new System.Drawing.Size(75, 23);
            this.btnInitOk.TabIndex = 1;
            this.btnInitOk.Text = "초기화";
            this.btnInitOk.UseVisualStyleBackColor = true;
            this.btnInitOk.Click += new System.EventHandler(this.BtnInitOk_Click);
            // 
            // btnPasswordCheck
            // 
            this.btnPasswordCheck.Location = new System.Drawing.Point(172, 24);
            this.btnPasswordCheck.Name = "btnPasswordCheck";
            this.btnPasswordCheck.Size = new System.Drawing.Size(75, 23);
            this.btnPasswordCheck.TabIndex = 2;
            this.btnPasswordCheck.Text = "확인";
            this.btnPasswordCheck.UseVisualStyleBackColor = true;
            this.btnPasswordCheck.Click += new System.EventHandler(this.BtnPasswordCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "지불률";
            // 
            // tbRatePersent
            // 
            this.tbRatePersent.Cursor = System.Windows.Forms.Cursors.No;
            this.tbRatePersent.Enabled = false;
            this.tbRatePersent.Location = new System.Drawing.Point(13, 77);
            this.tbRatePersent.Name = "tbRatePersent";
            this.tbRatePersent.Size = new System.Drawing.Size(74, 21);
            this.tbRatePersent.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "%";
            // 
            // btnRateOK
            // 
            this.btnRateOK.Enabled = false;
            this.btnRateOK.Location = new System.Drawing.Point(114, 76);
            this.btnRateOK.Name = "btnRateOK";
            this.btnRateOK.Size = new System.Drawing.Size(75, 23);
            this.btnRateOK.TabIndex = 6;
            this.btnRateOK.Text = "계산";
            this.btnRateOK.UseVisualStyleBackColor = true;
            this.btnRateOK.Click += new System.EventHandler(this.BtnRateOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "비밀번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "지불 금액";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "이익 금액(사용자)";
            // 
            // lbMyRate
            // 
            this.lbMyRate.Location = new System.Drawing.Point(124, 153);
            this.lbMyRate.Name = "lbMyRate";
            this.lbMyRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbMyRate.Size = new System.Drawing.Size(103, 12);
            this.lbMyRate.TabIndex = 10;
            this.lbMyRate.Text = "0";
            // 
            // lbYourRate
            // 
            this.lbYourRate.Location = new System.Drawing.Point(133, 112);
            this.lbYourRate.Name = "lbYourRate";
            this.lbYourRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbYourRate.Size = new System.Drawing.Size(94, 12);
            this.lbYourRate.TabIndex = 11;
            this.lbYourRate.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "원";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "원";
            // 
            // cbAlarm
            // 
            this.cbAlarm.AutoSize = true;
            this.cbAlarm.Location = new System.Drawing.Point(205, 79);
            this.cbAlarm.Name = "cbAlarm";
            this.cbAlarm.Size = new System.Drawing.Size(48, 16);
            this.cbAlarm.TabIndex = 14;
            this.cbAlarm.Text = "알람";
            this.cbAlarm.UseVisualStyleBackColor = true;
            this.cbAlarm.CheckedChanged += new System.EventHandler(this.CbAlarm_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Enabled = false;
            this.btnExit.Location = new System.Drawing.Point(172, 181);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FormInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 214);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbAlarm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbYourRate);
            this.Controls.Add(this.lbMyRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRateOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRatePersent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPasswordCheck);
            this.Controls.Add(this.btnInitOk);
            this.Controls.Add(this.tbPassword);
            this.KeyPreview = true;
            this.Name = "FormInit";
            this.Text = "초기화";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInit_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnInitOk;
        private System.Windows.Forms.Button btnPasswordCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRatePersent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRateOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMyRate;
        private System.Windows.Forms.Label lbYourRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbAlarm;
        private System.Windows.Forms.Button btnExit;
    }
}