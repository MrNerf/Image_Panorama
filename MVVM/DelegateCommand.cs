using System;
using System.Windows.Input;

namespace Image_panorama.MVVM
{
    /// <inheritdoc />
    /// <summary>
    /// Реализация DelegateCommand
    /// </summary>
    public class DelegateCommand : ICommand
    {
        private readonly Func<object, bool> _canExecute;
        private readonly Action<object> _execute;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<object> execute)
            : this(execute, null)
        {
            _execute = execute;
            _canExecute = AlwaysCanExecute;
        }

        public DelegateCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        /*public DelegateCommand(Action<object> execute)
        {
            _execute = execute;
            _canExecute = AlwaysCanExecute;
        }*/

        private static bool AlwaysCanExecute(object param)
        {
            return true;
        }

        public bool CanExecute(object param)
        {
            return _canExecute == null || _canExecute(param);
        }

        public void Execute(object param)
        {
            _execute(param);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute(parameter);
        }

        void ICommand.Execute(object parameter)
        {
            Execute(parameter);
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// Реализация <see cref="T:System.Windows.Input.ICommand" /> с параметрами.
    /// </summary>
    /// <typeparam name="T">Тип аргумента при выполнении команды.</typeparam>
    public class DelegateCommand<T> : RelayCommand
    {
        /// <summary>
        /// Реализация <see cref="ICommand"/> с параметрами.
        /// </summary>
        /// <param name="executeMethod">Метод, выполняющийся при вызове метода Execute команды. Может быть null.</param>
        /// <remarks><seealso cref="CanExecute"/>Всегда возвращает true.</remarks>
        public DelegateCommand(Action<T> executeMethod)
            : this(executeMethod, o => true)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Команда.
        /// </summary>
        /// <param name="executeMethod">Метод, выполняющийся при вызове метода Execute команды. Может быть null.</param>
        /// <param name="canExecuteMethod">Метод, выполняющийся при вызове метода CanExecute команды. Может быть null.</param>
        /// <exception cref="T:System.ArgumentNullException">Когда оба <paramref name="executeMethod" /> и <paramref name="canExecuteMethod" /> имеют значение <see langword="null" />.</exception>
        public DelegateCommand(Action<T> executeMethod, Func<T, bool> canExecuteMethod)
            : base(o => executeMethod((T)o), o => canExecuteMethod((T)o))
        {
            if (executeMethod == null || canExecuteMethod == null)
                throw new ArgumentNullException(nameof(executeMethod));

            var genericType = typeof(T);

            // ViewModelCommand allows object or Nullable<>.  
            // note: Nullable<> is a struct so we cannot use a class constraint.
            if (genericType.IsValueType && (!genericType.IsGenericType || !typeof(Nullable<>).IsAssignableFrom(genericType.GetGenericTypeDefinition())))
                throw new InvalidCastException("genericType");
        }

        /// <summary>
        /// Определяет, может ли команда быть выполнена.
        /// </summary>
        ///<param name="parameter">Параметр, используемый для определения доступности выполнения команды.</param>
        /// <returns>Возвращает <see langword="true"/> если команда может быть выполнена, иначе возвращает <see langword="false"/>.</returns>
        public bool CanExecute(T parameter)
        {
            return base.CanExecute(parameter);
        }

        ///<summary>
        /// Выполняет команду.
        ///</summary>
        ///<param name="parameter">Параметр, используемый командой.</param>
        public void Execute(T parameter)
        {
            base.Execute(parameter);
        }
    }
}