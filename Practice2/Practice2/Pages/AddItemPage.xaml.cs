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
    /// Логика взаимодействия для AddItemPage.xaml
    /// </summary>
    public partial class AddItemPage : Page
    {
        Items contextItems;
        public AddItemPage()
        {
            InitializeComponent();
            CBRarity.ItemsSource = App.DB.Rarity.ToList();
            CBHeroClass.ItemsSource = App.DB.HeroClass.ToList();
            contextItems = new Items();
            DataContext = contextItems;
        }
        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            App.DB.Items.Add(contextItems);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
