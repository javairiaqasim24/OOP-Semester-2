using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signup
{
    internal class MUser
    {
        public string UserName;
        public string Password;
        public string Role;

        public MUser(string name, string pin, string role)
        {
            UserName = name;
            Password = pin;
            Role = role;
        }

        public string SignIn(List<MUser> users, Action<int> SetColor, Action ResetColor)
        {
           
            
            foreach (var user1 in users)
            {
                if (user1.UserName == UserName && user1.Password == Password)
                {
                    return user1.Role;
                    
                }
                else
                {
                    SetColor(31);
                    Console.WriteLine("                                  Invalid credentials. Please try again.");
                    ResetColor();
                    
                }
            }
            return "";


        }
        public string SignUp()
        {

            using (StreamWriter sw = File.AppendText("credentials.txt"))
            {
                sw.WriteLine($"{UserName},{Password},{Role},");
            }

            return "                                   Signup successful! You can now log in....";
        }

    }
}
