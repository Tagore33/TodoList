using TodoList.Entities;
using TodoList.Repsotiory;
using TodoList.Aids.Enums;
using TodoList.Dtos;
using TodoList.Aids;

namespace TodoList
{
    public partial class TodoListForm : Form
    {
        private readonly ITodoTasksRepository _repository;
        private BindingSource _datasource;
        public TodoListForm(ITodoTasksRepository repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        private void TodoListForm_Load(object sender, EventArgs e)
        {
            CustomizeTodoTaskGridView();
            todoTasksGridView.DataSource = _repository.GetTodoTasks().AsReadDtos();
            SetTodoTasksPrioirtyColor();
        }

        private void todoTaskEditButton_Click(object sender, EventArgs e)
        {
            if (todoTasksGridView.SelectedRows.Count != 0)
            {
                DataGridViewRow row = todoTasksGridView.SelectedRows[0];
                CreateUpdateTodoTaskDto taskToEdit = new CreateUpdateTodoTaskDto
                {
                    TaskDate = (DateTime)row.Cells["taskDate"].Value,
                    TaskPriority = (Priority)row.Cells["taskPriority"].Value,
                    Completed = (string)row.Cells["taskStatus"].Value != "unfinished" ? true : false,
                    Description = (string)row.Cells["description"].Value
                };
                using (var form = new CreateUpdateTodoTaskForm())
                {
                    form.DataContext = taskToEdit;

                    if (form.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    taskToEdit = form.DataContext;
                }
                _repository.UpdateTodoTask(new TodoTask
                {
                    TaskId = (Guid)row.Cells["taskId"].Value,
                    TaskDate = (DateTime)taskToEdit.TaskDate,
                    TaskPriority = taskToEdit.TaskPriority,
                    Completed = taskToEdit.Completed,
                    Description = taskToEdit.Description
                });

                UpdateGridView();
            }
        }

        private void todoTaskAddButton_Click(object sender, EventArgs e)
        {
            CreateUpdateTodoTaskDto newTask = new CreateUpdateTodoTaskDto();

            using (var form = new CreateUpdateTodoTaskForm())
            {
                form.Text = "Create New Task";
                form.DataContext = newTask;

                if (form.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                newTask = form.DataContext;
            }

            _repository.CreateTodoTask(new TodoTask()
            {
                Completed = newTask.Completed,
                Description = newTask.Description,
                TaskPriority = newTask.TaskPriority,
                TaskDate = (DateTime)newTask.TaskDate,
                TaskId = Guid.NewGuid()
            });
            UpdateGridView();
        }
        private void todoTaskDeleteButton_Click(object sender, EventArgs e)
        {
            if (todoTasksGridView.SelectedRows.Count != 0)
            {
                Guid selectedTaskID = (Guid)todoTasksGridView.SelectedRows[0].Cells["taskId"].Value;
                string selectedTaskDescription = (string)todoTasksGridView.SelectedRows[0].Cells["description"].Value;

                if (MessageBox.Show("Delete task: " + selectedTaskDescription + "?", "Delete a Task", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            _repository.DeleteTodoTask(selectedTaskID);
            UpdateGridView();
            }
        }

        public void UpdateGridView()
        {
            todoTasksGridView.DataSource = _repository.GetTodoTasks().AsReadDtos();
            SetTodoTasksPrioirtyColor();
        }
        private void CustomizeTodoTaskGridView()
        {
            todoTasksGridView.AutoGenerateColumns = false;
            todoTasksGridView.Columns.Clear();
            todoTasksGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            todoTasksGridView.MultiSelect = false;
            todoTasksGridView.ReadOnly = true;

            var taskId = new DataGridViewTextBoxColumn { DataPropertyName = "taskId", Name = "taskId", HeaderText = "ID", Width = 50 };
            var taskStatus = new DataGridViewTextBoxColumn { DataPropertyName = "taskStatus", Name = "taskStatus", HeaderText = "Status", Width = 150 };
            var taskPriority = new DataGridViewTextBoxColumn { DataPropertyName = "taskPriority", Name = "taskPriority", HeaderText = "Priority", Width = 100 };
            var taskDate = new DataGridViewTextBoxColumn { DataPropertyName = "taskDate", Name = "taskDate", HeaderText = "Task due date", Width = 150 };
            var description = new DataGridViewTextBoxColumn { DataPropertyName = "description", Name = "description", HeaderText = "Description", Width = 350 };
            todoTasksGridView.Columns.AddRange(new[] { taskId, taskStatus, taskPriority, taskDate, description });
        }
        private void SetTodoTasksPrioirtyColor()
        {
            foreach (DataGridViewRow row in todoTasksGridView.Rows)
            {
                var priorityValue = Convert.ToString(row.Cells["taskPriority"].Value);

                if (priorityValue == Convert.ToString(Priority.Low))
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else if (priorityValue == Convert.ToString(Priority.Medium))
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            todoTasksGridView.ClearSelection();
        }

    }
}