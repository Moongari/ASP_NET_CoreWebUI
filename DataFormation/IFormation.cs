using System;
using System.Collections.Generic;
using System.Text;

namespace DataFormation
{
    public interface IFormation<T>
    {

        IEnumerable<Formation> Formations(IEnumerable<T> itemFormation,String nameFormation);

    }
}
