using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.Acadiverse
{
    public partial class ChatDisplay : UserControl
    {
        public ChatDisplay()
        {
            InitializeComponent();
        }

        public Account currentAccount;
        public Chat currentChat;

        private void ChatDisplay_Load(object sender, EventArgs e)
        {
            lblChatName.Text = currentChat.Name;
            rtbChatDescription.Text = currentChat.Description;
        }

        private void ChatDisplay_Click(object sender, EventArgs e)
        {
            new FrmChat
            {
                currentAccount = currentAccount,
                currentChat = currentChat
            }.Show();
        }
    }
}
