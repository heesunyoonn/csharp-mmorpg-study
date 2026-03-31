using System;
using System.Collections.Generic;
using System.Text;

namespace Course02_DataStructureAndAlgorithm
{
    /*
     * ROLE: [길찾기] 좌표 구조체
     */
    public struct Point
    {
        public int Y { get; }
        public int X { get; }

        public Point(int y, int x)
        {
            Y = y;
            X = x;
        }
    }
}
