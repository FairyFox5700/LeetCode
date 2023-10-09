    public class Solution
    {

        // temperatures = [73,74,75,71,69,72,76,73]
        public int[] DailyTemperatures(int[] temperatures)
        {
            var monoStack = new Stack<int>();
            var answer = new int[temperatures.Length];
            for (int i = 0; i < temperatures.Length; i++)
            {
                while (monoStack.Count > 0 && temperatures[i] > temperatures[monoStack.Peek()])
                {
                    var pop = monoStack.Pop();
                    answer[pop] = i - pop;
                }
                monoStack.Push(i);
            }

            return answer;
    }
    }