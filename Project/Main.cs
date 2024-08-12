namespace To_Do_List
{
    class Programm
    {
        public static void Main(string[] args)
        {
            ToDoList toDoList = new ToDoList();

            while (true)
            {
                Console.WriteLine("\nMenu\n1. Add a new Task\n2. View your Tasks\n3. Remove a Task\n4. Exit");
                Console.WriteLine("\nPlease select your action: ");
                int usersInput = int.Parse(Console.ReadLine());

                switch (usersInput)
                {
                    case 1:
                        Console.WriteLine("\nPlease enter task name: ");
                        string taskName = Console.ReadLine();
                        while (string.IsNullOrEmpty(taskName))
                        {
                            Console.WriteLine("Input cannot be empty");
                            taskName = Console.ReadLine();
                        }
                        Console.WriteLine("Please enter task date: ");
                        string taskDate = Console.ReadLine();
                        while (string.IsNullOrEmpty(taskDate))
                        {
                            Console.WriteLine("Input cannot be empty");
                            taskDate = Console.ReadLine();
                        }
                        Console.WriteLine("Please enter task description: ");
                        string taskDescription = Console.ReadLine();
                        while (string.IsNullOrEmpty(taskDescription))
                        {
                            Console.WriteLine("Input cannot be empty");
                            taskDescription = Console.ReadLine();
                        }
                        toDoList.AddTask(taskName, taskDate, taskDescription);
                        break;

                    case 2:
                        toDoList.ViewTask();
                        break;

                    case 3:
                        Console.WriteLine("\nPlease enter index of a task: ");
                        string input = Console.ReadLine();
                        int indexInput;
                        while (!int.TryParse(input, out indexInput))
                        {
                            Console.WriteLine("Input cannot be empty or non-numerical");
                            input = Console.ReadLine();
                        }
                        toDoList.RemoveTask(indexInput);
                        break;

                    case 4:
                        toDoList.SaveTasks();
                        return;

                    default:
                        Console.WriteLine("\nPlease enter number from 1 to 4: ");
                        break;
                }
            }
        }

    }
}