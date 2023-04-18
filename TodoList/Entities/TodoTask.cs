using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using TodoList.Aids.Enums;

namespace TodoList.Entities
{
    public class TodoTask
    {
        public Guid TaskId { get;init;}
        public bool Completed { get;init; }=false;
        public DateTime TaskDate { get;init;}
        public string? Description { get;init;}
        public Priority TaskPriority { get; init; }
    }
}
