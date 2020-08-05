using MagiZile.Acadiverse;
using MagiZile.Acadiverse.Properties;
using MagiZile.UserInteractions.ParentalControls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcadiverseDesktop
{
    public partial class FrmAcadiverseDesktopClient : Form
    {
        bool accountDeleted = false;
        bool passwordChanged = false;
        public Account currentAccount;
        public AccountWatcher objAccountWatcher;

        public FrmAcadiverseDesktopClient()
        {
            InitializeComponent();
        }
        
    }
}