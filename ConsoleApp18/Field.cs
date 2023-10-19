using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void Field()
        {
            Pen pen = new Pen(Brushes.AliceBlue, 1);
            graphics.DrawRectangle(pen, 20, 20, 250, 250);
        }
    }
}
