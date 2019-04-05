namespace VRTimer
{
    partial class ucStatistics
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
            this.iTalk_GroupBox1 = new iTalk.iTalk_GroupBox();
            this.iTalk_Panel3 = new iTalk.iTalk_Panel();
            this.iTalk_Label11 = new iTalk.iTalk_Label();
            this.iTalk_Label10 = new iTalk.iTalk_Label();
            this.iTalk_Label9 = new iTalk.iTalk_Label();
            this.iTalk_Panel2 = new iTalk.iTalk_Panel();
            this.iTalk_Label5 = new iTalk.iTalk_Label();
            this.iTalk_Label6 = new iTalk.iTalk_Label();
            this.iTalk_Label7 = new iTalk.iTalk_Label();
            this.iTalk_Label8 = new iTalk.iTalk_Label();
            this.tbPayment = new iTalk.iTalk_TextBox_Small();
            this.tbProfitFee = new iTalk.iTalk_TextBox_Small();
            this.lala = new iTalk.iTalk_Panel();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.tbTotlaFee = new iTalk.iTalk_TextBox_Small();
            this.tbTotlaHour = new iTalk.iTalk_TextBox_Small();
            this.iTalk_GroupBox1.SuspendLayout();
            this.iTalk_Panel3.SuspendLayout();
            this.iTalk_Panel2.SuspendLayout();
            this.lala.SuspendLayout();
            this.SuspendLayout();
            // 
            // iTalk_GroupBox1
            // 
            this.iTalk_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Panel3);
            this.iTalk_GroupBox1.Controls.Add(this.iTalk_Panel2);
            this.iTalk_GroupBox1.Controls.Add(this.lala);
            this.iTalk_GroupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.iTalk_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iTalk_GroupBox1.Name = "iTalk_GroupBox1";
            this.iTalk_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iTalk_GroupBox1.Size = new System.Drawing.Size(701, 147);
            this.iTalk_GroupBox1.TabIndex = 0;
            this.iTalk_GroupBox1.Text = "계산서";
            // 
            // iTalk_Panel3
            // 
            this.iTalk_Panel3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Panel3.Controls.Add(this.iTalk_Label11);
            this.iTalk_Panel3.Controls.Add(this.iTalk_Label10);
            this.iTalk_Panel3.Controls.Add(this.iTalk_Label9);
            this.iTalk_Panel3.Location = new System.Drawing.Point(490, 31);
            this.iTalk_Panel3.Name = "iTalk_Panel3";
            this.iTalk_Panel3.Padding = new System.Windows.Forms.Padding(5);
            this.iTalk_Panel3.Size = new System.Drawing.Size(203, 108);
            this.iTalk_Panel3.TabIndex = 4;
            this.iTalk_Panel3.Text = "iTalk_Panel3";
            // 
            // iTalk_Label11
            // 
            this.iTalk_Label11.AutoSize = true;
            this.iTalk_Label11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label11.Font = new System.Drawing.Font("맑은 고딕", 7F);
            this.iTalk_Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label11.Location = new System.Drawing.Point(9, 66);
            this.iTalk_Label11.Name = "iTalk_Label11";
            this.iTalk_Label11.Size = new System.Drawing.Size(190, 12);
            this.iTalk_Label11.TabIndex = 2;
            this.iTalk_Label11.Text = "총 이용 요금 * 지불률(30%) = 지불 금액";
            // 
            // iTalk_Label10
            // 
            this.iTalk_Label10.AutoSize = true;
            this.iTalk_Label10.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label10.Font = new System.Drawing.Font("맑은 고딕", 7F);
            this.iTalk_Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label10.Location = new System.Drawing.Point(9, 48);
            this.iTalk_Label10.Name = "iTalk_Label10";
            this.iTalk_Label10.Size = new System.Drawing.Size(190, 12);
            this.iTalk_Label10.TabIndex = 1;
            this.iTalk_Label10.Text = "총 이용 요금 * 이윤률(70%) = 이익 금액";
            // 
            // iTalk_Label9
            // 
            this.iTalk_Label9.AutoSize = true;
            this.iTalk_Label9.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label9.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label9.Location = new System.Drawing.Point(3, 9);
            this.iTalk_Label9.Name = "iTalk_Label9";
            this.iTalk_Label9.Size = new System.Drawing.Size(76, 30);
            this.iTalk_Label9.TabIndex = 0;
            this.iTalk_Label9.Text = "계산식";
            this.iTalk_Label9.Click += new System.EventHandler(this.ITalk_Label9_Click);
            // 
            // iTalk_Panel2
            // 
            this.iTalk_Panel2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Panel2.Controls.Add(this.iTalk_Label5);
            this.iTalk_Panel2.Controls.Add(this.iTalk_Label6);
            this.iTalk_Panel2.Controls.Add(this.iTalk_Label7);
            this.iTalk_Panel2.Controls.Add(this.iTalk_Label8);
            this.iTalk_Panel2.Controls.Add(this.tbPayment);
            this.iTalk_Panel2.Controls.Add(this.tbProfitFee);
            this.iTalk_Panel2.Location = new System.Drawing.Point(249, 31);
            this.iTalk_Panel2.Name = "iTalk_Panel2";
            this.iTalk_Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.iTalk_Panel2.Size = new System.Drawing.Size(235, 108);
            this.iTalk_Panel2.TabIndex = 3;
            this.iTalk_Panel2.Text = "iTalk_Panel2";
            // 
            // iTalk_Label5
            // 
            this.iTalk_Label5.AutoSize = true;
            this.iTalk_Label5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label5.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label5.Location = new System.Drawing.Point(11, 61);
            this.iTalk_Label5.Name = "iTalk_Label5";
            this.iTalk_Label5.Size = new System.Drawing.Size(55, 13);
            this.iTalk_Label5.TabIndex = 2;
            this.iTalk_Label5.Text = "지불 금액";
            // 
            // iTalk_Label6
            // 
            this.iTalk_Label6.AutoSize = true;
            this.iTalk_Label6.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label6.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label6.Location = new System.Drawing.Point(203, 61);
            this.iTalk_Label6.Name = "iTalk_Label6";
            this.iTalk_Label6.Size = new System.Drawing.Size(18, 13);
            this.iTalk_Label6.TabIndex = 2;
            this.iTalk_Label6.Text = "원";
            // 
            // iTalk_Label7
            // 
            this.iTalk_Label7.AutoSize = true;
            this.iTalk_Label7.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label7.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label7.Location = new System.Drawing.Point(203, 27);
            this.iTalk_Label7.Name = "iTalk_Label7";
            this.iTalk_Label7.Size = new System.Drawing.Size(18, 13);
            this.iTalk_Label7.TabIndex = 2;
            this.iTalk_Label7.Text = "원";
            // 
            // iTalk_Label8
            // 
            this.iTalk_Label8.AutoSize = true;
            this.iTalk_Label8.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label8.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label8.Location = new System.Drawing.Point(11, 27);
            this.iTalk_Label8.Name = "iTalk_Label8";
            this.iTalk_Label8.Size = new System.Drawing.Size(55, 13);
            this.iTalk_Label8.TabIndex = 2;
            this.iTalk_Label8.Text = "이익 금액";
            // 
            // tbPayment
            // 
            this.tbPayment.BackColor = System.Drawing.Color.Transparent;
            this.tbPayment.Enabled = false;
            this.tbPayment.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbPayment.ForeColor = System.Drawing.Color.DimGray;
            this.tbPayment.Location = new System.Drawing.Point(85, 54);
            this.tbPayment.MaxLength = 32767;
            this.tbPayment.Multiline = false;
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.ReadOnly = true;
            this.tbPayment.Size = new System.Drawing.Size(112, 28);
            this.tbPayment.TabIndex = 1;
            this.tbPayment.TabStop = false;
            this.tbPayment.Text = "0";
            this.tbPayment.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPayment.UseSystemPasswordChar = false;
            // 
            // tbProfitFee
            // 
            this.tbProfitFee.BackColor = System.Drawing.Color.Transparent;
            this.tbProfitFee.Enabled = false;
            this.tbProfitFee.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbProfitFee.ForeColor = System.Drawing.Color.DimGray;
            this.tbProfitFee.Location = new System.Drawing.Point(85, 20);
            this.tbProfitFee.MaxLength = 32767;
            this.tbProfitFee.Multiline = false;
            this.tbProfitFee.Name = "tbProfitFee";
            this.tbProfitFee.ReadOnly = true;
            this.tbProfitFee.Size = new System.Drawing.Size(112, 28);
            this.tbProfitFee.TabIndex = 1;
            this.tbProfitFee.Text = "0";
            this.tbProfitFee.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbProfitFee.UseSystemPasswordChar = false;
            // 
            // lala
            // 
            this.lala.BackColor = System.Drawing.Color.Transparent;
            this.lala.Controls.Add(this.iTalk_Label2);
            this.lala.Controls.Add(this.iTalk_Label4);
            this.lala.Controls.Add(this.iTalk_Label3);
            this.lala.Controls.Add(this.iTalk_Label1);
            this.lala.Controls.Add(this.tbTotlaFee);
            this.lala.Controls.Add(this.tbTotlaHour);
            this.lala.Location = new System.Drawing.Point(8, 31);
            this.lala.Name = "lala";
            this.lala.Padding = new System.Windows.Forms.Padding(5);
            this.lala.Size = new System.Drawing.Size(235, 108);
            this.lala.TabIndex = 2;
            this.lala.Text = "iTalk_Panel1";
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(11, 61);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(70, 13);
            this.iTalk_Label2.TabIndex = 2;
            this.iTalk_Label2.Text = "총 이용 요금";
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label4.Location = new System.Drawing.Point(203, 61);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(18, 13);
            this.iTalk_Label4.TabIndex = 2;
            this.iTalk_Label4.Text = "원";
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(203, 27);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(18, 13);
            this.iTalk_Label3.TabIndex = 2;
            this.iTalk_Label3.Text = "분";
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(11, 27);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(70, 13);
            this.iTalk_Label1.TabIndex = 2;
            this.iTalk_Label1.Text = "총 사용 시간";
            // 
            // tbTotlaFee
            // 
            this.tbTotlaFee.BackColor = System.Drawing.Color.Transparent;
            this.tbTotlaFee.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbTotlaFee.ForeColor = System.Drawing.Color.DimGray;
            this.tbTotlaFee.Location = new System.Drawing.Point(85, 54);
            this.tbTotlaFee.MaxLength = 32767;
            this.tbTotlaFee.Multiline = false;
            this.tbTotlaFee.Name = "tbTotlaFee";
            this.tbTotlaFee.ReadOnly = false;
            this.tbTotlaFee.Size = new System.Drawing.Size(112, 28);
            this.tbTotlaFee.TabIndex = 1;
            this.tbTotlaFee.Text = "0";
            this.tbTotlaFee.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTotlaFee.UseSystemPasswordChar = false;
            // 
            // tbTotlaHour
            // 
            this.tbTotlaHour.BackColor = System.Drawing.Color.Transparent;
            this.tbTotlaHour.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbTotlaHour.ForeColor = System.Drawing.Color.DimGray;
            this.tbTotlaHour.Location = new System.Drawing.Point(85, 20);
            this.tbTotlaHour.MaxLength = 32767;
            this.tbTotlaHour.Multiline = false;
            this.tbTotlaHour.Name = "tbTotlaHour";
            this.tbTotlaHour.ReadOnly = false;
            this.tbTotlaHour.Size = new System.Drawing.Size(112, 28);
            this.tbTotlaHour.TabIndex = 1;
            this.tbTotlaHour.Text = "0";
            this.tbTotlaHour.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTotlaHour.UseSystemPasswordChar = false;
            // 
            // ucStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.iTalk_GroupBox1);
            this.Name = "ucStatistics";
            this.Size = new System.Drawing.Size(707, 153);
            this.iTalk_GroupBox1.ResumeLayout(false);
            this.iTalk_Panel3.ResumeLayout(false);
            this.iTalk_Panel3.PerformLayout();
            this.iTalk_Panel2.ResumeLayout(false);
            this.iTalk_Panel2.PerformLayout();
            this.lala.ResumeLayout(false);
            this.lala.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_GroupBox iTalk_GroupBox1;
        private iTalk.iTalk_TextBox_Small tbTotlaHour;
        private iTalk.iTalk_Panel iTalk_Panel2;
        private iTalk.iTalk_Label iTalk_Label5;
        private iTalk.iTalk_Label iTalk_Label6;
        private iTalk.iTalk_Label iTalk_Label7;
        private iTalk.iTalk_Label iTalk_Label8;
        private iTalk.iTalk_TextBox_Small tbPayment;
        private iTalk.iTalk_TextBox_Small tbProfitFee;
        private iTalk.iTalk_Panel lala;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_Label iTalk_Label4;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_TextBox_Small tbTotlaFee;
        private iTalk.iTalk_Panel iTalk_Panel3;
        private iTalk.iTalk_Label iTalk_Label11;
        private iTalk.iTalk_Label iTalk_Label10;
        private iTalk.iTalk_Label iTalk_Label9;
    }
}
