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
    /// Логика взаимодействия для RedactPage.xaml
    /// </summary>
    public partial class RedactPage : Page
    {
        public RedactPage()
        {
            InitializeComponent();
            CBRedactName.ItemsSource = App.DB.Items.ToList();
            CBRedactRarity.ItemsSource = App.DB.Rarity.ToList();
            CBRedactHeroClass.ItemsSource = App.DB.HeroClass.ToList();
        }

        private void CBRedactName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var itema = CBRedactName.SelectedItem as Items;
            DataContext = itema;
        }

        private void BRedactSave_Click(object sender, RoutedEventArgs e)
        {
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BRedactCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
