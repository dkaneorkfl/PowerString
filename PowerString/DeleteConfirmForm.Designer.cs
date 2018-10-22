namespace PowerString
{
    partial class DeleteConfirmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteConfirmForm));
            this.DeleteOK = new System.Windows.Forms.Button();
            this.DeleteCheckLB = new System.Windows.Forms.Label();
            this.DeleteNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteOK
            // 
            this.DeleteOK.Location = new System.Drawing.Point(18, 191);
            this.DeleteOK.Name = "DeleteOK";
            this.DeleteOK.Size = new System.Drawing.Size(150, 50);
            this.DeleteOK.TabIndex = 1;
            this.DeleteOK.Text = "OK(&O)";
            this.DeleteOK.UseVisualStyleBackColor = true;
            this.DeleteOK.Click += new System.EventHandler(this.DeleteOK_Click);
            // 
            // DeleteCheckLB
            // 
            this.DeleteCheckLB.AutoSize = true;
            this.DeleteCheckLB.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCheckLB.Location = new System.Drawing.Point(12, 62);
            this.DeleteCheckLB.Name = "DeleteCheckLB";
            this.DeleteCheckLB.Size = new System.Drawing.Size(341, 33);
            this.DeleteCheckLB.TabIndex = 2;
            this.DeleteCheckLB.Text = "정말 삭제하시렵니까?";
            // 
            // DeleteNO
            // 
            this.DeleteNO.Location = new System.Drawing.Point(212, 191);
            this.DeleteNO.Name = "DeleteNO";
            this.DeleteNO.Size = new System.Drawing.Size(150, 50);
            this.DeleteNO.TabIndex = 0;
            this.DeleteNO.Text = "NO(&N)";
            this.DeleteNO.UseVisualStyleBackColor = true;
            this.DeleteNO.Click += new System.EventHandler(this.DeleteNO_Click);
            this.DeleteNO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeleteNO_KeyDown);
            // 
            // DeleteConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.DeleteNO);
            this.Controls.Add(this.DeleteCheckLB);
            this.Controls.Add(this.DeleteOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteConfirmForm";
            this.Text = "DeleteConfirmForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteOK;
        private System.Windows.Forms.Label DeleteCheckLB;
        private System.Windows.Forms.Button DeleteNO;
    }
}