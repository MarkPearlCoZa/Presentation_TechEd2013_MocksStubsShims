using System;
using System.Windows.Input;

namespace Customers.Commands
{
    public class AlwaysExecuteCommand : ICommand
    {
        private readonly Action _executeAction;

        public AlwaysExecuteCommand(Action executeAction)
        {
            _executeAction = executeAction;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _executeAction.Invoke();
        }

        public event EventHandler CanExecuteChanged;

        protected virtual void OnCanExecuteChanged()
        {
            EventHandler handler = CanExecuteChanged;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}