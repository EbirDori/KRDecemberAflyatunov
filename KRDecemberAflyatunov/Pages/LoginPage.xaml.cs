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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
            App.DB.Users.ToList();
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
                string login = TBLogin.Text;
                string password = PBPassword.Password;

                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Заполните все поля!");
                    return;
                }

                App.LogedUser = App.DB.Users.FirstOrDefault(x => x.Login == login && x.Password == password);

                if (App.LogedUser != null)
                {
                    if (App.LogedUser.idRole == 1)
                    {
                        NavigationService.Navigate(new StudentPageMain());
                        return;
                    }
                    if (App.LogedUser.idRole == 2)
                    {
                        NavigationService.Navigate(new TeacherPage());
                        return;
                    }
                    NavigationService.Navigate(new AdminPage());
                    return;
                }
                MessageBox.Show("Этого пользователя не существует");
            }
        }

    }
