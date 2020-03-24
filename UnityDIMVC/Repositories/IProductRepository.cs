using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityDIMVC.Repositories
{
    public interface IProductRepository
    {
        Product GetProduct(int id);
    }
}