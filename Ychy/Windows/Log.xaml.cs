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
using System.Windows.Shapes;
using Ychy.DB;

namespace Ychy.Windows
{
    /// <summary>
    /// Логика взаимодействия для Log.xaml
    /// </summary>
    public partial class Log : Window
    {
        public Log()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = user2Context.GetInstance().Auths.FirstOrDefault(s => s.Login == txt_login.Text &&  s.Password == txt_password.Text);
            if (user == null)
            {
                MessageBox.Show("Не верный пароль!");
            }
            else
            {
                MainWindow m = new MainWindow();
                  m.Show();
                this.Close();
            }

        }
    }
}
