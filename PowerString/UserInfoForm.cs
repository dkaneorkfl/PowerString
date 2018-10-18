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
    public partial class UserInfoForm : Form
    {
        private MainMenuForm _mainMenuForm = null;

        private UserInfoForm()
        {
            InitializeComponent();
        }

        public UserInfoForm(MainMenuForm mainMenuForm) : this()
        {
            _mainMenuForm = mainMenuForm;
        }


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void UserDeleteBtn_Click(object sender, EventArgs e)
        {
            MoveEvent.MoveToForm(new StartForm());
            _mainMenuForm.CloseForm();
            this.Close();
        }
    }
}
