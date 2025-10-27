using System.Windows.Input;

namespace MOS.Data
{
    public class DelegateCommand : ICommand
    {
        public readonly Action<object?> _Execute;

        public readonly Predicate<object?> _CanExecute;

        public event EventHandler? CanExecuteChanged;

        public DelegateCommand(Action<object?> _execute, Predicate<object?> _canExecute) => (_Execute, _CanExecute) = (_execute, _canExecute);


        public bool CanExecute(object? parameter) => _CanExecute?.Invoke(parameter) ?? true;

        public void Execute(object? parameter) => _Execute?.Invoke(parameter);

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
