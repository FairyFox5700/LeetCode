    public class SmallestInfiniteSet
    {

        private PriorityQueue<int, int> _pq;
        private HashSet<int> _set;
        private int _counter = 1;
        public SmallestInfiniteSet()
        {
            _set = new HashSet<int>();
            _pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => a.CompareTo(b)));
        }

        public int PopSmallest()
        {
            int answer = 0;
            if (_pq.Count > 0)
            {
                var item = _pq.Dequeue();
                _set.Remove(item);
                answer = item;
            }
            else
            {
                answer = _counter;
                _counter++;
                
            }
            return answer;
        }

        public void AddBack(int num)
        {
            if (num < _counter && !_set.Contains(num))
            {
                _pq.Enqueue(num, num);
                _set.Add(num);
            }
        }
    }
//https://leetcode.com/problems/smallest-number-in-infinite-set/editorial/
/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */