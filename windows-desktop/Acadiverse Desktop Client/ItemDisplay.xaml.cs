using MagiZile.Acadiverse;
using System;
using System.Collections.Generic;
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

namespace Acadiverse_Desktop_Client
{
    /// <summary>
    /// Interaction logic for StoreItemDisplay.xaml
    /// </summary>
    public partial class StoreItemDisplay : UserControl
    {
        public StoreItemDisplay()
        {
            InitializeComponent();
        }

        Submission item = new Submission("Item Name");

        public event EventHandler<ProfileNameClickedEventArgs> OnCreatorNameClicked;

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            OnCreatorNameClicked?.Invoke(this, new ProfileNameClickedEventArgs(item.Author));
        }
    }
}
