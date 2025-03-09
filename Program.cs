namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        List<char> BFSTraversal(Dictionary<char, List<char>> adj, char root)
        {
            //get the length of graph
            int length_of_graph = 8; //A B C D E F G H 
            //create a list to store traversed nodes
            List<char> traversed = new List<char>();
            //create a queue for BFS
            Queue<char> queue = new Queue<char>();
            //mark all the vertices as not visited
            Dictionary<char, bool> visited = new Dictionary<char, bool>();
            visited['A'] = false;
            visited['B'] = false;
            visited['C'] = false;
            visited['D'] = false;
            visited['E'] = false;
            visited['F'] = false;
            visited['G'] = false;
            visited['H'] = false;
            
            //mark the root node as visited before traversing
            visited[root] = true;
            queue.Enqueue(root); //queue in the root node because it is visited
            
            while (queue.Count > 0)
            {
                char current_node = queue.Dequeue();
                traversed.Add(current_node);

                foreach (char sibling in adj[current_node])
                {
                    if (visited[sibling] != true)
                    {
                        visited[sibling] = true;
                        queue.Enqueue(sibling);
                    }
                }
            }
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
        
        char source = 'A'; //start from node 'A'
        
        List<char> result = BFSTraversal(graph, source);
        foreach (char element in result)
        {
            Console.WriteLine(element + " ");
        }
    }
}