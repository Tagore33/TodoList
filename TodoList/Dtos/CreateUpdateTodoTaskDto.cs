
using TodoList.Aids.Enums;

namespace TodoList.Dtos
{
    public class CreateUpdateTodoTaskDto
    {
        public DateTime? taskDate { get; init; }
        public string? description { get; init; }
        public Priority taskPriority { get; init; }
        public bool completed { get; init; }
    }
}
