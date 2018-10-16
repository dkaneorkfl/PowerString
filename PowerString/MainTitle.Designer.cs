namespace PowerString
{
    partial class MainTitle
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
            this.MainTitleName = new System.Windows.Forms.Label();
            this.PracticeProblem = new System.Windows.Forms.Button();
            this.Nametb = new System.Windows.Forms.TextBox();
            this.Passwardtb = new System.Windows.Forms.TextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.Passwardlab = new System.Windows.Forms.Label();
            this.Signbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTitleName
            // 
            this.MainTitleName.AutoSize = true;
            this.MainTitleName.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainTitleName.Location = new System.Drawing.Point(73, 74);
            this.MainTitleName.Name = "MainTitleName";
            this.MainTitleName.Size = new System.Drawing.Size(230, 37);
            this.MainTitleName.TabIndex = 1;
            this.MainTitleName.Text = "메인(타이틀)";
            // 
            // PracticeProblem
            // 
            this.PracticeProblem.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PracticeProblem.Location = new System.Drawing.Point(666, 280);
            this.PracticeProblem.Name = "PracticeProblem";
            this.PracticeProblem.Size = new System.Drawing.Size(66, 32);
            this.PracticeProblem.TabIndex = 2;
            this.PracticeProblem.Text = "확인(&Enter)";
            this.PracticeProblem.UseVisualStyleBackColor = true;
            this.PracticeProblem.Click += new System.EventHandler(this.PracticeProblem_Click);
            // 
            // Nametb
            // 
            this.Nametb.Location = new System.Drawing.Point(512, 283);
            this.Nametb.Name = "Nametb";
            this.Nametb.Size = new System.Drawing.Size(100, 21);
            this.Nametb.TabIndex = 3;
            // 
            // Passwardtb
            // 
            this.Passwardtb.Location = new System.Drawing.Point(512, 322);
            this.Passwardtb.Name = "Passwardtb";
            this.Passwardtb.Size = new System.Drawing.Size(100, 21);
            this.Passwardtb.TabIndex = 4;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IDlabel.Location = new System.Drawing.Point(470, 283);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(26, 21);
            this.IDlabel.TabIndex = 5;
            this.IDlabel.Text = "ID";
            // 
            // Passwardlab
            // 
            this.Passwardlab.AutoSize = true;
            this.Passwardlab.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Passwardlab.Location = new System.Drawing.Point(419, 322);
            this.Passwardlab.Name = "Passwardlab";
            this.Passwardlab.Size = new System.Drawing.Size(90, 21);
            this.Passwardlab.TabIndex = 6;
            this.Passwardlab.Text = "passward";
            // 
            // Signbtn
            // 
            this.Signbtn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Signbtn.Location = new System.Drawing.Point(666, 322);
            this.Signbtn.Name = "Signbtn";
            this.Signbtn.Size = new System.Drawing.Size(97, 31);
            this.Signbtn.TabIndex = 7;
            this.Signbtn.Text = "회원가입";
            this.Signbtn.UseVisualStyleBackColor = true;
            this.Signbtn.Click += new System.EventHandler(this.Signbtn_Click);
            // 
            // MainTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 446);
            this.Controls.Add(this.Signbtn);
            this.Controls.Add(this.Passwardlab);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.Passwardtb);
            this.Controls.Add(this.Nametb);
            this.Controls.Add(this.PracticeProblem);
            this.Controls.Add(this.MainTitleName);
            this.Name = "MainTitle";
            this.Text = "MainTitle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MainTitleName;
        private System.Windows.Forms.Button PracticeProblem;
        private System.Windows.Forms.TextBox Nametb;
        private System.Windows.Forms.TextBox Passwardtb;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label Passwardlab;
        private System.Windows.Forms.Button Signbtn;
    }
}

