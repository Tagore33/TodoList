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
            string status = todoTask.completed==true ? "finished" : "unfinished";
            return new ReadTodoTaskDto
            {
                taskId = todoTask.taskId,
                description=todoTask.description,
                taskDate=todoTask.taskDate,
                taskPriority=todoTask.taskPriority,
                taskStatus=status
            };
        }
        public static IEnumerable<ReadTodoTaskDto> AsReadDtos(this IEnumerable<TodoTask> todoTasks)
        {
            var todoTaskDtos = todoTasks
              .Select(todoTask => new ReadTodoTaskDto { description = todoTask.description,
              taskStatus= todoTask.completed==true ? "finished" : "unfinished",
              taskDate = todoTask.taskDate,
              taskPriority= todoTask.taskPriority,
              taskId = todoTask.taskId
              })
              .ToList();

            return todoTaskDtos;
        }
    }
}
