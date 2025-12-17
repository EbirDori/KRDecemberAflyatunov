using KRDecemberAflyatunov.Models;
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

namespace KRDecemberAflyatunov.Windows
{
    /// <summary>
    /// Логика взаимодействия для StudentEditWindow.xaml
    /// </summary>
    public partial class StudentEditWindow : Window
    {
        public Students Students;
        public StudentEditWindow(Students students)
        {
            InitializeComponent();
            Students = students;
            DataContext = Students;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBPhone.Text))
            {
                MessageBox.Show("Поле Телефон не заполненно");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBEmail.Text))
            {
                MessageBox.Show("Поле Почта не заполненно");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBAdress.Text))
            {
                MessageBox.Show("Поле Адрес не заполненно");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBImage.Text))
            {
                MessageBox.Show("Поле ИЗОБРАЖЕНИЕ не заполненно");
                return;
            }

            if (Students.id == 0)
            {
                App.DB.Students.Add(Students);
            }
            App.DB.SaveChanges();
            MessageBox.Show("Сохранено");
            Close();
        }
    }
}
