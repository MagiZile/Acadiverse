using System.Windows.Controls;

namespace Acadiverse_Desktop_Client
{
        public static class ButtonAwaiterExtensions
        {
            public static ButtonAwaiter GetAwaiter(this Button button)
            {
                return new ButtonAwaiter()
                {
                    Button = button
                };
            }
    }
}
