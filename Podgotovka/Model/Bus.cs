using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka
{
    public class Bus
    {
        public string Name { get; set; }
        public int KolMest { get; set; }
        public double Rasxod { get; set; }
        public TimeSpan Vremiy { get; set; }  
        public string Vvid { get; set; }
        public string Title { get; internal set; }
    }
}
