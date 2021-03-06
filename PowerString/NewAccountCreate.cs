﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerString
{
    public partial class NewAccountCreate : Form
    {
        private MainTitle _mt;

        public NewAccountCreate(MainTitle mainForm)
        {
            _mt = mainForm;
            InitializeComponent();
            this.Location = new Point(100, 100);
        }

        private void NewAccountCreateBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _mt.Visible = true;
            _mt.Location = new Point(100, 100);
            this.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }
    }
}
