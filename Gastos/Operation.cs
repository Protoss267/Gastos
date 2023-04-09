using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gastos
{
    internal class Operation
    {
        public DateTime Now{get;set;}
       public string Product { get; set; }
       public int Cost { get; set; }

        public Operation(DateTime now, string product, int cost)
        {
            Now = now;
            Product = product;
            Cost = cost;
        }

        public override string ToString()
        {
            return  Product + "," + Cost ;
        }
    }
}
