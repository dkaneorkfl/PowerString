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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypingTestForm));
            this.BackToSelectionSelectionBtn = new System.Windows.Forms.Button();
            this.PresentTestSkipBtn = new System.Windows.Forms.Button();
            this.GoToNextTextBtn = new System.Windows.Forms.Button();
            this.TestCodeViewTxetBox = new System.Windows.Forms.TextBox();
            this.TestCodeInputTextBox = new System.Windows.Forms.TextBox();
            this.ExampleBox = new System.Windows.Forms.GroupBox();
            this.TimeProgress = new System.Windows.Forms.ProgressBar();
            this.TestTime = new System.Windows.Forms.Timer(this.components);
            this.ExampleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackToSelectionSelectionBtn
            // 
            this.BackToSelectionSelectionBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToSelectionSelectionBtn.Location = new System.Drawing.Point(12, 12);
            this.BackToSelectionSelectionBtn.Name = "BackToSelectionSelectionBtn";
            this.BackToSelectionSelectionBtn.Size = new System.Drawing.Size(210, 39);
            this.BackToSelectionSelectionBtn.TabIndex = 0;
            this.BackToSelectionSelectionBtn.Text = "선택창으로 돌아가기(&B)";
            this.BackToSelectionSelectionBtn.UseVisualStyleBackColor = true;
            this.BackToSelectionSelectionBtn.Click += new System.EventHandler(this.BackToSelectionSelectionBtn_Click);
            // 
            // PresentTestSkipBtn
            // 
            this.PresentTestSkipBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PresentTestSkipBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentTestSkipBtn.Location = new System.Drawing.Point(610, 12);
            this.PresentTestSkipBtn.Name = "PresentTestSkipBtn";
            this.PresentTestSkipBtn.Size = new System.Drawing.Size(210, 39);
            this.PresentTestSkipBtn.TabIndex = 1;
            this.PresentTestSkipBtn.Text = "현재 문제 건너뛰기(&S)";
            this.PresentTestSkipBtn.UseVisualStyleBackColor = true;
            // 
            // GoToNextTextBtn
            // 
            this.GoToNextTextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoToNextTextBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToNextTextBtn.Location = new System.Drawing.Point(680, 378);
            this.GoToNextTextBtn.Name = "GoToNextTextBtn";
            this.GoToNextTextBtn.Size = new System.Drawing.Size(140, 39);
            this.GoToNextTextBtn.TabIndex = 2;
            this.GoToNextTextBtn.Text = "다음 문제로(&N)";
            this.GoToNextTextBtn.UseVisualStyleBackColor = true;
            // 
            // TestCodeViewTxetBox
            // 
            this.TestCodeViewTxetBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TestCodeViewTxetBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TestCodeViewTxetBox.Enabled = false;
            this.TestCodeViewTxetBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestCodeViewTxetBox.Location = new System.Drawing.Point(3, 21);
            this.TestCodeViewTxetBox.Multiline = true;
            this.TestCodeViewTxetBox.Name = "TestCodeViewTxetBox";
            this.TestCodeViewTxetBox.ReadOnly = true;
            this.TestCodeViewTxetBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TestCodeViewTxetBox.Size = new System.Drawing.Size(395, 262);
            this.TestCodeViewTxetBox.TabIndex = 3;
            // 
            // TestCodeInputTextBox
            // 
            this.TestCodeInputTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.TestCodeInputTextBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestCodeInputTextBox.Location = new System.Drawing.Point(410, 21);
            this.TestCodeInputTextBox.Multiline = true;
            this.TestCodeInputTextBox.Name = "TestCodeInputTextBox";
            this.TestCodeInputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TestCodeInputTextBox.Size = new System.Drawing.Size(395, 262);
            this.TestCodeInputTextBox.TabIndex = 4;
            // 
            // ExampleBox
            // 
            this.ExampleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExampleBox.Controls.Add(this.TestCodeViewTxetBox);
            this.ExampleBox.Controls.Add(this.TestCodeInputTextBox);
            this.ExampleBox.Location = new System.Drawing.Point(12, 57);
            this.ExampleBox.Name = "ExampleBox";
            this.ExampleBox.Size = new System.Drawing.Size(808, 286);
            this.ExampleBox.TabIndex = 5;
            this.ExampleBox.TabStop = false;
            this.ExampleBox.Text = "문제 x/y";
            // 
            // TimeProgress
            // 
            this.TimeProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeProgress.BackColor = System.Drawing.SystemColors.Control;
            this.TimeProgress.ForeColor = System.Drawing.Color.Magenta;
            this.TimeProgress.Location = new System.Drawing.Point(12, 349);
            this.TimeProgress.MarqueeAnimationSpeed = 1;
            this.TimeProgress.Maximum = 10;
            this.TimeProgress.Name = "TimeProgress";
            this.TimeProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeProgress.Size = new System.Drawing.Size(808, 23);
            this.TimeProgress.Step = -1;
            this.TimeProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.TimeProgress.TabIndex = 0;
            this.TimeProgress.Value = 10;
            // 
            // TestTime
            // 
            this.TestTime.Interval = 1;
            this.TestTime.Tick += new System.EventHandler(this.TestTime_Tick);
            // 
            // TypingTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 425);
            this.Controls.Add(this.ExampleBox);
            this.Controls.Add(this.TimeProgress);
            this.Controls.Add(this.GoToNextTextBtn);
            this.Controls.Add(this.PresentTestSkipBtn);
            this.Controls.Add(this.BackToSelectionSelectionBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TypingTestForm";
            this.Text = "PowerString";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TypingTestScreen_FormClosed);
            this.ExampleBox.ResumeLayout(false);
            this.ExampleBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToSelectionSelectionBtn;
        private System.Windows.Forms.Button PresentTestSkipBtn;
        private System.Windows.Forms.Button GoToNextTextBtn;
        private System.Windows.Forms.TextBox TestCodeViewTxetBox;
        private System.Windows.Forms.TextBox TestCodeInputTextBox;
        private System.Windows.Forms.GroupBox ExampleBox;
        private System.Windows.Forms.ProgressBar TimeProgress;
        private System.Windows.Forms.Timer TestTime;
    }
}