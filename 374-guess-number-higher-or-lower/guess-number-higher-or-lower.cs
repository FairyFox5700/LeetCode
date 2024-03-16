/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        var left = 1;
        var right = n;
        while(left<=right)
        {
            var mid1 = left + (right - left) / 3;
            var mid2 = right - (right - left)/3;
            var number1 = guess(mid1);
            var number2 = guess(mid2);
            if(number1 == 0)
                return mid1;
            if(number2 == 0)
                return mid2;
            else if( number1 < 0)
                right = mid1 -1;
            else if(number2 >0)
                left = mid2+1;
            else
            {
                right = mid2 -1;
                left = mid1+1;
            }
        }

        return -1;
    }
}