| Classes  | Methods                              | Scenario                                       | Output                     |
|----------|--------------------------------------|------------------------------------------------|----------------------------|
| TodoList | List<Task> Tasks {get; set;}         | Store and get tasks                            | List<Task> tasks           |
|          | AddTask(String, taskName)            | Add a new task to Task List                    | bool                       |
|          | GetCompleteTasks(List<Task> Tasks)   | Filter the tasks to show only complete         | List<Task> completeTasks   |
|          | GetIncompleteTasks(List<Task> Tasks) | Filter tasks to find only incomplete           | List<Task> incompleteTasks |
|          | SearchTask(String name)              | Search for a specific task                     | bool                       |
|          | RemoveTask(String name)              | Remove task if exists                          | bool                       |
|          | OrderTasks(bool ascending)           | Order alphabetically true = asc / false = desc | List<Task> Tasks           |
| ListTask | String Name {get; set;}              | store and get name of task                     | String name                |
|          | bool Complete {get; set;} = false;   | check completion status                        | bool                       |