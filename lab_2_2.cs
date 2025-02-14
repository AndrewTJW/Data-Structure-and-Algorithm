namespace lab_2_2;

//implement queue using linked list
class lab_2_2
{
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
        int user_choice;
        string user_input;
        int max_size;
        int queue_count = 0;
        Node head = null, rear = null; 
        //enqueue
        int Enqueue()
        {
            if (queue_count == max_size) //queue max sizen reached
            {
                Console.WriteLine("Queue is full!");
                return -1;
            }

            if (queue_count >= 1)
            {
                while (rear.next != null)
                {
                    rear = rear.next;
                }
                Console.WriteLine("Enter the data you want to add to the queue: ");
                user_input = Console.ReadLine();
                Node new_node_rear = new Node(user_input);
                rear.next = new_node_rear;
                Console.WriteLine("Data added to queue in rear: " + rear.data);
                queue_count++;
                return 0;
            }
            Console.WriteLine("Enter the data you want to add to the queue: ");
            user_input = Console.ReadLine();
            Node new_node = new Node(user_input);
            new_node.next = head; //point to previous pointer if have, else point to null
            head = new_node; //update head to new node
            rear = new_node;
            queue_count++;
            Console.WriteLine("Added data: " + head.data + " to queue");
            return 0;
        }
        //dequeue
        int Dequeue()
        {
            Node tmp_ptr;
            if (queue_count == 0)
            {
                Console.WriteLine("Queue is empty!");
                return -1;
            }
            tmp_ptr = head;
            head = head.next;
            Console.WriteLine("Dequeued node with data: " + tmp_ptr.data);
            queue_count--;
            return 0;
        }
        //peek
        int Peek() //see top of queue
        {
            if (queue_count == 0)
            {
                Console.WriteLine("Queue is empty!");
                return -1;
            }
            Console.WriteLine("Queue's front: " + head.data);
            return 0;
        }
        //isEmpty
        int isEmpty()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty!");
                return -1;
            }
            Console.WriteLine("Queue is not empty!");
            return 0;
        }
        
        Console.WriteLine("Max size for queue: ");
        max_size = int.Parse(Console.ReadLine());
        //menu
        do
        {
            Console.WriteLine("Operations: \n");
            Console.WriteLine("===============");
            Console.WriteLine("1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Check if queue is empty");

            user_choice = Convert.ToInt16(Console.ReadLine());

            switch (user_choice)
            {
                case 1:
                    Enqueue();
                    break;
                case 2:
                    Dequeue();
                    break;
                case 3:
                    Peek();
                    break;
                case 4:
                    isEmpty();
                    break;
            }
        } while (user_choice >= 1 && user_choice <= 4);
    }
}