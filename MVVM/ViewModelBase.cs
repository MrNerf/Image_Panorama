using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Image_panorama.MVVM
{
    public class ViewModelBase : INotifyPropertyChanged, IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChanged([CallerMemberName]string propertyName = null)
        {
            InvokeInUiThread(() =>
            {
                var handler = PropertyChanged;
                handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            });
        }


        protected void RaiseAllPropertiesChanged()
        {
            InvokeInUiThread(() =>
            {
                var handler = PropertyChanged;
                if (handler == null) return;
                foreach (var property in GetType().GetProperties())
                {
                    handler(this, new PropertyChangedEventArgs(property.Name));
                }
            });
        }

        public static void InvokeInUiThread(Action action)
        {
            ThreadExtensions.InvokeInUiThread(action);
        }

        public static void BeginInvokeInUiThread(Action action)
        {
            ThreadExtensions.BeginInvokeInUiThread(action);
        }

        public virtual string this[string propertyName] => null;

        public virtual string Error => null;
    }
}