/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n)
    {
        int left = 0;
        int right = n;

        while(left<right)
        {
            var mid = left + (right -left)/2;
            Console.WriteLine(mid);
            var result = base.IsBadVersion(mid);
            if(result == true)
            {
             // can be somewhere elrier
                right = mid;
            }
            else
            {
                left = mid+1;
            }
        }

        return right;
        
    }
}