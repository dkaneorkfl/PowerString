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
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.tbxTestExample = new System.Windows.Forms.TextBox();
            this.tbxUserInput = new System.Windows.Forms.TextBox();
            this.pgbTimer = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainMenu.Location = new System.Drawing.Point(12, 13);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(205, 41);
            this.btnBackToMainMenu.TabIndex = 4;
            this.btnBackToMainMenu.Text = "메인메뉴로(&B)";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkip.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(613, 13);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(205, 41);
            this.btnSkip.TabIndex = 1;
            this.btnSkip.Text = "현재 문제 건너뛰기(&S)";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.TextChanged += new System.EventHandler(this.btnSkip_TextChanged);
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnResult
            // 
            this.btnResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResult.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(678, 404);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(140, 42);
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
            this.tbxTestExample.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTestExample.Location = new System.Drawing.Point(3, 3);
            this.tbxTestExample.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.tbxTestExample.Multiline = true;
            this.tbxTestExample.Name = "tbxTestExample";
            this.tbxTestExample.ReadOnly = true;
            this.tbxTestExample.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxTestExample.Size = new System.Drawing.Size(390, 301);
            this.tbxTestExample.TabIndex = 3;
            // 
            // tbxUserInput
            // 
            this.tbxUserInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxUserInput.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserInput.Location = new System.Drawing.Point(413, 3);
            this.tbxUserInput.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tbxUserInput.Multiline = true;
            this.tbxUserInput.Name = "tbxUserInput";
            this.tbxUserInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxUserInput.Size = new System.Drawing.Size(390, 301);
            this.tbxUserInput.TabIndex = 1;
            // 
            // pgbTimer
            // 
            this.pgbTimer.Location = new System.Drawing.Point(76, 373);
            this.pgbTimer.Maximum = 6000;
            this.pgbTimer.Name = "pgbTimer";
            this.pgbTimer.Size = new System.Drawing.Size(742, 25);
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
            this.lbl.Location = new System.Drawing.Point(20, 377);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(46, 17);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbxTestExample, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxUserInput, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(806, 307);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TypingTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pgbTimer);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TypingTestForm";
            this.Text = "PowerString";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TypingTestForm_FormClosed);
            this.Load += new System.EventHandler(this.TypingTestForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}