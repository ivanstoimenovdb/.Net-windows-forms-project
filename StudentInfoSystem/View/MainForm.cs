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
    public partial class MainForm : Form
    {
        public UserStatus userStatus; // Член Променлива за потребителите!!! 
        public MainForm()
        {
            InitializeComponent();
            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox helpBox = new AboutBox();
            helpBox.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        public void returnClearMethod()
        {



            if (loginLogoutToolStripMenuItem.Text == "Logout")
            {


                foreach (var item in groupPrivate.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                }
            }
            else
            {

                DefaultValue();

            }
        }


        public void OnlyClearMethod()
        {

            foreach (var item in groupPrivate.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
            foreach (var item in StudentInfo.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();

                }
                if (item is ComboBox)
                {
                    ((ComboBox)item).Items.Clear();
                }

            }

        }

        public void deactive()
        {
            foreach (var item in groupPrivate.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Enabled = false;
                }
            }
            foreach (var item in StudentInfo.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Enabled = false;
                }
                if (item is ComboBox)
                {
                    ((ComboBox)item).Enabled = false;
                }
            }
        }

        public void active()
        {
            foreach (var item in groupPrivate.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Enabled = true;
                }
            }
            foreach (var item in StudentInfo.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Enabled = true;
                }
                if (item is ComboBox)
                {
                    ((ComboBox)item).Enabled = true;
                }
            }
        }


        public void DefaultValue()
        {
            String ownName, fatherName, lastName, faculty, facNum, spec, flow, group;
            String combOKS, statComb, combCou;
            //comboOKS.Items.Add("Бакалавър");
            //StatusCombo.Items.Add("Учещ");
            //comboCourse.Items.Add("5");

            combOKS = "Бакалавър";
            statComb = "Учещ";
            combCou = "5";

            ownName = "Иван";
            fatherName = "Петров";
            lastName = "Стоименов";
            faculty = "ФКСТ";
            facNum = "391616014";
            spec = "КСИ И ИТ";
            flow = "1";
            group = "1";

            FirstName.Text = ownName;
            SecondName.Text = fatherName;
            LastName.Text = lastName;
            textFac.Text = faculty;
            textFacNum.Text = facNum;
            textFlow.Text = flow;
            textGroup.Text = group;
            textSpec.Text = spec;
            comboOKS.Items.Add(combOKS);
            StatusCombo.Items.Add(statComb);
            comboCourse.Items.Add(combCou);


        }

        public void DinamicValue()
        {
            String OwnName, FatherName, LastFRName;

            OwnName = FirstName.Text;
            FatherName = SecondName.Text;
            LastFRName = LastName.Text;

        }

        // Check Parameter for excisting
        private bool CheckParameter()
        {
            foreach (var item in groupPrivate.Controls)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).TextLength == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

            return false;
        }



        // check parameter for atleast 6 symbols
        private bool CheckLengthPar()
        {
            foreach (var item in groupPrivate.Controls)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).TextLength <= 6)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        private void loginLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LoginForm openForm = new LoginForm();
            openForm.ShowDialog();


            /*
            String fName, SName, LName;
            fName = FirstName.Text;
            SName = SecondName.Text;
            LName = LastName.Text;

            // Change button from login --> logout
            if (loginLogoutToolStripMenuItem.Text == "Login")
            {
                loginLogoutToolStripMenuItem.Text = "Logout";
            }
            else
            {
                loginLogoutToolStripMenuItem.Text = "Login";
            }
            */
            /*
            // Clear and return default 
            if (loginLogoutToolStripMenuItem.Text == "Logout")
            {
                OnlyClearMethod();
                userStatus = UserStatus.ANONYMOUS;
            }
            else
            {
                DefaultValue();
                userStatus = UserStatus.STUDENT;
            }
            */
            /*
            if (loginLogoutToolStripMenuItem.Text == "Logout")
            {
                userStatus = UserStatus.ANONYMOUS;
            }
            else
            {
                userStatus = UserStatus.STUDENT;
            }
            */
            //returnClearMethod();

            // Change settings by users;
            if (userStatus == UserStatus.ANONYMOUS)
            {
                DefaultValue();
                deactive();
            }
            else
            {
                OnlyClearMethod();
                active();
            }


            //MessageBox.Show(fName+" "+SName+" "+LName);




        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            String s;
            if (CheckParameter() && CheckLengthPar())
            {
                s = "Здрасти ";
                s = s + FirstName.Text;
                s = s + "\n Това е твоята първа програма на Visual Studio 2015!";
                MessageBox.Show(s);

            }
            else
            {
                MessageBox.Show("Някое от имената или не са попълнени или са по- малко от 6 знака !!!");
            }





        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AboutBox openAbout = new AboutBox();
            openAbout.ShowDialog();
        }

        private void uploadPic_Click(object sender, EventArgs e)
        {
            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                picture.ImageLocation = openPictureDialog.FileName;
            }

        }

        




    }
}