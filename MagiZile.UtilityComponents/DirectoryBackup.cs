using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.UtilityComponents
{
    public class DirectoryBackup
    {
        public string sourceFolder = "";
        public string destinationFolder = "";
        public List<string> errors = new List<string>();

        public DirectoryBackup(string sourceFolder, string destinationFolder)
        {
            this.sourceFolder = sourceFolder;
            this.destinationFolder = destinationFolder;
        }

        /// <summary>
        /// Backs up the specified directory to the specified destination, returning true if the backup completed without any errors or false if there were errors.
        /// </summary>
        /// <param name="deleteOnFail">Whether or not to delete the backup if it had any errors.</param>
        /// <returns>Whether or not the backup completed without any errors.</returns>
        public bool Backup(bool deleteOnFail)
        {
            errors.Clear();
            CopyDirectory(sourceFolder, destinationFolder);
            if (errors.Count == 0)
            {
                return true;
            }
            else
            {
                if (deleteOnFail == true)
                {
                    //Directory.Delete(dest + Path.GetFileName(source), true); Commented out until correct backup location can be specified.
                }
                return false;
            }
        }

        public void CopyDirectory(string source, string dest)
        {
            Directory.CreateDirectory(dest + Path.GetFileName(source));
            foreach (string file in Directory.GetFiles(source))
            {
                try
                {
                    File.Copy(file, dest + @"\" + Path.GetDirectoryName(source) + @"\" + Path.GetFileName(source));
                }
                catch (Exception ex)
                {
                    errors.Add("Error copying " + file + ": " + ex.Message); //Add the error description to the list of errors.
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
                finally
                {
                    System.Diagnostics.Debug.WriteLine(source + "- " + dest + Path.GetDirectoryName(source));
                }
            }
            foreach (string subdir in Directory.GetDirectories(source))
            {
                try
                {
                    CopyDirectory(subdir, dest + @"\" + Path.GetFileName(subdir));
                }
                catch (Exception ex)
                {
                    errors.Add("Error copying " + subdir + ": " + ex.Message); //Add the error description to the list of errors.
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
                finally
                {
                    System.Diagnostics.Debug.WriteLine(source + "- " + dest);
                }
            }
        }
    }
}
