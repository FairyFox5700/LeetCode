
public class Solution
{
    public IList<string> WatchedVideosByFriends(IList<IList<string>> watchedVideos, IList<IList<int>> friends, int id, int level)
    {
        Dictionary<string, int> videos = new Dictionary<string, int>();
        Queue<int> q = new Queue<int>();
        HashSet<int> visited = new HashSet<int>();

        q.Enqueue(id);
        visited.Add(id);

        while (level > 0)
        {
            int count = q.Count;
            for (int i = 0; i < count; i++)
            {
                int person = q.Dequeue();

                foreach (int friend in friends[person])
                {
                    if (!visited.Contains(friend))
                    {
                        visited.Add(friend);
                        q.Enqueue(friend);

                        if (level == 1)
                        {
                            foreach (string vid in watchedVideos[friend])
                            {
                                if (!videos.ContainsKey(vid))
                                    videos[vid] = 0;
                                videos[vid]++;
                            }
                        }
                    }
                }
            }

            level--;
        }

        var sortedVideos = videos.Keys.OrderBy(k => (videos[k], k)).ToList();
        return sortedVideos;
    }
}
