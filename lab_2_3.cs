namespace tutorial_lab_2_3;

class lab_2_3
{
    class Stack //create stack
    {
        public string[] data;
        public int top;

        //create constructor
        public Stack(int arg_maxsize)
        {
            data = new string[arg_maxsize];
            top = -1; //always starts from -1
        }
    }
    static void Main(string[] args)
    {
        int user_choice;
        string user_input;
        int max_size;
        
        Console.WriteLine("Max size for stack: ");
        max_size = Convert.ToInt16(Console.ReadLine());
        Stack stack = new Stack(max_size);
        //create push func
        int Push(string arg_val, Stack arg_stack)
        {
            if (arg_stack.top == max_size - 1)
            {
                Console.WriteLine("The stack is full!");
                return -1;
            }
            else
            {
                arg_stack.top += 1;
                arg_stack.data[arg_stack.top] = arg_val;
                Console.WriteLine("Data added to stack: " + arg_stack.data[arg_stack.top]);
            }
            return 0;
        }
        //create pop func
        int Pop(Stack arg_stack)
        {
            if (arg_stack.top == -1)
            {
                Console.WriteLine("The stack is empty!");
                return -1;
            }
            string val_removed = arg_stack.data[arg_stack.top];
            Console.WriteLine("Data removed from stack: " + arg_stack.data[arg_stack.top]);
            arg_stack.top -= 1;
            return 0;
        }
        //create peek func
        int Peek(Stack arg_stack)
        {
            if (arg_stack.top == -1)
            {
                Console.WriteLine("The stack is empty!");
                return -1;
            }
            Console.WriteLine("Top has data: " + arg_stack.data[arg_stack.top]);
            return 0;
        }
        //create isEmpty func
        bool isEmpty(Stack arg_stack)
        {
            if (arg_stack.top == -1)
            {
                Console.WriteLine("The stack is empty!");
                return true;
            }
            return false;
        }
        
        
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
                    Console.WriteLine("Element you want to add to stack: ");
                    user_input = Console.ReadLine();
                    Push(user_input, stack);
                    break;
                case 2:
                    Pop(stack);
                    break;
                case 3:
                    Peek(stack);
                    break;
                case 4:
                    bool output = isEmpty(stack);
                    if (output == true)
                    {
                        Console.WriteLine("Stack is empty!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Stack is not empty!");
                        break;
                    }
            }
        } while (user_choice >= 1 && user_choice <= 4);
    }
}