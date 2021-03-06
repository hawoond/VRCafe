﻿namespace VRTimer
{
    partial class ucTimerCalc
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerVR = new System.Windows.Forms.Timer(this.components);
            this.pbxTimerState = new System.Windows.Forms.PictureBox();
            this.lbStartTime = new iTalk.iTalk_Label();
            this.label6 = new iTalk.iTalk_Label();
            this.lbPay = new iTalk.iTalk_Label();
            this.label5 = new iTalk.iTalk_Label();
            this.lbTime = new iTalk.iTalk_Label();
            this.label4 = new iTalk.iTalk_Label();
            this.lblb = new iTalk.iTalk_Label();
            this.btnStart = new iTalk.iTalk_Button_2();
            this.label7 = new iTalk.iTalk_Label();
            this.lbRunning = new iTalk.iTalk_Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTimerState)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxTimerState
            // 
            this.pbxTimerState.Image = global::VRTimer.Properties.Resources.YelloCircle;
            this.pbxTimerState.Location = new System.Drawing.Point(442, 14);
            this.pbxTimerState.Name = "pbxTimerState";
            this.pbxTimerState.Size = new System.Drawing.Size(23, 23);
            this.pbxTimerState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTimerState.TabIndex = 35;
            this.pbxTimerState.TabStop = false;
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.BackColor = System.Drawing.Color.Transparent;
            this.lbStartTime.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.lbStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbStartTime.Location = new System.Drawing.Point(177, 18);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(33, 13);
            this.lbStartTime.TabIndex = 33;
            this.lbStartTime.Text = "00:00";
            this.lbStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.label6.Location = new System.Drawing.Point(119, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "시작시간 :";
            // 
            // lbPay
            // 
            this.lbPay.BackColor = System.Drawing.Color.Transparent;
            this.lbPay.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.lbPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbPay.Location = new System.Drawing.Point(381, 18);
            this.lbPay.Name = "lbPay";
            this.lbPay.Size = new System.Drawing.Size(38, 13);
            this.lbPay.TabIndex = 30;
            this.lbPay.Text = "0";
            this.lbPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.label5.Location = new System.Drawing.Point(323, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "이용요금 :";
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbTime.Location = new System.Drawing.Point(279, 18);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(25, 13);
            this.lbTime.TabIndex = 26;
            this.lbTime.Text = "0";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.label4.Location = new System.Drawing.Point(301, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "분";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.BackColor = System.Drawing.Color.Transparent;
            this.lblb.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.lblb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblb.Location = new System.Drawing.Point(220, 18);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(57, 13);
            this.lblb.TabIndex = 24;
            this.lblb.Text = "사용시간 :";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Image = null;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(480, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(42, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "시작";
            this.btnStart.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.label7.Location = new System.Drawing.Point(414, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "원";
            // 
            // lbRunning
            // 
            this.lbRunning.AutoSize = true;
            this.lbRunning.BackColor = System.Drawing.Color.Transparent;
            this.lbRunning.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.lbRunning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbRunning.Location = new System.Drawing.Point(43, 18);
            this.lbRunning.Name = "lbRunning";
            this.lbRunning.Size = new System.Drawing.Size(40, 13);
            this.lbRunning.TabIndex = 37;
            this.lbRunning.Text = "사용중";
            // 
            // ucTimerCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbRunning);
            this.Controls.Add(this.pbxTimerState);
            this.Controls.Add(this.lbStartTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label7);
            this.Name = "ucTimerCalc";
            this.Size = new System.Drawing.Size(525, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTimerState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Label lbTime;
        private iTalk.iTalk_Label label4;
        private iTalk.iTalk_Label lblb;
        private iTalk.iTalk_Button_2 btnStart;
        private System.Windows.Forms.Timer timerVR;
        private iTalk.iTalk_Label label5;
        private iTalk.iTalk_Label lbPay;
        private iTalk.iTalk_Label label7;
        private iTalk.iTalk_Label lbStartTime;
        private iTalk.iTalk_Label label6;
        private System.Windows.Forms.PictureBox pbxTimerState;
        private iTalk.iTalk_Label lbRunning;
    }
}
