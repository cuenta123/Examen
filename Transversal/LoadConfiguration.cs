using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transversal
{
    public class ChargeConfiguration: IConfiguration
    {
        private static ChargeConfiguration instance;

        public static ChargeConfiguration Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChargeConfiguration();
                }
                return instance;
            }
        }
        void IConfiguration.Load()
        {
            
        }
        
    }
}
