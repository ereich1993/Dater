using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dater.Models
{
    public class MenuItems
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Descrition { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int? Spicy { get; set; }
        public int? Vegetarian { get; set; }

    }
}
