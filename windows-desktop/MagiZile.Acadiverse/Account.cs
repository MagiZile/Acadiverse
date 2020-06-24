using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace MagiZile.Acadiverse
{
    /// <summary>
    /// Represents an Acadiverse account.
    /// </summary>
    public class Account : IEquatable<Account>
    {
        string username = "";
        string password = "";

        AcadiverseAccountType accountType = AcadiverseAccountType.Student;
        BsonObjectId id;
        int reputationPoints = 0;
        int money = 0;
        bool accountBanned = false;
        DateTime dateBanExpires = new DateTime(1970, 1, 1);
        string banReason = "";
        bool isAdmin = false;
        bool canPublish = true;
        bool canChat = true;
        DateTime accountCreationDate = new DateTime(1970, 1, 1);
        DateTime lastLoginDate = new DateTime(1970, 1, 1);
        DateTime birthday = new DateTime();
        string profileBio = "";
        string email = "";
        BsonArray infractionHistory;
        BsonArray privateMessages = new BsonArray();
        int chatStrikes = 0;
        int publishingStrikes = 0;
        int warnings = 0;
        
        int gradeLevel = 0;
        BsonArray buddies = new BsonArray();
        bool notifySubmissionComment = true;
        bool notifySubmissionUpvote = true;
        bool notifySubmissionFeatured = true;
        bool notifyAchievementReceived = true;
        bool notifyPMReceived = true;
        bool notifyMentioned = true;
        bool receivesPMs = true;
        bool acceptsBuddyInvites = true;
        int anniversaryAchievementCount = 0;
        int perfectQuizScoreAchievementCount = 0;
        int topPublisherAchievementCount = 0;
        string displayName = "";
        BsonArray notifications = new BsonArray();
        BsonArray blockedUsers = new BsonArray();
        string lastWarnedByModeratorName = "";
        string lastWarningReason = "";
        DateTime dateLastWarningReceived = DateTime.Now;
        bool acknowledgedLastWarning = true;
        Bitmap profileImage;

        /// <summary>
        /// The ObjectID for this account.
        /// </summary>
        public BsonObjectId ID { get => id; set => id = value; }

        /// <summary>
        /// The account's usernam, which is used to identify users.
        /// </summary>
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (AccountExists(value))
                {
                    throw new ArgumentException("This username is already in use.");
                }
                else
                {
                    username = value;
                }
            }
        }

        /// <summary>
        /// The account's password, which is encrypted.
        /// </summary>
        public string Password { get => password; set => password = value; }

        /// <summary>
        /// The type of account. Some features are restricted to certian types of accounts.
        /// </summary>
        public AcadiverseAccountType AccountType { get => accountType; set => accountType = value; }

        /// <summary>
        /// The number of Reputation Points that the user has. Reputation Points are earned by completing secnarios and getting likes on their submissions.
        /// </summary>
        public int ReputationPoints { get => reputationPoints; set => reputationPoints = value; }

        /// <summary>
        /// The amount of Acadicoins that the user has. Acadicoins are used to purchase items in-game.
        /// </summary>
        public int Money { get => money; set => money = value; }

        /// <summary>
        /// Whether or not this account is banned. Banned users cannot log in to Acadiverse.
        /// </summary>
        public bool AccountBanned { get => accountBanned; set => accountBanned = value; }

        /// <summary>
        /// The date that this user's ban expires. Accounts that are permabanned have this set to 1/1/1970.
        /// </summary>
        public DateTime DateBanExpires { get => dateBanExpires; set => dateBanExpires = value; }

        /// <summary>
        /// The reason that this account was banned.
        /// </summary>
        public string BanReason { get => banReason; set => banReason = value; }

        /// <summary>
        /// Whether or not the user is an admin.
        /// </summary>
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }

        /// <summary>
        /// Whether or not the user can publish Lessons, Scenarios, or other content to Acadiverse.
        /// </summary>
        public bool CanPublish { get => canPublish; set => canPublish = value; }

        /// <summary>
        /// Whetheer or not the user is allowed to use Chat or send PMs to users who are not moderators.
        /// </summary>
        public bool CanChat { get => canChat; set => canChat = value; }

        /// <summary>
        /// The date that the account was created.
        /// </summary>
        public DateTime AccountCreationDate { get => accountCreationDate; set => accountCreationDate = value; }

        /// <summary>
        /// The date that the user last logged in.
        /// </summary>
        public DateTime LastLoginDate { get => lastLoginDate; set => lastLoginDate = value; }

        /// <summary>
        /// The user's birthday as shown on their profile.
        /// </summary>
        public DateTime Birthday { get => birthday; set => birthday = value; }

        /// <summary>
        /// The bio ("About Me" section) on this user's profile.
        /// </summary>
        public string ProfileBio { get => profileBio; set => profileBio = value; }

        /// <summary>
        /// The email associated with this account.
        /// </summary>
        public string Email { get => email; set => email = value; }

        /// <summary>
        /// An array representing the infraction history, which moderators can take into consideration whenever a user violates the Terms of Service or the Code of Conduct, and can only be seen by moderators.
        /// </summary>
        public BsonArray InfractionHistory { get => infractionHistory; set => infractionHistory = value; }

        /// <summary>
        /// An array representing the user's private messages (PMs).
        /// </summary>
        public BsonArray PrivateMessages { get => privateMessages; set => privateMessages = value; }

        /// <summary>
        /// The number of strikes on this account given by the word filter. After three of these, the user will automatically lose the ability to chat/send PMs.
        /// </summary>
        public int ChatStrikes { get => chatStrikes; set => chatStrikes = value; }

        /// <summary>
        /// The number of strikes on this account given if a bad word or a slur is in anything that they are trying to publish. After three of these, the user will automatically lose the ability to publish content to Acadiverse.
        /// </summary>
        public int PublishingStrikes { get => publishingStrikes; set => publishingStrikes = value; }

        /// <summary>
        /// The number of warnings given to this user by a moderator. After 3 of these, the user will automatically be banned, with the length increasing the more warnings that the user gets.
        /// </summary>
        public int Warnings { get => warnings; set => warnings = value; }

        /// <summary>
        /// The user's grade level (for students) or the grade level taught (for teachers). 0 is used to represent kindergarten, and grades after 12 represent college; this is used to recommend content published to Acadiverse.
        /// </summary>
        public int GradeLevel { get => gradeLevel; set => gradeLevel = value; }

        /// <summary>
        /// An array representing the user's buddies.
        /// </summary>
        public BsonArray Buddies { get => buddies; set => buddies = value; }

        /// <summary>
        /// Whether or not the user should be notified if someoone else commonts on one of their submissions.
        /// </summary>
        public bool NotifySubmissionComment { get => notifySubmissionComment; set => notifySubmissionComment = value; }
        
        /// <summary>
        /// Whether or not the user should be notified if someone else upvotes one of their submissions.
        /// </summary>
        public bool NotifySubmissionUpvote { get => notifySubmissionUpvote; set => notifySubmissionUpvote = value; }
        
        /// <summary>
        /// Whether or not the user should be notified if one of their submissions gets featured.
        /// </summary>
        public bool NotifySubmissionFeatured { get => notifySubmissionFeatured; set => notifySubmissionFeatured = value; }
        
        /// <summary>
        /// Whether or not the user should be notified if they have received an achievement.
        /// </summary>
        public bool NotifyAchievementReceived { get => notifyAchievementReceived; set => notifyAchievementReceived = value; }
        
        /// <summary>
        /// Whether or not the user should be notified if they have received a PM.
        /// </summary>
        public bool NotifyPMReceived { get => notifyPMReceived; set => notifyPMReceived = value; }
        
        /// <summary>
        /// Whether or not the user should be notified if their username is mentioned ("@username") in chat or in the comments for a submission.
        /// </summary>
        public bool NotifyMentioned { get => notifyMentioned; set => notifyMentioned = value; }
        /// <summary>
        /// If false, no users who are not moderators will be able to send this user a PM.
        /// </summary>
        public bool ReceivesPMs { get => receivesPMs; set => receivesPMs = value; }
        
        /// <summary>
        /// If false, nobody can invite this user to be one of their buddies.
        /// </summary>
        public bool AcceptsBuddyInvites { get => acceptsBuddyInvites; set => acceptsBuddyInvites = value; }
        
        /// <summary>
        /// The number of times that the user has received the "[number] Anniversary" achievement.
        /// </summary>
        public int AnniversaryAchievementCount { get => anniversaryAchievementCount; set => anniversaryAchievementCount = value; }
        
        /// <summary>
        /// The number of times that the user has received the "Aced It" achievemet.
        /// </summary>
        public int PerfectQuizScoreAchievementCount { get => perfectQuizScoreAchievementCount; set => perfectQuizScoreAchievementCount = value; }
        
        /// <summary>
        /// The number of times that the user has received the "Top Publisher" achievement.
        /// </summary>
        public int TopPublisherAchievementCount { get => topPublisherAchievementCount; set => topPublisherAchievementCount = value; }
        
        /// <summary>
        /// The user's display name. This is what is shown instead of the username in chat messages, submissions and submission comments, the actual Acadiverse game itself, and the Buddies list.
        /// </summary>
        public string DisplayName { get => displayName; set => displayName = value; }
        
        /// <summary>
        /// An array representing the user's notifications.
        /// </summary>
        public BsonArray Notifications { get => notifications; set => notifications = value; }

        /// <summary>
        /// An array representing the users that this user has blocked. blocked users cannot send this user any PMs or comment on any of their sumbmissions (unless the blocked user is also a moderator).
        /// </summary>
        public BsonArray BlockedUsers { get => blockedUsers; set => blockedUsers = value; }

        /// <summary>
        /// The username of the moderator who last sent this user a warning.
        /// </summary>
        public string LastWarnedByModeratorName { get => lastWarnedByModeratorName; set => lastWarnedByModeratorName = value; }

        /// <summary>
        /// The reason of for the user's most-recent warning, if not yet acknowledged.
        /// </summary>
        public string LastWarningReason { get => lastWarningReason; set => lastWarningReason = value; }

        /// <summary>
        /// The date this user's most recent warning was received.
        /// </summary>
        public DateTime DateLastWarningReceived { get => dateLastWarningReceived; set => dateLastWarningReceived = value; }

        /// <summary>
        /// Whether or not this user's most-recent warning was acknowledged. This is used to determine whether or not to show the popup to notify a user that they have received a warning.
        /// </summary>
        public bool AcknowledgedLastWarning { get => acknowledgedLastWarning; set => acknowledgedLastWarning = value; }
        public Bitmap ProfileImage { get => profileImage; set => profileImage = value; }

        public static void SendEmail(string subject, string messageBody, Account account)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("noreply@magizile.com");
                message.To.Add(new MailAddress(account.email));
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = messageBody;
                smtp.Port = 587;
                smtp.Host = "smtp.magizile.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("noreply@magizile.com", "password");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Deletes this account from the server.
        /// </summary>
        public void DeleteAccount()
        {
            MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
            var database = dbclient.GetDatabase("acadiverse");
            var collection = database.GetCollection<BsonDocument>("accounts");
            var deleteFilter = Builders<BsonDocument>.Filter.Eq("username", Username);
            collection.DeleteOne(deleteFilter);
            foreach (BsonObjectId chatMessageID in ChatMessage.GetChatMessageIDs(Username))
            {
                ChatMessage msg = ChatMessage.LoadFromServer(chatMessageID);
                if (msg.SenderUsername == Username)
                {
                    msg.DeleteMessage(false);
                }
            }
        }

        /// <summary>
        /// Looks up a BsonDocument for an account with the specified username and loads it from the server.
        /// </summary>
        /// <param name="username">The username of the account to load from the server.</param>
        /// <returns>An Account object with the account data if the account exists, null otherwise.</returns>
        public static Account LoadFromServer(string username)
        {
            Account account = new Account();
            try
            {
                MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbclient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>("accounts");
                var filter = Builders<BsonDocument>.Filter.Eq("username", username);
                var document = collection.Find(filter).FirstOrDefault();
                if (document == null)
                {
                    return null;
                }
                account.ID = document.GetElement("_id").Value.AsObjectId;
                account.Username = document.GetElement("username").Value.AsString;
                account.Password = document.GetElement("password").Value.AsString;
                switch (document.GetElement("account_type").Value.AsString)
                {
                    case "Parent":
                        account.AccountType = AcadiverseAccountType.Parent;
                        break;
                    case "Student":
                        account.AccountType = AcadiverseAccountType.Student;
                        break;
                    case "Teacher":
                        account.AccountType = AcadiverseAccountType.Teacher;
                        break;
                }
                account.ReputationPoints = document.GetElement("reputation_points").Value.ToInt32();
                account.Money = document.GetElement("money").Value.ToInt32();
                account.AccountBanned = document.GetElement("account_banned").Value.ToBoolean();
                account.DateBanExpires = document.GetElement("date_ban_expires").Value.ToUniversalTime();
                account.banReason = document.GetElement("ban_reason").Value.AsString;
                account.IsAdmin = document.GetElement("is_admin").Value.ToBoolean();
                account.CanPublish = document.GetElement("can_publish").Value.ToBoolean();
                account.CanChat = document.GetElement("can_chat").Value.ToBoolean(); ;
                account.AccountCreationDate = document.GetElement("account_creation_date").Value.ToUniversalTime();
                account.LastLoginDate = document.GetElement("last_login_date").Value.ToUniversalTime();
                account.Birthday = document.GetElement("birthday").Value.ToUniversalTime();
                account.ProfileBio = document.GetElement("profile_bio").Value.AsString;
                account.Email = document.GetElement("email").Value.AsString;
                account.PrivateMessages = document.GetElement("private_messages").Value.AsBsonArray;
                account.ChatStrikes = document.GetElement("chat_strikes").Value.ToInt32();
                account.PublishingStrikes = document.GetElement("publishing_strikes").Value.ToInt32();
                account.Warnings = document.GetElement("warnings").Value.ToInt32();
                account.Notifications = document.GetElement("notifications").Value.AsBsonArray;
                account.NotifyAchievementReceived = document.GetElement("notify_achievement_received").Value.ToBoolean();
                account.NotifySubmissionFeatured = document.GetElement("notify_submission_featured").Value.ToBoolean();
                account.NotifyMentioned = document.GetElement("notify_mentioned").Value.ToBoolean();
                account.NotifySubmissionComment = document.GetElement("notify_submission_comment").Value.ToBoolean();
                account.NotifySubmissionUpvote = document.GetElement("notify_submission_upvote").Value.ToBoolean();
                account.NotifyPMReceived = document.GetElement("notify_pm_received").Value.ToBoolean();
                account.ReceivesPMs = document.GetElement("receives_pms").Value.ToBoolean();
                account.BlockedUsers = document.GetElement("blocked_users").Value.AsBsonArray;
                account.AcknowledgedLastWarning = document.GetElement("acknowledged_last_warning").Value.ToBoolean();
                account.LastWarnedByModeratorName = document.GetElement("last_warned_by_moderator_name").Value.ToString();
                account.DateLastWarningReceived = document.GetElement("date_last_warning_received").Value.ToUniversalTime();
                account.LastWarningReason = document.GetElement("last_warning_reason").Value.AsString;
                StreamWriter objBitmapFile = new StreamWriter("profile.bmp");
                objBitmapFile.Write(document.GetElement("profile_image_data").Value.AsString);
                objBitmapFile.Close();
                objBitmapFile.Dispose();
                account.ProfileImage = new Bitmap(Image.FromFile("profile.bmp"));
                File.Delete("profile.bmp");
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (DnsClient.DnsResponseException) //This exception is usually thrown if the client cannot connect to the server for some reason.
            {
                Globals.ShowErrorMessage(Properties.Resources.str_connection_error); //Show an error message informing the user that there was a problem connecting.
            }
#pragma warning restore CA1031 // Do not catch general exception types
            catch (TimeoutException) //This exception is thrown if the connection times out, which may be caused by a firewall blocking Acadiverse Desktop Client for Windows.
            {
                Globals.ShowErrorMessage("The connection timed out. Please check your firewall settings to see if Acadiverse Desktop Client for Windows is blocked. Don't worry; all Acadiverse programs are safe!"); //Show an error message informing users of the problem.
            }
            catch (KeyNotFoundException) //This exception is thrown if a key does not exist, which is usually due to an update being rolled out that changes how account data is structured, such as adding new features.
            {
                return account; //Returns the account with the current values. This is here in case an update requires adding or removing keys/values (they are always added at the end of the document), so users can still log in after the update has been rolled out.
            }
            return account;
        }

        /// <summary>
        /// Looks up a BsonDocument for an account with the specified username and loads it from the server.
        /// </summary>
        /// <param name="id">The ID of the account to load from the server.</param>
        /// <returns>An Account object with the account data if the account exists, null otherwise.</returns>
        public static Account LoadFromServer(BsonObjectId id)
        {
            Account account = new Account();
            try
            {
                MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbclient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>("accounts");
                var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                var document = collection.Find(filter).FirstOrDefault();
                account = LoadFromServer(document.GetElement("username").Value.ToString());
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
            return account;
        }
        /// <summary>
        /// Saves this account's data to the server.
        /// </summary>
        public void SaveToServer()
        {
            try
            {
                MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbclient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>("accounts");
#pragma warning disable IDE0059 // Unnecessary assignment of a value
                var filter = Builders<BsonDocument>.Filter.Eq("username", username);
#pragma warning restore IDE0059 // Unnecessary assignment of a value
                if (!AccountExists(username))
                {
                    Properties.Resources.img_profile_default.Save("profile.bmp");
                    StreamReader objImageFile = new StreamReader("profile.bmp");
                    string profileImageData = objImageFile.ReadToEnd();
                    objImageFile.Close();
                    objImageFile.Dispose();
                    File.Delete("profile.bmp");
                    var document = new BsonDocument { { "username", Username },
                {"password", Password },
                {"account_type", AccountType.ToString() },
                {"reputation_points", new BsonInt32(ReputationPoints) },
                {"money", new BsonInt32(Money) },
                {"infraction_history", new BsonArray() },
                {"account_banned", new BsonBoolean(AccountBanned) },
                {"date_ban_expires", new BsonDateTime(DateBanExpires) },
                { "ban_reason", BanReason },
                {"is_admin", new BsonBoolean(IsAdmin) },
                {"private_messages", new BsonArray() },
                {"can_publish", new BsonBoolean(CanPublish) },
                {"can_chat", new BsonBoolean(CanChat) },
                {"account_creation_date", new BsonDateTime(AccountCreationDate) },
                {"last_login_date", new BsonDateTime(LastLoginDate) },
                {"birthday", new BsonDateTime(Birthday) },
                {"profile_bio", ProfileBio },
                {"email", Email },
                {"chat_strikes", ChatStrikes },
                {"publishing_strikes", PublishingStrikes },
                {"warnings", Warnings },
                {"notifications", new BsonArray() },
                {"notify_acieivement_received", NotifyAchievementReceived },
                {"notify_submission_featured", NotifySubmissionFeatured },
                {"notify_mentioned", NotifyMentioned },
                {"notify_submission_comment", NotifySubmissionComment },
                {"notify_submission_upvote", NotifySubmissionUpvote },
                {"notify_pm_received", NotifyPMReceived },
                {"receives_pms", ReceivesPMs },
                {"blocked_users", new BsonArray() },
                {"acknowledged_last_warning", true },
                {"last_warned_by_moderator_name", "" },
                {"date_last_warning_receieved", new DateTime(0) },
                {"last_warning_reason", LastWarningReason },
                        {"profile_image_data", profileImageData }
                    };
                    collection.InsertOne(document);
                }
                else
                {
                    Globals.UpdateValue("accounts", "username", Username, "username", Username);
                    Globals.UpdateValue("accounts", "username", Username, "password", Password);
                    Globals.UpdateValue("accounts", "username", Username, "account_type", AccountType.ToString());
                    Globals.UpdateValue("accounts", "username", Username, "reputation_points", new BsonInt32(ReputationPoints));
                    Globals.UpdateValue("accounts", "username", Username, "money", new BsonInt32(Money));
                    Globals.UpdateValue("accounts", "username", Username, "account_banned", new BsonBoolean(AccountBanned));
                    Globals.UpdateValue("accounts", "username", Username, "date_ban_expires", new BsonDateTime(dateBanExpires));
                    Globals.UpdateValue("accounts", "username", Username, "ban_reason", BanReason);
                    Globals.UpdateValue("accounts", "username", Username, "is_admin", new BsonBoolean(IsAdmin));
                    Globals.UpdateValue("accounts", "username", Username, "private_messages", PrivateMessages);
                    Globals.UpdateValue("accounts", "username", Username, "can_publish", new BsonBoolean(CanPublish));
                    Globals.UpdateValue("accounts", "username", Username, "can_chat", new BsonBoolean(CanChat));
                    Globals.UpdateValue("accounts", "username", Username, "last_login_date", new BsonDateTime(LastLoginDate));
                    Globals.UpdateValue("accounts", "username", Username, "profile_bio", ProfileBio);
                    Globals.UpdateValue("accounts", "username", Username, "birthday", new BsonDateTime(Birthday));
                    Globals.UpdateValue("accounts", "username", Username, "email", Email);
                    Globals.UpdateValue("accounts", "username", Username, "chat_strikes", ChatStrikes);
                    Globals.UpdateValue("accounts", "username", Username, "publishing_strikes", PublishingStrikes);
                    Globals.UpdateValue("accounts", "username", Username, "warnings", Warnings);
                    Globals.UpdateValue("accounts", "username", Username, "notifications", Notifications);
                    Globals.UpdateValue("accounts", "username", Username, "notify_achievement_received", NotifyAchievementReceived);
                    Globals.UpdateValue("accounts", "username", Username, "notify_submission_featured", NotifySubmissionFeatured);
                    Globals.UpdateValue("accounts", "username", Username, "notify_mentioned", NotifyMentioned);
                    Globals.UpdateValue("accounts", "username", Username, "notify_submission_comment", NotifySubmissionComment);
                    Globals.UpdateValue("accounts", "username", Username, "notify_submission_upvote", NotifySubmissionUpvote);                 
                    Globals.UpdateValue("accounts", "username", Username, "notify_pm_received", NotifyPMReceived);
                    Globals.UpdateValue("accounts", "username", Username, "receives_pms", ReceivesPMs);
                    Globals.UpdateValue("accounts", "username", Username, "blocked_users", BlockedUsers);
                    Globals.UpdateValue("accounts", "username", Username, "acknowledged_last_warning", AcknowledgedLastWarning);
                    Globals.UpdateValue("accounts", "username", Username, "last_warned_by_moderator_name", LastWarnedByModeratorName);
                    Globals.UpdateValue("accounts", "username", Username, "date_last_Warning_received", DateLastWarningReceived);
                    Globals.UpdateValue("accounts", "username", Username, "last_warning_reason", LastWarningReason);
                    ProfileImage.Save("profile.bmp");
                    StreamReader objImageFile = new StreamReader("profile.bmp");
                    string profileImageData = objImageFile.ReadToEnd();
                    objImageFile.Close();
                    objImageFile.Dispose();
                    File.Delete("profile.bmp");
                    Globals.UpdateValue("accounts", "username", Username, "profile_image_data", profileImageData);
                }
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

        /// <summary>
        /// Returns wether or not an account with the specified username exists.
        /// </summary>
        /// <param name="username">The username to look for.</param>
        /// <returns>True if the account exists, false otherwise.</returns>
        public static bool AccountExists(string username)
        {
            try
            {
                return Globals.InCollection("accounts", "username", username);
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
            return false;
        }

        /// <summary>
        /// Returns wether or not an account with the specified ID exists.
        /// </summary>
        /// <param name="id">The ID to look for.</param>
        /// <returns>True if the account exists, false otherwise.returns>
public static bool AccountExists(BsonObjectId id)
        {
            try
            {
                MongoClient dbclient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbclient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>("accounts");
                var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                return collection.Find(filter).CountDocuments() != 0;
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
            return false;
        }

        /// <summary>
        /// Gets a list of all accounts.
        /// </summary>
        /// <returns>A list of all accounts that exist on the server.</returns>
        public static List<Account> GetAccountList()
        {
            try
            {
                MongoClient dbClient = new MongoClient(Globals.CONNECTION_STRING);
                var database = dbClient.GetDatabase("acadiverse");
                var collection = database.GetCollection<BsonDocument>("accounts");
                var documents = collection.Find(new BsonDocument()).ToList();
                List<Account> accounts = new List<Account>();
                foreach (BsonDocument doc in documents)
                {
                    accounts.Add(LoadFromServer(doc.GetElement(1).Value.AsString));
                }
                return accounts;
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
            return new List<Account>();
        }

        /// <summary>
        /// Sends a PM from one Account to another.
        /// </summary>
        /// <param name="sender">The Account that sent the PM.</param>
        /// <param name="recipient">The Account that is supposed to receive the PM.</param>
        /// <param name="subject">The PM's subject.</param>
        /// <param name="message">The PM's contents.</param>
        public static void SendPM(Account sender, Account recipient, string subject, string message)
        {
            if (recipient.ReceivesPMs || UserRole.UserHasRole(sender, "moderators") || UserRole.UserHasRole(sender, "admins"))
            {
                if (!recipient.BlockedUsers.Contains(new BsonString(sender.username)) || UserRole.UserHasRole(sender, "moderators"))
                {
                    recipient.PrivateMessages.Add(new BsonDocument { { "sender", sender.Username },
                        {"receipient", recipient.Username },
                        {"subject", subject },
                        {"message", message },
                        {"date", DateTime.Now } });
                    recipient.SaveToServer();
                    sender.PrivateMessages.Add(new BsonDocument { { "sender", sender.Username },
                        {"receipient", recipient.Username },
                        {"subject", subject },
                        {"message", message },
                        {"date", DateTime.Now } });
                        sender.SaveToServer();
                    recipient.NotifyUser(AcadiverseNotificationType.PMReceived, Properties.Resources.str_notification_pm.Replace("$1", sender.Username));
                }
                else
                {
                    Globals.ShowErrorMessage(Properties.Resources.str_pm_user_blocked);
                }
            }
            else
            {
                Globals.ShowErrorMessage(Properties.Resources.str_pm_user_opted_out);
            }
        }

        /// <summary>
        /// Sends the current Account a notification.
        /// </summary>
        /// <param name="notificationType">The type of notification.</param>
        /// <param name="notificationText">The notification text.</param>
        public void NotifyUser(AcadiverseNotificationType notificationType, string notificationText)
        {
            switch (notificationType)
            {
                case AcadiverseNotificationType.AcheivementReceived:
                    if (!NotifyAchievementReceived)
                    {
                        return;
                    }
                    break;
                case AcadiverseNotificationType.Mentioned:
                    if (!NotifyMentioned)
                    {
                        return;
                    }
                    break;
                case AcadiverseNotificationType.PMReceived:
                    if (!NotifyPMReceived)
                    {
                        return;
                    }
                    break;
                case AcadiverseNotificationType.SubmissionComment:
                    if (!NotifySubmissionComment)
                    {
                        return;
                    }
                    break;
                case AcadiverseNotificationType.SubmissionFeatured:
                    if (!NotifySubmissionFeatured)
                    {
                        return;
                    }
                    break;
                case AcadiverseNotificationType.SubmissionUpvote:
                    if (!NotifySubmissionUpvote)
                    {
                        return;
                    }
                    break;
                default:
                    throw (new ArgumentException());
            }
            Notifications.Add(new BsonDocument { { "notification_text", notificationText },
                {"date", DateTime.Now } });
            SaveToServer();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Account);
        }

        public bool Equals(Account other)
        {
            return other != null &&
                   EqualityComparer<BsonObjectId>.Default.Equals(ID, other.ID) &&
                   Username == other.Username &&
                   Password == other.Password &&
                   AccountType == other.AccountType &&
                   ReputationPoints == other.ReputationPoints &&
                   Money == other.Money &&
                   AccountBanned == other.AccountBanned &&
                   DateBanExpires == other.DateBanExpires &&
                   BanReason == other.BanReason &&
                   PrivateMessages == other.PrivateMessages &&
                   CanPublish == other.CanPublish &&
                   CanChat == other.CanChat &&
                   AccountCreationDate == other.AccountCreationDate &&
                   LastLoginDate == other.LastLoginDate &&
                   Birthday == other.Birthday &&
                   ProfileBio == other.ProfileBio &&
                   Email == other.Email;
        }

        public override int GetHashCode()
        {
            var hashCode = -678888326;
            hashCode = hashCode * -1521134295 + EqualityComparer<BsonObjectId>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Username);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            hashCode = hashCode * -1521134295 + AccountType.GetHashCode();
            hashCode = hashCode * -1521134295 + ReputationPoints.GetHashCode();
            hashCode = hashCode * -1521134295 + Money.GetHashCode();
            hashCode = hashCode * -1521134295 + AccountBanned.GetHashCode();
            hashCode = hashCode * -1521134295 + DateBanExpires.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BanReason);
            hashCode = hashCode * -1521134295 + EqualityComparer<BsonArray>.Default.GetHashCode(PrivateMessages);
            hashCode = hashCode * -1521134295 + CanPublish.GetHashCode();
            hashCode = hashCode * -1521134295 + CanChat.GetHashCode();
            hashCode = hashCode * -1521134295 + AccountCreationDate.GetHashCode();
            hashCode = hashCode * -1521134295 + LastLoginDate.GetHashCode();
            hashCode = hashCode * -1521134295 + Birthday.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProfileBio);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            return hashCode;
        }
    }
}
