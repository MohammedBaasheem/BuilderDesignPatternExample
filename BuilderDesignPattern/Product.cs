using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; } 
        public string Manufacturer { get; set; } 
        public List<string> Features { get; set; } 

        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}\nPrice: {Price}\nCategory: {Category}\nManufacturer: {Manufacturer}\nFeatures: {string.Join(", ", Features ?? new List<string>())}";
        }
    }
}
