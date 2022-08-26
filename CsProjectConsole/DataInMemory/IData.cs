using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProjectConsole.DataInMemory
{
    interface IData <T> where T: class 
    {
        //void LoadSampleData();
        IEnumerable<T> GetAll();
        T Get(long id);
        T Name(string name); 
        IEnumerable<T> GetByName(string name);
        T Add(T obj);
        bool Remove(long id);
        bool Remove(T obj);
        T Update(T obj);
         
    }
}
