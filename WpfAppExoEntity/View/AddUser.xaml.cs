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
using WpfAppExoEntity.DAL;
using WpfAppExoEntity.DTO;

namespace WpfAppExoEntity
{
    /// <summary>
    /// Logique d'interaction pour AddUser.xaml
    /// </summary>
    partial class AddUser : Page
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AjoutUtilisateur(object sender, RoutedEventArgs e)
        {
            Personne personne = new Personne();
            personne.Nom = Nom.Text;

            using (var context = new MesDepensesContext())
            {
                context.Personnes.Add(personne);
                context.SaveChanges();
            }
        }
    }
}
