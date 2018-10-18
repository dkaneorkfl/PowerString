namespace PowerString
{
    partial class DeleteCheckForm
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
            this.DeleteCheckOK = new System.Windows.Forms.Button();
            this.DeleteCheckLB = new System.Windows.Forms.Label();
            this.DeleteCheckNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteCheckOK
            // 
            this.DeleteCheckOK.Location = new System.Drawing.Point(43, 101);
            this.DeleteCheckOK.Name = "DeleteCheckOK";
            this.DeleteCheckOK.Size = new System.Drawing.Size(100, 40);
            this.DeleteCheckOK.TabIndex = 0;
            this.DeleteCheckOK.Text = "OK";
            this.DeleteCheckOK.UseVisualStyleBackColor = true;
            this.DeleteCheckOK.Click += new System.EventHandler(this.DeleteCheckOK_Click);
            // 
            // DeleteCheckLB
            // 
            this.DeleteCheckLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteCheckLB.AutoSize = true;
            this.DeleteCheckLB.Font = new System.Drawing.Font("Gulim", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCheckLB.Location = new System.Drawing.Point(38, 47);
            this.DeleteCheckLB.Name = "DeleteCheckLB";
            this.DeleteCheckLB.Size = new System.Drawing.Size(316, 28);
            this.DeleteCheckLB.TabIndex = 1;
            this.DeleteCheckLB.Text = "정말 삭제하시겠습니까?";
            // 
            // DeleteCheckNO
            // 
            this.DeleteCheckNO.Location = new System.Drawing.Point(245, 101);
            this.DeleteCheckNO.Name = "DeleteCheckNO";
            this.DeleteCheckNO.Size = new System.Drawing.Size(100, 40);
            this.DeleteCheckNO.TabIndex = 2;
            this.DeleteCheckNO.Text = "No";
            this.DeleteCheckNO.UseVisualStyleBackColor = true;
            this.DeleteCheckNO.Click += new System.EventHandler(this.DeleteCheckNO_Click);
            // 
            // DeleteCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 186);
            this.Controls.Add(this.DeleteCheckNO);
            this.Controls.Add(this.DeleteCheckLB);
            this.Controls.Add(this.DeleteCheckOK);
            this.Name = "DeleteCheckForm";
            this.Text = "계정 삭제 확인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteCheckOK;
        private System.Windows.Forms.Label DeleteCheckLB;
        private System.Windows.Forms.Button DeleteCheckNO;
    }
}