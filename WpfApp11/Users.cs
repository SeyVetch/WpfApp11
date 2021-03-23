using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    public class Users
    {
        public string[] users = { "Admin" };
        public string[] passwords = { "Admin" };
        public void WriteUsers()
        {
            try
            {
                StreamWriter sw;
                sw = new StreamWriter("C:\\Users\\1234\\source\\repos\\WpfApp11\\Users.txt");
                foreach (string line in users)
                {
                    sw.WriteLine(line);
                }
                sw.Close();
                sw = new StreamWriter("C:\\Users\\1234\\source\\repos\\WpfApp11\\Passwords.txt");
                foreach (string line in passwords)
                {
                    sw.WriteLine(line);
                }
                sw.Close();
            }
            catch (Exception e) { }
        }
        public void ReadUsers()
        {
            try
            {
                StreamReader sr;
                string line = "";
                int N;
                int i;
                sr = new StreamReader("C:\\Users\\1234\\source\\repos\\WpfApp11\\Users.txt");
                N = 0;
                while (line != null)
                {
                    N += 1;
                    line = sr.ReadLine();
                }
                sr.Close();
                sr = new StreamReader("C:\\Users\\1234\\source\\repos\\WpfApp11\\Users.txt");
                users = new string[N];
                i = 0;
                while (i < N)
                {
                    line = sr.ReadLine();
                    users[i] = line;
                    i += 1;
                }
                sr.Close();
                line = "";
                sr = new StreamReader("C:\\Users\\1234\\source\\repos\\WpfApp11\\Passwords.txt");
                N = 0;
                while (line != null)
                {
                    N += 1;
                    line = sr.ReadLine();
                }
                sr.Close();
                sr = new StreamReader("C:\\Users\\1234\\source\\repos\\WpfApp11\\Passwords.txt");
                passwords = new string[N];
                i = 0;
                while (i < N)
                {
                    line = sr.ReadLine();
                    passwords[i] = line;
                    i += 1;
                }
                sr.Close();
            }
            catch (Exception e) { }
        }
        public void Update()
        {
            this.ReadUsers();
        }
    }
}
