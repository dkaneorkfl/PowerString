namespace PowerString
{
    partial class QuizSelection
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
            this.SingleGameButton = new System.Windows.Forms.Button();
            this.MainTitleReturnButton = new System.Windows.Forms.Button();
            this.UserInfobtn = new System.Windows.Forms.Button();
            this.MultiGameButton = new System.Windows.Forms.Button();
            this.SelectCategoryList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SingleGameButton
            // 
            this.SingleGameButton.Location = new System.Drawing.Point(12, 246);
            this.SingleGameButton.Name = "SingleGameButton";
            this.SingleGameButton.Size = new System.Drawing.Size(273, 82);
            this.SingleGameButton.TabIndex = 3;
            this.SingleGameButton.Text = "싱글게임";
            this.SingleGameButton.UseVisualStyleBackColor = true;
            this.SingleGameButton.Click += new System.EventHandler(this.SingleGameButton_Click);
            // 
            // MainTitleReturnButton
            // 
            this.MainTitleReturnButton.Location = new System.Drawing.Point(713, 415);
            this.MainTitleReturnButton.Name = "MainTitleReturnButton";
            this.MainTitleReturnButton.Size = new System.Drawing.Size(75, 23);
            this.MainTitleReturnButton.TabIndex = 5;
            this.MainTitleReturnButton.Text = "뒤로가기";
            this.MainTitleReturnButton.UseVisualStyleBackColor = true;
            this.MainTitleReturnButton.Click += new System.EventHandler(this.MainTitleReturnButton_Click);
            // 
            // UserInfobtn
            // 
            this.UserInfobtn.Location = new System.Drawing.Point(585, 415);
            this.UserInfobtn.Name = "UserInfobtn";
            this.UserInfobtn.Size = new System.Drawing.Size(96, 23);
            this.UserInfobtn.TabIndex = 0;
            this.UserInfobtn.Text = "사용자 정보(&U)";
            this.UserInfobtn.UseVisualStyleBackColor = true;
            this.UserInfobtn.Click += new System.EventHandler(this.button1UserInfobtn_Click_1);
            // 
            // MultiGameButton
            // 
            this.MultiGameButton.Location = new System.Drawing.Point(526, 245);
            this.MultiGameButton.Name = "MultiGameButton";
            this.MultiGameButton.Size = new System.Drawing.Size(262, 82);
            this.MultiGameButton.TabIndex = 4;
            this.MultiGameButton.Text = "멀티게임";
            this.MultiGameButton.UseVisualStyleBackColor = true;
            this.MultiGameButton.Click += new System.EventHandler(this.MultiGameButton_Click);
            // 
            // SelectCategoryList
            // 
            this.SelectCategoryList.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SelectCategoryList.FormattingEnabled = true;
            this.SelectCategoryList.Location = new System.Drawing.Point(166, 111);
            this.SelectCategoryList.Name = "SelectCategoryList";
            this.SelectCategoryList.Size = new System.Drawing.Size(449, 27);
            this.SelectCategoryList.TabIndex = 6;
            this.SelectCategoryList.SelectedIndexChanged += new System.EventHandler(this.SelectCategoryList_SelectedIndexChanged);
            // 
            // QuizSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectCategoryList);
            this.Controls.Add(this.MainTitleReturnButton);
            this.Controls.Add(this.MultiGameButton);
            this.Controls.Add(this.SingleGameButton);
            this.Controls.Add(this.UserInfobtn);
            this.Name = "QuizSelection";
            this.Text = "QuizSelection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuizSelection_FormClosed);
            this.Load += new System.EventHandler(this.QuizSelection_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SingleGameButton;
        private System.Windows.Forms.Button MainTitleReturnButton;
        private System.Windows.Forms.Button UserInfobtn;
        private System.Windows.Forms.Button MultiGameButton;
        private System.Windows.Forms.ComboBox SelectCategoryList;
    }
}