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
            memo = new int [profit.Length];
            Array.Fill(memo, -1);
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
            return JobsMaxProfit(jobs, 0);
        }

        private int JobsMaxProfit(List<Job> jobs, int jobIndex)
        {
            if (jobIndex == -1 || jobIndex >= jobs.Count)
            {
                return 0;
            }

            if (memo[jobIndex] != -1)
            {
                return memo[jobIndex];
            }

            var endTimeOfJob = jobs[jobIndex].EndTime;
            var nextJob = GetNextJob(jobs, endTimeOfJob, jobIndex+1, jobs.Count-1);
            // take or not to take
            memo[jobIndex] = Math.Max(0 + JobsMaxProfit(jobs, jobIndex + 1),
                jobs[jobIndex].Profit + JobsMaxProfit(jobs, nextJob));

            Console.WriteLine("jIn:" + jobIndex + " profit:" + memo[jobIndex]);

            return memo[jobIndex];
        }
    }