namespace PowerString
{
    partial class UserInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoForm));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MyInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectBySmallCat = new System.Windows.Forms.ComboBox();
            this.SelectByBigCat = new System.Windows.Forms.ComboBox();
            this.UserDeleteBtn = new System.Windows.Forms.Button();
            this.UserListLB = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Location = new System.Drawing.Point(711, 414);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(109, 27);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "닫기(&C)";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // MyInfo
            // 
            this.MyInfo.Location = new System.Drawing.Point(11, 18);
            this.MyInfo.Multiline = true;
            this.MyInfo.Name = "MyInfo";
            this.MyInfo.ReadOnly = true;
            this.MyInfo.Size = new System.Drawing.Size(163, 107);
            this.MyInfo.TabIndex = 2;
            this.MyInfo.Text = "내 정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "연습 기록 정렬하기";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.SelectBySmallCat);
            this.groupBox1.Controls.Add(this.SelectByBigCat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(180, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(640, 393);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "선택한 사용자 연습 기록";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(624, 315);
            this.dataGridView1.TabIndex = 7;
            // 
            // SelectBySmallCat
            // 
            this.SelectBySmallCat.FormattingEnabled = true;
            this.SelectBySmallCat.Location = new System.Drawing.Point(376, 33);
            this.SelectBySmallCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectBySmallCat.Name = "SelectBySmallCat";
            this.SelectBySmallCat.Size = new System.Drawing.Size(258, 28);
            this.SelectBySmallCat.TabIndex = 6;
            // 
            // SelectByBigCat
            // 
            this.SelectByBigCat.FormattingEnabled = true;
            this.SelectByBigCat.Location = new System.Drawing.Point(195, 33);
            this.SelectByBigCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectByBigCat.Name = "SelectByBigCat";
            this.SelectByBigCat.Size = new System.Drawing.Size(175, 28);
            this.SelectByBigCat.TabIndex = 5;
            this.SelectByBigCat.SelectedIndexChanged += new System.EventHandler(this.SelectByBigCat_SelectedIndexChanged);
            // 
            // UserDeleteBtn
            // 
            this.UserDeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UserDeleteBtn.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDeleteBtn.Location = new System.Drawing.Point(11, 132);
            this.UserDeleteBtn.Name = "UserDeleteBtn";
            this.UserDeleteBtn.Size = new System.Drawing.Size(163, 36);
            this.UserDeleteBtn.TabIndex = 6;
            this.UserDeleteBtn.Text = "내 계정 삭제";
            this.UserDeleteBtn.UseVisualStyleBackColor = true;
            this.UserDeleteBtn.Click += new System.EventHandler(this.UserDeleteBtn_Click);
            // 
            // UserListLB
            // 
            this.UserListLB.FormattingEnabled = true;
            this.UserListLB.ItemHeight = 16;
            this.UserListLB.Location = new System.Drawing.Point(11, 175);
            this.UserListLB.Name = "UserListLB";
            this.UserListLB.Size = new System.Drawing.Size(163, 228);
            this.UserListLB.TabIndex = 7;
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.UserListLB);
            this.Controls.Add(this.UserDeleteBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MyInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserInfoForm";
            this.Text = "PowerText";
            this.Load += new System.EventHandler(this.UserInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MyInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox SelectBySmallCat;
        private System.Windows.Forms.ComboBox SelectByBigCat;
        private System.Windows.Forms.Button UserDeleteBtn;
        private System.Windows.Forms.ListBox UserListLB;
    }
}