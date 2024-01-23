public class Solution {
    public int Reverse(int x) {
        int answer = 0;
        while( x !=0)
        {
            int pop = x%10;
            x = x/10;
          
            
            if(answer > 0 && answer> int.MaxValue/10)
                return 0;
            if (answer > 0 && answer == int.MaxValue/10 && pop>7 )
                return 0;
            if(answer < 0 && answer < int.MinValue/10)
                return 0;
            if(answer < 0 && answer == int.MinValue/10 && pop < (-8))
                return 0;
            answer= answer*10 + pop;
            // Console.WriteLine(int.MaxValue); // 2147483647
            //Console.WriteLine(int.MaxValue/10); // 7
            //Console.WriteLine(int.MinValue); // -2147483648
            //Console.WriteLine(int.MinValue/10); // 87
            Console.WriteLine(answer);
        }

        return answer;
    }
}