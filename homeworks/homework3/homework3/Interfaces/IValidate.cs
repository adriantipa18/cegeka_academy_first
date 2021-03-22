using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3.Interfaces
{
    interface IValidate
    {
        bool NameEquals(Item item, string compareTo);
        bool QualityLowerThan(Item item, int compareTo);
        bool SellInLowerThan(Item item, int compareTo);
    }
}
