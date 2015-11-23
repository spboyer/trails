using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trails.Models
{
    public class Runner
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public int Age { get; set; }
        public string FavoriteBeer { get; set; }

        public Runner()
        {

        }
    }
}
