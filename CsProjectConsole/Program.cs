using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsProjectConsole.MyApps;
using CsProjectConsole.Utility;

namespace CsProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory.SelectedPackage = Packages.Products;
            IMyApps app = Factory.GetApp();
           
            app.ReadMenuSelection();

            Console.ReadLine();
        }
    }
}
