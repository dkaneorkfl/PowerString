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
            this.TesterName = new System.Windows.Forms.Label();
            this.IncorrectPer = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.TimeProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // MoveToMainMenu
            // 
            this.MoveToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MoveToMainMenu.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveToMainMenu.Location = new System.Drawing.Point(12, 223);
            this.MoveToMainMenu.Name = "MoveToMainMenu";
            this.MoveToMainMenu.Size = new System.Drawing.Size(127, 39);
            this.MoveToMainMenu.TabIndex = 0;
            this.MoveToMainMenu.Text = "메인메뉴로 (&M)";
            this.MoveToMainMenu.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(443, 223);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(127, 39);
            this.Close.TabIndex = 1;
            this.Close.Text = "닫기 (&C)";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // TesterName
            // 
            this.TesterName.AutoSize = true;
            this.TesterName.Location = new System.Drawing.Point(64, 91);
            this.TesterName.Name = "TesterName";
            this.TesterName.Size = new System.Drawing.Size(63, 15);
            this.TesterName.TabIndex = 2;
            this.TesterName.Text = "OOO 님";
            // 
            // IncorrectPer
            // 
            this.IncorrectPer.AutoSize = true;
            this.IncorrectPer.Location = new System.Drawing.Point(212, 91);
            this.IncorrectPer.Name = "IncorrectPer";
            this.IncorrectPer.Size = new System.Drawing.Size(52, 15);
            this.IncorrectPer.TabIndex = 3;
            this.IncorrectPer.Text = "오타율";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(350, 91);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(37, 15);
            this.Score.TabIndex = 4;
            this.Score.Text = "점수";
            // 
            // TimeProgress
            // 
            this.TimeProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeProgress.Location = new System.Drawing.Point(12, 172);
            this.TimeProgress.Name = "TimeProgress";
            this.TimeProgress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TimeProgress.Size = new System.Drawing.Size(558, 23);
            this.TimeProgress.TabIndex = 6;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 284);
            this.Controls.Add(this.TimeProgress);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.IncorrectPer);
            this.Controls.Add(this.TesterName);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.MoveToMainMenu);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MoveToMainMenu;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label TesterName;
        private System.Windows.Forms.Label IncorrectPer;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.ProgressBar TimeProgress;
    }
}