//to-do
// implement insertion
// insertion at beginning
// insertion at the end
// insertion at the middle

// implement deletion
// deletion at the beginning
// deletion at the end

//implement search 

//implement display

using System.Reflection;

namespace lab_tutorial2;

class Node //created a node class for [node] object //need unsafe to make pointer available
{
    public string data;
    public Node next;

    public Node() { }
    public Node(string arg_data)
    {
        data = arg_data;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Node start = null; //create a header to point to the existing node
        //menu terminal
        int user_choice;
        string user_input;
        
        int InsertionAtBeginning()
        {
            Console.WriteLine("Data to be inserted at the first node: ");
            user_input = Console.ReadLine();
            Node new_node = new Node(user_input);
            new_node.next = start;
            start = new_node;
            return 0;
        }

        int InsertionAtEnd()
        {
            Node tmp_ptr = start; //create temporary pointer to point to start for traversal //traverser always need to start from header
            Console.WriteLine("Data to be inserted at the last node: ");
            user_input = Console.ReadLine();
            Node new_node = new Node(user_input); //create a new node
            while (tmp_ptr.next != null) //traverse the linked list through tmp_pointer 
            {
                tmp_ptr = tmp_ptr.next;
            }
            tmp_ptr.next = new_node;
            return 0;
        }

        int InsertionAtTheMiddle()
        {
            Node tmp_ptr = start;
            Console.WriteLine("Data to be inserted at the middle node: ");
            user_input = Console.ReadLine();
            Node new_node = new Node(user_input);
            Console.WriteLine("At which node do you want to inserted the new node (specify the value): ");
            string tmp_data = Console.ReadLine();
            while (tmp_ptr != null) //traverse the linked list to compare data
            {
                if (tmp_ptr.data == tmp_data)
                {
                    break;
                }
                tmp_ptr = tmp_ptr.next; //move to the next node
            }
            //insert at the side of the current node
            if (tmp_ptr == null) //when traversal reaches the end of the linked list, means node not found 
            {
                Console.WriteLine("Node not found!");
                return 1;
            }
            new_node.next = tmp_ptr.next;
            tmp_ptr.next = new_node;
            return 0;
        }

        int DeletionAtBeginning()
        {
            if (start == null)
            {
                Console.WriteLine("There is no node to delete!");
                return 1;
            }
            Node tmp_ptr = start;
            start = start.next;
            Console.WriteLine("Node with value: " + tmp_ptr.data + " is deleted!");
            return 0;
        }

        int DeletionAtMiddle()
        {
            Node ptr = start;
            Console.WriteLine("The node to be deleted (value): ");
            string key = Console.ReadLine();
            if (ptr == null || ptr.next == null) //if there is no node or 1 node 
            {
                Console.WriteLine("There is no node to delete!");
            }
            while (ptr != null && ptr.next != null)
            {
                Node tmp_ptr = ptr.next;
                if (tmp_ptr.data == key)
                {
                    ptr.next = tmp_ptr.next;
                    break;
                }
                ptr = ptr.next; //go to the next node if [key] not found
            }
            return 0;
        }
        do
        {
            Console.WriteLine("Please choose one of the following options: \n");
            Console.WriteLine("1. Add node at the beginning");
            Console.WriteLine("2. Add node at the end");
            Console.WriteLine("3. Add node at the middle");
            Console.WriteLine("4. Delete node at the beginning of linked list");
            Console.WriteLine("5. Delete node at the end of the linked list");
            Console.WriteLine("6. Search List");
            Console.WriteLine("7. Display List");
            user_choice = Convert.ToInt16(Console.ReadLine());
            switch (user_choice)
            {
                case 1: 
                    //insertion at the beginning
                    InsertionAtBeginning();
                    Console.WriteLine("Insertion at the beginning of the node is successful!");
                    break;
                case 2:
                    //insertion at the end
                    InsertionAtEnd();
                    Console.WriteLine("Insertion at the end of the node is successful!");
                    break;
                case 3:
                    //insertion at the middle
                    DeletionAtBeginning();
                    Console.WriteLine("Insertion at the middle of the node is successful!");
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
            }
        } while (user_choice >= 1 && user_choice <= 7);
        //implement insertion
        
        Console.WriteLine("Hello, World!");
        
    }
}