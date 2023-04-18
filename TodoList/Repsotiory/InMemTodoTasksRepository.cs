using TodoList.Aids.Enums;
using TodoList.Entities;

namespace TodoList.Repsotiory
{
    public class InMemTodoTasksRepository : ITodoTasksRepository
    {
        private readonly List<TodoTask> todoTasks = new(){ 
            new TodoTask{TaskId=Guid.NewGuid(),TaskDate=DateTime.Now.Date, Description="example", TaskPriority=Priority.Medium}
            };
        public void CreateTodoTask(TodoTask todoTask)
        {
            todoTasks.Add(todoTask);
        }

        public void DeleteTodoTask(Guid id)
        {
            var index = todoTasks.FindIndex(ExistingTodoTask => ExistingTodoTask.TaskId == id);
            todoTasks.RemoveAt(index);
        }

        public TodoTask GetTodoTask(Guid id)
        {
            var todoTask = todoTasks.Where(todoTask => todoTask.TaskId == id).SingleOrDefault();
            return todoTask;
        }

        public IEnumerable<TodoTask> GetTodoTasks()
        {
            return todoTasks;
        }
        public void UpdateTodoTask(TodoTask todoTask)
        {
            var index = todoTasks.FindIndex(ExistingTodoTask => ExistingTodoTask.TaskId == todoTask.TaskId);
            todoTasks[index] = todoTask;
        }
    }
}
