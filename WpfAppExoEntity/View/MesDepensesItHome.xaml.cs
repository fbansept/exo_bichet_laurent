using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using WpfAppExoEntity.DAL;
using WpfAppExoEntity.DTO;

namespace WpfAppExoEntity
{
    /// <summary>
    /// Logique d'interaction pour MesDepensesItHome.xaml
    /// </summary>
    public partial class MesDepensesItHome : Page
    {
        ObservableCollection<Personne> ListPersonnes { get; set; }

        public MesDepensesItHome()
        {
            InitializeComponent();

            ListPersonnes = new ObservableCollection<Personne>();

            using (var context = new MesDepensesContext())
            {
                ListBoxUtilisateur.ItemsSource = context.Personnes.ToList();
            }
        }

        private void Button_View(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            ExpenseReportPage expenseReportPage = new ExpenseReportPage();
            this.NavigationService.Navigate(expenseReportPage);
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            AddUser addUser = new AddUser();
            this.NavigationService.Navigate(addUser);
        }
    }
}
