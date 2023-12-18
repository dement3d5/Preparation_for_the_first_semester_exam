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
using Ychy.Models;
using Ychy.VM;

namespace Ychy.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditTeamWindow.xaml
    /// </summary>
    public partial class EditTeamWindow : Window
    {
        public EditTeamWindow(Nteam nteam)
        {
            InitializeComponent();
            DataContext = new EditTeamVM(nteam);
        }
    }
}
