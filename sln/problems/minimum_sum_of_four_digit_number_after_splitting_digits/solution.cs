public class Solution {
   	public int MinimumSum(int num) {
        var res = new int[4];
        int i = 0;
        while (num > 0) {
            res[i++] = num%10;
            num = num/10;
        }
        Array.Sort(res);
        return res[0]*10 + res[1]*10 + res[2] + res[3];
    }
}