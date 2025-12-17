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
    /// Логика взаимодействия для UspevPage.xaml
    /// </summary>
    public partial class UspevPage : Page
    {
        public UspevPage()
        {
            InitializeComponent();
            DGUspev.ItemsSource = App.DB.Grades.Where(x => x.Students.idUser == App.LogedUser.id).ToList();
        }
    }
}
