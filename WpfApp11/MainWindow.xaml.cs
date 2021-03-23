using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static bool flagLog = false;
        static bool flagFail = false;
        List<Person> listUsers = new List<Person>(); 
        public MainWindow()
        {
            InitializeComponent();
            listUsers.Add(new Person(0, "Alex", "Admin", "Admin"));
            listUsers.Add(new Person(1, "Betty", "Bet", "pass"));
            listUsers.Add(new Person(2, "Casey", "Case", "pass"));
            listUsers.Add(new Person(3, "Daniel", "Dan", "pass"));
            listUsers.Add(new Person(4, "Ena", "Ena", "pass"));
            string line = Txt.ReadLine();
            if (!(line == "None"))
            {
                int id = Convert.ToInt32(line);
                Window1 window1 = new Window1(listUsers[id]);
                this.Hide();
                window1.ShowDialog();
                this.Show();
            }
        }

        private void BtnLog_Click(object sender, RoutedEventArgs e)
        {
            if (Captchatb.Text == Captchatxt.Text || !flagFail) {
                bool flag = false;
                int N = -1;
                for (int i = 0; i < listUsers.Count(); i++)
                {
                    Person user = listUsers[i];
                    string username = user.Login;
                    flag = username == Username.Text;
                    if (flag)
                    {
                        N = i;
                        break;
                    }
                }
                if (flag && Password.Text == listUsers[N].Password)
                {
                    flagFail = false;
                    Captcha.Visibility = Visibility.Hidden;
                    Window1 window1 = new Window1(listUsers[N]);
                    if (flagLog)
                    {
                        Txt.WriteLine(N.ToString());
                    }
                    else
                    {
                        Txt.WriteLine("None");
                    }
                    this.Hide();
                    window1.ShowDialog();
                    this.Show();
                }
                else
                {
                    flagFail = true;
                    Captchatxt.Text = CaptchaClass.GetNew();
                    Captcha.Visibility = Visibility.Visible;
                }
            }
            Captchatxt.Text = CaptchaClass.GetNew();
        }

        private void BtnLogd_Click(object sender, RoutedEventArgs e)
        {
            flagLog = !flagLog;
            if (flagLog)
            {
                BtnLogd.Content = "V";
            }
            else
            {
                BtnLogd.Content = "X";
            }
        }

        private void Captchabtn_Click(object sender, RoutedEventArgs e)
        {
            Captchatxt.Text = CaptchaClass.GetNew();
        }
    }
}
