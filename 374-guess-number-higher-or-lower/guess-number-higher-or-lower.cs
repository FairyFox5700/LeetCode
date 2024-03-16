public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int left = 1;
        int right = n;
        while (left <= right) {
            int mid1 = left + (right - left) / 3;
            int mid2 = right - (right - left) / 3;
            int res1 = guess(mid1);
            int res2 = guess(mid2);
            
            if (res1 == 0) return mid1;
            if (res2 == 0) return mid2;
            
            if (res1 < 0) {
                right = mid1 - 1; // The target is less than mid1
            } else if (res2 > 0) {
                left = mid2 + 1; // The target is greater than mid2
            } else {
                left = mid1 + 1; // The target is between mid1 and mid2
                right = mid2 - 1;
            }
        }
        return -1; // This should theoretically never be reached if the API behaves as expected
    }
}
