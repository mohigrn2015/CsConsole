using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsProjectConsole.DTO;
using CsProjectConsole.MyApps;
using CsProjectConsole.Repository;

namespace CsProjectConsole.Utility
{
    public class Factory
    {
        public static Packages SelectedPackage;

        public static IMyApps GetApp()
        {
            IMyApps app = null;
            switch (Factory.SelectedPackage)
            {
                case Packages.Products:
                    app = new AppProducts();
                    break;
                default:
                    app = null;
                    break;
            }
            return app;
        }
        public static IRepository GetRepo()
        {
            IRepository repo = null;
            switch (Factory.SelectedPackage)
            {
                case Packages.Products:
                    repo = new RepoProducts();
                    break;
                default:
                    repo = null;
                    break;
            }
            return repo;
        }

        public static IObjects GetDTO()
        {
            IObjects dto = null;
            switch (Factory.SelectedPackage)
            {
                case Packages.Products:
                    dto = new Products();
                    break;
                default:
                    dto = null;
                    break;
            }
            return dto;
        }
    }
}
