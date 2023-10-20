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
        private static void DrawHeadEnemy()
        {
            graphics.FillEllipse(System.Drawing.Brushes.LightPink, snake2[0][0], snake2[0][1], 10, 10);
        }
    }
}
