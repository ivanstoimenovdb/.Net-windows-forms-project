using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoSystem.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            StudentInfoSystem.Logic.LoginValidation lv = new StudentInfoSystem.Logic.LoginValidation(UserBox.Text,PassBox.Text);
            lv.ValidateUserInput();
            if (lv.ValidateUserInput())
            {
                this.Hide();
                this.DialogResult = DialogResult.OK;
                MainForm secondForm = new MainForm();
                secondForm.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show(lv.errText);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LogInWindow_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
