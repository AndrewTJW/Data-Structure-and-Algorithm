namespace tutorial1a;

class tutorial1a
{
    static void Main(string[] args)
    {
        int user_choice;
        int size = 0;
        int maxLength = 5;
        int[] arr = new int[maxLength];
        //functions

        //insertion function
        int Insertion(int arg_int, int arg_position)
        {
            if (size == maxLength)
            {
                Console.WriteLine("Array overflow!");
                return 1;
            }
            else if (arg_position >= 0 && arg_position <= size)
            {
                for (int j = size - 1;  j >= arg_position; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[arg_position] = arg_int;
                size++;
            }
            else
            {
                Console.WriteLine("Invalid position!");
            }
            return 0;
        }

        //deletion function
        int Deletion(int arg_position)
        {
            if (size == 0)
            {
                Console.WriteLine("Underflow!");
                return 1;
            }
            else if (arg_position >= 0 && arg_position <= size)
            {
                for (int j = arg_position; j < size - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                size--; //array size is logically reduced through this but still remains in memory 
                Console.WriteLine("Deletion successful!");
            }
            else
            {
                Console.WriteLine("Invalid Position");
            }
            return 0;
        }

        //find element
        int FindElement(int arg_position)
        {
            if (arg_position >= 0 && arg_position < size)
            {
                Console.WriteLine("Element at position "+ arg_position + " is " + arr[arg_position]);
                return 0;
            } 
            else
            {
                Console.WriteLine("Invalid Position!");
                return 1;
            }
        }

        //find index
        int FindIndex(int arg_int)
        {
            for (int j = 0; j < size; j++)
            {
                if (arr[j] == arg_int)
                {
                    Console.WriteLine("Index of element " + arr[j] + " is " + j);
                    return 0;
                }
            }
            Console.WriteLine("Element not found!");
            return 1;
        }

        //empty array
        void EmptyArray()
        {
            size = 0;
            Console.WriteLine("Array Emptied!");
        }

        //display whole array
        void DisplayArray()
        {
            for (int j = 0; j < size; j++)
            {
                Console.WriteLine("Element at position " + j + " is " + arr[j]);
            }
        }





        //menu display
        do
        {
            Console.WriteLine("Operations can be performed");
            Console.WriteLine("============================== \n");

            Console.WriteLine("1. Insert Element");
            Console.WriteLine("2. Delete Element");
            Console.WriteLine("3. Find element at position");
            Console.WriteLine("4. Find index");
            Console.WriteLine("5. Empty the array");
            Console.WriteLine("6. Display array \n");

            Console.WriteLine("Your choice(1-6): ");
            user_choice = Convert.ToInt16(Console.ReadLine());

            switch (user_choice) {
                case 1:
                    Console.WriteLine("Element to insert: ");
                    int element = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Position to insert: ");
                    int position = Convert.ToInt16(Console.ReadLine());
                    Insertion(element, position);
                    break;
                case 2:
                    Console.WriteLine("Position to delete: ");
                    int position_del = Convert.ToInt16(Console.ReadLine());
                    Deletion(position_del);
                    break;
                case 3:
                    Console.WriteLine("Find element at position: ");
                    int element_to_find = Convert.ToInt16(Console.ReadLine());
                    FindElement(element_to_find);
                    break;
                case 4:
                    Console.WriteLine("Find index of element: ");
                    int index_to_find = Convert.ToInt16(Console.ReadLine());
                    FindIndex(index_to_find);
                    break;
                case 5:
                    Console.WriteLine("Emptying Array!");
                    EmptyArray();
                    break;
                case 6:
                    DisplayArray();
                    break;
            }
        } while (user_choice >= 1 && user_choice <= 6);
        Console.WriteLine("Program ended!");
    }
}