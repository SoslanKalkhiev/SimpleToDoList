﻿namespace SimpleToDoList
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonToggleDone = new System.Windows.Forms.Button();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.dateTimePickerDue = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDone = new System.Windows.Forms.CheckBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(466, 231);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 40);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "button1";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(466, 289);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(89, 38);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "button2";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonToggleDone
            // 
            this.buttonToggleDone.Location = new System.Drawing.Point(466, 345);
            this.buttonToggleDone.Name = "buttonToggleDone";
            this.buttonToggleDone.Size = new System.Drawing.Size(89, 37);
            this.buttonToggleDone.TabIndex = 2;
            this.buttonToggleDone.Text = "button3";
            this.buttonToggleDone.UseVisualStyleBackColor = true;
            this.buttonToggleDone.Click += new System.EventHandler(this.buttonToggleDone_Click);
            // 
            // listBoxTasks
            // 
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
            this.dateTimePickerDue.Location = new System.Drawing.Point(451, 141);
            this.dateTimePickerDue.Name = "dateTimePickerDue";
            this.dateTimePickerDue.Size = new System.Drawing.Size(127, 20);
            this.dateTimePickerDue.TabIndex = 5;
            // 
            // checkBoxDone
            // 
            this.checkBoxDone.AutoSize = true;
            this.checkBoxDone.Location = new System.Drawing.Point(451, 167);
            this.checkBoxDone.Name = "checkBoxDone";
            this.checkBoxDone.Size = new System.Drawing.Size(80, 17);
            this.checkBoxDone.TabIndex = 6;
            this.checkBoxDone.Text = "checkBox1";
            this.checkBoxDone.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(448, 50);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 13);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "label1";
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(448, 125);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(35, 13);
            this.labelDueDate.TabIndex = 8;
            this.labelDueDate.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDueDate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.checkBoxDone);
            this.Controls.Add(this.dateTimePickerDue);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.buttonToggleDone);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Name = "MainForm";
            this.Text = "Form1";
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
    }
}

