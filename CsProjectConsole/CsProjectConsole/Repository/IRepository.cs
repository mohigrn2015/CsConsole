using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProjectConsole.Repository
{
    public interface IRepository
    {

    }
    interface IRepository<T> where T: class
    {
        T Add(T obj);
        T Get(long id);
        T Name(string name);
        IEnumerable<T> GetAll();
        T Update(T svm);
        bool Remove(long id);
        bool Remove(T svm);
    }
}
