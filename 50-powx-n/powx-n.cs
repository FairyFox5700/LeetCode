public class Solution {
    public double MyPow(double x, int n) {
        if(n==0)
            return 1D;
        if(n<0)
        {
            x = 1/x;
            long nlong = (-1) * n;
            return MyPowHelper(x, nlong);
        }
        return MyPowHelper(x, n);
        
        // n is off , 5 = 2 * (2^2)(n-1/2)

        //n id even
        // 4 =  2^2^2 = 2^2^(n/2)
        // 2^5 =
        // 2^2 = 4
        // 2^1 = 1
        // 2^100 = 2^50 * 2+2
        // 2^50 = 4^2 * 2^25
        // 2^25 = 4^2 *  2 * 2^12
        
    }
     public double MyPowHelper(double x, long n) 
     {

         if(n==0)
            return 1;
        
        var half = MyPowHelper(x, n/2);

        if(n%2==0)
        {
            return half* half;
        }

        return half * half * x;
     }
    

}