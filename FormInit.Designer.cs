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
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.No;
            this.tbPassword.Location = new System.Drawing.Point(13, 7);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '♥';
            this.tbPassword.Size = new System.Drawing.Size(296, 21);
            this.tbPassword.TabIndex = 0;
            // 
            // btnInitOk
            // 
            this.btnInitOk.Location = new System.Drawing.Point(316, 7);
            this.btnInitOk.Name = "btnInitOk";
            this.btnInitOk.Size = new System.Drawing.Size(75, 23);
            this.btnInitOk.TabIndex = 1;
            this.btnInitOk.Text = "초기화";
            this.btnInitOk.UseVisualStyleBackColor = true;
            this.btnInitOk.Click += new System.EventHandler(this.BtnInitOk_Click);
            // 
            // FormInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 38);
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
    }
}