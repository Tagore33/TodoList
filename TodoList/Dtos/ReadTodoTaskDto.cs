using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Aids.Enums;

namespace TodoList.Dtos
{
    public class ReadTodoTaskDto
    {
        public Guid taskId { get;init; }
        public DateTime taskDate { get; init; }
        public string? description { get; init; }
        public Priority taskPriority { get; init; }
        public string taskStatus { get; init; } = null!;
    }
}
