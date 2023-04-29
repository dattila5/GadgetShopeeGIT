using GadgetShopeeManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetShopeeManager.BL
{
    internal interface IShopeeLogic
    {
        public ObservableCollection<Gadget> LoadData();
        public void AddGadget();
        public void ExportData(ObservableCollection<Gadget> gadgets);
        public void DeleteGadget(ObservableCollection<Gadget> gadgets, Gadget SelectedGadget);
        public void ShellGadget(Gadget SelectedGadget);
    }
}
