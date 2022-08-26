using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProjectConsole.DTO
{
    public class Products : IObjects
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Details { get; set; }
        public Nullable<double> Price { get; set; }
    }
}
