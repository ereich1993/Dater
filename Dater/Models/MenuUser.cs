using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dater.Models
{
    public class MenuUser
    {
        public List<MenuItems> menuItems { get; set; } = new List<MenuItems>();
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
