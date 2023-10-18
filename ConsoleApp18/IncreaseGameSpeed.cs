using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void IncreaseGameSpeed()
        {
            // уменьшить speed на 10
            // добавить проверку, чтобы значение speed не опускалось ниже 10
            speed -= 10;
            if (speed < 10)
                speed = 10;
        }
    }
}
