using System;
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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        // 메인메뉴로 돌아가기 버튼
        private void MoveToMainMenu_Click(object sender, EventArgs e)
        {
            MoveEvent.MoveToForm(new MainMenuForm());
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
