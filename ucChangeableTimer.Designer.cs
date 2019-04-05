namespace VRTimer
{
    partial class ucChangeableTimer
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
            this.cbChangeTimer = new iTalk.iTalk_CheckBox();
            this.timer_Calc = new VRTimer.ucTimerCalc();
            this.timer_fixed = new VRTimer.ucTimer();
            this.lbSerialNo = new iTalk.iTalk_Label();
            this.SuspendLayout();
            // 
            // cbChangeTimer
            // 
            this.cbChangeTimer.BackColor = System.Drawing.Color.White;
            this.cbChangeTimer.Checked = false;
            this.cbChangeTimer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbChangeTimer.ForeColor = System.Drawing.Color.Transparent;
            this.cbChangeTimer.Location = new System.Drawing.Point(642, 18);
            this.cbChangeTimer.Name = "cbChangeTimer";
            this.cbChangeTimer.Size = new System.Drawing.Size(88, 15);
            this.cbChangeTimer.TabIndex = 2;
            this.cbChangeTimer.Text = "사용시간제";
            this.cbChangeTimer.CheckedChanged += new iTalk.iTalk_CheckBox.CheckedChangedEventHandler(this.CbChangeTimer_CheckedChanged);
            // 
            // timer_Calc
            // 
            this.timer_Calc.BackColor = System.Drawing.Color.White;
            this.timer_Calc.Location = new System.Drawing.Point(0, 0);
            this.timer_Calc.Name = "timer_Calc";
            this.timer_Calc.Size = new System.Drawing.Size(636, 50);
            this.timer_Calc.TabIndex = 1;
            this.timer_Calc.Visible = false;
            // 
            // timer_fixed
            // 
            this.timer_fixed.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.timer_fixed.Location = new System.Drawing.Point(1, 0);
            this.timer_fixed.Name = "timer_fixed";
            this.timer_fixed.Size = new System.Drawing.Size(636, 50);
            this.timer_fixed.TabIndex = 0;
            // 
            // lbSerialNo
            // 
            this.lbSerialNo.AutoSize = true;
            this.lbSerialNo.BackColor = System.Drawing.Color.Transparent;
            this.lbSerialNo.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSerialNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbSerialNo.Location = new System.Drawing.Point(3, 18);
            this.lbSerialNo.Name = "lbSerialNo";
            this.lbSerialNo.Size = new System.Drawing.Size(99, 13);
            this.lbSerialNo.TabIndex = 22;
            this.lbSerialNo.Text = "1KWPH800N08472";
            // 
            // ucChangeableTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lbSerialNo);
            this.Controls.Add(this.cbChangeTimer);
            this.Controls.Add(this.timer_Calc);
            this.Controls.Add(this.timer_fixed);
            this.Name = "ucChangeableTimer";
            this.Size = new System.Drawing.Size(732, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucTimer timer_fixed;
        private ucTimerCalc timer_Calc;
        private iTalk.iTalk_CheckBox cbChangeTimer;
        private iTalk.iTalk_Label lbSerialNo;
    }
}
