using System;
using System.Windows;
using System.Windows.Input;

namespace WPF.MyFlatTheme.Commands
{
    public class MaximizeResoreWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (!(parameter is Window window))
                return false;

            return true;
        }

        public void Execute(object parameter)
        {
            var window = parameter as Window;

            if (window.WindowState == WindowState.Maximized)
                window.WindowState = WindowState.Normal;
            else
                window.WindowState = WindowState.Maximized;
        }
    }
}
