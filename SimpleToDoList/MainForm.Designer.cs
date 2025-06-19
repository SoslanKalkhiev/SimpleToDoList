namespace SimpleToDoList
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonToggleDone = new System.Windows.Forms.Button();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.dateTimePickerDue = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDone = new System.Windows.Forms.CheckBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(417, 237);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 48);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemove.Location = new System.Drawing.Point(551, 237);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(96, 48);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Убрать";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonToggleDone
            // 
            this.buttonToggleDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToggleDone.Location = new System.Drawing.Point(417, 321);
            this.buttonToggleDone.Name = "buttonToggleDone";
            this.buttonToggleDone.Size = new System.Drawing.Size(96, 48);
            this.buttonToggleDone.TabIndex = 2;
            this.buttonToggleDone.Text = "Изменить состояние";
            this.buttonToggleDone.UseVisualStyleBackColor = true;
            this.buttonToggleDone.Click += new System.EventHandler(this.buttonToggleDone_Click);
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(26, 53);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(357, 329);
            this.listBoxTasks.TabIndex = 3;
            this.listBoxTasks.SelectedIndexChanged += new System.EventHandler(this.listBoxTasks_SelectedIndexChanged);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(451, 79);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(127, 20);
            this.textBoxTitle.TabIndex = 4;
            // 
            // dateTimePickerDue
            // 
            this.dateTimePickerDue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerDue.Location = new System.Drawing.Point(451, 141);
            this.dateTimePickerDue.Name = "dateTimePickerDue";
            this.dateTimePickerDue.Size = new System.Drawing.Size(127, 20);
            this.dateTimePickerDue.TabIndex = 5;
            // 
            // checkBoxDone
            // 
            this.checkBoxDone.AutoSize = true;
            this.checkBoxDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDone.Location = new System.Drawing.Point(451, 167);
            this.checkBoxDone.Name = "checkBoxDone";
            this.checkBoxDone.Size = new System.Drawing.Size(83, 17);
            this.checkBoxDone.TabIndex = 6;
            this.checkBoxDone.Text = "Выполнено";
            this.checkBoxDone.UseVisualStyleBackColor = true;
            this.checkBoxDone.CheckedChanged += new System.EventHandler(this.checkBoxDone_CheckedChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.labelTitle.Location = new System.Drawing.Point(448, 63);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(79, 13);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Введите дело:";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(448, 125);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(77, 13);
            this.labelDueDate.TabIndex = 8;
            this.labelDueDate.Text = "Введите дату:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Location = new System.Drawing.Point(551, 321);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(96, 48);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelDueDate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.checkBoxDone);
            this.Controls.Add(this.dateTimePickerDue);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.buttonToggleDone);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Список дел";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonToggleDone;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerDue;
        private System.Windows.Forms.CheckBox checkBoxDone;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Button buttonEdit;
    }
}

