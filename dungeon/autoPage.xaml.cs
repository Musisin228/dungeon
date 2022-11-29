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

namespace dungeon
{
    /// <summary>
    /// Логика взаимодействия для autoPage.xaml
    /// </summary>
    public partial class autoPage : Page
    {
        public autoPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTb.Text.Trim().Length <= 0 ||
               PasswordTb.Text.Trim().Length <= 0)
                MessageBox.Show("Заполните поля");
            else
            {
    
                Navigation.AuthorizateUser = DbCoonection.db.Client.ToList().Find(x => x.Login == LoginTb.Text && x.Password == PasswordTb.Text); 
                if (Navigation.AuthorizateUser == null)
                {
                    MessageBox.Show("Такого пользователя нет!");
                }
                else
                {
                    Navigation.Update(new UserPage());
                    Navigation.IsAutorizate = true;

                    MessageBox.Show("Успешно");
                }

            }
        }
    }
}
