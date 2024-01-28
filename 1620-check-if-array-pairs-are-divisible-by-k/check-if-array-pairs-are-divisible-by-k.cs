public class Solution {
    public bool CanArrange(int[] arr, int k) {
        // a mod k = x
        // b mod k = k -x --- then we can for a pair with a and b, as k -x +x = k
        var freq = new int[k];
        for(int i = 0; i< arr.Count(); i++)
        {
            var el = arr[i] % k;
            if(el < 0)
            {
                el+=k;
            }
            freq[el]++;
        }

        // all elements that are deivisible by k equally are stored in freq[0]
        // to form a pairs , it should be even count of elements
        if(freq[0]%2 !=0)
            return false;
        // now we have an array of all possible frequencies combinations
        // meaning we calculated x in formula
        for(int i = 1; i<=freq.Count()/2; i++)
        {
            // i = 1, need to look for 4 ( 5-1)
            if(freq[i] != freq[k-i])
                return false;
        }
        // [1,2,3,4,5,10,6,7,8,9], k= 5
        // 0 --> 2 ( 5 and 10 )
        // 1 --> 2 ( 1 and 6 )
        // 2 --> 2 ( 2 and 7 )
        // 3 --> 2 ( 3 and 8 )
        // 4 --> 2 ( 4 and 9 )
        return true;
    }
}