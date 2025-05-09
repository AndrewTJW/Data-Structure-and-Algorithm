﻿namespace lab_4_4;

class lab_2_4
{
    //Node object
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
        int stack_count = 0;

        Node head = null, rear = null;
        //push
        int Push()
        {
            if (stack_count == max_size)
            {
                Console.WriteLine("Stack overflow!");
                return -1;
            }

            if (stack_count >= 1) //more than 1 node in stack add new node to the end
            {
                while (rear.next != null)
                {
                    rear = rear.next;
                }
                Console.WriteLine("Enter the data you want to add to the queue: ");
                user_input = Console.ReadLine();
                Node new_node_rear = new Node(user_input);
                rear.next = new_node_rear;
                Console.WriteLine("Data added to queue in rear: " + rear.next.data);
                stack_count++;
                return 0;
            }
            Console.WriteLine("Enter data to add to stack: ");
            user_input = Console.ReadLine();
            Node new_node = new Node(user_input);
            new_node.next = head;
            head = new_node;
            rear = new_node;
            Console.WriteLine("Data added to stack: " + head.data);
            stack_count++;
            return 0;
        }
        //pop
        int Pop()
        {
            if (stack_count == 0)
            {
                Console.WriteLine("Stack underflow!");
                return -1;
            }

            if (stack_count == 1)
            {
                head = null;
                Console.WriteLine("Data removed from stack: " + rear.data);
                stack_count--;
                return 0;
            }
            Node traverser = head;
            while (traverser.next != null)
            {
                rear = traverser;
                traverser = traverser.next;
            }

            rear.next = null;
            Console.WriteLine("Data removed from stack: " + traverser.data);
            stack_count--;
            return 0;
        }
        //peek
        int Peek()
        {
            if (stack_count == 0)
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            Console.WriteLine("Stack's front: " + head.data);
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
        
        Console.WriteLine("Max size for stack: ");
        max_size = int.Parse(Console.ReadLine());
        //menu
        do
        {
            Console.WriteLine("Operations: \n");
            Console.WriteLine("===============");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Check if stack is empty");

            user_choice = Convert.ToInt16(Console.ReadLine());

            switch (user_choice)
            {
                case 1:
                    Push();
                    break;
                case 2:
                    Pop();
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