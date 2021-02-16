using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsProjectConsole.DataInMemory;
using CsProjectConsole.DTO;

namespace CsProjectConsole.Repository
{
    public class RepoProducts : IRepository<Products>, IRepository
    {
        ProductsData Prod = new ProductsData();
        public Products Add(Products obj) 
        {
            return Prod.Add(obj);
        }

        public Products Get(long id)
        {
            return Prod.Get(id);
        }


        public IEnumerable<Products> GetAll()
        {
            return Prod.GetAll();
        }

        public IEnumerable<Products> GetByName(string name)
        {
            return Prod.GetByName(name);
        }

        public Products Name(string name)
        {

            return Prod.Name(name);
        }

        public bool Remove(long id)
        {
            return Prod.Remove(id);
        }

        public bool Remove(Products svm)
        {
            return Prod.Remove(svm);
        }

        public Products Update(Products svm)
        {
            return Prod.Update(svm);
        }
    }
}
