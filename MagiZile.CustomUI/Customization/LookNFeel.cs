using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MagiZile.CustomUI.Customization
{
    /// <summary>
    /// Represents a look n' feel style.
    /// </summary>
    public class LookNFeel
    {
        public IconSet icons = null;
        public GUISkin skin = null;

        public IconSet Icons
        {
            get
            {
                return icons;
            }
            set
            {
                icons = value;
            }
        }


        public IconSet IconSet
        {
            get
            {
                return icons;
            }

            set
            {
            }
        }

        public LookNFeel(Form window, FlatStyle buttonFlatStyle)
        {
            skin = GUISkin.LoadSkinFromWindow(window, buttonFlatStyle);
            icons = new IconSet(window);
        }

        public void Apply(Form window)
        {
            icons.Apply();
            skin.Apply(window);
        }

        public void Save(string path, string name)
        {
            Directory.CreateDirectory(path + @"\" + name);
            skin.Save(path + @"\" + name + @"\skin.gskin");
            XmlWriter objFile = XmlWriter.Create(path + @"\" + name + @"\icons.iconset");
            for (int i = 0; i < icons.IconCount(); i++)
            {
                objFile.WriteStartElement("icon");
                icons.GetIcon(i).Save("TEMP.tmp");
                StreamReader objTempFile = new StreamReader("TEMP.tmp");
                objFile.WriteElementString("data", objTempFile.ReadToEnd());
                objTempFile.Close();
                objTempFile.Dispose();
                File.Delete("TEMP.tmp");
                objFile.WriteEndElement();
            }
        }

        public void LoadFromFile(string path, string name)
        {
            skin.LoadFromFile(path + @"\" + name + @"\skin.gskin");
        }
    }
}