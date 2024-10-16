public class Solution
{
    public long MinimumSteps(string s)
    {
        var end = s.Length - 1;
        var currentRight = s[end];
        while (currentRight == '1' && end >0)
        {
            end--;
            currentRight = s[end];
        }
        ///currentRight point to the last 1

        var start = end > 0 ? end : 0;
        var currentLeft = s[start];
        var stepsCount = 0L;
        var countOfZeros = 0L;
        var oneEncountered = false;
        while (start>=0)
        {
            if(currentLeft== '0')
            {
        
                countOfZeros++;

            }
            else
            {
                stepsCount+= countOfZeros;
                oneEncountered = true;
               
            }
             start--;
            currentLeft = start>=0? s[start]: currentLeft;
        }

        return stepsCount;  
    }
}