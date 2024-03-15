    public class Solution
    {
        public class Job
        {
            public int StartTime { get; set; }
            public int EndTime { get; set; }
            public int Profit { get; set; }
        }


        private int GetNextJob(List<Job> orderedJob, int endTime, int left, int right)
        {
            int nextJobIndex = -1;
            while (left <= right)
            {
                var mid = (left + right) / 2;
                var job = orderedJob[mid];
                if (job.StartTime >= endTime)
                {
                    nextJobIndex = mid;
                    right = mid - 1;
                }
                else
                {
                   left = mid + 1;
                }
            }

            Console.WriteLine(nextJobIndex);
            return nextJobIndex;
        }


        private int[] memo;
        public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
        {
            memo = new int [profit.Length+1];
            Array.Fill(memo, 0);
            var jobs = new List<Job>();
            for (int i = 0; i < startTime.Length; i++)
            {
                jobs.Add(new Job
                {
                    StartTime = startTime[i],
                    EndTime = endTime[i],
                    Profit = profit[i]
                });
            }

            jobs = jobs.OrderBy(x => x.StartTime).ToList();

            // for each job we are calculating the max profit
            // of scheduling it, or skiping it
            return JobsMaxProfit(jobs);
        }

        //bottomUp
        private int JobsMaxProfit(List<Job> jobs)
        {

        for (int i = jobs.Count - 1; i >= 0; i--)
    {
        int profitWithCurrentJob = jobs[i].Profit;
        int nextJobIndex = GetNextJob(jobs, jobs[i].EndTime, i + 1, jobs.Count - 1);
        if (nextJobIndex != -1) {
            profitWithCurrentJob += memo[nextJobIndex]; // Add profit from scheduling the next non-conflicting job
        }
        
        memo[i] = Math.Max(memo[i + 1], profitWithCurrentJob); // Max profit of skipping or taking the current job
        
        // Debugging output, can be removed in production
        Console.WriteLine("Job Index: " + i + ", Profit: " + memo[i]);
    }

            return memo[0];
        }
    }