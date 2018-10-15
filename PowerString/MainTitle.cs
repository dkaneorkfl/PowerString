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
    public partial class MainTitle : Form
    {
        public MainTitle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PracticeProblem_Click(object sender, EventArgs e)
        {
            SelectionOfProblem selectionOfProblem = new SelectionOfProblem(); //버튼을 클릭하면 3번화면이 나오게됨.
            selectionOfProblem.ShowDialog();//model
        }
    }
}
