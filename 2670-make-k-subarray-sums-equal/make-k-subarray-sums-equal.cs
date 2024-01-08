    public class Solution
    {
        /*They all need to be equal.
         * Visually we see the easiest way to make them equal is to turn the 2 into 1.
         * However, programitically to make a list of numbers equal it is best to move them all to the "median". 
         * The "median" of "1,2,1" is "1". Median can be programmatically found by sorting and taking the middle element:*/
        public long MakeSubKSumEqual(int[] arr, int k)
        {
            // repeating patter will e gdp ( len(arr), k))
            var result = 0L;
            var g = GCP(arr.Length, k);
            var currentSlice = new List<int>();
            // 1 4 1 3
            for(int i =0; i<g; i++)
            {
                for(int j =i; j< arr.Length; j+=g)
                {
                    currentSlice.Add(arr[j]);
                }
      
            var median = Median(currentSlice);
          
            for(int d = 0;d< currentSlice.Count();d++)
            {
                result += Math.Abs(median - currentSlice[d]);
            }
            currentSlice.Clear();
            }
  
            return result;
        }

        private int Median(List<int> slice)
        {
            slice = slice.OrderBy(e=>e).ToList();
            var midIndex = slice.Count() / 2;
             return slice[midIndex];
        }
        // greatest commmon product
        private int GCP(int first, int second)
        {
            while(first!=0 && second!=0)
            {
                if(first>second)
                {
                    first%=second;
                }
                else
                {
                    second%=first;
                }
            }

            return first | second; // if one of them is 0, or opertaion returns non zerovalue 
        }
    }