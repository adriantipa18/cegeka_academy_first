using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3.Interfaces
{
    interface IOperations
    {
        void IncrementQuality(Item item, int plusThis);
        void DecrementQuality(Item item, int minusThis);

        void IncrementSellIn(Item item, int plusThis);
        void DecrementSellIn(Item item, int minusThis);
    }
}
