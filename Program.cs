//program works but only can do it once, then need to reset again
namespace lab2
{
    internal class Program
    {
        class Queue
        {
            public string[] data;
            public int front;
            public int rear;
            public int count;

            //constructor
            public Queue(int arg_max_size)
            {
                data = new string[arg_max_size];
                front = -1;
                rear = -1;
                count = 0;
            }
        }
        static void Main(string[] args)
        {
            //implement queue using linked list
            //need front and rear
            //initialize queue
            string user_input;
            int user_choice;
            Console.WriteLine("Max size for queue: ");
            int max_size = Convert.ToInt16(Console.ReadLine());
            Queue queue = new Queue(max_size);

            int Enqueue(string arg_val, Queue arg_q)
            {
                if (arg_q.rear == max_size - 1)
                {
                    Console.WriteLine("Overflow, queue is full!");
                    return -1;
                }
                if (arg_q.front == -1 && arg_q.rear == -1)
                {
                    arg_q.front = 0;
                    arg_q.rear = 0;
                }
                else
                {
                    arg_q.rear += 1;
                }
                arg_q.data[arg_q.rear] = arg_val;
                Console.WriteLine("Element added in queue: " + arg_q.data[arg_q.rear]);
                arg_q.count += 1;
                return 0;
            }

            int Dequeue(Queue arg_q)
            {
                if (arg_q.front == -1 || arg_q.front > arg_q.rear) //if queue is empty or if front > rear
                {
                    Console.WriteLine("Underflow, queue is empty!");
                    return 1;
                }
                else
                {
                    string val_removed = arg_q.data[arg_q.front];
                    Console.WriteLine("Element removed from queue: " + val_removed);
                    arg_q.front += 1; //move front to the next element, hence removing queue
                }
                arg_q.count -= 1;
                return 0;
            }

            int Peek(Queue arg_q)
            {
                if (arg_q.count == 0)
                {
                    Console.WriteLine("Queue is empty");
                    return 1;
                }
                else
                {
                    Console.WriteLine("Value in front is: " + arg_q.data[arg_q.front]);
                    return 0;
                }
            }

            bool isEmpty(Queue arg_q)
            {
                if (arg_q.count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

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
                        Console.WriteLine("Element you want to add to queue: ");
                        user_input = Console.ReadLine();
                        Enqueue(user_input, queue);
                        break;
                    case 2:
                        Dequeue(queue);
                        break;
                    case 3:
                        Peek(queue);
                        break;
                    case 4:
                        bool output = isEmpty(queue);
                        if (output == true)
                        {
                            Console.WriteLine("Queue is empty!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Queue is not empty!");
                            break;
                        }
                }
            } while (user_choice >= 1 && user_choice <= 4);
        }
    }
}
