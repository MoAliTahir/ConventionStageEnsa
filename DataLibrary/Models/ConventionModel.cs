using System;

namespace DataLibrary.Models
{
    public class ConventionModel
    {
        public int Id { get; set; }
        public int IdEtudiant { get; set; }
        public string NomEntreprise { get; set; }
        public string Ville { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Etat { get; set; }
    }
}