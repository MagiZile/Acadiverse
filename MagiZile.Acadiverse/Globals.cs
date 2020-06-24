using Microsoft.Win32;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MagiZile.Acadiverse
{ 
    public static class Globals
    {
        /// <summary>
        /// The MongoDb connection string. NOTE: WHEN POSTING ON GITHUB, THE STRING MUST BE REPLACED WITH "HIDDEN"!
        ///</summary>
        public const string CONNECTION_STRING = "mongodb+srv://admin:o5b8NeDcgO9yF9jn@acadiverse.axveq.gcp.mongodb.net/acadiverse?retryWrites=true&w=majority";

        //NOTE: WHEN POSTING CODE TO GITHUB, THE VALUE MUST BE REPLACED WITH "HIDDEN"!
        private const string PASSPHRASE = "g438v364gv349G#$G#$GFDeg";

        // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
        private const string INIT_VECTOR = "pemgail9uzpgzl88";

        // This constant is used to determine the keysize of the encryption algorithm
        private const int KEY_SIZE = 256;
        
        //This is the registry path used to store settings such as login information.
        public const string REGISTRY_PATH = @"HKEY_CURRENT_USER\SOFTWARE\MagiZile\Acadiverse";

        /// <summary>
        /// Shows an error message.
        /// </summary>
        /// <param name="message">The message to show.</param>
        public static void ShowErrorMessage(string message)
        {
            System.Windows.MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        /// <summary>
        /// Encrypts the specified string.
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static string EncryptString(string plainText)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(INIT_VECTOR);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(PASSPHRASE, null);
            byte[] keyBytes = password.GetBytes(KEY_SIZE / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged
            {
                Mode = CipherMode.CBC
            };
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(cipherTextBytes);
        }

        /// <summary>
        /// Shows a confirmation message.
        /// </summary>
        /// <param name="prompt">The prompt to show in the message.</param>
        /// <param name="cancelButtonIsDefault">Whether or not the Cancel button is the default button</param>
        /// <returns>Whether or not the user clicked OK on the confirmation message.</returns>
        public static bool ShowConfirmationMessage(string prompt, bool cancelButtonIsDefault)
        {
            if (!cancelButtonIsDefault)
            {
                return System.Windows.Forms.MessageBox.Show(prompt, "Confirmation", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                return System.Windows.Forms.MessageBox.Show(prompt, "Confirmation", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning, System.Windows.Forms.MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.OK;
            }
        }

        /// <summary>
        /// Reports the specified chat message.
        /// </summary>
        /// <param name="content">The chat message to report.</param>
        /// <param name="reportSender">The account used to send the report.</param>
        /// <param name="reason">The reason for sending the report.</param>
        public static void Report(ChatMessage content, Account reportSender, string reason)
        {
            foreach (Account account in Account.GetAccountList())
            {
                if (UserRole.UserHasRole(account, "moderators"))
                {
                    Account.SendPM(Account.LoadFromServer("ACADIVERSE_SYSTEM"), Account.LoadFromServer(account.Username), Properties.Resources.str_report_message_subject.Replace("$1", reportSender.Username).Replace("$2", content.SenderUsername), Properties.Resources.str_report_message_contents.Replace("$1", reportSender.Username).Replace("$2", content.SenderUsername).Replace("$3", reason).Replace("$4", content.MessageContents));
                }
            }
        }

        /// <summary>
        /// Reports the specified submission,
        /// </summary>
        /// <param name="content">The submission to report.</param>
        /// <param name="reportSender">The account used to send the report.</param>
        /// <param name="reason">The reason for sending the report.</param>
        public static void Report(Submission content, Account reportSender, string reason)
        {
            foreach (Account account in Account.GetAccountList())
            {
                if (UserRole.UserHasRole(account, "moderators"))
                {
                    Account.SendPM(Account.LoadFromServer("ACADIVERSE_SYSTEM"), Account.LoadFromServer(account.Username), Properties.Resources.str_report_message_subject.Replace("$1", reportSender.Username).Replace("$2", content.Author.Username), Properties.Resources.str_report_message_contents.Replace("$1", reportSender.Username).Replace("$2", content.Author.Username).Replace("$3", reason).Replace("$4", "Submission ID: " + content.Id));
                }
            }
        }

        /// <summary>
        /// Reports the specified account.
        /// </summary>
        /// <param name="reportedAccount">The account to report.</param>
        /// <param name="context">The context of the report.</param>
        /// <param name="reportSender">The account used to send the report.</param>
        /// <param name="reason">The reason for sendng the report.</param>
        public static void Report(Account reportedAccount, string context, Account reportSender, string reason)
        {
            foreach (Account account in Account.GetAccountList())
            {
                if (UserRole.UserHasRole(account, "moderators"))
                {
                    Account.SendPM(Account.LoadFromServer("ACADIVERSE_SYSTEM"), Account.LoadFromServer(account.Username), Properties.Resources.str_report_message_subject.Replace("$1", reportSender.Username).Replace("$2", reportedAccount.Username), Properties.Resources.str_report_message_contents.Replace("$1", reportSender.Username).Replace("$2", reportedAccount.Username).Replace("$3", reason).Replace("$4", context));
                }
            }
        }

        /// <summary>
        /// Decrypts the specified string.
        /// </summary>
        /// <param name="cipherText"></param>
        /// <returns></returns>
        public static string DecryptString(string cipherText)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(INIT_VECTOR);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(PASSPHRASE, null);
            byte[] keyBytes = password.GetBytes(KEY_SIZE / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged
            {
                Mode = CipherMode.CBC
            };
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }
        
        /// <summary>
        /// Bans the specified user for the specified amount of time (permanently if the specified time is equal to zero). Banned users cannot log in to Acadiverse at all.
        /// </summary>
        /// <param name="moderator">The moderator name for use in the logged infeaction.</param>
        /// <param name="account">The account to ban.</param>
        /// <param name="reason">The reason for banning the user.</param>
        /// <param name="banLength">The length of time to ban the user for (a TimeSpan of 0 is used for permanent bans).</param>
        public static void BanUser(Account moderator, Account account, string reason, TimeSpan banLength)
        { 
            account.AccountBanned = true;
            account.BanReason = reason;
            if (banLength.Equals(new TimeSpan(0)))
            {
                account.DateBanExpires = new DateTime(1970, 1, 1);
                new Infraction(account.Username, InfractionType.Permaban, moderator.Username, DateTime.Now, reason).SaveToServer();
            }
            else
            {
                account.DateBanExpires = DateTime.Now.Add(banLength);
                new Infraction(account.Username, InfractionType.Tempban, moderator.Username, DateTime.Now, reason).SaveToServer();
            }
            account.SaveToServer();
        }
        
        /// <summary>
        /// Adds an ordinal suffix to a number and returns the resulting string.
        /// </summary>
        /// <param name="number">The number to add an ordinal suffix to.</param>
        /// <returns>The number with an ordinal suffix added to it, returned as a string.</returns>
        public static string NumberWithOrdinalSuffix(int number)
        {
            string result = number.ToString();
            if (number.ToString().EndsWith("1") && !number.ToString().EndsWith("11"))
            {
                result += "st";
            }
            else if (number.ToString().EndsWith("2") && !number.ToString().EndsWith("12"))
            {
                result += "nd";
            }
            else if (number.ToString().EndsWith("3") && !number.ToString().EndsWith("13"))
            {
                result += "rd";
            }
            else
            {
                result += "th";
            }
            return result;
        }

        /// <summary>
        /// Warns the specified user, banning them if they have a certain number of warnings.
        /// </summary>
        /// <param name="moderator">The moderator account for the sender of the PM as well as the moderator for the logged infeaction.</param>
        /// <param name="account">The account to send a warning message to.</param>
        /// <param name="reason">The reason that the user was given a warning.</param>

        public static void WarnUser(Account moderator, Account account, string reason)
        {
            Account.SendPM(moderator, account, Properties.Resources.str_warning_message_subject, Properties.Resources.str_warning_message_contents.Replace("$1", reason));
            account.Warnings++;
            account.AcknowledgedLastWarning = false;
            account.LastWarnedByModeratorName = moderator.Username;
            account.DateLastWarningReceived = DateTime.Now;
            account.LastWarningReason = reason;
            account.SaveToServer();
            new Infraction(account.Username, InfractionType.Warning, moderator.Username, DateTime.Now, reason).SaveToServer();
            if (account.Warnings == 3)
            {
                BanUser(Account.LoadFromServer("ACADIVERSE_SYSTEM"), account, Properties.Resources.str_automatic_ban_reason.Replace("$1", NumberWithOrdinalSuffix(3)), new TimeSpan(6, 0, 0)); ;
            }
            else if (account.Warnings == 4)
            {
                BanUser(Account.LoadFromServer("ACADIVERSE_SYSTEM"), account, Properties.Resources.str_automatic_ban_reason.Replace("$1", NumberWithOrdinalSuffix(4)), new TimeSpan(12, 0, 0));
            }
            else if (account.Warnings == 5)
            {
                BanUser(Account.LoadFromServer("ACADIVERSE_SYSTEM"), account, Properties.Resources.str_automatic_ban_reason.Replace("$1", NumberWithOrdinalSuffix(5)), new TimeSpan(24, 0, 0));
            }
            else if (account.Warnings == 6)
            {
                BanUser(Account.LoadFromServer("ACADIVERSE_SYSTEM"), account, Properties.Resources.str_automatic_ban_reason.Replace("$1", NumberWithOrdinalSuffix(6)), new TimeSpan(48, 0, 0));
            }
            else if (account.Warnings == 7)
            {
                BanUser(Account.LoadFromServer("ACADIVERSE_SYSTEM"), account, Properties.Resources.str_automatic_ban_reason.Replace("$1", NumberWithOrdinalSuffix(7)), new TimeSpan(14, 0, 0, 0));
            }
            else if (account.Warnings == 8)
            {
                BanUser(Account.LoadFromServer("ACADIVERSE_SYSTEM"), account, Properties.Resources.str_automatic_ban_reason.Replace("$1", NumberWithOrdinalSuffix(8)), new TimeSpan(30, 0, 0, 0));
            }
            else if (account.Warnings == 9)
            {
                BanUser(Account.LoadFromServer("ACADIVERSE_SYSTEM"), account, Properties.Resources.str_automatic_ban_reason.Replace("$1", NumberWithOrdinalSuffix(9)), new TimeSpan(90, 0, 0, 0));
            }
            else if (account.Warnings == 10)
            {
                BanUser(Account.LoadFromServer("ACADIVERSE_SYSTEM"), account, Properties.Resources.str_automatic_ban_reason.Replace("$1", NumberWithOrdinalSuffix(10)), new TimeSpan(180, 0, 0, 0));
            }
            else if (account.Warnings == 11)
            {
                BanUser(Account.LoadFromServer("ACADIVERSE_SYSTEM"), account, Properties.Resources.str_automatic_ban_reason.Replace("$1", NumberWithOrdinalSuffix(11)), new TimeSpan(365, 0, 0, 0));
            }
            else if (account.Warnings == 12)
            {
                BanUser(Account.LoadFromServer("ACADIVERSE_SYSTEM"), account, Properties.Resources.str_automatic_ban_reason.Replace("$1", NumberWithOrdinalSuffix(12)), new TimeSpan(365, 0, 0, 0));
            }
        }

        public static void UpdateValue(string collectionName, string filterName, string filterValue, string variable, string value)
        {
            try
            {
                MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbclient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>(collectionName);
                var filter = Builders<BsonDocument>.Filter.Eq(filterName, filterValue);
                var update = Builders<BsonDocument>.Update.Set(variable, value);
                collection.UpdateOne(filter, update);
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (DnsClient.DnsResponseException)
            {
                Globals.ShowErrorMessage(Properties.Resources.str_connection_error);
            }
#pragma warning restore CA1031 // Do not catch general exception types
            catch (TimeoutException)
            {
                Globals.ShowErrorMessage("The connection timed out. Please check your firewall settings to see if Acadiverse Desktop Client for Windows is blocked. Don't worry; all Acadiverse programs are safe!");
            }
        }

        public static void UpdateValue(string collectionName, string filterName, string filterValue, string variable, BsonDateTime value)
        {
            try
            {
                MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbclient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>(collectionName);
                var filter = Builders<BsonDocument>.Filter.Eq(filterName, filterValue);
                var update = Builders<BsonDocument>.Update.Set(variable, value);
                collection.UpdateOne(filter, update);
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (DnsClient.DnsResponseException)
            {
                Globals.ShowErrorMessage(Properties.Resources.str_connection_error);
            }
#pragma warning restore CA1031 // Do not catch general exception types
            catch (TimeoutException)
            {
                Globals.ShowErrorMessage("The connection timed out. Please check your firewall settings to see if Acadiverse Desktop Client for Windows is blocked. Don't worry; all Acadiverse programs are safe!");
            }
        }

        public static void UpdateValue(string collectionName, string filterName, string filterValue, string variable, BsonBoolean value)
        {
            try
            {
                MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbclient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>(collectionName);
                var filter = Builders<BsonDocument>.Filter.Eq(filterName, filterValue);
                var update = Builders<BsonDocument>.Update.Set(variable, value);
                collection.UpdateOne(filter, update);
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (DnsClient.DnsResponseException)
            {
                Globals.ShowErrorMessage(Properties.Resources.str_connection_error);
            }
#pragma warning restore CA1031 // Do not catch general exception types
            catch (TimeoutException)
            {
                Globals.ShowErrorMessage("The connection timed out. Please check your firewall settings to see if Acadiverse Desktop Client for Windows is blocked. Don't worry; all Acadiverse programs are safe!");
            }
        }

        public static void UpdateValue(string collectionName, string filterName, string filterValue, string variable, BsonInt32 value)
        {
            try
            {
                MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbclient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>(collectionName);
                var filter = Builders<BsonDocument>.Filter.Eq(filterName, filterValue);
                var update = Builders<BsonDocument>.Update.Set(variable, value);
                collection.UpdateOne(filter, update);
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (DnsClient.DnsResponseException)
            {
                Globals.ShowErrorMessage(Properties.Resources.str_connection_error);
            }
#pragma warning restore CA1031 // Do not catch general exception types
            catch (TimeoutException)
            {
                Globals.ShowErrorMessage("The connection timed out. Please check your firewall settings to see if Acadiverse Desktop Client for Windows is blocked. Don't worry; all Acadiverse programs are safe!");
            }
        }

        public static void UpdateValue(string collectionName, string filterName, string filterValue, string variable, BsonArray value)
        {
            try
            {
                MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbclient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>(collectionName);
                var filter = Builders<BsonDocument>.Filter.Eq(filterName, filterValue);
                var update = Builders<BsonDocument>.Update.Set(variable, value);
                collection.UpdateOne(filter, update);
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (DnsClient.DnsResponseException)
            {
                Globals.ShowErrorMessage(Properties.Resources.str_connection_error);
            }
#pragma warning restore CA1031 // Do not catch general exception types
            catch (TimeoutException)
            {
                Globals.ShowErrorMessage("The connection timed out. Please check your firewall settings to see if Acadiverse Desktop Client for Windows is blocked. Don't worry; all Acadiverse programs are safe!");
            }
        }

        public static void UpdateValue(string collectionName, string filterName, string filterValue, string variable, BsonObjectId value)
            {
            try
            {
                MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbclient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>(collectionName);
                var filter = Builders<BsonDocument>.Filter.Eq(filterName, filterValue);
                var update = Builders<BsonDocument>.Update.Set(variable, value);
                collection.UpdateOne(filter, update);
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (DnsClient.DnsResponseException)
            {
                Globals.ShowErrorMessage(Properties.Resources.str_connection_error);
            }
#pragma warning restore CA1031 // Do not catch general exception types
            catch (TimeoutException)
            {
                Globals.ShowErrorMessage("The connection timed out. Please check your firewall settings to see if Acadiverse Desktop Client for Windows is blocked. Don't worry; all Acadiverse programs are safe!");
            }
        }

        public static bool InCollection(string collectionName, string filterElementName, string filterValue)
        {
                MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbclient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>(collectionName);
                var filter = Builders<BsonDocument>.Filter.Eq(filterElementName, filterValue);
                return collection.Find(filter).CountDocuments() != 0;
        }
    }
}