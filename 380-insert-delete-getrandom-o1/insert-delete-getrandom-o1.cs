    public class RandomizedSet
    {
        Dictionary<int,int> dict = new Dictionary<int, int>();
        List<int> list = new List<int>();
        public RandomizedSet()
        {

        }

        public bool Insert(int val)
        {
            if (dict.ContainsKey(val))
            {
               return false;
            }

            var currentIndex = list.Count;
            dict[val] = currentIndex;
            list.Add(val);
            return true;
        }

        public bool Remove(int val)
        {
            if (!dict.ContainsKey(val))
            {
                return false;
            }
            var lastIndex = list.Count-1;
            var indexToRemove = dict[val];
            if(indexToRemove != lastIndex)
            {
                list[indexToRemove] = list[lastIndex];
                dict[list[indexToRemove]] = indexToRemove;
            }
            dict.Remove(val);
            list.RemoveAt(lastIndex);
            return true;
        }

        public int GetRandom()
        {
            var randomIndex = (new Random()).Next(0, list.Count);
            return list[randomIndex];
        }
    }