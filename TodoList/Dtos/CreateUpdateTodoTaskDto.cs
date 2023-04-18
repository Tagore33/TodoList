
using TodoList.Aids.Enums;

namespace TodoList.Dtos
{
    public class CreateUpdateTodoTaskDto
    {
        public DateTime? TaskDate { get; init; }
        public string? Description { get; init; }
        public Priority TaskPriority { get; init; }
        public bool Completed { get; init; }
    }
}
