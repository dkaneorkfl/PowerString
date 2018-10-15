namespace PowerString
{
    partial class QuizSelection
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
            this.CategorySelectionButton = new System.Windows.Forms.Button();
            this.SingleGameButton = new System.Windows.Forms.Button();
            this.MultiGameButton = new System.Windows.Forms.Button();
            this.CategoryName = new System.Windows.Forms.Label();
            this.NumberOfQuestions = new System.Windows.Forms.Label();
            this.MainTitleReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategorySelectionButton
            // 
            this.CategorySelectionButton.Location = new System.Drawing.Point(278, 92);
            this.CategorySelectionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CategorySelectionButton.Name = "CategorySelectionButton";
            this.CategorySelectionButton.Size = new System.Drawing.Size(317, 63);
            this.CategorySelectionButton.TabIndex = 0;
            this.CategorySelectionButton.Text = "카테고리 선택";
            this.CategorySelectionButton.UseVisualStyleBackColor = true;
            this.CategorySelectionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SingleGameButton
            // 
            this.SingleGameButton.Location = new System.Drawing.Point(14, 328);
            this.SingleGameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SingleGameButton.Name = "SingleGameButton";
            this.SingleGameButton.Size = new System.Drawing.Size(312, 109);
            this.SingleGameButton.TabIndex = 3;
            this.SingleGameButton.Text = "싱글게임";
            this.SingleGameButton.UseVisualStyleBackColor = true;
            this.SingleGameButton.Click += new System.EventHandler(this.SingleGameButton_Click);
            // 
            // MultiGameButton
            // 
            this.MultiGameButton.Location = new System.Drawing.Point(601, 327);
            this.MultiGameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MultiGameButton.Name = "MultiGameButton";
            this.MultiGameButton.Size = new System.Drawing.Size(299, 109);
            this.MultiGameButton.TabIndex = 4;
            this.MultiGameButton.Text = "멀티게임";
            this.MultiGameButton.UseVisualStyleBackColor = true;
            this.MultiGameButton.Click += new System.EventHandler(this.MultiGameButton_Click);
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSize = true;
            this.CategoryName.Location = new System.Drawing.Point(330, 247);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(92, 17);
            this.CategoryName.TabIndex = 1;
            this.CategoryName.Text = "카테고리 이름: ";
            // 
            // NumberOfQuestions
            // 
            this.NumberOfQuestions.AutoSize = true;
            this.NumberOfQuestions.Location = new System.Drawing.Point(453, 247);
            this.NumberOfQuestions.Name = "NumberOfQuestions";
            this.NumberOfQuestions.Size = new System.Drawing.Size(76, 17);
            this.NumberOfQuestions.TabIndex = 2;
            this.NumberOfQuestions.Text = "총 문재 갯수";
            // 
            // MainTitleReturnButton
            // 
            this.MainTitleReturnButton.Location = new System.Drawing.Point(815, 553);
            this.MainTitleReturnButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTitleReturnButton.Name = "MainTitleReturnButton";
            this.MainTitleReturnButton.Size = new System.Drawing.Size(86, 31);
            this.MainTitleReturnButton.TabIndex = 5;
            this.MainTitleReturnButton.Text = "뒤로가기";
            this.MainTitleReturnButton.UseVisualStyleBackColor = true;
            this.MainTitleReturnButton.Click += new System.EventHandler(this.MainTitleReturnButton_Click);
            // 
            // QuizSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.MainTitleReturnButton);
            this.Controls.Add(this.NumberOfQuestions);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.MultiGameButton);
            this.Controls.Add(this.SingleGameButton);
            this.Controls.Add(this.CategorySelectionButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuizSelection";
            this.Text = "QuizSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CategorySelectionButton;
        private System.Windows.Forms.Button SingleGameButton;
        private System.Windows.Forms.Button MultiGameButton;
        private System.Windows.Forms.Label CategoryName;
        private System.Windows.Forms.Label NumberOfQuestions;
        private System.Windows.Forms.Button MainTitleReturnButton;
    }
}