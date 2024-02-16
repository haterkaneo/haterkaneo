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
using Practice2.Models;

namespace Practice2.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

       
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGInfo.ItemsSource = App.DB.Items.ToList();
        }

        private void BAddItem_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddItemPage());
        }

        private void BDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            Items items = DGInfo.SelectedItem as Items;
            if(items == null)
            {
                MessageBox.Show("Ошибка");
                return;
            }

            App.DB.Items.Remove(items);
            App.DB.SaveChanges();
            DGInfo.ItemsSource = App.DB.Items.ToList();

        }


        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BRedactItem_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RedactPage());
        }

        private void BSort_Click(object sender, RoutedEventArgs e)
        {
            
            var items = App.DB.Items.Where(x => x.Price == 70);

        }
    }
}
