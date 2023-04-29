using GadgetShopeeManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel;

namespace GadgetShopeeManager.ViewModel
{
    public class GadgetAddVM : BaseVM
    {

        private string? _name;
        private string? _description;
        private string? _startLicit;
        private string? _type;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }
        public string StartLicit
        {
            get { return _startLicit; }
            set
            {
                if (_startLicit != value)
                {
                    _startLicit = value;
                    OnPropertyChanged(nameof(_startLicit));
                }
            }
        }
        public string Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    OnPropertyChanged(nameof(_type));
                }
            }
        }

        public ICommand CreateCommand { get; }
        public Gadget Gadget { get; set; }

        public GadgetAddVM()
        {
            CreateCommand = new RelayCommand(CreateBtnPressed);
        }

        private void CreateBtnPressed(object? param)
        {
            Window w = param as Window;
            Gadget = new Gadget
            {
                Name = Name,
                Start_licit = int.Parse(StartLicit),
                Type = Type,
                Description = Description,
            };
            w.DialogResult = true;
            w.Close();
        }
    }
}
