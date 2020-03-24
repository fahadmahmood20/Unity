using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityDIMVC.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Product GetProduct(int id)
        {
            // Get data from db and populate product object
            return new Product();
        }
    }
}