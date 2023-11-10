using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.OOPSnake
{
    public class Scores
    {
        int _amount = 0;
        public int Amount
        {
            get
            {
                return _amount;
            }
        }

        public void Increase()
        {
            _amount++;
        }
    }
}
