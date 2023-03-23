using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airQuality
{
    public class ViewModel
    {
        public List<Daten> Data { get; set; }

        public ViewModel()
        {
            Data = new List<Daten>()
        {
            new Daten { Name = "David", Height = 170 },
            new Daten { Name = "Michael", Height = 96 },
            new Daten { Name = "Steve", Height = 65 },
            new Daten { Name = "Joel", Height = 182 },
            new Daten { Name = "Bob", Height = 134 }
        };
        }
    }
}
