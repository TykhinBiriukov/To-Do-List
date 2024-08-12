namespace To_Do_List
{
    class Task
    {
        public string TaskName { get; set; }
        public string TaskDate{ get; set; }
        public string TaskDescription { get; set; }
        public Task(string taskName, string taskDate, string taskDescription) 
        {
            TaskName = taskName;
            TaskDate = taskDate;
            TaskDescription = taskDescription;
        }
    }
}