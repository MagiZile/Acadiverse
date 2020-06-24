using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.CustomUI
{
    public class GridControlItemMap
    {
        int[,] LayoutContents = new int[0, 0];
        float itemSize = 64;

        public GridControlItemMap(int width, int height, float itemSize)
        {
            
            LayoutContents = new int[width * Convert.ToInt32(itemSize), height * Convert.ToInt32(itemSize)];
        }

        public GridControlItemMap()
        {
            LayoutContents = new int[1280, 960];
        }

        public float ItemSize
        {
            get
            {
                return itemSize;
            }
            set
            {
                itemSize = value;
            }
        }

        public int Width
        {
            get
            {
                return LayoutContents.GetLength(0);
            }
            set
            {
                resizeLayoutArray(value, LayoutContents.GetLength(1));
            }
        }

        public int Height
        {
            get
            {
                return LayoutContents.GetLength(1);
            }
            set
            {
                resizeLayoutArray(LayoutContents.GetLength(0), value);
            }
        }

        public int GetItem(int r, int c)
        {
            return LayoutContents[r, c];
        }

        public void SetItem(int value, int r, int c)
        {
            LayoutContents[r, c] = value;
        }

        void resizeLayoutArray(int widthChange, int heightChange)
        {
            int[,] newLayoutArray = new int[LayoutContents.GetLength(0) + widthChange, LayoutContents.GetLength(1) + heightChange];
            for (int r = 0; r < LayoutContents.GetLength(0); r++)
            {
                for (int c = 0; c < LayoutContents.GetLength(1); c++)
                {
                    if (r < newLayoutArray.GetLength(0) && c < newLayoutArray.GetLength(1))
                    {
                        newLayoutArray[r, c] = LayoutContents[r, c];
                    }
                }
            }
            LayoutContents = newLayoutArray;
        }
    }
}
