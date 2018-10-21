namespace PowerString
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
            this.btnSingleGame = new System.Windows.Forms.Button();
            this.btnBackToMainTitle = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.btnMultiGame = new System.Windows.Forms.Button();
            this.cbxCategorySelect = new System.Windows.Forms.ComboBox();
            this.lblChooseCodeCategory = new System.Windows.Forms.Label();
            this.lblExampleCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSingleGame
            // 
            this.btnSingleGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSingleGame.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleGame.Location = new System.Drawing.Point(162, 244);
            this.btnSingleGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSingleGame.Name = "btnSingleGame";
            this.btnSingleGame.Size = new System.Drawing.Size(240, 112);
            this.btnSingleGame.TabIndex = 3;
            this.btnSingleGame.Text = "싱글게임\r\n(&S)";
            this.btnSingleGame.UseVisualStyleBackColor = true;
            this.btnSingleGame.Click += new System.EventHandler(this.SingleGameBtn_Click);
            // 
            // btnBackToMainTitle
            // 
            this.btnBackToMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackToMainTitle.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainTitle.Location = new System.Drawing.Point(12, 398);
            this.btnBackToMainTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBackToMainTitle.Name = "btnBackToMainTitle";
            this.btnBackToMainTitle.Size = new System.Drawing.Size(140, 42);
            this.btnBackToMainTitle.TabIndex = 5;
            this.btnBackToMainTitle.Text = "뒤로가기(&B)";
            this.btnBackToMainTitle.UseVisualStyleBackColor = true;
            this.btnBackToMainTitle.Click += new System.EventHandler(this.BackToMainTitleBtn_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserInfo.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInfo.Location = new System.Drawing.Point(680, 398);
            this.btnUserInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(140, 42);
            this.btnUserInfo.TabIndex = 0;
            this.btnUserInfo.Text = "사용자 정보(&U)";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Click += new System.EventHandler(this.UserInfoBtn_Click);
            // 
            // btnMultiGame
            // 
            this.btnMultiGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMultiGame.Font = new System.Drawing.Font("Gulim", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiGame.Location = new System.Drawing.Point(435, 244);
            this.btnMultiGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMultiGame.Name = "btnMultiGame";
            this.btnMultiGame.Size = new System.Drawing.Size(240, 112);
            this.btnMultiGame.TabIndex = 4;
            this.btnMultiGame.Text = "멀티게임\r\n(&M)";
            this.btnMultiGame.UseVisualStyleBackColor = true;
            this.btnMultiGame.Click += new System.EventHandler(this.MultiGameBtn_Click);
            // 
            // cbxCategorySelect
            // 
            this.cbxCategorySelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCategorySelect.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxCategorySelect.FormattingEnabled = true;
            this.cbxCategorySelect.Location = new System.Drawing.Point(165, 130);
            this.cbxCategorySelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCategorySelect.Name = "cbxCategorySelect";
            this.cbxCategorySelect.Size = new System.Drawing.Size(510, 32);
            this.cbxCategorySelect.TabIndex = 6;
            this.cbxCategorySelect.SelectedValueChanged += new System.EventHandler(this.cbxCategorySelect_SelectedValueChanged);
            // 
            // lblChooseCodeCategory
            // 
            this.lblChooseCodeCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChooseCodeCategory.AutoSize = true;
            this.lblChooseCodeCategory.Font = new System.Drawing.Font("Gulim", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblChooseCodeCategory.Location = new System.Drawing.Point(208, 42);
            this.lblChooseCodeCategory.Name = "lblChooseCodeCategory";
            this.lblChooseCodeCategory.Size = new System.Drawing.Size(436, 48);
            this.lblChooseCodeCategory.TabIndex = 7;
            this.lblChooseCodeCategory.Text = "코드 카테고리 선택";
            this.lblChooseCodeCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExampleCount
            // 
            this.lblExampleCount.AutoSize = true;
            this.lblExampleCount.Location = new System.Drawing.Point(47, 142);
            this.lblExampleCount.Name = "lblExampleCount";
            this.lblExampleCount.Size = new System.Drawing.Size(46, 17);
            this.lblExampleCount.TabIndex = 8;
            this.lblExampleCount.Text = "label1";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.lblExampleCount);
            this.Controls.Add(this.lblChooseCodeCategory);
            this.Controls.Add(this.cbxCategorySelect);
            this.Controls.Add(this.btnBackToMainTitle);
            this.Controls.Add(this.btnMultiGame);
            this.Controls.Add(this.btnSingleGame);
            this.Controls.Add(this.btnUserInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMenuForm";
            this.Text = "PowerString";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestSelection_FormClosed);
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSingleGame;
        private System.Windows.Forms.Button btnBackToMainTitle;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnMultiGame;
        private System.Windows.Forms.ComboBox cbxCategorySelect;
        private System.Windows.Forms.Label lblChooseCodeCategory;
        private System.Windows.Forms.Label lblExampleCount;
    }
}