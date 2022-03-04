using cu.Generics.Avond.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cu.Generics.Avond.Core.Generics
{
    public class Repository<T> : IRepository<T> 
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T toAdd)
        {
            _items.Add(toAdd);
        }

        public T Get(int index)
        {
            return _items[index];
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        public void Remove(int index)
        {
            _items.RemoveAt(index);
        }

    }
}
