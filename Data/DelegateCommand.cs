using System.Windows.Input;

namespace MOS.Data
{
    public class DelegateCommand : ICommand
    {
        #region Events
        public readonly Action<object?> _Execute;

        public readonly Predicate<object?> _CanExecute;

        public event EventHandler? CanExecuteChanged;
        #endregion

        #region Constructors
        public DelegateCommand(Action<object?> _execute, Predicate<object?> _canExecute) => (_Execute, _CanExecute) = (_execute, _canExecute);
        #endregion

        #region Public Methods
        public bool CanExecute(object? parameter) => _CanExecute?.Invoke(parameter) ?? true;

        public void Execute(object? parameter) => _Execute?.Invoke(parameter);

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        #endregion
    }
}
