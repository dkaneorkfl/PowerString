namespace PowerString
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.MainTitleLabel = new System.Windows.Forms.Label();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.IdInputBox = new System.Windows.Forms.TextBox();
            this.GoToNewAccountCreateBtn = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.DeveloperLabel = new System.Windows.Forms.Label();
            this.LogOnInfoGBox = new System.Windows.Forms.GroupBox();
            this.PwInputBox = new System.Windows.Forms.TextBox();
            this.LogOnInfoGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTitleLabel
            // 
            this.MainTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainTitleLabel.AutoSize = true;
            this.MainTitleLabel.Font = new System.Drawing.Font("굴림", 28F);
            this.MainTitleLabel.Location = new System.Drawing.Point(258, 39);
            this.MainTitleLabel.Name = "MainTitleLabel";
            this.MainTitleLabel.Size = new System.Drawing.Size(334, 141);
            this.MainTitleLabel.TabIndex = 1;
            this.MainTitleLabel.Text = "코드 타자 연습\r\n\r\nPower String\r\n";
            this.MainTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogInBtn
            // 
            this.LogInBtn.Font = new System.Drawing.Font("굴림", 15F);
            this.LogInBtn.Location = new System.Drawing.Point(203, 30);
            this.LogInBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(129, 65);
            this.LogInBtn.TabIndex = 2;
            this.LogInBtn.Text = "확인(&Enter)";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // IdInputBox
            // 
            this.IdInputBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdInputBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.IdInputBox.Location = new System.Drawing.Point(6, 29);
            this.IdInputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdInputBox.Name = "IdInputBox";
            this.IdInputBox.Size = new System.Drawing.Size(191, 25);
            this.IdInputBox.TabIndex = 3;
            this.IdInputBox.Text = "사용자명";
            this.IdInputBox.Enter += new System.EventHandler(this.IdInputBox_Enter);
            this.IdInputBox.Leave += new System.EventHandler(this.IdInputBox_Leave);
            // 
            // GoToNewAccountCreateBtn
            // 
            this.GoToNewAccountCreateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GoToNewAccountCreateBtn.Font = new System.Drawing.Font("굴림", 15F);
            this.GoToNewAccountCreateBtn.Location = new System.Drawing.Point(255, 339);
            this.GoToNewAccountCreateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GoToNewAccountCreateBtn.Name = "GoToNewAccountCreateBtn";
            this.GoToNewAccountCreateBtn.Size = new System.Drawing.Size(340, 38);
            this.GoToNewAccountCreateBtn.TabIndex = 7;
            this.GoToNewAccountCreateBtn.Text = "새로운 사용자 등록";
            this.GoToNewAccountCreateBtn.UseVisualStyleBackColor = true;
            this.GoToNewAccountCreateBtn.Click += new System.EventHandler(this.GoToNewAccountCreateBtn_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(12, 399);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(82, 18);
            this.VersionLabel.TabIndex = 10;
            this.VersionLabel.Text = "Version 1.0";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeveloperLabel
            // 
            this.DeveloperLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeveloperLabel.AutoSize = true;
            this.DeveloperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeveloperLabel.Location = new System.Drawing.Point(535, 399);
            this.DeveloperLabel.Name = "DeveloperLabel";
            this.DeveloperLabel.Size = new System.Drawing.Size(285, 18);
            this.DeveloperLabel.TabIndex = 11;
            this.DeveloperLabel.Text = "Developed by EJY, SHK, MJK, DSK, SKO";
            this.DeveloperLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogOnInfoGBox
            // 
            this.LogOnInfoGBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogOnInfoGBox.Controls.Add(this.PwInputBox);
            this.LogOnInfoGBox.Controls.Add(this.IdInputBox);
            this.LogOnInfoGBox.Controls.Add(this.LogInBtn);
            this.LogOnInfoGBox.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOnInfoGBox.Location = new System.Drawing.Point(255, 209);
            this.LogOnInfoGBox.Name = "LogOnInfoGBox";
            this.LogOnInfoGBox.Size = new System.Drawing.Size(340, 113);
            this.LogOnInfoGBox.TabIndex = 12;
            this.LogOnInfoGBox.TabStop = false;
            this.LogOnInfoGBox.Text = "로그인";
            // 
            // PwInputBox
            // 
            this.PwInputBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwInputBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.PwInputBox.Location = new System.Drawing.Point(6, 70);
            this.PwInputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PwInputBox.Name = "PwInputBox";
            this.PwInputBox.Size = new System.Drawing.Size(191, 25);
            this.PwInputBox.TabIndex = 13;
            this.PwInputBox.Text = "비밀번호";
            this.PwInputBox.Enter += new System.EventHandler(this.PwInputBox_Enter);
            this.PwInputBox.Leave += new System.EventHandler(this.PwInputBox_Leave);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 425);
            this.Controls.Add(this.LogOnInfoGBox);
            this.Controls.Add(this.DeveloperLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.GoToNewAccountCreateBtn);
            this.Controls.Add(this.MainTitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StartForm";
            this.Text = "PowerString";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LogOnInfoGBox.ResumeLayout(false);
            this.LogOnInfoGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MainTitleLabel;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.TextBox IdInputBox;
        private System.Windows.Forms.Button GoToNewAccountCreateBtn;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label DeveloperLabel;
        private System.Windows.Forms.GroupBox LogOnInfoGBox;
        private System.Windows.Forms.TextBox PwInputBox;
    }
}

