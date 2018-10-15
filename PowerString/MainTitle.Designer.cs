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
            this.goToUserInfo = new System.Windows.Forms.Button();
            this.MainTitleName = new System.Windows.Forms.Label();
            this.PracticeProblem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goToUserInfo
            // 
            this.goToUserInfo.Location = new System.Drawing.Point(791, 553);
            this.goToUserInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goToUserInfo.Name = "goToUserInfo";
            this.goToUserInfo.Size = new System.Drawing.Size(110, 31);
            this.goToUserInfo.TabIndex = 0;
            this.goToUserInfo.Text = "사용자 정보(&U)";
            this.goToUserInfo.UseVisualStyleBackColor = true;
            this.goToUserInfo.Click += new System.EventHandler(this.goToUserInfo_Click);
            // 
            // MainTitleName
            // 
            this.MainTitleName.AutoSize = true;
            this.MainTitleName.Font = new System.Drawing.Font("Gulim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainTitleName.Location = new System.Drawing.Point(323, 171);
            this.MainTitleName.Name = "MainTitleName";
            this.MainTitleName.Size = new System.Drawing.Size(291, 47);
            this.MainTitleName.TabIndex = 1;
            this.MainTitleName.Text = "메인(타이틀)";
            // 
            // PracticeProblem
            // 
            this.PracticeProblem.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PracticeProblem.Location = new System.Drawing.Point(383, 272);
            this.PracticeProblem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PracticeProblem.Name = "PracticeProblem";
            this.PracticeProblem.Size = new System.Drawing.Size(136, 65);
            this.PracticeProblem.TabIndex = 2;
            this.PracticeProblem.Text = "연습문제";
            this.PracticeProblem.UseVisualStyleBackColor = true;
            this.PracticeProblem.Click += new System.EventHandler(this.PracticeProblem_Click);
            // 
            // MainTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 594);
            this.Controls.Add(this.PracticeProblem);
            this.Controls.Add(this.MainTitleName);
            this.Controls.Add(this.goToUserInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainTitle";
            this.Text = "MainTitle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToUserInfo;
        private System.Windows.Forms.Label MainTitleName;
        private System.Windows.Forms.Button PracticeProblem;
    }
}

