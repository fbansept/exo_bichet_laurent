using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppExoEntity.DTO
{
    class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        //public virtual Depense Depenses { get; set; } //relation one to zero or one vers la table Depense

    }
}
