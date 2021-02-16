using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProjectConsole.MyApps
{
    public interface IMyApps
    {
        //ActionType Action { get; set; }
        void ShowMenu();
        void ReadMenuSelection();
        void WaitForGoBack();
        void ManageAllAction();
        void ShowAllDataAction();
        void SearchByIDAction();
        void SearchByNameAction();
        void AddNewItemAction();
        void UpdateByIDAction();
        void DeleteByIDAction();
        void AboutThisProject();
        void DevelopedBy();
    }
}
