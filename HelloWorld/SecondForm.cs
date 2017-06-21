using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {

            String s;
            s = "Здрасти!!! Това е твоята първа програма на Visual Studio 2015 !!! ";
            MessageBox.Show(s);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s;
            s = "Здравейте, ";
            s = s + '\n';
            foreach (var item in gbUser.Controls)
            {
                if (item is TextBox)
                {
                  
                    s = s + ((TextBox)item).Text;
                    s = s + '\n';
          
                }
            }
            s = s + " Това е твоята първа програма на visual studio 2015";
            MessageBox.Show(s);
            /*
            if (txtName.TextLength <= 2)
            {

                txtName.Text= ("Името трябва да съдържа минимум 3 букви !!!"); 
                // Важен момент !!! Както можем да извличаме така можем и да пишем във формите(ТеxtBox) !!!   
            }
            else
            {
                s = "Здрасти, ";
                s = s + txtName.Text + txtName2.Text + txtName3.Text;
                s = s + "\n Това е твоята първа програма на visual studio 2015";
                MessageBox.Show(s);
            }
            */
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Умножение на две числа : 
            int x, y, res;
            String result;
            x = int.Parse(X.Text);
            y = int.Parse(Y.Text);
            res = x * y;
            result = res.ToString();
            equality.Text = result;

            // Факториел :
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FactCalc_Click(object sender, EventArgs e)
        {
            int fact;
            int rs = 1;
            fact = int.Parse(factoriel.Text);
            for (int i = 1; i <= fact; i++)
            {
                rs = rs * i;
            }
            ResFact.Text = rs.ToString();
        }

        private void CCB_Click(object sender, EventArgs e)
        {
            CCB.BackColor = Color.GreenYellow;
        }

        private void CCBMultiply_Click(object sender, EventArgs e)
        {
            X.BackColor = Color.Red;
            Y.BackColor = Color.Blue;
            equality.BackColor = Color.Coral;
        }

        private void CCBFact_Click(object sender, EventArgs e)
        {
            factoriel.BackColor = Color.Red;
            ResFact.BackColor = Color.Blue;
        }

        private void txtName3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
