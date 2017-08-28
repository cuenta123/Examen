using Domain;
using Ninject;
using Ninject.Activation;
using Ninject.Modules;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Bind<Service.IServiceProvider>().To<OracleProvider>();            
            var proovedor = kernel.Get<Service.IServiceProvider>();
            Console.ReadLine();
          
        }
    }
}
