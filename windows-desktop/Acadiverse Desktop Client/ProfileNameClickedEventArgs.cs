using MagiZile.Acadiverse;
using System;

namespace Acadiverse_Desktop_Client
{
    public class ProfileNameClickedEventArgs: EventArgs
    {
        Account data;

        public Account Data { get => data; set => data = value; }

        public ProfileNameClickedEventArgs(Account data)
        {

        }
    }
}