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

            foreach (var i in Enum.GetNames(typeof(Priority)))
            {
                int count = 1;
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
                    description = todoTaskDescriptionTextBox.Text,
                    taskDate = todoTaskDateTimePicker.Value,
                    taskPriority = (Priority)todoTaskPriorityComboBox.SelectedIndex,
                    completed = taskStatusCheckBox.Checked == false ? false : true,
                };
                return _dataContext;
            }
            set
            {
                _dataContext = value;
                todoTaskPriorityComboBox.SelectedIndex = todoTaskPriorityComboBox.FindString(Convert.ToString(_dataContext.taskPriority));
                todoTaskDescriptionTextBox.Text = _dataContext.description;
                todoTaskDateTimePicker.Value = _dataContext.taskDate != null ? _dataContext.taskDate.Value : DateTime.Now.Date;
                taskStatusCheckBox.Checked = _dataContext.completed;
            }
        }
    }
}
