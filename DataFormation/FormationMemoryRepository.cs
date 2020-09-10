using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DataFormation
{
   public class FormationMemoryRepository
    {

        List<Formation> formationsList = new List<Formation>();
        public List<Formation> GetAllFormation()
        {
            return formationsList;
        }



        public FormationMemoryRepository()
        {
            formationsList.Add(new Formation { Id = 1, Nom = "Java", NomSeo = "Oracle", Description = "Apprendre Java" });
            formationsList.Add(new Formation { Id = 2, Nom = "PHP", NomSeo = "Symphony", Description = "Apprendre PHP" });
            formationsList.Add(new Formation { Id = 3, Nom = "C#", NomSeo = "Microsoft", Description = "Apprendre C#" });
            formationsList.Add(new Formation { Id = 4, Nom = "Angular", NomSeo = "ANGULAR JS", Description = "Apprendre Angular" });
        }




        public Formation GetformationById(int id)
        {


            return formationsList.Find(f => f.Id == id);
           // return formationsList.FirstOrDefault(f => f.Id == id);

        }
    }
}
