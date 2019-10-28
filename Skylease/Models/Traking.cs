using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skylease.Models
{
    public class Traking
    {
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string CargoType { get; set; }
        public string Pieces { get; set; }
        public string Weight { get; set; }
        public string Volumen { get; set; }
        public List<TrakingHistor> TrakingHistors { get; set; }
    }
    public class TrakingHistor
    {
        public DateTime date { get; set; }
        public string Pieces { get; set; }
        public string Weight { get; set; }
        public string Note { get; set; }
    }


  


}
