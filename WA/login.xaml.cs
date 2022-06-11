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

namespace WA
{
    /// <summary>
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login() // принятие ссылки формы
        {
            InitializeComponent();
        }

        // функция входа
        private void enter_Click(object sender, RoutedEventArgs e)
        {
            string us = log.Text;

            string user = "login";
            string pas = "password";

            if (us.Length > 0)
            {
                if (password.Password.Length > 0) // проверка введён ли пароль         
                {
                    if ((pas == password.Password) & (user == us)) // если такая запись существует       
                    {
                        MessageBox.Show("Пользователь авторизовался"); // сообщение о авторизации
                        Manager.MainFrame.Navigate(new dom());
                    }
                    else MessageBox.Show("Пользователя не найден. Поверьте правильность вводимых данных."); // вывод ошибки
                }
                else MessageBox.Show("Введите пароль"); // вывод ошибки
            }
        }
    }
}
