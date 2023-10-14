 public class Solution
 {
     public bool CanVisitAllRooms(IList<IList<int>> rooms)
     {
         /*
         Solution Algorithm (Using DFS)
 Create a function to check if all rooms can be visited using DFS.
 Start DFS from the first room (Room 0) and mark it as visited.
 For each key in Room 0, if the corresponding room is not visited, recursively call the DFS function on that room.
 Continue this process for each unvisited room found in the previous step.
 If DFS is successful, and all rooms are visited, return True; otherwise, return False.
 Solution Algorithm (Using BFS)
 Create a function to check if all rooms can be visited using BFS.
 Start BFS from the first room (Room 0) and enqueue it into the queue.
 Mark Room 0 as visited.
 While the queue is not empty, dequeue a room and process its keys.
 For each key in the current room, if the corresponding room is not visited, mark it as visited and enqueue it.
 Continue this process for each unvisited room found in the previous step.
 If BFS is successful, and all rooms are visited, return True; otherwise, return False.
 */

         var visitedRooms = new HashSet<int>();

         /// dfs

          
          DFS(visitedRooms, 0, rooms);
      

         return visitedRooms.Count == rooms.Count;
     }

     private void DFS(HashSet<int> visited, int room, IList<IList<int>> rooms)
     {
        if (visited.Contains(room)) return;
         visited.Add(room);

         foreach (var neigbourRoom in rooms[room])
         {
             
             DFS(visited, neigbourRoom,rooms);
         }
     }
 }