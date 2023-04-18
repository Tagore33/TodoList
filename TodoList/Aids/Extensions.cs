using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Dtos;
using TodoList.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TodoList.Aids
{
    public static class Extensions
    {
        public static ReadTodoTaskDto AsReadDto (this TodoTask todoTask)
        {
            string status = todoTask.Completed ? "finished" : "unfinished";
            return new ReadTodoTaskDto
            {
                TaskId = todoTask.TaskId,
                Description=todoTask.Description,
                TaskDate=todoTask.TaskDate,
                TaskPriority=todoTask.TaskPriority,
                TaskStatus=status
            };
        }
        public static IEnumerable<ReadTodoTaskDto> AsReadDtos(this IEnumerable<TodoTask> todoTasks)
        {
            var todoTaskDtos = todoTasks
              .Select(todoTask => new ReadTodoTaskDto { Description = todoTask.Description,
              TaskStatus= todoTask.Completed? "finished" : "unfinished",
              TaskDate = todoTask.TaskDate,
              TaskPriority= todoTask.TaskPriority,
              TaskId = todoTask.TaskId
              })
              .ToList();

            return todoTaskDtos;
        }
    }
}
