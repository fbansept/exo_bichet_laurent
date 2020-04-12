using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppExoEntity.DTO
{
    class Depense //Class qui définit la structure de la table Depense
    {
        //[ForeignKey("Personne")] // Annotation de Foreign Key pointant sur la ta personne Utilisable par EntityFramwork
        //public int DepenseId { get; set; } // entity repère "ID" et génère la Primary Key

        public int Id { get; set; }

        public int Montant { get; set; } // champ Montant
        public string Type_Depense { get; set; } //Champ type de dépenses

        public virtual Personne Personne { get; set; } //relation one to zero or one vers la table Personne

    }
}
