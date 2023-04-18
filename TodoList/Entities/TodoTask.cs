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
        public Guid taskId { get;init;}
        public bool completed { get;init; }=false;
        public DateTime taskDate { get;init;}
        public string? description { get;init;}
        public Priority taskPriority { get; init; }
    }
}
