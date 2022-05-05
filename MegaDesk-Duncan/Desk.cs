using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Duncan
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    public class Desk
    {
        // Constants
        public const short MIN_DEPTH = 12;
        public const short MAX_DEPTH = 48;
        public const short MIN_WIDTH = 24;
        public const short MAX_WIDTH = 96;
        public const short MIN_NUM_DRAWERS = 2;
        public const short MAX_NUM_DRAWERS = 7;

        // Properties
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }
        public DesktopMaterial SurfaceMaterial { get; set; }
    }
}
