using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace DownloadManager.Helpers
{
  public class RelayCommand : ICommand
  {
    private readonly Action<object> _execute;
    private readonly Func<object, bool> _canExecute;

    public event EventHandler CanExecuteChanged
    {
      add { CommandManager.RequerySuggested += value; }
      remove { CommandManager.RequerySuggested -= value; }
    }

    public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
    {
      this._execute = execute;
      this._canExecute = canExecute;
    }

    public bool CanExecute(object parameter)
    {
      return this._canExecute == null || this._canExecute(parameter);
    }

    public void Execute(object parameter)
    {
      this._execute(parameter);
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName]string prop = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
  }
}