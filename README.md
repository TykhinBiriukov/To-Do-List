
# To-Do List

The To-Do List Application is a simple console-based program that allows users to manage their tasks. Users can add tasks, view all tasks, delete tasks, and save/load tasks from a file. Save/load feature is done by converting code to Json format file and reading it when the app is activated to restore your task list.



## 📦 Tech Stack

### Used Languages
- C#

### Backend
- File I/O (StreamWriter, StreamReader)
- Convertation to Json (JsonSerializer)
## 🛠 Features
- Add a New Task: Users can add tasks to their list by providing name, date and description. Tasks are stored in memory or optionally persisted in a file.

- View All Tasks: Displays a numbered list of all tasks, showing task's index, name, date and description.

- Delete a Task: Allows users to remove tasks from their list by selecting the task number.

- Save and Load Tasks: Tasks can be saved to a file on disk and reloaded when the application starts, allowing users to maintain their task list across sessions.

- User Input Validation: The application includes input validation to ensure that user inputs are correct and within the expected range, preventing errors and enhancing user experience.
