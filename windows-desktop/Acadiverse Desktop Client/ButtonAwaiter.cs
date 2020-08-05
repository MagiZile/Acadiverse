using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace Acadiverse_Desktop_Client
{
    public class ButtonAwaiter : INotifyCompletion
    {
        public bool IsCompleted
        {
            get { return false; }
        }

        public void GetResult()
        {

        }

        public Button Button { get; set; }

        public void OnCompleted(Action continuation)
        {
            RoutedEventHandler h = null;
            h = (o, e) =>
            {
                Button.Click -= h;
                continuation();
            };
            Button.Click += h;
        }
    }
}