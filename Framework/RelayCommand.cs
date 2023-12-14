using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pratica_DashBoard.FrameWork
{
    public class RelayCommand<T> : ICommand
    {
        public RelayCommand(Action<T> execute, Func<bool> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }
            this.execute = execute;
            this.canExecute = canExecute;
        }
        public RelayCommand(Action<T> execute) : this(execute, null) { }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private Func<bool> canExecute;
        private Action<T> execute;

        public bool CanExecute(object parameter)
        {
            return (canExecute == null) || canExecute();
        }
        public void Execute(object parameter)
        {
            try
            {
                execute((T)parameter);
            }
            catch (Exception e)
            {
                // Questo messaggio ???? in WPF ?
                Console.WriteLine(e.Message);
            }
        }
    }

    public class RelayCommand : ICommand
    {
        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }
            this.execute = execute;
            this.canExecute = canExecute;
        }
        public RelayCommand(Action execute) : this(execute, null) { }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private Func<bool> canExecute;
        private Action execute;

        
        public bool CanExecute(object parameter)
        {
            return (canExecute == null) || canExecute();
        }

        // L'interfaccia ICommand definisce il metodo Execute
        // con un parametro 'object', quindi anche se qui il parametro
        // non viene, il metodo usato va dichiarato così.
        public void Execute(object parameter)
        { 
                execute();
        }

    }
}
