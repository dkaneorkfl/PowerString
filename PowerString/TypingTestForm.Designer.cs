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
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.tbxTestExample = new System.Windows.Forms.TextBox();
            this.tbxUserInput = new System.Windows.Forms.TextBox();
            this.pgbTimer = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainMenu.Location = new System.Drawing.Point(13, 12);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(205, 38);
            this.btnBackToMainMenu.TabIndex = 0;
            this.btnBackToMainMenu.Text = "메인메뉴로(&B)";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkip.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(613, 12);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(205, 38);
            this.btnSkip.TabIndex = 1;
            this.btnSkip.Text = "현재 문제 건너뛰기(&S)";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.TextChanged += new System.EventHandler(this.btnSkip_TextChanged);
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnResult
            // 
            this.btnResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResult.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(681, 379);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(137, 35);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "결과 확인(&N)";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // tbxTestExample
            // 
            this.tbxTestExample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTestExample.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTestExample.Location = new System.Drawing.Point(13, 55);
            this.tbxTestExample.Multiline = true;
            this.tbxTestExample.Name = "tbxTestExample";
            this.tbxTestExample.ReadOnly = true;
            this.tbxTestExample.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxTestExample.Size = new System.Drawing.Size(395, 243);
            this.tbxTestExample.TabIndex = 3;
            // 
            // tbxUserInput
            // 
            this.tbxUserInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxUserInput.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserInput.Location = new System.Drawing.Point(425, 56);
            this.tbxUserInput.Multiline = true;
            this.tbxUserInput.Name = "tbxUserInput";
            this.tbxUserInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxUserInput.Size = new System.Drawing.Size(395, 243);
            this.tbxUserInput.TabIndex = 4;
            // 
            // pgbTimer
            // 
            this.pgbTimer.Location = new System.Drawing.Point(86, 332);
            this.pgbTimer.Name = "pgbTimer";
            this.pgbTimer.Size = new System.Drawing.Size(651, 23);
            this.pgbTimer.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(31, 379);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(45, 15);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "label1";
            // 
            // TypingTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 425);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pgbTimer);
            this.Controls.Add(this.tbxUserInput);
            this.Controls.Add(this.tbxTestExample);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Name = "TypingTestForm";
            this.Text = "TypingTestScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TypingTestForm_FormClosed);
            this.Load += new System.EventHandler(this.TypingTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox tbxTestExample;
        private System.Windows.Forms.TextBox tbxUserInput;
        private System.Windows.Forms.ProgressBar pgbTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl;
    }
}