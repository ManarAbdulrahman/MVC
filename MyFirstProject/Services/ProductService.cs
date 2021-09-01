using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.Services 
{
    public class ProductService : IProductService
    {
        public List<Product> Products = new List<Product>()
        {
            new Product {Id = 1, Name = "Blue Brain", Price = 150, Description= "This Watch For cool People only", Color = "Blue", Type = "Classic", Warrenty = 5, WaterResistanr = true, PhotoPath ="/photos/blue.jpg", VideoPath = "" },
            new Product {Id = 2, Name = "Black Brain", Price = 250, Description= "This Watch For Non Fun People", Color = "Black", Type = "Classic", Warrenty = 4, WaterResistanr = true, PhotoPath ="/photos/black.jpg", VideoPath = "" },
            new Product {Id = 3, Name = "Digital Brain", Price = 150, Description= "This Watch For no one", Color = "Digital Colors", Type = "Classic", Warrenty = 5, WaterResistanr = true, PhotoPath ="/photos/digital.jpg", VideoPath = "" },
            new Product {Id = 4, Name = "Green Brain", Price = 455, Description= "It's bad don't buy it ", Color = "Green", Type = "Classic", Warrenty = 2, WaterResistanr = true, PhotoPath ="/photos/green.jpg", VideoPath = "" },
            new Product {Id = 5, Name = "Not very White Brain", Price = 150, Description= "This Watch For Aunties", Color = "off White", Type = "Classic", Warrenty = 7, WaterResistanr = true, PhotoPath ="/photos/purl.jpg", VideoPath = "" },
            new Product {Id = 6, Name = "White Brain", Price = 150, Description= "This Watch For old People only", Color = "White", Type = "Classic", Warrenty = 5, WaterResistanr = true, PhotoPath ="/photos/White.jpg", VideoPath = "" }


        };

        public List<Product> GetAll()
        {
            return Products;
        }

        public Product GetProductById(int id)
        {
            return Products.Find(x => x.Id == id);
        }
    }
}
