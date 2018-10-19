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
            this.ResultLine = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.TextGroup = new System.Windows.Forms.GroupBox();
            this.ResultImg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearImgList = new System.Windows.Forms.ImageList(this.components);
            this.TextGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImg)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ResultLine
            // 
            this.ResultLine.AutoSize = true;
            this.ResultLine.Location = new System.Drawing.Point(6, 35);
            this.ResultLine.Name = "ResultLine";
            this.ResultLine.Size = new System.Drawing.Size(107, 15);
            this.ResultLine.TabIndex = 2;
            this.ResultLine.Text = "어쩌구 저쩌구!";
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
            // TextGroup
            // 
            this.TextGroup.Controls.Add(this.ResultLine);
            this.TextGroup.Location = new System.Drawing.Point(25, 89);
            this.TextGroup.Name = "TextGroup";
            this.TextGroup.Size = new System.Drawing.Size(415, 130);
            this.TextGroup.TabIndex = 5;
            this.TextGroup.TabStop = false;
            this.TextGroup.Text = "ooo님";
            // 
            // ResultImg
            // 
            this.ResultImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResultImg.Image = global::PowerString.Properties.Resources.verymore;
            this.ResultImg.Location = new System.Drawing.Point(3, 3);
            this.ResultImg.Name = "ResultImg";
            this.ResultImg.Size = new System.Drawing.Size(110, 108);
            this.ResultImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResultImg.TabIndex = 6;
            this.ResultImg.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.ResultImg);
            this.panel1.Location = new System.Drawing.Point(446, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 114);
            this.panel1.TabIndex = 6;
            // 
            // ClearImgList
            // 
            this.ClearImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ClearImgList.ImageStream")));
            this.ClearImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.ClearImgList.Images.SetKeyName(0, "more.jpg");
            this.ClearImgList.Images.SetKeyName(1, "verymore.jpg");
            this.ClearImgList.Images.SetKeyName(2, "welldone.jpg");
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 284);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextGroup);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.MoveToMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.TextGroup.ResumeLayout(false);
            this.TextGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MoveToMainMenu;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label ResultLine;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.GroupBox TextGroup;
        private System.Windows.Forms.PictureBox ResultImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList ClearImgList;
    }
}