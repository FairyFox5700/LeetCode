    public class Solution
    {
        public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
        {
            var width = Math.Min(ax2, bx2) - Math.Max(ax1, bx1); // end of the first or senond - begining of the first or second
            var heigh = Math.Min(ay2, by2) - Math.Max(ay1, by1);
            var areaA = (ax2 - ax1) * (ay2 - ay1);
            var areaB = (by2 - by1) * (bx2 - bx1);
            if(width > 0 && heigh > 0)
            {
            var area = width * heigh;
          

         
            return areaA + areaB - area;
            }
            return areaA + areaB;
        }
    }