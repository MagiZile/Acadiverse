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
    /// Represents a GUI skin.
    /// </summary>
    public class GUISkin
    {
        public Color background = SystemColors.Control;
        public Color foreground = SystemColors.ControlText;
        public FlatStyle buttonStyle = FlatStyle.Standard;
        public Font font = new Font("Arial", 12, FontStyle.Regular);


        public Color FormBackgroundColor
        {
            get
            {
                return background;
            }
            set
            {
                background = value;
            }
        }

        public Color FormTextColor
        {
            get
            {
                return foreground;
            }
            set
            {
                foreground = value;
            }
        }

        public FlatStyle ButtonFlatStyle
        {
            get
            {
                return buttonStyle;
            }
            set
            {
                buttonStyle = value;
            }
        }

        public Font FormFont
        {
            get
            {
                return font;
            }
            set
            {
                font = value;
            }
        }

        public static GUISkin LoadSkinFromWindow(Form window, FlatStyle buttonFlatStyle)
        {
            GUISkin skin = new GUISkin();
            skin.FormBackgroundColor = window.BackColor;
            skin.FormFont = window.Font;
            skin.FormTextColor = window.ForeColor;
            skin.ButtonFlatStyle = buttonFlatStyle;
            return skin;
        }

        /// <summary>
        /// Loads a style from a file.
        /// </summary>
        /// <param name="path">The file to load from.</param>
        public void LoadFromFile(string path)
        {
            XmlReader objFile = XmlReader.Create(path);
            objFile.Read();
            objFile.Read();
            objFile.Read();
            background = (Color)objFile.ReadContentAs(typeof(Color), null);
            objFile.Read();
            objFile.Read();
            foreground = (Color)objFile.ReadContentAs(typeof(Color), null);
            objFile.Read();
            objFile.Read();
            switch (objFile.ReadContentAsString())
            {
                case "Flat":
                    buttonStyle = FlatStyle.Flat;
                    break;
                case "Popup":
                    buttonStyle = FlatStyle.Popup;
                    break;
                case "Standard":
                    buttonStyle = FlatStyle.Standard;
                    break;
                case "System":
                    buttonStyle = FlatStyle.System;
                    break;
                default:
                    throw (new InvalidOperationException());
            }
            objFile.Read();
            objFile.Read();
            font = (Font)objFile.ReadContentAs(typeof(Font), null);
            objFile.Read();
            objFile.Read();
            objFile.Read();
            objFile.Close();
            objFile.Dispose();
        }
        
        /// <summary>
        /// Saves the current instance's properties to a file.
        /// </summary>
        /// <param name="path">The file to save to.</param>
        public void Save(string path)
        {
            XmlWriter objFile = XmlWriter.Create(path);
            objFile.WriteStartDocument();
            objFile.WriteStartElement("looknfeel");
            objFile.WriteElementString("backgroundColor", background.ToString());
            objFile.WriteElementString("textColor", foreground.ToString());
            objFile.WriteElementString("buttonStyle", buttonStyle.ToString());
            objFile.WriteElementString("font", font.ToString());
            objFile.WriteStartElement("icons");
            objFile.WriteEndElement();
            objFile.WriteEndElement();
            objFile.WriteEndDocument();
            objFile.Close();
            objFile.Dispose();
        }

        /// <summary>
        /// Gets all of the controls of the specified type from the specified control.
        /// </summary>
        /// <param name="ctl">The control to get the controls of.</param>
        /// <param name="type">The type of control.</param>
        /// <returns>All of the controls of the specified type.</returns>
        public static IEnumerable<Control> GetControlsOfType(Control ctl, Type type)
        {
            var controls = ctl.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetControlsOfType(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);

        }

        /// <summary>
        /// Styles all controls in the specified container, and any containers in it.
        /// </summary>
        /// <param name="ctl">The control to style.</param>
        /// <param name="font">The font of the control.</param>
        /// <param name="backColor">The background color of the control.</param>
        /// <param name="foreColor">The text color of the control.</param>
        public static void StyleContainer(Control ctl, Font font, Color backColor, Color foreColor)
        {
            foreach (Control c in ctl.Controls)
            {
                c.BackColor = backColor;
                c.ForeColor = foreColor;
                c.Font = font;
                if (c.HasChildren == true)
                {
                    StyleContainer(c, font, backColor, foreColor);
                }
            }
            ctl.BackColor = backColor;
            ctl.ForeColor = foreColor;
            ctl.Font = font;
        }

        /// <summary>
        /// Applies the current LookNFeel instance's properties to the specified window.
        /// </summary>
        /// <param name="window">The window to apply the styles to.</param>
        public void Apply(Form window)
        {
            window.BackColor = background;
            window.ForeColor = foreground;
            foreach (var btn in GetControlsOfType(window, typeof(Button)))
            {
                (btn as Button).FlatStyle = buttonStyle;
            }
            foreach (Control control in window.Controls)
            {
                StyleContainer(control, font, foreground, background);
            }
        }
    }
}
