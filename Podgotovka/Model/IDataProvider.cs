using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka.Model
{
    interface IDataProvider
    {
        IEnumerable<Bus> GetBuses();
        IEnumerable<Vvid> GetBusVvid();
    }
}
