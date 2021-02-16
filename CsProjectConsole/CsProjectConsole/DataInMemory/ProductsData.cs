using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsProjectConsole.DTO;

namespace CsProjectConsole.DataInMemory
{
    public class ProductsData : IData<Products>
    {
        static List<Products> data = new List<Products>() {
            new Products () { ProductID= 101,    ProductName= "Residential Stair Lift",         IsActive= true,      Details="450V, Color in Red ",             Price=1320},
            new Products () { ProductID= 102,    ProductName= "Coment Brick Making Machin",     IsActive= false,     Details="500V, Color in Blue",             Price=1600 },
            new Products () { ProductID= 105,    ProductName= "Fly Ash Brick Making Machine",   IsActive= true,      Details="250V, Color in Green",            Price=550 },
            new Products () { ProductID= 104,    ProductName= "Hitachi Excavator",              IsActive= true,      Details="300V, Color in White",            Price=1000 },
            new Products () { ProductID= 103,    ProductName= "Komatsu Excavator",              IsActive= false,     Details="280V, Color in Gold",             Price=1500 },
            new Products () { ProductID= 106,    ProductName= "Hitachi Excavator",              IsActive= false,     Details="300V, Color in Black",            Price=1000 },
            new Products () { ProductID= 107,    ProductName = "Laptop",                         IsActive = false,    Details = "RAM-4GB, Color in Black",       Price = 52000 },
            new Products () { ProductID= 125,    ProductName = "Speker",                         IsActive = true,     Details = "High Qualifide, Color in Black",Price = 2000 },
            new Products () { ProductID= 109,    ProductName = "Mouce",                          IsActive = true,     Details = "A4 Tech, Color in Black",       Price = 500 },
            new Products () { ProductID= 110,    ProductName = "Key-Board",                      IsActive = false,    Details = "A4 Tech, Color in Black",       Price = 600 }

        };

        public Products Add(Products obj)
        {

            obj.ProductID = 1;
            if (data != null && data.Count > 0)
            {
                obj.ProductID = data.Max(a => a.ProductID) + 1;
                data.Add(obj);
            }
            return obj;


        }

        public Products Get(long id)
        {
            Products cust = data.Find(p => p.ProductID == id);
            return cust;
        }

        public Products Get(string name)
        {
            Products Data= data.FirstOrDefault(p => p.ProductName == name);
            return Data;

        }

        public IEnumerable<Products> GetAll()
        {
            return data;
        }

        public IEnumerable<Products> GetByName(string name)
        {
            var gets = data.Where(a => a.ProductName.Contains(name)); 
            return gets;
        }

        //public void LoadSampleData()
        //{
        //    this.Add(new Products { ProductName = "Laptop", IsActive = false, Details = "RAM-4GB, Color in Black",      Price = 52000 });
        //    this.Add(new Products { ProductName = "Speker", IsActive = true, Details = "High Qualifide, Color in Black", Price = 2000 });
        //    this.Add(new Products { ProductName = "Mouce", IsActive = true, Details = "A4 Tech, Color in Black",          Price = 500 });
        //    this.Add(new Products { ProductName = "Key-Board", IsActive = false, Details = "A4 Tech, Color in Black",     Price = 600 });
        //}

        public Products Name(string name)
        {
            return data.FirstOrDefault(p => p.ProductName.Contains(name));
        }

        public bool Remove(long id)
        {
            data.RemoveAll(p => p.ProductID == id);
            return true;
        }

        public bool Remove(Products obj)
        {
            data.RemoveAll(p => p.ProductID==obj.ProductID);
            return true;
        }

        public Products Update(Products obj)
        {
            Products r = data.Find(p=>p.ProductID==obj.ProductID);
            
            if (obj.ProductName !=null && obj.ProductName.Trim() != "")
            {
                r.ProductName = obj.ProductName;
            }
            if (obj.IsActive != null)
            {
                r.IsActive = obj.IsActive;
            }
            if (obj.Details != null && obj.Details.Trim() != "")
            {
                r.Details = obj.Details;
            }
            if (obj.Price != null)
            {
                r.Price = obj.Price;
            }
            return r;
        }

    }
}
