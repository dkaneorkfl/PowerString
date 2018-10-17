namespace PowerString
{
    partial class TypingTestForm
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
            this.BackToSelectionSelectionBtn = new System.Windows.Forms.Button();
            this.PresentTestSkipBtn = new System.Windows.Forms.Button();
            this.GoToNextTextBtn = new System.Windows.Forms.Button();
            this.TestCodeViewTxetBox = new System.Windows.Forms.TextBox();
            this.TestCodeInputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BackToSelectionSelectionBtn
            // 
            this.BackToSelectionSelectionBtn.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToSelectionSelectionBtn.Location = new System.Drawing.Point(13, 13);
            this.BackToSelectionSelectionBtn.Name = "BackToSelectionSelectionBtn";
            this.BackToSelectionSelectionBtn.Size = new System.Drawing.Size(205, 40);
            this.BackToSelectionSelectionBtn.TabIndex = 0;
            this.BackToSelectionSelectionBtn.Text = "선택창으로 돌아가기(&B)";
            this.BackToSelectionSelectionBtn.UseVisualStyleBackColor = true;
            this.BackToSelectionSelectionBtn.Click += new System.EventHandler(this.BackToSelectionSelectionBtn_Click);
            // 
            // PresentTestSkipBtn
            // 
            this.PresentTestSkipBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PresentTestSkipBtn.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentTestSkipBtn.Location = new System.Drawing.Point(628, 13);
            this.PresentTestSkipBtn.Name = "PresentTestSkipBtn";
            this.PresentTestSkipBtn.Size = new System.Drawing.Size(190, 40);
            this.PresentTestSkipBtn.TabIndex = 1;
            this.PresentTestSkipBtn.Text = "현재 문제 건너뛰기(&S)";
            this.PresentTestSkipBtn.UseVisualStyleBackColor = true;
            // 
            // GoToNextTextBtn
            // 
            this.GoToNextTextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoToNextTextBtn.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToNextTextBtn.Location = new System.Drawing.Point(681, 404);
            this.GoToNextTextBtn.Name = "GoToNextTextBtn";
            this.GoToNextTextBtn.Size = new System.Drawing.Size(137, 37);
            this.GoToNextTextBtn.TabIndex = 2;
            this.GoToNextTextBtn.Text = "다음 문제로(&N)";
            this.GoToNextTextBtn.UseVisualStyleBackColor = true;
            // 
            // TestCodeViewTxetBox
            // 
            this.TestCodeViewTxetBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestCodeViewTxetBox.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestCodeViewTxetBox.Location = new System.Drawing.Point(13, 59);
            this.TestCodeViewTxetBox.Multiline = true;
            this.TestCodeViewTxetBox.Name = "TestCodeViewTxetBox";
            this.TestCodeViewTxetBox.ReadOnly = true;
            this.TestCodeViewTxetBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TestCodeViewTxetBox.Size = new System.Drawing.Size(418, 259);
            this.TestCodeViewTxetBox.TabIndex = 3;
            // 
            // TestCodeInputTextBox
            // 
            this.TestCodeInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestCodeInputTextBox.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestCodeInputTextBox.Location = new System.Drawing.Point(407, 59);
            this.TestCodeInputTextBox.Multiline = true;
            this.TestCodeInputTextBox.Name = "TestCodeInputTextBox";
            this.TestCodeInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TestCodeInputTextBox.Size = new System.Drawing.Size(413, 259);
            this.TestCodeInputTextBox.TabIndex = 4;
            // 
            // TypingTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.TestCodeInputTextBox);
            this.Controls.Add(this.TestCodeViewTxetBox);
            this.Controls.Add(this.GoToNextTextBtn);
            this.Controls.Add(this.PresentTestSkipBtn);
            this.Controls.Add(this.BackToSelectionSelectionBtn);
            this.Name = "TypingTestForm";
            this.Text = "TypingTestScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TypingTestScreen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToSelectionSelectionBtn;
        private System.Windows.Forms.Button PresentTestSkipBtn;
        private System.Windows.Forms.Button GoToNextTextBtn;
        private System.Windows.Forms.TextBox TestCodeViewTxetBox;
        private System.Windows.Forms.TextBox TestCodeInputTextBox;
    }
}