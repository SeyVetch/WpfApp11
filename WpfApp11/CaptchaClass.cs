using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    class CaptchaClass
    {
        public static string symbols = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        static Random rng = new Random();
        public static string GetNew()
        {
            string res = "";
            for (int i = 0; i < 12; i++)
            {
                res += symbols[rng.Next(62)];
            }
            return res;
        }
    }
}
