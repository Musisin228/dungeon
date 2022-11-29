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
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
            ServiceList.ItemsSource = DbCoonection.db.Lvl_Up.ToList();
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            var pisos = (sender as Button).DataContext as Lvl_Up;
            Navigation.AuthorizateUser.Lvl += pisos.Xp;
            DbCoonection.db.SaveChanges();//kak ispravit?
        }
    }
}
