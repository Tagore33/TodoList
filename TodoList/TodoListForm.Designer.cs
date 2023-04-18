namespace TodoList
{
    partial class TodoListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            todoTasksGridView = new DataGridView();
            todoTaskEditButton = new Button();
            todoTaskAddButton = new Button();
            todoTaskDeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)todoTasksGridView).BeginInit();
            SuspendLayout();
            // 
            // todoTasksGridView
            // 
            todoTasksGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todoTasksGridView.Location = new Point(44, 81);
            todoTasksGridView.Name = "todoTasksGridView";
            todoTasksGridView.RowTemplate.Height = 25;
            todoTasksGridView.Size = new Size(981, 341);
            todoTasksGridView.TabIndex = 1;
            // 
            // todoTaskEditButton
            // 
            todoTaskEditButton.Location = new Point(148, 36);
            todoTaskEditButton.Name = "todoTaskEditButton";
            todoTaskEditButton.Size = new Size(75, 23);
            todoTaskEditButton.TabIndex = 2;
            todoTaskEditButton.Text = "Edit Task";
            todoTaskEditButton.UseVisualStyleBackColor = true;
            todoTaskEditButton.Click += todoTaskEditButton_Click;
            // 
            // todoTaskAddButton
            // 
            todoTaskAddButton.Location = new Point(44, 36);
            todoTaskAddButton.Name = "todoTaskAddButton";
            todoTaskAddButton.Size = new Size(75, 23);
            todoTaskAddButton.TabIndex = 3;
            todoTaskAddButton.Text = "Add Task";
            todoTaskAddButton.UseVisualStyleBackColor = true;
            todoTaskAddButton.Click += todoTaskAddButton_Click;
            // 
            // todoTaskDeleteButton
            // 
            todoTaskDeleteButton.Location = new Point(257, 36);
            todoTaskDeleteButton.Name = "todoTaskDeleteButton";
            todoTaskDeleteButton.Size = new Size(75, 23);
            todoTaskDeleteButton.TabIndex = 4;
            todoTaskDeleteButton.Text = "Delete";
            todoTaskDeleteButton.UseVisualStyleBackColor = true;
            todoTaskDeleteButton.Click += todoTaskDeleteButton_Click;
            // 
            // TodoListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 434);
            Controls.Add(todoTaskDeleteButton);
            Controls.Add(todoTaskAddButton);
            Controls.Add(todoTaskEditButton);
            Controls.Add(todoTasksGridView);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "TodoListForm";
            Text = "Todo List";
            Load += TodoListForm_Load;
            ((System.ComponentModel.ISupportInitialize)todoTasksGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView todoTasksGridView;
        private Button todoTaskEditButton;
        private Button todoTaskAddButton;
        private Button todoTaskDeleteButton;
    }
}