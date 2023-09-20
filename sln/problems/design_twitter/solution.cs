    public class Twit
    {
        public int UserId { get; set; }
        public int TweetId { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    public class Twitter
    {
        private Dictionary<int, LinkedList<Twit>> _userTwits;
        private Dictionary<int, HashSet<int>> _userFollowers;

        public Twitter()
        {
            _userFollowers = new Dictionary<int, HashSet<int>>();
            _userTwits = new Dictionary<int, LinkedList<Twit>>();

        }

        public void PostTweet(int userId, int tweetId)
        {
            if (_userTwits.ContainsKey(userId))
            {
                _userTwits[userId].AddFirst(new Twit { UserId = userId, TweetId = tweetId, TimeStamp = DateTime.Now });
            }
            else
            {
                _userTwits.Add(userId, new LinkedList<Twit>(new List<Twit> { new Twit { UserId = userId, TweetId = tweetId, TimeStamp = DateTime.Now } }));
            }
        }

        public IList<int> GetNewsFeed(int userId)
        {
            var twits = new List<Twit>();
            // top ten user tweets
            if (_userTwits.ContainsKey(userId))
            {
                var userTwits = _userTwits[userId].Take(10);
                twits.AddRange(userTwits);
            }

            // get user followers
            if (_userFollowers.ContainsKey(userId))
            {
                var userFollowers = _userFollowers[userId];
                foreach (var follower in userFollowers)
                {
                    if (_userTwits.ContainsKey(follower))
                    {
                        var followerTwits = _userTwits[follower].Take(10);
                        twits.AddRange(followerTwits);
                    }
                }
            }

            var pq = new PriorityQueue<Twit, DateTime>(Comparer<DateTime>.Create((a,b)=> b.CompareTo(a)));
            foreach (var follower in twits)
            {
                pq.Enqueue(follower, follower.TimeStamp);
            }

            var result = new List<int>();

            while (pq.Count > 0 && result.Count < 10 )
            {
                result.Add(pq.Dequeue().TweetId);
            }

            return result;
        }

        public void Follow(int followerId, int followeeId)
        {
            if (!_userFollowers.ContainsKey(followerId))
            {
                _userFollowers.Add(followerId, new HashSet<int> { followeeId });
            }
            else
            {
                _userFollowers[followerId].Add(followeeId);
            }
        }

        public void Unfollow(int followerId, int followeeId)
        {
            if (_userFollowers.ContainsKey(followerId))
            {
                _userFollowers[followerId].Remove(followeeId);
            }
        }
    }

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.PostTweet(userId,tweetId);
 * IList<int> param_2 = obj.GetNewsFeed(userId);
 * obj.Follow(followerId,followeeId);
 * obj.Unfollow(followerId,followeeId);
 */