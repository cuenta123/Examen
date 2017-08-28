using Ninject.Activation;
using Ninject.Modules;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class ChangeProovedor: NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<Service.IServiceProvider>().To<OracleProvider>();
        }
    }
}
