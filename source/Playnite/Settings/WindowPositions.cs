using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playnite
{
    public class WindowPosition
    {
        public class Point
        {
            public double X
            {
                get; set;
            }

            public double Y
            {
                get; set;
            }
        }

        public Point Position
        {
            get; set;
        }

        public Point Size
        {
            get; set;
        }

        public System.Windows.WindowState State
        {
            get; set;
        } = System.Windows.WindowState.Normal;
    }

    public class WindowPositions
    {
        public Dictionary<string, WindowPosition> Positions
        {
            get; set;
        } = new Dictionary<string, WindowPosition>();

        public WindowPositions()
        {
            WindowPosition defaultP = new WindowPosition();
            /* WindowPosition.Point position = new WindowPosition.Point();
            position.X = 0;
            position.Y = 0;
            WindowPosition.Point Size = new WindowPosition.Point();
            Size.X = 1280; // hardcoded
            Size.Y = 800; // hardcoded
            defaultP.Position = position;
            defaultP.Size = Size; */
            defaultP.State = System.Windows.WindowState.Maximized;
            Positions["Main"] = defaultP;
        }
    }
}
