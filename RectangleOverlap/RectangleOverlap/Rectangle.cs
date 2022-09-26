using System.Collections.Generic;

namespace RectangleOverlap
{
    public class Rectangle
    {
        public static bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            var rec2X1 = rec2[0];
            var rec2X2 = rec2[2];

            var rec1X1 = rec1[0];
            var rec1X2 = rec1[2];

            var rec2Y1 = rec2[1];
            var rec2Y2 = rec2[3];

            var rec1Y1 = rec1[1];
            var rec1Y2 = rec1[3];

            if(rec2X1 < rec1X1 && rec1X1 < rec2X2 && rec2Y1 < rec1Y1 && rec1Y1 < rec2Y2)
                return true;

            if (rec1X1 < rec2X1 && rec2X1 < rec1X2 && rec1Y1 < rec2Y1 && rec2Y1 < rec1Y2)
                return true;

            if (rec2X1 < rec1X1 && rec1X1 < rec2X2 && rec1Y1 < rec2Y2 && rec2Y2 < rec1Y2)
                return true;

            if (rec1X1 < rec2X1 && rec2X1 < rec1X2 && rec2Y1 < rec1Y2 && rec1Y2 < rec2Y2)
                return true;


            return false;
        }
    }
}
