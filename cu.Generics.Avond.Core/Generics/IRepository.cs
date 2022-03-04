using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cu.Generics.Avond.Core.Generics
{
    public interface IRepository<T>
    {
        //basis crud
        void Add(T toAdd);
        IEnumerable<T> GetAll();
        T Get(int index);
        void Remove(int index);
        
    }
}
