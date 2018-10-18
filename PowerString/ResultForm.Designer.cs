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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.MoveToMainMenu = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.TimeProgress = new System.Windows.Forms.ProgressBar();
            this.ClearQuoteLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ResultGroup = new System.Windows.Forms.GroupBox();
            this.ClearImg = new System.Windows.Forms.PictureBox();
            this.ImageHold = new System.Windows.Forms.GroupBox();
            this.ResultGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearImg)).BeginInit();
            this.ImageHold.SuspendLayout();
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
            this.MoveToMainMenu.Click += new System.EventHandler(this.MoveToMainMenu_Click);
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
            this.TimeProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.TimeProgress.TabIndex = 6;
            // 
            // ClearQuoteLabel
            // 
            this.ClearQuoteLabel.AutoSize = true;
            this.ClearQuoteLabel.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ClearQuoteLabel.Location = new System.Drawing.Point(40, 17);
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
            this.TimeLabel.Size = new System.Drawing.Size(353, 15);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "XXX초 동안 코드를 작성해 XX%의 오타를 냈습니다.";
            // 
            // ResultGroup
            // 
            this.ResultGroup.Controls.Add(this.TimeLabel);
            this.ResultGroup.Controls.Add(this.ScoreLabel);
            this.ResultGroup.Location = new System.Drawing.Point(12, 70);
            this.ResultGroup.Name = "ResultGroup";
            this.ResultGroup.Size = new System.Drawing.Size(444, 109);
            this.ResultGroup.TabIndex = 9;
            this.ResultGroup.TabStop = false;
            this.ResultGroup.Text = "OOO님은";
            // 
            // ClearImg
            // 
            this.ClearImg.Image = global::PowerString.Properties.Resources.welldone;
            this.ClearImg.Location = new System.Drawing.Point(0, 8);
            this.ClearImg.Name = "ClearImg";
            this.ClearImg.Size = new System.Drawing.Size(108, 100);
            this.ClearImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClearImg.TabIndex = 1;
            this.ClearImg.TabStop = false;
            // 
            // ImageHold
            // 
            this.ImageHold.Controls.Add(this.ClearImg);
            this.ImageHold.Location = new System.Drawing.Point(462, 71);
            this.ImageHold.Name = "ImageHold";
            this.ImageHold.Size = new System.Drawing.Size(110, 108);
            this.ImageHold.TabIndex = 9;
            this.ImageHold.TabStop = false;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 284);
            this.Controls.Add(this.ImageHold);
            this.Controls.Add(this.ResultGroup);
            this.Controls.Add(this.ClearQuoteLabel);
            this.Controls.Add(this.TimeProgress);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.MoveToMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "결과 발표!";
            this.ResultGroup.ResumeLayout(false);
            this.ResultGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearImg)).EndInit();
            this.ImageHold.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MoveToMainMenu;
        private new System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.ProgressBar TimeProgress;
        private System.Windows.Forms.Label ClearQuoteLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.GroupBox ResultGroup;
        private System.Windows.Forms.PictureBox ClearImg;
        private System.Windows.Forms.GroupBox ImageHold;
    }
}