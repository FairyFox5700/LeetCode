    public class Solution
    {
     
        public string Multiply(string num1, string num2)
        {
            if(num1 == "0" || num2 == "0")
                return "0";
            var val = num1.Length + num2.Length;
            var arr = new int[val];
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                for(int j = num2.Length -1; j>=0; j--)
                {
                    int digit = (num1[i] -'0') * (num2[j]-'0');
                  
                    var value = digit + arr[i + j+1];
                    var overflow = value / 10;
                    var rest = value % 10;
                    arr[i+j+1] = rest;
                    arr[i + j] += overflow;
                }
            }

            return string.Join("" ,arr[0]!= 0 ?arr : arr.Skip(1));
        }
    }