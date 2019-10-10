using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Goodwin
{
    class Desk
    {
        

        public double DeskWidth { get; set; }
        public double DeskDepth { get; set; }
        public int NumOfDrawers { get; set; }
        public SurfaceMaterial Material { get; set; }




        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MAXDRAWERS = 7;

        

    }
    public enum SurfaceMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }

}
