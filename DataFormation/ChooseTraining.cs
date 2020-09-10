using System;
using System.Collections.Generic;
using System.Text;

namespace DataFormation
{
    public class ChooseTraining : IFormation<Formation>
    {
        public String NameFormation {get;set;}



        public IEnumerable<Formation> Formations(IEnumerable<Formation> itemFormation,String nameFormation)
        {
            this.NameFormation = nameFormation;

            foreach (var item in itemFormation)
            {
                if (item.Nom.Contains(NameFormation))
                {
                    yield return item;

                }
            }

        }
    }
}
