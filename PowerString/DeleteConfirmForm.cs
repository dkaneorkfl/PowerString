using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerString;
using PowerString.Data;

namespace PowerString
{
    public partial class DeleteConfirmForm : Form
    {
        private MainMenuForm _mainMenuForm;
        private UserInfoForm _userInfoForm;
        private Tester _tester;

        private DeleteConfirmForm()
        {
            InitializeComponent();
        }

        public DeleteConfirmForm(MainMenuForm mainMenuForm, UserInfoForm userInfoForm, Tester tester) : this()
        {
            _mainMenuForm = mainMenuForm;
            _userInfoForm = userInfoForm;
            _tester = tester;
        }

        private void DeleteOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("계정이 삭제되었습니다.");
            DataRepository.Tester.Delete(_tester);

            this.Close();
            _userInfoForm.Close();
            _mainMenuForm.CloseForm();
            MoveEvent.MoveToForm(new StartForm());
        }

        private void DeleteNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteNO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
