namespace VRTimer
{
    partial class ucTimer
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
            this.btnStart = new iTalk.iTalk_Button_2();
            this.label2 = new iTalk.iTalk_Label();
            this.lblb = new iTalk.iTalk_Label();
            this.label3 = new iTalk.iTalk_Label();
            this.timerVR = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new iTalk.iTalk_Label();
            this.label6 = new iTalk.iTalk_Label();
            this.label7 = new iTalk.iTalk_Label();
            this.lbStartTime = new iTalk.iTalk_Label();
            this.tbTime = new iTalk.iTalk_ComboBox();
            this.tbExcessTime = new iTalk.iTalk_Label();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.pbxTimerState = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTimerState)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Image = null;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(480, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(42, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "시작";
            this.btnStart.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.label2.Location = new System.Drawing.Point(2, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "시간 :";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.BackColor = System.Drawing.Color.Transparent;
            this.lblb.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblb.Location = new System.Drawing.Point(119, 18);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(57, 13);
            this.lblb.TabIndex = 13;
            this.lblb.Text = "시작시간 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.label3.Location = new System.Drawing.Point(97, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "분";
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbTime.Location = new System.Drawing.Point(279, 18);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(25, 13);
            this.lbTime.TabIndex = 19;
            this.lbTime.Text = "0";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.label6.Location = new System.Drawing.Point(301, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "분";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.label7.Location = new System.Drawing.Point(220, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "사용시간 :";
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.BackColor = System.Drawing.Color.Transparent;
            this.lbStartTime.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbStartTime.Location = new System.Drawing.Point(177, 18);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(33, 13);
            this.lbStartTime.TabIndex = 20;
            this.lbStartTime.Text = "00:00";
            this.lbStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTime
            // 
            this.tbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tbTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tbTime.DropDownHeight = 100;
            this.tbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.tbTime.FormattingEnabled = true;
            this.tbTime.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tbTime.IntegralHeight = false;
            this.tbTime.ItemHeight = 20;
            this.tbTime.Items.AddRange(new object[] {
            "30",
            "60",
            "1"});
            this.tbTime.Location = new System.Drawing.Point(43, 11);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(55, 26);
            this.tbTime.StartIndex = 0;
            this.tbTime.TabIndex = 0;
            this.tbTime.TabStop = false;
            // 
            // tbExcessTime
            // 
            this.tbExcessTime.BackColor = System.Drawing.Color.Transparent;
            this.tbExcessTime.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.tbExcessTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.tbExcessTime.Location = new System.Drawing.Point(384, 18);
            this.tbExcessTime.Name = "tbExcessTime";
            this.tbExcessTime.Size = new System.Drawing.Size(35, 13);
            this.tbExcessTime.TabIndex = 25;
            this.tbExcessTime.Text = "0";
            this.tbExcessTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(414, 18);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(18, 13);
            this.iTalk_Label3.TabIndex = 24;
            this.iTalk_Label3.Text = "분";
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label4.Location = new System.Drawing.Point(323, 18);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(57, 13);
            this.iTalk_Label4.TabIndex = 23;
            this.iTalk_Label4.Text = "초과시간 :";
            // 
            // pbxTimerState
            // 
            this.pbxTimerState.Image = global::VRTimer.Properties.Resources.YelloCircle;
            this.pbxTimerState.Location = new System.Drawing.Point(442, 14);
            this.pbxTimerState.Name = "pbxTimerState";
            this.pbxTimerState.Size = new System.Drawing.Size(23, 23);
            this.pbxTimerState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTimerState.TabIndex = 26;
            this.pbxTimerState.TabStop = false;
            // 
            // ucTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pbxTimerState);
            this.Controls.Add(this.tbExcessTime);
            this.Controls.Add(this.iTalk_Label3);
            this.Controls.Add(this.iTalk_Label4);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.lbStartTime);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Name = "ucTimer";
            this.Size = new System.Drawing.Size(525, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTimerState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Button_2 btnStart;
        private iTalk.iTalk_Label label2;
        private iTalk.iTalk_Label lblb;
        private iTalk.iTalk_Label label3;
        private System.Windows.Forms.Timer timerVR;
        private iTalk.iTalk_Label lbTime;
        private iTalk.iTalk_Label label6;
        private iTalk.iTalk_Label label7;
        private iTalk.iTalk_Label lbStartTime;
        private iTalk.iTalk_ComboBox tbTime;
        private iTalk.iTalk_Label tbExcessTime;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_Label iTalk_Label4;
        private System.Windows.Forms.PictureBox pbxTimerState;
    }
}
