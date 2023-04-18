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
        public Guid TaskId { get;init; }
        public DateTime TaskDate { get; init; }
        public string? Description { get; init; }
        public Priority TaskPriority { get; init; }
        public string TaskStatus { get; init; } = null!;
    }
}
