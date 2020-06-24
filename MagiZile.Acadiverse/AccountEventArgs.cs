using System;

namespace MagiZile.Acadiverse
{
    public class AccountEventArgs : EventArgs
    {
        readonly Account data;

        public Account Data { get => data; }

        public AccountEventArgs(Account data)
        {
            this.data = data;
        }
    }
}