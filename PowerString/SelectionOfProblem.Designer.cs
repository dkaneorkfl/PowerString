namespace PowerString
{
    partial class SelectionOfProblem
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
            this.CategorySelectionButton.Location = new System.Drawing.Point(243, 69);
            this.CategorySelectionButton.Name = "CategorySelectionButton";
            this.CategorySelectionButton.Size = new System.Drawing.Size(277, 47);
            this.CategorySelectionButton.TabIndex = 0;
            this.CategorySelectionButton.Text = "카테고리 선택";
            this.CategorySelectionButton.UseVisualStyleBackColor = true;
            this.CategorySelectionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SingleGameButton
            // 
            this.SingleGameButton.Location = new System.Drawing.Point(12, 246);
            this.SingleGameButton.Name = "SingleGameButton";
            this.SingleGameButton.Size = new System.Drawing.Size(273, 82);
            this.SingleGameButton.TabIndex = 3;
            this.SingleGameButton.Text = "싱글게임";
            this.SingleGameButton.UseVisualStyleBackColor = true;
            // 
            // MultiGameButton
            // 
            this.MultiGameButton.Location = new System.Drawing.Point(526, 245);
            this.MultiGameButton.Name = "MultiGameButton";
            this.MultiGameButton.Size = new System.Drawing.Size(262, 82);
            this.MultiGameButton.TabIndex = 4;
            this.MultiGameButton.Text = "멀티게임";
            this.MultiGameButton.UseVisualStyleBackColor = true;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSize = true;
            this.CategoryName.Location = new System.Drawing.Point(289, 185);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(89, 12);
            this.CategoryName.TabIndex = 1;
            this.CategoryName.Text = "카테고리 이름: ";
            // 
            // NumberOfQuestions
            // 
            this.NumberOfQuestions.AutoSize = true;
            this.NumberOfQuestions.Location = new System.Drawing.Point(396, 185);
            this.NumberOfQuestions.Name = "NumberOfQuestions";
            this.NumberOfQuestions.Size = new System.Drawing.Size(73, 12);
            this.NumberOfQuestions.TabIndex = 2;
            this.NumberOfQuestions.Text = "총 문재 갯수";
            // 
            // MainTitleReturnButton
            // 
            this.MainTitleReturnButton.Location = new System.Drawing.Point(713, 415);
            this.MainTitleReturnButton.Name = "MainTitleReturnButton";
            this.MainTitleReturnButton.Size = new System.Drawing.Size(75, 23);
            this.MainTitleReturnButton.TabIndex = 5;
            this.MainTitleReturnButton.Text = "뒤로가기";
            this.MainTitleReturnButton.UseVisualStyleBackColor = true;
            this.MainTitleReturnButton.Click += new System.EventHandler(this.MainTitleReturnButton_Click);
            // 
            // SelectionOfProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTitleReturnButton);
            this.Controls.Add(this.NumberOfQuestions);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.MultiGameButton);
            this.Controls.Add(this.SingleGameButton);
            this.Controls.Add(this.CategorySelectionButton);
            this.Name = "SelectionOfProblem";
            this.Text = "SelectionOfProblem";
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