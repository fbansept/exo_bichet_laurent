using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfAppExoEntity.DAL;
using WpfAppExoEntity.DTO;

namespace WpfAppExoEntity
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MesDepensesContext>());
            using (var context = new MesDepensesContext())
            {
                context.Database.CreateIfNotExists();
            }
        }
    }
}
