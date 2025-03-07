namespace Lab4;

//implement graphs to demonstrate BFS and DFS
class Lab4
{
    //implement a node for queue
    public class Node
    {
        public string data;
        public Node next;
        
        //constructor
        public Node(string arg_data)
        {
            data = arg_data;
        }
    }
    
    static void Main(string[] args)
    {
        List<string> BFSTraversal(List<string> adj, char root)
        {
            int index_of_visited = 0; //initialized as 0 will +1 when enqueue -1 when dequeue
            //get the length of graph
            int length_of_graph = adj.Count;
            //create a list to store traversed nodes
            List<string> traversed = new List<string>();
            //create a queue for BFS
            Queue<char> queue = new Queue<char>();
            //mark all the vertices as not visited
            bool[] visited = new bool[length_of_graph];
            //mark the root node as visited before traversing
            visited[index_of_visited] = true;
            queue.Enqueue(root); //queue in the root node because it is visited
            return traversed;
        }

        //create a dictionary to store the graph
        Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>();
        graph['A'] = new List<char>{'B', 'C', 'D'};
        graph['B'] = new List<char>{'A', 'D', 'E'};
        graph['C'] = new List<char>{'A', 'F', 'G'};
        graph['D'] = new List<char>{'C', 'B'};
        graph['E'] = new List<char>{'B', 'H'};
        graph['F'] = new List<char>{'C', 'E'};
        graph['G'] = new List<char>{'C', 'F'};
        graph['H'] = new List<char>{'E', 'F', 'G'};
        
        
        Console.WriteLine("Hello, World!");
    }
}