using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FakeData.WPF.ViewModels.Helpers
{
    public class SaveCommand : ICommand
    {
        private Action _action;

        public SaveCommand(Action action)
        {
            _action = action;
        }

        public event EventHandler CanExecuteChanged;

        bool ICommand.CanExecute(object parameter)
        {
            return true;
        }

        void ICommand.Execute(object parameter)
        {
            _action();
        }
    }
}
