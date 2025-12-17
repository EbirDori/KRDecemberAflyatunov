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

namespace KRDecemberAflyatunov.Pages
{
    /// <summary>
    /// Логика взаимодействия для TeacherPageMain.xaml
    /// </summary>
    public partial class TeacherPageMain : Page
    {
        public TeacherPageMain()
        {
            InitializeComponent();
        }

        private void BtnProfile_Click(object sender, RoutedEventArgs e)
        {
            EnterFrame.NavigationService.Navigate(new TeacherPage());
        }
    }
}
