namespace PowerString
{
    partial class ResultForm
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
            this.MoveToMainMenu = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.IncorrectPercentLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.TimeProgress = new System.Windows.Forms.ProgressBar();
            this.ClearQuoteLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ResultGroup = new System.Windows.Forms.GroupBox();
            this.ClearImg = new System.Windows.Forms.PictureBox();
            this.ResultGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearImg)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveToMainMenu
            // 
            this.MoveToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MoveToMainMenu.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveToMainMenu.Location = new System.Drawing.Point(12, 234);
            this.MoveToMainMenu.Name = "MoveToMainMenu";
            this.MoveToMainMenu.Size = new System.Drawing.Size(140, 38);
            this.MoveToMainMenu.TabIndex = 0;
            this.MoveToMainMenu.Text = "메인메뉴로 (&M)";
            this.MoveToMainMenu.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(430, 234);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(140, 38);
            this.Close.TabIndex = 1;
            this.Close.Text = "닫기 (&C)";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // IncorrectPercentLabel
            // 
            this.IncorrectPercentLabel.AutoSize = true;
            this.IncorrectPercentLabel.Location = new System.Drawing.Point(193, 34);
            this.IncorrectPercentLabel.Name = "IncorrectPercentLabel";
            this.IncorrectPercentLabel.Size = new System.Drawing.Size(171, 15);
            this.IncorrectPercentLabel.TabIndex = 3;
            this.IncorrectPercentLabel.Text = "XX%의 오타를 냈습니다.";
            this.IncorrectPercentLabel.Click += new System.EventHandler(this.IncorrectPercentLabel_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(6, 64);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(189, 15);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "점수를 XXX 점 받았습니다.";
            this.ScoreLabel.Click += new System.EventHandler(this.ScoreLabel_Click);
            // 
            // TimeProgress
            // 
            this.TimeProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeProgress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimeProgress.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TimeProgress.Location = new System.Drawing.Point(12, 194);
            this.TimeProgress.Name = "TimeProgress";
            this.TimeProgress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TimeProgress.Size = new System.Drawing.Size(558, 23);
            this.TimeProgress.TabIndex = 6;
            // 
            // ClearQuoteLabel
            // 
            this.ClearQuoteLabel.AutoSize = true;
            this.ClearQuoteLabel.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ClearQuoteLabel.Location = new System.Drawing.Point(40, 27);
            this.ClearQuoteLabel.Name = "ClearQuoteLabel";
            this.ClearQuoteLabel.Size = new System.Drawing.Size(496, 40);
            this.ClearQuoteLabel.TabIndex = 7;
            this.ClearQuoteLabel.Text = "코드 작성을 완료했습니다!";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(6, 34);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(184, 15);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "XXX초 동안 코드를 작성해";
            // 
            // ResultGroup
            // 
            this.ResultGroup.Controls.Add(this.IncorrectPercentLabel);
            this.ResultGroup.Controls.Add(this.TimeLabel);
            this.ResultGroup.Controls.Add(this.ScoreLabel);
            this.ResultGroup.Location = new System.Drawing.Point(12, 79);
            this.ResultGroup.Name = "ResultGroup";
            this.ResultGroup.Size = new System.Drawing.Size(444, 100);
            this.ResultGroup.TabIndex = 9;
            this.ResultGroup.TabStop = false;
            this.ResultGroup.Text = "OOO님은";
            // 
            // ClearImg
            // 
            this.ClearImg.Image = global::PowerString.Properties.Resources.welldone;
            this.ClearImg.Location = new System.Drawing.Point(462, 79);
            this.ClearImg.Name = "ClearImg";
            this.ClearImg.Size = new System.Drawing.Size(110, 110);
            this.ClearImg.TabIndex = 1;
            this.ClearImg.TabStop = false;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 284);
            this.Controls.Add(this.ClearImg);
            this.Controls.Add(this.ResultGroup);
            this.Controls.Add(this.ClearQuoteLabel);
            this.Controls.Add(this.TimeProgress);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.MoveToMainMenu);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.ResultGroup.ResumeLayout(false);
            this.ResultGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MoveToMainMenu;
        private new System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label IncorrectPercentLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.ProgressBar TimeProgress;
        private System.Windows.Forms.Label ClearQuoteLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.GroupBox ResultGroup;
        private System.Windows.Forms.PictureBox ClearImg;
    }
}