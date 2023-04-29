using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GadgetShopeeManager.ViewModel
{
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Action<object> _executeWithParam;

        public RelayCommand(Action<object> method)
        {
            _executeWithParam = method ?? throw new ArgumentNullException(nameof(method));
        }
        public RelayCommand(Action method)
        {
            _execute = method ?? throw new ArgumentNullException(nameof(method));
        }


        public void Execute(object? parameter)
        {
            if (_execute != null && parameter == null)
            {
                _execute();
            }
            else if (_executeWithParam != null && parameter != null)
            {
                _executeWithParam(parameter);
            }
        }

        public event EventHandler? CanExecuteChanged;
        public bool CanExecute(object? parameter)
        {
            return true;
        }

    }
}