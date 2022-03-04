using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cu.Generics.Avond.Core.Generics
{
    public class Order<T>
    {
        public T Item { get; set; }
        public int Quantity { get; set; }
    }
    
}
