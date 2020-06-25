using MagiZile.Acadiverse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acadiverse_Lesson_Studio
{
    static class Program
    {
        /// <summary>
        /// If this is true, Acadiverse Lesson Studio will be launched in "debug mode", where the program will start without the launcher or a Teacher account.
        /// </summary>
        static readonly bool debug = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (debug)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmSplashScreen
                {
                    currentAccount = Account.LoadFromServer("DEBUG")
                });
            }
            else
            {
                if (Globals.CorrectPassword(args[0], "KmkZMDPtDzT2whOKbaTFWAkHBQbzixRIEJ7LPJQC3ls="))
                {
                    Console.WriteLine("Acadiverse Lesson Studio must be run from the Acadiverse Launcher.");
                }
                else
                {
                    Account account = Account.LoadFromServer(args[1]);
                    if (!(account.Password == Globals.SaltedPassword(args[2])))
                    {
                        Console.WriteLine("The password you entered was incorrect.");
                    }
                    else
                    {
                        if (account.AccountBanned)
                        {
                            Console.WriteLine("The account you tried to launch Acadiverse Lesson Studio with is currently banned from Acadiverse.");
                        }
                        else
                        {
                            if (!(account.AccountType == AcadiverseAccountType.Teacher))
                            {
                                Console.WriteLine("Acadiverse Lesson Studio can only be used by Teacher accounts.");
                            }
                            else
                            {
                                Application.EnableVisualStyles();
                                Application.SetCompatibleTextRenderingDefault(false);
                                Application.Run(new FrmSplashScreen
                                {
                                    currentAccount = account
                                });
                            }
                        }
                    }
                }
            }
        }
    }
}
