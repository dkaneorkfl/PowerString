﻿namespace PowerString
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.SingleGameBtn = new System.Windows.Forms.Button();
            this.BackToMainTitleBtn = new System.Windows.Forms.Button();
            this.UserInfoBtn = new System.Windows.Forms.Button();
            this.MultiGameBtn = new System.Windows.Forms.Button();
            this.SelectCategoryList = new System.Windows.Forms.ComboBox();
            this.ChooseCodeCategoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SingleGameBtn
            // 
            this.SingleGameBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SingleGameBtn.Font = new System.Drawing.Font("굴림", 20F);
            this.SingleGameBtn.Location = new System.Drawing.Point(170, 266);
            this.SingleGameBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SingleGameBtn.Name = "SingleGameBtn";
            this.SingleGameBtn.Size = new System.Drawing.Size(240, 52);
            this.SingleGameBtn.TabIndex = 3;
            this.SingleGameBtn.Text = "싱글게임(&S)";
            this.SingleGameBtn.UseVisualStyleBackColor = true;
            this.SingleGameBtn.Click += new System.EventHandler(this.SingleGameBtn_Click);
            // 
            // BackToMainTitleBtn
            // 
            this.BackToMainTitleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackToMainTitleBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainTitleBtn.Location = new System.Drawing.Point(12, 373);
            this.BackToMainTitleBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackToMainTitleBtn.Name = "BackToMainTitleBtn";
            this.BackToMainTitleBtn.Size = new System.Drawing.Size(140, 39);
            this.BackToMainTitleBtn.TabIndex = 5;
            this.BackToMainTitleBtn.Text = "뒤로가기(&B)";
            this.BackToMainTitleBtn.UseVisualStyleBackColor = true;
            this.BackToMainTitleBtn.Click += new System.EventHandler(this.BackToMainTitleBtn_Click);
            // 
            // UserInfoBtn
            // 
            this.UserInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInfoBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInfoBtn.Location = new System.Drawing.Point(680, 373);
            this.UserInfoBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserInfoBtn.Name = "UserInfoBtn";
            this.UserInfoBtn.Size = new System.Drawing.Size(140, 39);
            this.UserInfoBtn.TabIndex = 0;
            this.UserInfoBtn.Text = "사용자 정보(&U)";
            this.UserInfoBtn.UseVisualStyleBackColor = true;
            this.UserInfoBtn.Click += new System.EventHandler(this.UserInfoBtn_Click);
            // 
            // MultiGameBtn
            // 
            this.MultiGameBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MultiGameBtn.Font = new System.Drawing.Font("굴림", 20F);
            this.MultiGameBtn.Location = new System.Drawing.Point(440, 266);
            this.MultiGameBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MultiGameBtn.Name = "MultiGameBtn";
            this.MultiGameBtn.Size = new System.Drawing.Size(240, 52);
            this.MultiGameBtn.TabIndex = 4;
            this.MultiGameBtn.Text = "멀티게임(&M)";
            this.MultiGameBtn.UseVisualStyleBackColor = true;
            this.MultiGameBtn.Click += new System.EventHandler(this.MultiGameBtn_Click);
            // 
            // SelectCategoryList
            // 
            this.SelectCategoryList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectCategoryList.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SelectCategoryList.FormattingEnabled = true;
            this.SelectCategoryList.Location = new System.Drawing.Point(170, 137);
            this.SelectCategoryList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectCategoryList.Name = "SelectCategoryList";
            this.SelectCategoryList.Size = new System.Drawing.Size(510, 32);
            this.SelectCategoryList.TabIndex = 6;
            this.SelectCategoryList.SelectedIndexChanged += new System.EventHandler(this.SelectCategoryList_SelectedIndexChanged);
            // 
            // ChooseCodeCategoryLabel
            // 
            this.ChooseCodeCategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChooseCodeCategoryLabel.AutoSize = true;
            this.ChooseCodeCategoryLabel.Font = new System.Drawing.Font("굴림", 28F);
            this.ChooseCodeCategoryLabel.Location = new System.Drawing.Point(207, 39);
            this.ChooseCodeCategoryLabel.Name = "ChooseCodeCategoryLabel";
            this.ChooseCodeCategoryLabel.Size = new System.Drawing.Size(428, 47);
            this.ChooseCodeCategoryLabel.TabIndex = 7;
            this.ChooseCodeCategoryLabel.Text = "코드 카테고리 선택";
            this.ChooseCodeCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 425);
            this.Controls.Add(this.ChooseCodeCategoryLabel);
            this.Controls.Add(this.SelectCategoryList);
            this.Controls.Add(this.BackToMainTitleBtn);
            this.Controls.Add(this.MultiGameBtn);
            this.Controls.Add(this.SingleGameBtn);
            this.Controls.Add(this.UserInfoBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMenuForm";
            this.Text = "PowerString";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestSelection_FormClosed);
            this.Load += new System.EventHandler(this.TestSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SingleGameBtn;
        private System.Windows.Forms.Button BackToMainTitleBtn;
        private System.Windows.Forms.Button UserInfoBtn;
        private System.Windows.Forms.Button MultiGameBtn;
        private System.Windows.Forms.ComboBox SelectCategoryList;
        private System.Windows.Forms.Label ChooseCodeCategoryLabel;
    }
}