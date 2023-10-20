using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static int[] GetNextCoordinates()
        {
            // создать копию координат головы (новый массив с такими же координатами)

            // в зависимости от направления добавить или отнять 10 от соответствующей
            // координаты (например при direction 1, надо отнять 10 от Y, при direction 2 надо добавить 10 к Х)

            // Переключить controlBlock в false - чтобы можно было поменять направление
            // вернуть получившийся массив
            int[] coordinates = new int[2] { snake[0][0], snake[0][1] };

            if (direction==1)
            {
                coordinates[1] = coordinates[1]-10;
                if (coordinates[1] < 20)
                    coordinates[1] = 260;
            }
            if (direction == 2)
            {
                coordinates[0] = coordinates[0] + 10;
                if (coordinates[0] > 260)
                    coordinates[0] = 20;
            }
            if (direction == 3)
            {
                coordinates[1] = coordinates[1] + 10;
                if (coordinates[1] > 260)
                    coordinates[1] = 20;
            }
            if (direction == 4)
            {
                coordinates[0] = coordinates[0] - 10;
                if (coordinates[0] < 20)
                    coordinates[0] = 260;
            }

            controlBlock = false;
            return coordinates;

        }
    }
}
