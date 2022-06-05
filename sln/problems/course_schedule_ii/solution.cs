public class Solution {
        private int[] _inDegrees;

        private List<int> _coursesInOrder;
        Queue<int> zeroInDegreeQueue = new Queue<int>();
        // simle adjacency list
        private Dictionary<int, List<int>> graph;

        public int[] FindOrder(int numCourses, int[][] prerequisites) 
        {
            //Create a graph from the given edges
            graph = new();
            _inDegrees = new int[numCourses];
            for (int i = 0; i < numCourses; i++)
                graph.Add(i, new());

            foreach (var pre in prerequisites)
            {
                var course = pre[0];
                var req = pre[1];
                graph[course].Add(req);
                _inDegrees[req]++;
            }

            _coursesInOrder = new();
            foreach (var course in graph.Keys)
            {
                if (_inDegrees[course] == 0)
                {
                    zeroInDegreeQueue.Enqueue(course);
                    _coursesInOrder.Add(course);
                }
            }
            Search();
            _coursesInOrder.Reverse();
            if(_coursesInOrder.Count<0 || _coursesInOrder.Count != numCourses)
            {
                return new int[0];
            }
        
            return _coursesInOrder.ToArray();
        }


        private void Search()
        {
            while (zeroInDegreeQueue.Count > 0)
            {
                var el = zeroInDegreeQueue.Dequeue();
                
                foreach (var req in graph[el])
                {
                    _inDegrees[req]--;
                    if (_inDegrees[req] == 0)
                    {
                        zeroInDegreeQueue.Enqueue(req);
                        _coursesInOrder.Add(req);
                    }
                }
            }

}
}
  /*  private ColoringStates[] _coloringStates;

    private List<int> _coursesInOrder;
        // simle adjacency list
    private Dictionary<int, List<int>> graph;
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        
            //Create a graph from the given edges
            graph = new();
            for (int i = 0; i < numCourses; i++)
                graph.Add(i, new());

            foreach (var pre in prerequisites)
            {
                var course = pre[0];
                var req = pre[1];
                graph[course].Add(req);
            }

            _coloringStates = new ColoringStates[numCourses];
            _coursesInOrder = new ();
            foreach (var course in graph.Keys)
            {
                if (DFS(course) == false)
                {
                    return new int[0];
                }
            }

            return _coursesInOrder.ToArray();
        }


        private bool DFS(int course)
        {
            if (_coloringStates[course] == ColoringStates.Temp)
            {
                //we have found a cycle
                return false;
            }
            //course already visited
            if (_coloringStates[course] == ColoringStates.Visited)
            {
                return true;
            }

            _coloringStates[course] = ColoringStates.Temp;
            foreach (var req in graph[course])
            {
                // if false for any of adjacent-> return false
                if (DFS(req) == false)
                {
                    return false;
                }
            }

            _coloringStates[course] = ColoringStates.Visited;
            _coursesInOrder.Add(course);
            return true;
        }
    }

 public enum ColoringStates
    {
        Unvisited,
        Temp,
        Visited,

    }*/
