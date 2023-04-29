using GadgetShopeeManager.BL;
using GadgetShopeeManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GadgetShopeeManager.ViewModel
{
    public class MainVM : BaseVM
    {
        private IShopeeLogic _logic;
        public ICommand AddGadgetCommand { get; }
        public ICommand DeleteGadgetCommand { get; }
        public ICommand ShellGadgetCommand { get; }
        public ICommand ExportGadgetsCommand { get; }

        private ObservableCollection<Gadget> _gadgets;
        private Gadget _selectedGadget;
        private ObservableCollection<Licit> _licits;

        public ObservableCollection<Gadget> Gadgets
        {
            get { return _gadgets; }
            set
            {
                if (_gadgets != value)
                {
                    _gadgets = value;
                    OnPropertyChanged(nameof(Gadgets));
                }
            }
        }
        public ObservableCollection<Licit> Licits
        {
            get { return _licits; }
            set
            {
                if (_licits != value)
                {
                    _licits = value;
                    OnPropertyChanged(nameof(Licits));
                }
            }
        }

        public Gadget SelectedGadget
        {
            get { return _selectedGadget; }
            set
            {
                if (_selectedGadget != value)
                {
                    _selectedGadget = value;
                    OnPropertyChanged(nameof(SelectedGadget));
                    SelectedGadgetChanged();
                }
            }
        }

        private void SelectedGadgetChanged()
        {
            Licits.Clear();
            if (SelectedGadget != null)
            {
                SelectedGadget.Licits.ToList().ForEach(x => Licits.Add(x));
            }
        }

        public MainVM()
        {
            _logic = new ShopeeEFLogic();
            Gadgets = _logic.LoadData();
            Licits = new ObservableCollection<Licit>();
            AddGadgetCommand = new RelayCommand(_logic.AddGadget);
            DeleteGadgetCommand = new RelayCommand(DeleteGadget);
            ShellGadgetCommand = new RelayCommand(ShellGadget);
            ExportGadgetsCommand = new RelayCommand(ExportGadgets);
        }

        private void DeleteGadget() => _logic.DeleteGadget(Gadgets, SelectedGadget);
        private void ShellGadget() => _logic.ShellGadget(SelectedGadget);
        private void ExportGadgets() => _logic.ExportData(Gadgets);
    }
}
