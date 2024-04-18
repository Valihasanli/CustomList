using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList.Models
{
    public class Item
    {
        public int Id { get; set; }
        static int _id;
        public Item()
        {
            _id++;
            Id = _id;
        }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Adi:{Name}";
        }
    }
}
