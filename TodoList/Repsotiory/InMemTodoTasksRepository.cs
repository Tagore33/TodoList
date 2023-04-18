using TodoList.Aids.Enums;
using TodoList.Entities;

namespace TodoList.Repsotiory
{
    public class InMemTodoTasksRepository : ITodoTasksRepository
    {
        private readonly List<TodoTask> todoTasks = new(){ 
            new TodoTask{taskId=Guid.NewGuid(),taskDate=DateTime.Now.Date, description="example", taskPriority=Priority.medium}
            };
        public void CreateTodoTask(TodoTask todoTask)
        {
            todoTasks.Add(todoTask);
        }

        public void DeleteTodoTask(Guid id)
        {
            var index = todoTasks.FindIndex(ExistingTodoTask => ExistingTodoTask.taskId == id);
            todoTasks.RemoveAt(index);
        }

        public TodoTask GetTodoTask(Guid id)
        {
            var todoTask = todoTasks.Where(todoTask => todoTask.taskId == id).SingleOrDefault();
            return todoTask;
        }

        public IEnumerable<TodoTask> GetTodoTasks()
        {
            return todoTasks;
        }
        public void UpdateTodoTask(TodoTask todoTask)
        {
            var index = todoTasks.FindIndex(ExistingTodoTask => ExistingTodoTask.taskId == todoTask.taskId);
            todoTasks[index] = todoTask;
        }
    }
}
