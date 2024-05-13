using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore.Interfaces
{
    public interface IECrud<T>
    {
        void eCreate(T entity);
        T eRead(int id);
        bool eUpdate(T entity);
        bool eDelete(int id);
    }
}
