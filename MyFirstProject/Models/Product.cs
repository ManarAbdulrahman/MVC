using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int Warrenty { get; set; }
        public bool WaterResistanr { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
        public string VideoPath { get; set; }


    }


}
