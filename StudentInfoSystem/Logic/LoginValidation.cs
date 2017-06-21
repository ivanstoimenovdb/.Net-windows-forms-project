using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.Logic
{

    class LoginValidation
    {
        private string _username;
        private string _password;
        public string errText { get; private set; }

        public LoginValidation(string username, string pass)
        {
            this._username = username;
            this._password = pass;
            errText = string.Empty;
        }
        private bool CheckLengthPar()
        {
            Boolean b;
            if (_username.Length < 4 || _password.Length < 4)
            {
                b = false;
            }
            else
            {
                b = true;
            }

            return b;
        }

        public bool ValidateUserInput()
        {
            Boolean b;
            if (CheckLengthPar())
            {
                b = true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Въвели сте по–малко от 4  символа ! Поне едно от олетата трябва да съдържат поне 4 символа");
                b = false;
            }



            int UserExists = StudentInfoSystem.Data.UserData._IsUserPassCorrect(_username, _password);
            if (UserExists < 1)
            {
                errText += "Въвели сте грешно потребителско име или парола!";
                return false;
            }

            return b;


        }
    }
}
