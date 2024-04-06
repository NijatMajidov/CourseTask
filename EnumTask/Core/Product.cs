using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Product
    {
        private static int _id;
        public int No { get; set; }
        public string Name {  get; set; }
        public double Price { get; set; }
        public Enums Type {  get; set; }

        public Product()
        {
            No = ++_id;
        }

        public override string ToString()
        {
            return $"No: {No}; Name: {Name}; Price: {Price}; Type: {Type}";
        }
    }
}
