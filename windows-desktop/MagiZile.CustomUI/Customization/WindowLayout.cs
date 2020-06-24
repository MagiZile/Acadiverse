using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MagiZile.CustomUI.Customization
{
    public class WindowLayout
    {
        readonly Dictionary<string, bool> visibleDialogs = new Dictionary<string, bool>();

        public WindowLayout(Dictionary<string, bool> dialogVisibilityDefaults, Form window)
        {

            visibleDialogs = dialogVisibilityDefaults;
            for (int i = 0; i < visibleDialogs.Count; i++)
            {
                if (window.OwnedForms[i].Name == visibleDialogs.Keys.ToList<string>()[i])
                {
                    window.OwnedForms[i].Visible = visibleDialogs.Values.ToList<bool>()[i];
                }
            }
        }

        public static WindowLayout Load(string path, Form window)
        {
            Dictionary<string, bool> visibleWindows = new Dictionary<string, bool>();
            XmlReader objFile = XmlReader.Create(path);
            objFile.Read();
            objFile.Read();
            int dialogCount = objFile.ReadContentAsInt();
            for (int i = 0; i <= dialogCount; i++)
            {
                objFile.Read();
                visibleWindows.Add(objFile.ReadContentAsString(), objFile.ReadContentAsBoolean());
                objFile.Read();
            }
            objFile.Read();
            objFile.Close();
            objFile.Dispose();
            return new WindowLayout(visibleWindows, window);
        }

        public void Save(string path)
        {
            XmlWriter objFile = XmlWriter.Create(path);
            objFile.WriteStartDocument();
            objFile.WriteStartElement("layout");
            objFile.WriteElementString("dialogCount", visibleDialogs.Count.ToString());
            for (int i = 0; i < visibleDialogs.Count; i++)
            {
                objFile.WriteStartElement("dialog");
                objFile.WriteElementString("name", visibleDialogs.Keys.ToList<string>()[i]);
                objFile.WriteElementString("visible", visibleDialogs.Values.ToList<bool>()[i].ToString());
                objFile.WriteEndElement();
            }
            objFile.WriteEndElement();
            objFile.WriteEndDocument();
            objFile.Close();
            objFile.Dispose();
        }
    }
}