namespace TodoList
{
    partial class CreateUpdateTodoTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            todoTaskPriorityComboBox = new ComboBox();
            todoTaskDescriptionTextBox = new TextBox();
            todoTaskPriorityLabel = new Label();
            todoTaskDescriptionLabel = new Label();
            cancelButton = new Button();
            confirmButton = new Button();
            taskStatusCheckBox = new CheckBox();
            todoTaskDateTimePicker = new DateTimePicker();
            label1 = new Label();
            todoTaskDueDate = new Label();
            SuspendLayout();
            // 
            // todoTaskPriorityComboBox
            // 
            todoTaskPriorityComboBox.FormattingEnabled = true;
            todoTaskPriorityComboBox.Location = new Point(225, 17);
            todoTaskPriorityComboBox.Name = "todoTaskPriorityComboBox";
            todoTaskPriorityComboBox.Size = new Size(121, 25);
            todoTaskPriorityComboBox.TabIndex = 1;
            // 
            // todoTaskDescriptionTextBox
            // 
            todoTaskDescriptionTextBox.Location = new Point(225, 104);
            todoTaskDescriptionTextBox.Multiline = true;
            todoTaskDescriptionTextBox.Name = "todoTaskDescriptionTextBox";
            todoTaskDescriptionTextBox.Size = new Size(340, 153);
            todoTaskDescriptionTextBox.TabIndex = 0;
            // 
            // todoTaskPriorityLabel
            // 
            todoTaskPriorityLabel.AutoSize = true;
            todoTaskPriorityLabel.Location = new Point(140, 20);
            todoTaskPriorityLabel.Name = "todoTaskPriorityLabel";
            todoTaskPriorityLabel.Size = new Size(54, 17);
            todoTaskPriorityLabel.TabIndex = 2;
            todoTaskPriorityLabel.Text = "Priority";
            // 
            // todoTaskDescriptionLabel
            // 
            todoTaskDescriptionLabel.AutoSize = true;
            todoTaskDescriptionLabel.Location = new Point(140, 104);
            todoTaskDescriptionLabel.Name = "todoTaskDescriptionLabel";
            todoTaskDescriptionLabel.Size = new Size(79, 17);
            todoTaskDescriptionLabel.TabIndex = 3;
            todoTaskDescriptionLabel.Text = "Description";
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(490, 307);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            confirmButton.DialogResult = DialogResult.OK;
            confirmButton.Location = new Point(398, 307);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(75, 23);
            confirmButton.TabIndex = 5;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            // 
            // taskStatusCheckBox
            // 
            taskStatusCheckBox.AutoSize = true;
            taskStatusCheckBox.Location = new Point(224, 288);
            taskStatusCheckBox.Name = "taskStatusCheckBox";
            taskStatusCheckBox.Size = new Size(79, 21);
            taskStatusCheckBox.TabIndex = 6;
            taskStatusCheckBox.Text = "Finished";
            taskStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // todoTaskDateTimePicker
            // 
            todoTaskDateTimePicker.Location = new Point(224, 58);
            todoTaskDateTimePicker.Name = "todoTaskDateTimePicker";
            todoTaskDateTimePicker.Size = new Size(200, 25);
            todoTaskDateTimePicker.TabIndex = 7;
            todoTaskDateTimePicker.Value = new DateTime(2023, 4, 18, 9, 0, 20, 0);
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 9;
            // 
            // todoTaskDueDate
            // 
            todoTaskDueDate.AutoSize = true;
            todoTaskDueDate.Location = new Point(140, 64);
            todoTaskDueDate.Name = "todoTaskDueDate";
            todoTaskDueDate.Size = new Size(66, 17);
            todoTaskDueDate.TabIndex = 8;
            todoTaskDueDate.Text = "Due Date";
            // 
            // AddEditTodoTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 379);
            Controls.Add(todoTaskDueDate);
            Controls.Add(label1);
            Controls.Add(todoTaskDateTimePicker);
            Controls.Add(taskStatusCheckBox);
            Controls.Add(confirmButton);
            Controls.Add(cancelButton);
            Controls.Add(todoTaskDescriptionLabel);
            Controls.Add(todoTaskPriorityLabel);
            Controls.Add(todoTaskPriorityComboBox);
            Controls.Add(todoTaskDescriptionTextBox);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "AddEditTodoTaskForm";
            Text = "AddEditTodoTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox todoTaskPriorityComboBox;
        private TextBox todoTaskDescriptionTextBox;
        private Label todoTaskPriorityLabel;
        private Label todoTaskDescriptionLabel;
        private Button cancelButton;
        private Button confirmButton;
        private CheckBox taskStatusCheckBox;
        private DateTimePicker todoTaskDateTimePicker;
        private Label label1;
        private Label todoTaskDueDate;
    }
}