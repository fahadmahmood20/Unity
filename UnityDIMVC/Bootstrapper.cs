using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnityDIMVC.Repositories;

namespace UnityDIMVC
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise() {

            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IProductRepository, ProductRepository>();

            return container; 
        }
    }
}