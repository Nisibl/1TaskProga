namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.OutputTableStudentsButton = new System.Windows.Forms.Button();
            this.OutputGistogramOfStudentsButton = new System.Windows.Forms.Button();
            this.FillTableDemoDataButton = new System.Windows.Forms.Button();
            this.InputNameLabel = new System.Windows.Forms.Label();
            this.InputNameTextBox = new System.Windows.Forms.TextBox();
            this.InputSpecialityTextBox = new System.Windows.Forms.TextBox();
            this.InputSpecialityLabel = new System.Windows.Forms.Label();
            this.InputGroupTextBox = new System.Windows.Forms.TextBox();
            this.InputGroupLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(12, 12);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(285, 52);
            this.AddStudentButton.TabIndex = 0;
            this.AddStudentButton.Text = "Добавить Студента";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Location = new System.Drawing.Point(12, 70);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(285, 52);
            this.DeleteStudentButton.TabIndex = 1;
            this.DeleteStudentButton.Text = "Удалить Студента";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // OutputTableStudentsButton
            // 
            this.OutputTableStudentsButton.Location = new System.Drawing.Point(12, 128);
            this.OutputTableStudentsButton.Name = "OutputTableStudentsButton";
            this.OutputTableStudentsButton.Size = new System.Drawing.Size(285, 52);
            this.OutputTableStudentsButton.TabIndex = 2;
            this.OutputTableStudentsButton.Text = "Вывести Таблицу студентов";
            this.OutputTableStudentsButton.UseVisualStyleBackColor = true;
            this.OutputTableStudentsButton.Click += new System.EventHandler(this.OutputTableStudentsButton_Click);
            // 
            // OutputGistogramOfStudentsButton
            // 
            this.OutputGistogramOfStudentsButton.Location = new System.Drawing.Point(12, 186);
            this.OutputGistogramOfStudentsButton.Name = "OutputGistogramOfStudentsButton";
            this.OutputGistogramOfStudentsButton.Size = new System.Drawing.Size(285, 52);
            this.OutputGistogramOfStudentsButton.TabIndex = 3;
            this.OutputGistogramOfStudentsButton.Text = "Вывести Гистограмму Студентов";
            this.OutputGistogramOfStudentsButton.UseVisualStyleBackColor = true;
            this.OutputGistogramOfStudentsButton.Click += new System.EventHandler(this.OutputGistogramOfStudentsButton_Click);
            // 
            // FillTableDemoDataButton
            // 
            this.FillTableDemoDataButton.Location = new System.Drawing.Point(12, 244);
            this.FillTableDemoDataButton.Name = "FillTableDemoDataButton";
            this.FillTableDemoDataButton.Size = new System.Drawing.Size(285, 52);
            this.FillTableDemoDataButton.TabIndex = 4;
            this.FillTableDemoDataButton.Text = "Заполнить таблицу демонстрационными данными";
            this.FillTableDemoDataButton.UseVisualStyleBackColor = true;
            this.FillTableDemoDataButton.Click += new System.EventHandler(this.FillTableDemoDataButton_Click);
            // 
            // InputNameLabel
            // 
            this.InputNameLabel.AutoSize = true;
            this.InputNameLabel.Location = new System.Drawing.Point(303, 30);
            this.InputNameLabel.Name = "InputNameLabel";
            this.InputNameLabel.Size = new System.Drawing.Size(159, 16);
            this.InputNameLabel.TabIndex = 5;
            this.InputNameLabel.Text = "Введите Имя студента:";
            // 
            // InputNameTextBox
            // 
            this.InputNameTextBox.Location = new System.Drawing.Point(306, 63);
            this.InputNameTextBox.Name = "InputNameTextBox";
            this.InputNameTextBox.Size = new System.Drawing.Size(262, 22);
            this.InputNameTextBox.TabIndex = 6;
            // 
            // InputSpecialityTextBox
            // 
            this.InputSpecialityTextBox.Location = new System.Drawing.Point(306, 147);
            this.InputSpecialityTextBox.Name = "InputSpecialityTextBox";
            this.InputSpecialityTextBox.Size = new System.Drawing.Size(262, 22);
            this.InputSpecialityTextBox.TabIndex = 8;
            // 
            // InputSpecialityLabel
            // 
            this.InputSpecialityLabel.AutoSize = true;
            this.InputSpecialityLabel.Location = new System.Drawing.Point(303, 115);
            this.InputSpecialityLabel.Name = "InputSpecialityLabel";
            this.InputSpecialityLabel.Size = new System.Drawing.Size(234, 16);
            this.InputSpecialityLabel.TabIndex = 7;
            this.InputSpecialityLabel.Text = "Введите Специальность студента:";
            // 
            // InputGroupTextBox
            // 
            this.InputGroupTextBox.Location = new System.Drawing.Point(306, 236);
            this.InputGroupTextBox.Name = "InputGroupTextBox";
            this.InputGroupTextBox.Size = new System.Drawing.Size(262, 22);
            this.InputGroupTextBox.TabIndex = 10;
            // 
            // InputGroupLabel
            // 
            this.InputGroupLabel.AutoSize = true;
            this.InputGroupLabel.Location = new System.Drawing.Point(303, 204);
            this.InputGroupLabel.Name = "InputGroupLabel";
            this.InputGroupLabel.Size = new System.Drawing.Size(180, 16);
            this.InputGroupLabel.TabIndex = 9;
            this.InputGroupLabel.Text = "Введите Группу студента:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(585, 312);
            this.Controls.Add(this.InputGroupTextBox);
            this.Controls.Add(this.InputGroupLabel);
            this.Controls.Add(this.InputSpecialityTextBox);
            this.Controls.Add(this.InputSpecialityLabel);
            this.Controls.Add(this.InputNameTextBox);
            this.Controls.Add(this.InputNameLabel);
            this.Controls.Add(this.FillTableDemoDataButton);
            this.Controls.Add(this.OutputGistogramOfStudentsButton);
            this.Controls.Add(this.OutputTableStudentsButton);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.AddStudentButton);
            this.Name = "Form1";
            this.Text = "DecanatPRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.Button OutputTableStudentsButton;
        private System.Windows.Forms.Button OutputGistogramOfStudentsButton;
        private System.Windows.Forms.Button FillTableDemoDataButton;
        private System.Windows.Forms.Label InputNameLabel;
        private System.Windows.Forms.TextBox InputNameTextBox;
        private System.Windows.Forms.TextBox InputSpecialityTextBox;
        private System.Windows.Forms.Label InputSpecialityLabel;
        private System.Windows.Forms.TextBox InputGroupTextBox;
        private System.Windows.Forms.Label InputGroupLabel;
    }
}

