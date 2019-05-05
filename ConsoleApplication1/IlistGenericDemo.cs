using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class UserInformation
    {
        private string username = string.Empty;
        private string password = string.Empty;
        public UserInformation(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string GetName
        {
            get
            {
                return username;
            }
        }
        public string GetPassword
        {
            get
            {
                return password;
            }
        }
    }
    class CheckUserInformation
    {
        static void Main()
        {
            IList<UserInformation> list = new List<UserInformation>();
            for (int i = 0; i < 5; i++)
            {
                UserInformation ui = new UserInformation("username: " + i.ToString(), "password: " + i.ToString());
                list.Add(ui);
            }
            foreach (UserInformation u in list)
                Console.WriteLine("{0}, {1}",u.GetName,u.GetPassword);
        }
    }
}
