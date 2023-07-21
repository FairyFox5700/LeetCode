/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighborsneighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null)
        {
            return null;
        }
        var visited = new Dictionary<Node, Node>();
        Node DFS(Node node) 
        {
            if(visited.ContainsKey(node))
            {
                // already visited
                return visited[node] ;
            }
            // else clone node
            var newNode = new Node(node.val);
            visited[node] = newNode;
            foreach(var nodev in node.neighbors)
            {
                newNode.neighbors.Add(DFS(nodev));
            }

            return newNode;            
        }
        
        return DFS(node);
    }
}