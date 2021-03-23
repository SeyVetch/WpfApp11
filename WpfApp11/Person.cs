using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    public class Person
    {
        public int ID; 
        public string Name, Login, Password;
        public Person(int id, string name, string login, string password)
        {
            this.ID = id;
            this.Name = name;
            this.Login = login;
            this.Password = password;
        }
    }
}
