using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppExoEntity.DTO;

namespace WpfAppExoEntity.DAL
{
    class MesDepensesContext : DbContext
    {
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Depense> Depenses { get; set; }

        public MesDepensesContext() : base("Mes_Depenses") //nom de de la base de données (Doute..avec catalog=Mes_Depenses dans app.config.)
        {
        }
    }
}
