using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarden
{
    public static class Numbers
    {
        private static int _size;
        private static int _x;
        private static int _y;
        private static bool _needSwap;
        private static Point[] Minus(int x, int y)
        {
            return [
                GetPoint(1,2.5),
                GetPoint(4,2.5)
                ];
        }
        public static Point[] GetDigit(int digit, int x, int y, bool needSwap, int sizeProc = 500)
        {
            _x = x;
            _y = y;

            _size = sizeProc;

            _needSwap = needSwap;


            if (digit == '-' - '0')
            {
                return Minus(x, y);
            }

            if (digit < 0 || digit > 9)
            {
                throw new InvalidDataException($"digits must be between 0 <--> 9 and '-'(characher Minus). You = '{(char)(digit + '0')}'");
            }

            Point[] result;

            switch (digit)
            {
                case (0):
                    result =  Zero();
                    break;

                case (1):
                    result = One();
                    break;

                case (2):
                    result = Two();
                    break;

                case (3):
                    result = Three();
                    break;

                case (4):
                    result = Four();
                    break;

                case (5):
                    result = Five();
                    break;

                case (6):
                    result = Six();
                    break;

                case (7):
                    result = Seven();
                    break;

                case (8):
                    result = Eight();
                    break;

                default:
                    result = Nine();
                    break;
    
            }


            return result;
        }
        private static Point GetPoint(double X, double Y)
        {
            if (_needSwap)
            {
                if (X > 2.5)
                {
                    (X, Y) = (Y, 5 - X);
                }
                else
                {
                    (X, Y) = (Y, 5 - X);
                }
            }

            int x = (int)(_x + X * _size / 100);
            int y = (int)(_y + Y * _size / 100);

            return new Point(x,y);
        }
        private static Point[] Zero()
        {
            return
                    [
                GetPoint(2,0),
                GetPoint(3,0),
                GetPoint(4,1),
                GetPoint(4,4),
                GetPoint(3,5),
                GetPoint(2,5),
                GetPoint(1,4),
                GetPoint(1,1),
                GetPoint(2,0)
                ];
        }
        private static Point[] One()
        {
            return
                [
                GetPoint(1,2),
                GetPoint(3,0),
                GetPoint(3,5)
                ];
        }
        private static Point[] Two()
        {
            return [
                 GetPoint(1,2),
                 GetPoint(1,1),
                 GetPoint(2,0),
                 GetPoint(3,0),
                 GetPoint(4,1),
                 GetPoint(4,2),
                 GetPoint(1,5),
                 GetPoint(4,5)
                ];
        }
        private static Point[] Three()
        {
            return [
                GetPoint( 1, 1),
                GetPoint( 2, 0),
                GetPoint( 4, 1),
                GetPoint( 2, 2.5),
                GetPoint( 4, 4),
                GetPoint( 2, 5),
                GetPoint( 1, 4)
            ];
        }
        private static Point[] Four()
        {
            return [
                GetPoint(  1, 0),
                GetPoint( 1, 2),
                GetPoint( 4, 2),
                GetPoint(  4, 0),
                GetPoint(  4, 5)
                ];
        }
        private static Point[] Five()
        {
            return [
                GetPoint( 4, 0),
                GetPoint( 1, 0),
                GetPoint( 1, 2),
                GetPoint( 3, 2),
                GetPoint( 4, 3),
                GetPoint( 4, 4),
                GetPoint(  3, 5),
                GetPoint( 1, 5)
                ];
        }
        private static Point[] Six()
        {
            return [
                GetPoint( 4, 1),
                GetPoint( 3, 0),
                GetPoint( 2, 0),
                GetPoint( 1, 1),
                GetPoint( 1, 4),
                GetPoint( 2, 5),
                GetPoint( 3, 5),
                GetPoint( 4, 4),
                GetPoint( 4, 3),
                GetPoint( 3, 2),
                GetPoint( 2, 2),
                GetPoint( 1, 3)
                ];
        }
        private static Point[] Seven()
        {
            return [
                GetPoint( 1, 0),
                GetPoint( 4, 0),
                GetPoint( 2.5, 2),
                GetPoint( 1.5, 2),
                GetPoint( 3.5, 2),
                GetPoint( 2.5, 2),
                GetPoint( 1, 5)
                ];
        }
        private static Point[] Eight()
        {
            return [
                GetPoint(  2, 0),
                GetPoint(  3, 0),
                GetPoint(  4, 1),
                GetPoint(  4, 2),
                GetPoint(  1, 3),
                GetPoint(  1, 4),
                GetPoint(  2, 5),
                GetPoint(  3, 5),
                GetPoint( 4, 4),
                GetPoint(  4, 3),
                GetPoint(  1, 2),
                GetPoint(  1, 1),
                GetPoint(  2, 0)
                ];
        }
        private static Point[] Nine()
        {
            return [
                GetPoint( 4, 2),
                GetPoint(  3, 3),
                GetPoint(  2, 3),
                GetPoint(  1, 2),
                GetPoint(  1, 1),
                GetPoint( 2, 0),
                GetPoint(  3, 0),
                GetPoint(  4, 1),
                GetPoint( 4, 4),
                GetPoint(  3, 5),
                GetPoint(  2, 5),
                GetPoint(  1, 4),
                GetPoint(  1, 3.5)
            ];
        }
    }
}
