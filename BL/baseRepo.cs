using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebasePlayground.BL
{
    interface baseRepo<T>
    {
        Task create(T obj);
        Task createByChild(string child , T obj);
        Task<IEnumerable<T>> getAll();
        Task<IEnumerable<T>> getAllByChild(string child);
        Task<T> getByKey(string key);
        Task update(T obj);
        Task deleteByKey(string key);
    }
}
