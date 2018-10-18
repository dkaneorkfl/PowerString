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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.MoveToMainMenu = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.TesterName = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearImgList = new System.Windows.Forms.ImageList(this.components);
            this.ClearImg = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearImg)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveToMainMenu
            // 
            this.MoveToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MoveToMainMenu.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveToMainMenu.Location = new System.Drawing.Point(12, 233);
            this.MoveToMainMenu.Name = "MoveToMainMenu";
            this.MoveToMainMenu.Size = new System.Drawing.Size(140, 39);
            this.MoveToMainMenu.TabIndex = 0;
            this.MoveToMainMenu.Text = "메인메뉴로 (&M)";
            this.MoveToMainMenu.UseVisualStyleBackColor = true;
            this.MoveToMainMenu.Click += new System.EventHandler(this.MoveToMainMenu_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(430, 233);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(140, 39);
            this.Close.TabIndex = 1;
            this.Close.Text = "닫기 (&C)";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // TesterName
            // 
            this.TesterName.AutoSize = true;
            this.TesterName.Location = new System.Drawing.Point(6, 35);
            this.TesterName.Name = "TesterName";
            this.TesterName.Size = new System.Drawing.Size(107, 15);
            this.TesterName.TabIndex = 2;
            this.TesterName.Text = "어쩌구 저쩌구!";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Score.Location = new System.Drawing.Point(52, 23);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(496, 40);
            this.Score.TabIndex = 4;
            this.Score.Text = "코드 작성을 완료했습니다!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TesterName);
            this.groupBox1.Location = new System.Drawing.Point(25, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 114);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ooo님";
            // 
            // ClearImgList
            // 
            this.ClearImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ClearImgList.ImageStream")));
            this.ClearImgList.TransparentColor = System.Drawing.Color.Turquoise;
            this.ClearImgList.Images.SetKeyName(0, "more.jpg");
            this.ClearImgList.Images.SetKeyName(1, "welldone.jpg");
            // 
            // ClearImg
            // 
            this.ClearImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearImg.Image = global::PowerString.Properties.Resources.more;
            this.ClearImg.Location = new System.Drawing.Point(449, 97);
            this.ClearImg.Name = "ClearImg";
            this.ClearImg.Size = new System.Drawing.Size(110, 106);
            this.ClearImg.TabIndex = 6;
            this.ClearImg.TabStop = false;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 284);
            this.Controls.Add(this.ClearImg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.MoveToMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MoveToMainMenu;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label TesterName;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList ClearImgList;
        private System.Windows.Forms.PictureBox ClearImg;
    }
}