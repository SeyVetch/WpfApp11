using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    static class Txt
    {
        public static void WriteLine(string line)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\1234\\source\\repos\\WpfApp11\\Data.txt");
                sw.WriteLine(line);
                sw.Close();
            }
            catch (Exception e) { }
        }
        public static string ReadLine()
        {
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\1234\\source\\repos\\WpfApp11\\Data.txt");
                string line = sr.ReadLine();
                sr.Close();
                return line;
            }
            catch (Exception e) { return "None"; }
        }
    }
}
