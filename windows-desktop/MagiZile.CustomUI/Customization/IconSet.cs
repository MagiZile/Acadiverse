using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.CustomUI.Customization
{
    public class IconSet
    {
        int index = 0;
        List<Image> icons = new List<Image>();
        public Form window = null;

        public IconSet(Window window)
        {
            this.window = window;
            GetIconsFromForm(window);
        }

        public Image GetIcon(int itemindex)
        {
            return icons[itemindex];
        }

        public int IconCount()
        {
            return icons.Count;
        }

        public void AddIcon(Image image)
        {
            icons.Add(image);
        }

        public void RemoveIcon(Image image)
        {
            icons.Remove(image);
        }

        public void Apply()
        {
            foreach (Control ctl in window.Controls)
            {
                if (ctl.GetType() == typeof(MenuStrip))
                {
                    ChangeIcons((MenuStrip)ctl);
                }
            }
        }

        /// <summary>
        /// Changes the icons of the selected MenuStrip, used in the Apply method.
        /// </summary>
        /// <param name="menu"></param>
        void ChangeIcons(MenuStrip menu)
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                ChangeMenuIcons(item);
            }
            index = 0;
        }

        /// <summary>
        /// Recursive method for changing the icon images of a menu item and all of its sub-items.
        /// </summary>
        /// <param name="item">The menu item to change the icons of.</param>
        void ChangeMenuIcons(ToolStripMenuItem item)
        {
            index++;
            item.Image = icons[index];
            foreach (ToolStripMenuItem subitem in item.DropDownItems)
            {
                ChangeMenuIcons(subitem);
            }
        }

        void GetIconsFromForm(Form form)
        {
            foreach (Control ctl in window.Controls)
            {
                if (ctl.GetType() == typeof(MenuStrip))
                {
                    GetIconsFromMenu((MenuStrip)ctl);
                }
            }
        }

        void GetIconsFromMenu(MenuStrip menu)
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                GetIcons(item);
            }
        }

        void GetIcons(ToolStripMenuItem item)
        {
            icons.Add(item.Image);
            foreach (ToolStripMenuItem subitem in item.DropDownItems)
            {
                GetIcons(subitem);
            }
        }
    }
}
