using DnsClient.Protocol;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MagiZile.Acadiverse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class UpdatesAvailableWindow : Window
    {
        public UpdatesAvailableWindow()
        {
            InitializeComponent();
        }

        public string changeLog;
        public string applicationName;

        private void UpdatesAvailableWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            lblUpdatesAvailable.Content = "Updates for " + applicationName + " are available.";
            
        }

        private void btnRemindMeLater_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnInstallUpdates_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("http://acadiverse.magizile.com/download");
        }
    }
}
