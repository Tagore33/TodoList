using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Entities;

namespace TodoList.Repsotiory
{
    public interface ITodoTasksRepository
    {
         TodoTask GetTodoTask (Guid id);
         void DeleteTodoTask (Guid id);
         IEnumerable<TodoTask> GetTodoTasks ();
         void CreateTodoTask (TodoTask todoTask);
         void UpdateTodoTask (TodoTask todoTask);
    }
}
