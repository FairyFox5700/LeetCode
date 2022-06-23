public class Solution {
  public int MaxArea(int[] height) {
        var length = height.Count();
        int start= 0;
        int end = length -1;
        int totalArea =0;
        while(start< end){
            int area = Math.Min(height[start],height[end]) * (end- start);
            totalArea = Math.Max(area, totalArea);
            
            if(height[start]> height[end]){
                end--;
            }
            else
            {
                start++;
            }
        }
      return totalArea;
    }
}