using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Domain.Contracts.Base
{
    public interface IEdit<T>
    {
        List<T> GetList();
        void Insert(T element);
        void Insert(IEnumerable<T> elements);
        void Update(T element);
        void Update(IEnumerable<T> elements);
        void Delete(T element);
        void Delete(IEnumerable<T> elements);
    }
}
