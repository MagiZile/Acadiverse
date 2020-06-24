using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.Acadiverse
{
    public class Avatar
    {
        readonly int[] appearance = new int[10];

        public int GetHat()
        {
            return appearance[0];
        }

        public int GetHairStyle()
        {
            return appearance[1];
        }
        
        public int GetHairColor()
        {
            return appearance[2];
        }

        public int GetEyeColor()
        {
            return appearance[3];
        }

        public int GetFacialHairStyle()
        {
            return appearance[4];
        }

        public int GetFacialHairColor()
        {
            return appearance[5];
        }

        public int GetSkinColor()
        {
            return appearance[6];
        }

        public int GetShirt()
        {
            return appearance[7];
        }

        public int GetPants()
        {
            return appearance[8];
        }

        public int GetShoes()
        {
            return appearance[9];
        }
    }
}
