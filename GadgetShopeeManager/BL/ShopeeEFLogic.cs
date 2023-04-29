using GadgetShopeeManager.Model;
using GadgetShopeeManager.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GadgetShopeeManager.BL
{
    public class ShopeeEFLogic : IShopeeLogic
    {
        gadgetshopeeContext ctx = new gadgetshopeeContext();

        public void AddGadget()
        {
            GadgetAddWindow addWindow = new GadgetAddWindow();
            addWindow.Closed += AddGadgetWindowClosed;
            addWindow.ShowDialog();
        }

        private void AddGadgetWindowClosed(object? sender, EventArgs e)
        {
            GadgetAddWindow addWindow = sender as GadgetAddWindow;
            if (addWindow.DialogResult == true)
            {
                ctx.Gadgets.Add(addWindow.ViewModel.Gadget);
                ctx.SaveChanges();
            }
        }

        public void ExportData(ObservableCollection<Gadget> gadgets)
        {
            var exportgadgets = gadgets.Where(x => x.Deleted_at == null).Select(x => $"{x.Name}|{x.Type}|{x.Description}|{x.Start_licit}|{ctx.Licits.Where(y => y.Gadget == x).Count()};").ToList();
            File.WriteAllLines("export.txt", exportgadgets);
        }

        public ObservableCollection<Gadget> LoadData()
        {
            var data = ctx.Gadgets.Where(x => x.Deleted_at == null).Include(x => x.Licits).ThenInclude(x => x.User).ToList();
            return new ObservableCollection<Gadget>(data);
        }

        public void ShellGadget(Gadget gadget)
        {
            MessageBox.Show($"A kereskedes jelenleg nem engedelyezett! A(z) {gadget.Name} eszkozt jelenleg nem adhatja el!.");
        }

        public void DeleteGadget(ObservableCollection<Gadget> gadgets, Gadget selectedGadget)
        {
            selectedGadget.Deleted_at = DateTime.Now;
            gadgets.Remove(selectedGadget);
            ctx.SaveChanges();
        }
    }
}
