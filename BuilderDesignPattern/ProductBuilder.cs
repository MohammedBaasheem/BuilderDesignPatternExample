using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    internal class ProductBuilder
    {
        private Product _product = new Product();

        public ProductBuilder SetName(string name)
        {
            _product.Name = name;
            return this; 
        }

        public ProductBuilder SetDescription(string description)
        {
            _product.Description = description;
            return this;
        }

        public ProductBuilder SetPrice(decimal price)
        {
            _product.Price = price;
            return this;
        }

        public ProductBuilder SetCategory(string category)
        {
            _product.Category = category;
            return this;
        }

        public ProductBuilder SetManufacturer(string manufacturer)
        {
            _product.Manufacturer = manufacturer;
            return this;
        }

        public ProductBuilder SetFeatures(List<string> features)
        {
            _product.Features = features;
            return this;
        }


        public Product Build()
        {
            return _product;
        }
    }
}
