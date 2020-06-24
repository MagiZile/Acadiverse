using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.CustomUI
{
    public partial class GridControl : UserControl
    {
        public GridControl()
        {
            InitializeComponent();
        }

        void ChangeTableDimensions()
        {
            tlpLayout.ColumnCount = grid.Width / Convert.ToInt32(grid.ItemSize);
            tlpLayout.RowCount = grid.Height / Convert.ToInt32(grid.ItemSize);
            tlpLayout.RowStyles.Add(new RowStyle(SizeType.Percent, grid.ItemSize));
            tlpLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, grid.ItemSize));
            tlpLayout.Controls.Clear();
            for (int r = 0; r < grid.Width; r++)
            {
                for (int c = 0; c < grid.Height; c++)
                {
                    PictureBox objPictureBox = new PictureBox();
                    objPictureBox.Name = "pic" + r + c;
                    objPictureBox.BackgroundImage = images.Images[grid.GetItem(r, c)];
                    tlpLayout.Controls.Add(objPictureBox, r, c);
                }
            }
        }

        public GridControlItemMap grid = new GridControlItemMap(1280, 960, 64);
        public ImageList images = new ImageList();
        /*
public ImageList Images
{
   get
   {
       return images;
   }
   set
   {
       images = value;
   }
}

public float ItemSize
{
   get
   {
       return grid.ItemSize;
   }
   set
   {
       grid.ItemSize = value;
       ChangeTableDimensions();
   }
}

public int GridWidth
{
   get
   {
       return grid.Width;
   }
   set
   {
       grid.Width = value;
       ChangeTableDimensions();
   }
}

public int GridHeight
{
   get
   {
       return grid.Height;
   }
   set
   {
       grid.Height = value;
       ChangeTableDimensions();
   }
}

public void SetItemImage(int index, int r, int c)
{
   grid.SetItem(index, r, c);
   foreach (Control ctl in tlpLayout.Controls)
   {
       if (ctl.GetType() == typeof(PictureBox) && ctl.Name == "pic" + r + c)
       {
           ctl.BackgroundImage = images.Images[index];
       }
   }
}
*/
    }
}
