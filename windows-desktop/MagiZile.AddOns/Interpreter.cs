using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.AddOns
{
    public static class Interpreter
    {
        /// <summary>
        /// Copies the specified package's scripts.
        /// </summary>
        /// <param name="file">The package to copy scripts from.</param>
        public static void ExtractPackage(string file)
        {

        }

        /// <summary>
        /// Executes the specified script.
        /// </summary>
        /// <param name="script">The script to execute.</param>
        public static void Execute(string script)
        {
            StreamReader objScript = new StreamReader(script);
            if (ValidSyntax(script) == false)
            {
                return;
            }
        }

        /// <summary>
        /// Checks a script for syntax errors.
        /// </summary>
        /// <param name="script">The script to check.</param>
        /// <returns>Whether or not the script is a valid MgiZile Add-Ons Language program.</returns>
        public static bool ValidSyntax(string script)
        {
            StreamReader objScript = new StreamReader(script);
            string scriptContents = objScript.ReadToEnd();
            objScript.Close();
            string[] lines = scriptContents.Split('\n');
            foreach (string line in lines)
            {
                string[] statements = line.Split();
                string strippedComments = "";
                foreach (string statement in statements)
                {
                    if (statement.Contains("***") == false)
                    {
                        strippedComments += statement;
                    }
                }
            }
            if (lines[0] != "Start")
            {
                RaiseError(2, "");
                return false;
            }
            for (int index = 1; index < lines.Length - 1; index++)
            {

            }
            if (lines[lines.Length - 1] != "Finish")
            {
                RaiseError(2, "");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Adds a menu using a menu definition file.
        /// </summary>
        /// <param name="definitionFile"></param>
        public static void AddMenu(string definitionFile)
        {

        }

        /// <summary>
        /// Raises a script error.
        /// </summary>
        /// <param name="errorText">The error to raise.</param>
        /// <param name="errorCode">The error code.</param>
        public static void RaiseError(string errorText, int errorCode)
        {
            MessageBox.Show("Error " + errorCode + ": " + errorText, "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw (new Exception("Error " + errorCode + ": " + errorText));
        }

        /// <summary>
        /// Raises a acript error with the specified code.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="context">Additional information about the error.</param>
        public static void RaiseError(int errorCode, string context)
        {
            string message = "Unknown Error.";
            switch (errorCode)
            {
                case 1:
                    message = "The script \"" + context + "\" could not be unpacked. The file may be corrupted or damaged.";
                    break;
                case 2:
                    message = "Syntax Error.";
                    break;
                case 3:
                    message = "Too many levels of recursion.";
                    break;
                case 4:
                    message = "The script file associated with \"" + context + "\" could not be found.";
                    break;
                case 5:
                    message = "The custom menu file \"" + context + "\" could not be found.";
                    break;
                case 6:
                    message = "Could not create menu from \"" + context + "\". The file may be corrupted or damaged.";
                    break;
            }
            MessageBox.Show("Error " + errorCode + ": " + message, "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw (new Exception("Error " + errorCode + ": " + message));
        }
    }
}
