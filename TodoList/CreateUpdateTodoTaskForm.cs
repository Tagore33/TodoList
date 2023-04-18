using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoList.Aids.Enums;
using TodoList.Dtos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TodoList
{
    public partial class CreateUpdateTodoTaskForm : Form
    {
        private CreateUpdateTodoTaskDto _dataContext;
        public CreateUpdateTodoTaskForm()
        {
            var priorities = new BindingList<KeyValuePair<int, string>>();
            int count = 0;
            foreach (var i in Enum.GetNames(typeof(Priority)))
            {
                priorities.Add(new(count, i));
                count++;
            }

            InitializeComponent();
            todoTaskPriorityComboBox.DataSource = priorities;
            todoTaskPriorityComboBox.ValueMember = "Key";
            todoTaskPriorityComboBox.DisplayMember = "Value";
        }
        public CreateUpdateTodoTaskDto DataContext
        {
            get
            {
                _dataContext = new CreateUpdateTodoTaskDto()
                {
                    Description = todoTaskDescriptionTextBox.Text,
                    TaskDate = todoTaskDateTimePicker.Value,
                    TaskPriority = (Priority)todoTaskPriorityComboBox.SelectedIndex,
                    Completed = taskStatusCheckBox.Checked
                };
                return _dataContext;
            }
            set
            {
                _dataContext = value;
                todoTaskPriorityComboBox.SelectedIndex = todoTaskPriorityComboBox.FindString(Convert.ToString(_dataContext.TaskPriority));
                todoTaskDescriptionTextBox.Text = _dataContext.Description;
                todoTaskDateTimePicker.Value = _dataContext.TaskDate != null ? _dataContext.TaskDate.Value : DateTime.Now.Date;
                taskStatusCheckBox.Checked = _dataContext.Completed;
            }
        }
    }
}
