using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;
using DataLibrary.Models;

namespace DataLibrary.BusinessLogic
{
    public static class ConventionProcessor
    {
        public static int addConvention(int idEtudient, string nomEntreprise, string ville, DateTime dateDebut,
            DateTime dateFin, string etat)
        {
            ConventionModel data = new ConventionModel
            {
                IdEtudiant = idEtudient,
                NomEntreprise = nomEntreprise,
                Ville = ville,
                DateDebut = dateDebut,
                DateFin = dateFin,
                Etat = etat
            };

            string sql = @"insert into dbo.Convention (IdEtudiant, NomEntreprise, Ville, DateDebut, DateFin, Etat)
                    values(@IdEtudiant, @NomEntreprise, @Ville, @DateDebut, @DateFin, @Etat);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<ConventionModel> LoadConventions()
        {
            string sql = @"select Id, IdEtudiant, NomEntreprise, Ville, DateDebut, DateFin, Etat 
                            from dbo.Convention;";
            return SqlDataAccess.LoadData<ConventionModel>(sql);
        }
    }
}
