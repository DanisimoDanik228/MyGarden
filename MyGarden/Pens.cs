using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarden
{
    internal static class Pens
    {
        public static Pen main_garden = new Pen(Brushes.Brown, 4);
        public static Pen number = new Pen(Brushes.Black, 2);
        public static Pen line_for_number = new Pen(Brushes.Black, 2);
        public static Pen line_for_rect = new Pen(Brushes.Brown, 1);
        public static Pen select_Rects = new Pen(Brushes.LightGreen,1);
    }
}
