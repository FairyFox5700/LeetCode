    public class Solution
    {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            var ax1 = rec1[0];
            var ay1 = rec1[1];
            var ax2 = rec1[2];
            var ay2 = rec1[3];

            var bx1 = rec2[0];
            var by1 = rec2[1];
            var bx2 = rec2[2];
            var by2 = rec2[3];
            var width = Math.Min(ax2, bx2) - Math.Max(ax1, bx1); // end of the first or senond - begining of the first or second
            var heigh = Math.Min(ay2, by2) - Math.Max(ay1, by1);
            if (width > 0 && heigh >0)
            {
                return true;
            }
            return false;
        }
    }