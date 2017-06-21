using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.Data
{
    class UserData
    {

        public static int IsUserPassCorrect(String username, String password)
        {
            return UserData._IsUserPassCorrect(username, password);
        }

        public static int _IsUserPassCorrect(String username, String password)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            String Query = "SELECT * FROM Users "
                            + "WHERE Users.Username = '" + username + "' "
                            + "AND Users.Password = '" + password + "'";

            user[] queryArray;
            IEnumerable<user> queryResult = dc.ExecuteQuery<user>(Query);
            queryArray = queryResult.ToArray<user>();

            if (queryResult == null)
            {
                return -1;
            }
            else
            {
                return queryArray[0].Role;
            }

            

        }
        
      
	}





    }

