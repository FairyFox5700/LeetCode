public class Solution {
   public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            //In this question we have applied a simple logic that if there is a cycle then it is not possible to schedule the courses
            var visited = new HashSet<int>();
            var dict = new Dictionary<int, HashSet<int>>();
            foreach (var prerequisite in prerequisites)
            {
                var course = prerequisite[0];
                var prerequisiteCourse = prerequisite[1];

                if (!dict.ContainsKey(course))
                {
                    dict[course] = new HashSet<int>();
                }
               if (!dict.ContainsKey(prerequisiteCourse))
                {
                    dict[prerequisiteCourse] = new HashSet<int>();
                }

                dict[course].Add(prerequisiteCourse);
            }

            foreach (var entry in dict)
            {
                Console.WriteLine("Key: " + entry.Key + ", Value: " + string.Join(", ", entry.Value));
            }
            foreach( var course in dict.Keys)
            {
                if (!visited.Contains(course))
                {
                    if (!DFS(course, dict, visited))
                    {
                        return false;
                    }
                }
               
            }
             return true;



            bool DFS(int n, Dictionary<int,HashSet<int>> dict, HashSet<int> visited)
            {
                if (visited.Contains(n))
                {
                    //loop detected
                    return false;
                }
                visited.Add(n);
                foreach (var neighbour in dict[n])
                {
                    if (!DFS(neighbour, dict, visited))
                    {
                        return false;
                    }
                }
                // remove from visited, as we can attent it without loops, thus we can finish this course
                visited.Remove(n);
                // empty list, to not check it again
                dict[n] = new HashSet<int>();
                return true;
            }

        }
}