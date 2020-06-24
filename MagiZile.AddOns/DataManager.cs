using MagiZile.CustomUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.AddOns
{
    public static class DataManager
    {
        public static TabbedDocuments.Tab GetActveTab(TabbedDocuments tabbedDocumentsControl)
        {
            TabbedDocuments.Tab objActiveTab = tabbedDocumentsControl.GetActiveDocument();
            return objActiveTab;
        }

        public static void SaveActiveTab(TabbedDocuments tabbedDocumentsControl)
        {
            GetActveTab(tabbedDocumentsControl).Save(tabbedDocumentsControl);
        }
    }
}
