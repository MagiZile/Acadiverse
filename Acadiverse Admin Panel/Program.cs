using MagiZile.Acadiverse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acadiverse_Admin_Panel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Wrong number of arguments.");
            }
            else
            {
                Account account = Account.LoadFromServer(args[0]);
                if (account == null)
                {
                    Console.WriteLine("incorrect username.");
                }
                else
                {
                    if (account.Password != Globals.EncryptString(args[1]))
                    {
                        Console.WriteLine("Incorrect password.");
                    }
                    else
                    {
                        if (!UserRole.UserHasRole(account, "admins"))
                        {
                            Console.WriteLine("Only Acadiverse admins can use this program. Where did you get it; only Acadiverse admins should be able to download it in the first place!");
                        }
                        else
                        {
                            Application.EnableVisualStyles();
                            Application.SetCompatibleTextRenderingDefault(false);
                            Application.Run(new FrmMain
                            {
                                currentAccount = Account.LoadFromServer(args[0])
                            });
                        }
                    }
                }
            }            
        }
    }
}
