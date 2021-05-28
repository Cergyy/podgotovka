using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka.Model
{
    class LocalDataProvider : IDataProvider

    {
        public IEnumerable<Bus> GetBuses()
        {
            return new Bus[]
                {
                new Bus {Name="Первый",KolMest=20,Rasxod=7.7,Vremiy=TimeSpan.FromMinutes(20),Vvid="Легкий" },
                new Bus {Name="Второй",KolMest=30,Rasxod=8.7,Vremiy=TimeSpan.FromMinutes(30),Vvid="Тяжелый" }
                };
          }
    public IEnumerable<Vvid> GetBusVvid()
    {
        return new Vvid[]
        {
            new Vvid{Title="Легкий"},
            new Vvid{Title="Тяжелый"},
            new Vvid{Title="Турбореактивная"}
        };

    }
}

}
