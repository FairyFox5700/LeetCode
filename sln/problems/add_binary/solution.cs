public class Solution {
    public string AddBinary(string a, string b) {
        //
        var carry = 0;
        string result= null;
        var diff = a.Length - b.Length;
        var list = Enumerable.Range('0', Math.Abs(diff));
        if(diff > 0)
        {
            b= b.PadLeft(a.Length, '0');
        }
        else
        {
            a= a.PadLeft(b.Length, '0');
        }
       
        for(int i = a.Count()-1; i>= 0; i-- )
        { 
            var first = a[i];
            var second = b[i];
            var sum = char.GetNumericValue(first) + char.GetNumericValue(second) + carry;
            Console.WriteLine(sum);
    
            result =(sum %2).ToString() + result; // for 0 = 0; for 1 = 1 and for 2 = 0
                    // 1+0 , 1+1 , 0+1 , 2+1
            carry = (int)sum / 2; // for everyting more then 2, it will be 1
        }
        if(carry != 0)
        {
            result = carry + result; 
        }
        return result;  
    }
}