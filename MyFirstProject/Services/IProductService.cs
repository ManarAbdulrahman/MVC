using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstProject.Models;//add this class call for models (products)


namespace MyFirstProject.Services 
{
    public interface IProductService
    {
        List<Product> GetAll(); // called prjectname.Models to retraive (inhertnce)
        Product GetProductById(int id);
    }
}
