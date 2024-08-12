namespace To_Do_List
{
    using System.Diagnostics;
    using System.Text.Json;

    internal class ToDoList
    {
        public List<Task> tasks;

        public ToDoList() 
        {
            try
            {
                tasks = LoadTasks();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading tasks: {ex.Message}");
            }
        }

        public void AddTask(string taskName, string taskDate, string taskDescription)
        {
            tasks.Add(new Task(taskName, taskDate, taskDescription));
        }

        public void ViewTask()
        {
            Console.WriteLine();
            if (tasks.Count > 0)
            {      for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i+1}: {tasks[i].TaskName}\n  - {tasks[i].TaskDate}\n  - {tasks[i].TaskDescription}");
                    Console.WriteLine("----------");
                }
            }
            else
            {
                Console.WriteLine("No task to show");
            }
        }

        public void RemoveTask(int indexInput)
        {
            if (tasks.Count > 0 && indexInput <= tasks.Count)
            {
                tasks.RemoveAt(indexInput - 1);
            }
            else
            {
                Console.WriteLine("Please enter valid task index");
            }
        }

        public void SaveTasks()
        {
            string fileName = "TaskList.json";
            string result = JsonSerializer.Serialize(tasks);
            File.WriteAllText(fileName, result);
        }

        public List<Task> LoadTasks()
        {
            string path = $"{Directory.GetCurrentDirectory()}\\TaskList.json";
            if (File.Exists(path))
            {
                string fileName = "TaskList.json";
                string jsonString = File.ReadAllText(fileName);
                List<Task> tasks = JsonSerializer.Deserialize<List<Task>>(jsonString);
                return tasks;
            }
            tasks = new List<Task>();
            return tasks;
        }
    }
}