using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void ChangeHeadCoordinateEnemy(int[] xy)
        {
            snake2[0] = new int[] { xy[0], xy[1] };
        }
    }
}
