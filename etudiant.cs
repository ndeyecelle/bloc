//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet_School
{
    using System;
    using System.Collections.Generic;
    
    public partial class etudiant
    {
        public int id { get; set; }
        public string prenom { get; set; }
        public string nom { get; set; }
        public int credit { get; set; }
        public string reglement { get; set; }
        public string anneescolaire { get; set; }
        public int idclasse { get; set; }
    
        public virtual classe classe { get; set; }
    }
}
