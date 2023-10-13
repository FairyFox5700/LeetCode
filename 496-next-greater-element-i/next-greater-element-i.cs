 public class Solution
 {
     public int[] NextGreaterElement(int[] nums1, int[] nums2)
     {
            var hashmap  = new Dictionary<int, int>();
            var monoStack = new Stack<int>();

            monoStack.Push(nums2[0]);
            hashmap.Add(nums2[0], -1);
            for (int i = 1; i < nums2.Length; i++)
            {
                hashmap.Add(nums2[i], -1);//initial value, in case there is no greater element
                while (monoStack.Count()>0 && monoStack.Peek() < nums2[i])
                {
                    var pop = monoStack.Pop();
                    hashmap[pop] =nums2[i];
                }
                monoStack.Push(nums2[i]);
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = hashmap[nums1[i]];
            }

            return nums1;
     }
 }