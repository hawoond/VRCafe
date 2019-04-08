﻿namespace VRTimer
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
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.No;
            this.tbPassword.Location = new System.Drawing.Point(13, 23);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '♥';
            this.tbPassword.Size = new System.Drawing.Size(175, 21);
            this.tbPassword.TabIndex = 0;
            // 
            // btnInitOk
            // 
            this.btnInitOk.Enabled = false;
            this.btnInitOk.Location = new System.Drawing.Point(194, 70);
            this.btnInitOk.Name = "btnInitOk";
            this.btnInitOk.Size = new System.Drawing.Size(75, 23);
            this.btnInitOk.TabIndex = 1;
            this.btnInitOk.Text = "초기화";
            this.btnInitOk.UseVisualStyleBackColor = true;
            this.btnInitOk.Click += new System.EventHandler(this.BtnInitOk_Click);
            // 
            // btnPasswordCheck
            // 
            this.btnPasswordCheck.Location = new System.Drawing.Point(194, 22);
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
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "이윤률";
            // 
            // tbRatePersent
            // 
            this.tbRatePersent.Cursor = System.Windows.Forms.Cursors.No;
            this.tbRatePersent.Enabled = false;
            this.tbRatePersent.Location = new System.Drawing.Point(12, 71);
            this.tbRatePersent.Name = "tbRatePersent";
            this.tbRatePersent.Size = new System.Drawing.Size(74, 21);
            this.tbRatePersent.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "%";
            // 
            // btnRateOK
            // 
            this.btnRateOK.Enabled = false;
            this.btnRateOK.Location = new System.Drawing.Point(113, 70);
            this.btnRateOK.Name = "btnRateOK";
            this.btnRateOK.Size = new System.Drawing.Size(75, 23);
            this.btnRateOK.TabIndex = 6;
            this.btnRateOK.Text = "적용";
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
            // FormInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 107);
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
    }
}