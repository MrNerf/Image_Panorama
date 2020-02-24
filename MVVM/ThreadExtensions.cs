using System;
using System.Windows;

namespace Image_panorama.MVVM
{
    public static class ThreadExtensions
    {
        public static void InvokeInUiThread(Action action)
        {
            var application = Application.Current;

            // ReSharper disable once UseNullPropagation
            if (application == null) return;

            var dispatcher = application.Dispatcher;

            if (dispatcher == null) return;

            if (dispatcher.CheckAccess())
                action.Invoke();
            else
                dispatcher.Invoke(action);
        }

        public static void BeginInvokeInUiThread(Action action)
        {
            var application = Application.Current;

            // ReSharper disable once UseNullPropagation
            if (application == null) return;

            var dispatcher = application.Dispatcher;

            if (dispatcher == null) return;

            if (dispatcher.CheckAccess())
                action.Invoke();
            else
                dispatcher.BeginInvoke(action);
        }
    }
}