using Microsoft.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.UserInteractions.Data
{
    public class FormValidator
    {
        public static bool ContainsIllegalCharacters(TextBox objField)
        {
            if (objField.Text.Contains("!") || objField.Text.Contains("@") || objField.Text.Contains("#") || objField.Text.Contains("$") || objField.Text.Contains("%") || objField.Text.Contains("&") || objField.Text.Contains("*") || objField.Text.Contains("(") || objField.Text.Contains("-") || objField.Text.Contains("_") || objField.Text.Contains("+") || objField.Text.Contains("=") || objField.Text.Contains("[") || objField.Text.Contains("}") || objField.Text.Contains("{") || objField.Text.Contains("}") || objField.Text.Contains("|") || objField.Text.Contains(@"\") || objField.Text.Contains(@"\") || objField.Text.Contains(":") || objField.Text.Contains(";") || objField.Text.Contains("'") || objField.Text.Contains("\"") || objField.Text.Contains(",") || objField.Text.Contains(".") || objField.Text.Contains("/") || objField.Text.Contains("<") || objField.Text.Contains(">") || objField.Text.Contains("?") || objField.Text.Contains("~") || objField.Text.Contains("`") || objField.Text.Contains(" "))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool PasswordsMatch(TextBox objField1, TextBox objField2)
        {
            if (objField1.Text == objField2.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidEmail(TextBox objField, Color objInvalidColor)
        {
            if (objField.Text.Contains("@") && objField.Text.Contains("."))
            {
                objField.BackColor = SystemColors.Window; //Reset the color to default.
                return true;
            }
            else
            {
                objField.BackColor = Color.Red;
                return false;
            }
        }
    }
}
