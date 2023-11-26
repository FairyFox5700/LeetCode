    public class Solution
    {
        public int MinimumOperations(int[] nums)
        {
            var queue = new PriorityQueue<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    queue.Enqueue(nums[i], nums[i]);
            }

            // nums = [,5,3,5]
            // min queue
            if (queue.Count == 1)
                return 1;

            var operations = 0;
            while (queue.Count > 0)
            {
                var el = queue.Dequeue(); // take the min
                var currentCount = queue.Count;
                var newNumbers = new List<int>();
                while (currentCount > 0)
                {
                    var secondEl = queue.Dequeue(); // take the second min
                    var diff = secondEl - el;
                    Console.WriteLine(secondEl);
                    if (diff > 0)
                    {
                        newNumbers.Add(diff);
                        
                    }
                    currentCount--;
                }

                foreach (var diff in newNumbers)
                {
                    queue.Enqueue(diff, diff);
                }
                operations += 1;
            }

            if (queue.Count > 0)
            {

                operations += 1;
            }

            return operations;
            /*Traverse the array and push all the elements which are greater than 0, in the priority queue.
    Create a variable op, to store the number of operations, and initialise it with 0.
    Now, iterate over the priority queue pq till its size is greater than one in each iteration:
    Increment the value of variable op.
    Then select the top two elements, let’s say p and q to apply the given operation.
    After applying the operation, one element will definitely become 0. Push the other one back into the priority queue if it is greater than zero.
    *Time Complexity: O(NlogN)
    Auxiliary Space: O(N)/
    https://prepfortech.in/leetcode-solutions/make-array-zero-by-subtracting-equal-amounts/
    //https://www.geeksforgeeks.org/minimum-operations-for-reducing-array-to-0-by-subtracting-smaller-element-from-a-pair-repeatedly/
        }
    }*/

        }
    }