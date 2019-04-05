namespace VRTimer
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucStatistics = new VRTimer.ucStatistics();
            this.btnExit = new iTalk.iTalk_Label();
            this.btnInfo = new iTalk.iTalk_Icon_Info();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.lbTime = new iTalk.iTalk_Label();
            this.iTalk_GroupBox1 = new iTalk.iTalk_GroupBox();
            this.tbaHour = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.tbHalf = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label5 = new iTalk.iTalk_Label();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.tbPay = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.label3 = new iTalk.iTalk_Label();
            this.label2 = new iTalk.iTalk_Label();
            this.ucChangeableTimer4 = new VRTimer.ucChangeableTimer();
            this.ucChangeableTimer3 = new VRTimer.ucChangeableTimer();
            this.ucChangeableTimer2 = new VRTimer.ucChangeableTimer();
            this.ucChangeableTimer1 = new VRTimer.ucChangeableTimer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.iTalk_GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VRTimer.Properties.Resources.VR_Cafe;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // ucStatistics
            // 
            this.ucStatistics.BackColor = System.Drawing.Color.White;
            this.ucStatistics.Location = new System.Drawing.Point(13, 357);
            this.ucStatistics.Name = "ucStatistics";
            this.ucStatistics.Size = new System.Drawing.Size(736, 153);
            this.ucStatistics.TabIndex = 51;
            this.ucStatistics.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.btnExit.Location = new System.Drawing.Point(713, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 47);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.White;
            this.btnInfo.ForeColor = System.Drawing.Color.DimGray;
            this.btnInfo.Location = new System.Drawing.Point(674, 9);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(33, 33);
            this.btnInfo.TabIndex = 49;
            this.btnInfo.Text = "iTalk_Icon_Info1";
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            this.btnInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(59, 6);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(133, 40);
            this.iTalk_HeaderLabel1.TabIndex = 45;
            this.iTalk_HeaderLabel1.Text = "고객관리";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbTime.Location = new System.Drawing.Point(646, 78);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(89, 30);
            this.lbTime.TabIndex = 35;
            this.lbTime.Text = "15:21:00";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.tbaHour);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label3);
            this.iTalk_GroupBox1.Controls.Add(this.tbHalf);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label5);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label4);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label2);
            this.iTalk_GroupBox1.Controls.Add(this.tbPay);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Label1);
            this.iTalk_GroupBox1.Controls.Add(this.label3);
            this.iTalk_GroupBox1.Controls.Add(this.label2);
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(20, 57);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(609, 66);
            this.iTalk_GroupBox1.TabIndex = 40;
            this.iTalk_GroupBox1.Text = "요금 설정";
            this.iTalk_GroupBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            // 
            // tbaHour
            // 
            this.tbaHour.BackColor = System.Drawing.Color.Transparent;
            this.tbaHour.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbaHour.ForeColor = System.Drawing.Color.DimGray;
            this.tbaHour.Location = new System.Drawing.Point(485, 31);
            this.tbaHour.MaxLength = 32767;
            this.tbaHour.Multiline = false;
            this.tbaHour.Name = "tbaHour";
            this.tbaHour.ReadOnly = false;
            this.tbaHour.Size = new System.Drawing.Size(50, 26);
            this.tbaHour.TabIndex = 24;
            this.tbaHour.Text = "500";
            this.tbaHour.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbaHour.UseSystemPasswordChar = false;
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(444, 37);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(35, 13);
            this.iTalk_Label3.TabIndex = 26;
            this.iTalk_Label3.Text = "1시간";
            this.iTalk_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbHalf
            // 
            this.tbHalf.BackColor = System.Drawing.Color.Transparent;
            this.tbHalf.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbHalf.ForeColor = System.Drawing.Color.DimGray;
            this.tbHalf.Location = new System.Drawing.Point(362, 31);
            this.tbHalf.MaxLength = 32767;
            this.tbHalf.Multiline = false;
            this.tbHalf.Name = "tbHalf";
            this.tbHalf.ReadOnly = false;
            this.tbHalf.Size = new System.Drawing.Size(50, 26);
            this.tbHalf.TabIndex = 24;
            this.tbHalf.Text = "500";
            this.tbHalf.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbHalf.UseSystemPasswordChar = false;
            // 
            // iTalk_Label5
            // 
            this.iTalk_Label5.AutoSize = true;
            this.iTalk_Label5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label5.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label5.Location = new System.Drawing.Point(537, 37);
            this.iTalk_Label5.Name = "iTalk_Label5";
            this.iTalk_Label5.Size = new System.Drawing.Size(18, 13);
            this.iTalk_Label5.TabIndex = 26;
            this.iTalk_Label5.Text = "원";
            this.iTalk_Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label4.Location = new System.Drawing.Point(414, 37);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(18, 13);
            this.iTalk_Label4.TabIndex = 26;
            this.iTalk_Label4.Text = "원";
            this.iTalk_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(326, 37);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(30, 13);
            this.iTalk_Label2.TabIndex = 26;
            this.iTalk_Label2.Text = "30분";
            this.iTalk_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPay
            // 
            this.tbPay.BackColor = System.Drawing.Color.Transparent;
            this.tbPay.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPay.ForeColor = System.Drawing.Color.DimGray;
            this.tbPay.Location = new System.Drawing.Point(117, 31);
            this.tbPay.MaxLength = 32767;
            this.tbPay.Multiline = false;
            this.tbPay.Name = "tbPay";
            this.tbPay.ReadOnly = false;
            this.tbPay.Size = new System.Drawing.Size(50, 26);
            this.tbPay.TabIndex = 24;
            this.tbPay.Text = "500";
            this.tbPay.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPay.UseSystemPasswordChar = false;
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(243, 37);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(77, 13);
            this.iTalk_Label1.TabIndex = 25;
            this.iTalk_Label1.Text = "○ 단위시간제";
            this.iTalk_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.label3.Location = new System.Drawing.Point(175, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "\\ / 분";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.label2.Location = new System.Drawing.Point(34, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "○ 사용시간제";
            // 
            // ucChangeableTimer4
            // 
            this.ucChangeableTimer4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucChangeableTimer4.Location = new System.Drawing.Point(13, 310);
            this.ucChangeableTimer4.Name = "ucChangeableTimer4";
            this.ucChangeableTimer4.Size = new System.Drawing.Size(736, 54);
            this.ucChangeableTimer4.TabIndex = 39;
            this.ucChangeableTimer4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            // 
            // ucChangeableTimer3
            // 
            this.ucChangeableTimer3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucChangeableTimer3.Location = new System.Drawing.Point(13, 249);
            this.ucChangeableTimer3.Name = "ucChangeableTimer3";
            this.ucChangeableTimer3.Size = new System.Drawing.Size(736, 54);
            this.ucChangeableTimer3.TabIndex = 38;
            this.ucChangeableTimer3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            // 
            // ucChangeableTimer2
            // 
            this.ucChangeableTimer2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucChangeableTimer2.Location = new System.Drawing.Point(13, 188);
            this.ucChangeableTimer2.Name = "ucChangeableTimer2";
            this.ucChangeableTimer2.Size = new System.Drawing.Size(736, 54);
            this.ucChangeableTimer2.TabIndex = 37;
            this.ucChangeableTimer2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            // 
            // ucChangeableTimer1
            // 
            this.ucChangeableTimer1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ucChangeableTimer1.Location = new System.Drawing.Point(13, 128);
            this.ucChangeableTimer1.Name = "ucChangeableTimer1";
            this.ucChangeableTimer1.Size = new System.Drawing.Size(736, 54);
            this.ucChangeableTimer1.TabIndex = 36;
            this.ucChangeableTimer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(761, 517);
            this.ControlBox = false;
            this.Controls.Add(this.ucStatistics);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.iTalk_HeaderLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.iTalk_GroupBox1);
            this.Controls.Add(this.ucChangeableTimer4);
            this.Controls.Add(this.ucChangeableTimer3);
            this.Controls.Add(this.ucChangeableTimer2);
            this.Controls.Add(this.ucChangeableTimer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(126, 39);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "고객관리 Program";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.iTalk_GroupBox1.ResumeLayout(false);
            this.iTalk_GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Label lbTime;
        private iTalk.iTalk_GroupBox iTalk_GroupBox1;
        private iTalk.iTalk_TextBox_Small tbaHour;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_TextBox_Small tbHalf;
        private iTalk.iTalk_Label iTalk_Label5;
        private iTalk.iTalk_Label iTalk_Label4;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_TextBox_Small tbPay;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Label label3;
        private iTalk.iTalk_Label label2;
        private ucChangeableTimer ucChangeableTimer4;
        private ucChangeableTimer ucChangeableTimer3;
        private ucChangeableTimer ucChangeableTimer2;
        private ucChangeableTimer ucChangeableTimer1;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_Icon_Info btnInfo;
        private iTalk.iTalk_Label btnExit;
        private ucStatistics ucStatistics;
    }
}

