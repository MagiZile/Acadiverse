using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadiverse_Lesson_Studio
{
    public static class ProgramOptions
    {
        //General
        
        /// <summary>
        /// If true, Acadicverse Lesson Studio will automatically check if an update is available when launched.
        /// </summary>
        public static bool CheckForUpdates = true;

        /// <summary>
        /// The directory where projects are saved.
        /// </summary>
        public static string SaveDirectory = @"C:\Users\" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.Substring(System.Environment.MachineName.Length + 1) + @"\Documents\Acadiverse Lesson Studio\Projects";

        /// <summary>
        /// It true, projects will be automatically saved.
        /// </summary>
        public static bool AutoSave = true; 

        /// <summary>
        /// The interval between auto-saves in minutes.
        /// </summary>
        public static int AutoSaveInterval = 10;

        /// <summary>
        /// If true, the Tip of the Day window will be shown at startup.
        /// </summary>
        public static bool ShowTips = true;

        /// <summary>
        /// If true, the Start Page, which shows recent projects, links to online Help pages, and Acadiverse Lesson Studio news, will be shown at startup.
        /// </summary>
        public static bool ShowStartPage = true;

        /// <summary>
        /// If true, projects will be synced to the user's Acadiverse account so they are accissible from any computer.
        /// </summary>
        public static bool SyncXProjects = true;

        /// <summary>
        /// If true, settings will be synced to the user's Acadiverse Account so they are accessible from any computer.
        /// </summary>
        public static bool SyncSettings = true;

        //Security

        /// <summary>
        /// If true, a password will be required each time Acadiverse Lesson Studio is launched.
        /// </summary>
        public static bool PasswordEnabled = false;

        /// <summary>
        /// The maximum number of attempts allowed before the program is quit and/or locked (disabled) if those features are enabled.
        /// </summary>
        public static int MaxPasswordAttempts = 3;

        /// <summary>
        /// If true, Acadiverse Lesson Studio will quit after too many failed password attempts.
        /// </summary>
        public static bool QuitAfterFail = false;

        /// <summary>
        /// If true, Acadiverse LEsson Studio will be locked (disabled) after too many failed password attempts.
        /// </summary>
        public static bool LockoutEnabled = false;

        /// <summary>
        /// The number of hours that Acadiverse Lesson Studio should be locked (disabled) for if the "lock out after too many failed password attempts" feature is enabled.
        /// </summary>
        public static int LockoutDuration = 6;

        /// <summary>
        /// The password used to unlock Acadiverse Lesson Studio. This password is encrypted using the same password/algorithm that is used to encrypt account passwords.
        /// </summary>
        public static string Password = "";

        //Backup

        /// <summary>
        /// If true, projects will automatically be backed up.when saved.
        /// </summary>
        public static bool AutoBackupEnabled = true;

        /// <summary>
        /// If true, old backups will be deleted to save space.
        /// </summary>
        public static bool DeleteOldBackups = false;

        /// <summary>
        /// The number of days before old backups are automatically deleted.
        /// </summary>
        public static int DaysToBackupDeletion = 14;

        /// <summary>
        /// If true, backups will be synced to the user's Acadiverse account and encrypted with the same password/algorithm that is used to encrypt users' passwords.
        /// </summary>
        public static bool SyncBackups = true;

        /// <summary>
        /// The directory in which to save project backups.
        /// </summary>
        public static string BackupDirectory = @"C:\Users\" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.Substring(System.Environment.MachineName.Length + 1) + @"\AppData\Roaming\MagiZile\Acadiverse\Acadiverse LEsson Studio\Backups\ProjectBackups\";

    }
}
