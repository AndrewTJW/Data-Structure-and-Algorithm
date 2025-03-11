//to implement dijkstra algo
//need binary heap/priority queue to store the vertex that has the lowest weight in their edge
//need keep track of visited nodes, either through class or list
//need a list to keep track of all the vertices
//implement the graph

namespace Dijkstra_Algo;

class Dijkstra_Algo
{
    class Vertex
    {
        public char data;
        public bool visited;
        public int distance;

        public Vertex(char data)
        {
            this.data = data;
            this.visited = false;
            this.distance = int.MaxValue; //set to infinity
        }
    }
    
    
    static void Main(string[] args)
    {
        int max_node = 4;
        int [,] adjMatrix = new int[max_node, max_node]; //adjacency matrix

        void CreateGraph()
        {
            for (int i = 0; i < max_node; i++)
            {
                for (int j = 0; j < max_node; j++)
                {
                    adjMatrix[i, j] = int.MaxValue; //set all node to have no connection first 
                }
            }
        }

        void addEdge(int start, int end, int weight)
        {
            adjMatrix[start, end] = weight; //one for weighted
            adjMatrix[end, start] = weight; //two for unweighted
        }
        
        //initialize priority queue
        PriorityQueue<int, int> qp = new PriorityQueue<int, int>();
        //initialize a list to keep track of all the vertices
        List<Vertex> vertices = new List<Vertex>();
        //shortest path
        //initialize graph
        CreateGraph();
        
        //initialize vertexes
        Vertex A = new Vertex('A');
        vertices.Add(A);
        Vertex B = new Vertex('B');
        vertices.Add(B);
        Vertex C = new Vertex('C');
        vertices.Add(C);
        Vertex D = new Vertex('D');
        vertices.Add(D);
        
        //add edges with weight 
        addEdge(0,1, 4);
        addEdge(0,2, 1);
        addEdge(1,2, 2);
        addEdge(2,3, 3);
        addEdge(3,1, 5);
        
        
        void Relaxation(Vertex arg_vertex)
        {
            int index_of_vertex = vertices.IndexOf(arg_vertex); //gets the index of the vertex
            //get index of the Vertex
            for (int i = 0; i < max_node; i++)
            {
                if (adjMatrix[index_of_vertex, i] != int.MaxValue && vertices[i].visited == false)
                {
                    if (arg_vertex.distance + adjMatrix[index_of_vertex, i] < vertices[i].distance)
                    {
                        vertices[i].distance = arg_vertex.distance + adjMatrix[index_of_vertex, i];
                        qp.Enqueue(i, vertices[i].distance);
                    }
                }
            }
        }
        
        void RunDijkstraAlgorithm(Vertex arg_source_node)
        {
            int arg_source_index = vertices.IndexOf(arg_source_node);
            vertices[arg_source_index].distance = 0; //since visited source node first, the weight = 0
            qp.Enqueue(arg_source_index, 0);
            while (qp.Count > 0)
            {
                int curr_vertex_index = qp.Dequeue();
                if (vertices[curr_vertex_index].visited != true)
                {
                    Relaxation(vertices[curr_vertex_index]);
                    vertices[curr_vertex_index].visited = true;
                }
            }
        }
        
        
        //declare source node
        Vertex source_node = A;
        RunDijkstraAlgorithm(source_node);
        Console.WriteLine("Shortest distances from source node " + source_node.data + ":");
        for (int i = 0; i < vertices.Count; i++)
        {
            Console.WriteLine(vertices[i].data + ": " +  vertices[i].distance.ToString());
        }
    }
}