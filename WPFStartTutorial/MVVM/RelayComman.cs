using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFStartTutorial.MVVM
{
    class RelayComman : ICommand
    {
        private Action<object?> execute;
        private Func<object?, bool>? canExecute;
        public event EventHandler? CanExecuteChanged
        {
            // This event is part of the ICommand interface and is used to signal 
            // changes in the command's ability to execute.
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public RelayComman(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
        public bool CanExecute(object? parameter)
        {
            // If there is no canExecute function, return true
            return canExecute == null || canExecute(parameter); 
        }

        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
}
