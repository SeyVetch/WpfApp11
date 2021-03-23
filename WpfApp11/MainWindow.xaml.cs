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
        public static bool flagLog = false;
        public static bool flagFail = false;
        static Users U = new Users();
        public MainWindow()
        {
            InitializeComponent();
            U.Update();
            users.Text = String.Join(" ", U.users);
            passswords.Text = String.Join(" ", U.passwords);
            string line = Txt.ReadLine();
            if (!(line == "None"))
            {
                int id = Convert.ToInt32(line);
                Window1 window1 = new Window1(U.users[id]);
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
                for (int i = 0; i < U.users.Length; i++)
                {
                    string user = U.users[i];
                    flag = user == Username.Text;
                    if (flag)
                    {
                        N = i;
                        break;
                    }
                }
                if (flag && Password.Text == U.passwords[N])
                {
                    flagFail = false;
                    Captcha.Visibility = Visibility.Hidden;
                    Window1 window1 = new Window1(U.users[N]);
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
    }
}
