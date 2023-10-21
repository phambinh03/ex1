using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Item
    {
        public Item() { }
        public Item(int id,string name,string size) { }
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Size { get; set; }
    }
}
