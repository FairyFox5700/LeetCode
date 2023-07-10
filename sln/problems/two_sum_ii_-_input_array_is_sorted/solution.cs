public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var leftIndex = 0;
        var rightIndex = numbers.Length -1;
        var arr = new int[2];
        while (leftIndex < rightIndex)
        {
            // 1 3 5 6 7 [10 11]
            // if we some 3 + 7 = 10 we dont need to check 
           var currentsum = numbers[leftIndex] + numbers[rightIndex];
            if( currentsum == target)
           {
               arr[0] = leftIndex+1;
               arr[1] = rightIndex+1;
               break;
           }
           else if(currentsum > target)
           {
               rightIndex--;
           }
           else
           {
                leftIndex++;
           }
        }
        return arr;
    }
}