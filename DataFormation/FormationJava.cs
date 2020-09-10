using System;
using System.Collections.Generic;
using System.Text;

namespace DataFormation
{
    public class FormationJava : IFormation<Formation>
    {
        public IEnumerable<Formation> Formations(IEnumerable<Formation> itemFormation)
        {

            foreach (var item in itemFormation)
            {
                if (item.Nom.Contains("JAVA"))
                {
                    yield return item;

                }
            }

        }
    }
}
