using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_mart
{

    class Kund
    {
        public string namn { get; set; }//writes the name of the customer 
        public string KundInfo()
        {
            return this.namn;
        }
    }

}
