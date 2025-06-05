using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleToDoList
{
    public partial class FormTaskEdit : Form
    {
        public TaskItem EditedTask { get; private set; }
        public bool IsSaved { get; private set; }
        public FormTaskEdit()
        {
            InitializeComponent();
            EditedTask = null;
            IsSaved = false;
        }
        public FormTaskEdit(TaskItem taskToEdit) : this()
        {
            if (taskToEdit == null) return;

            EditedTask = new TaskItem(taskToEdit.Description, taskToEdit.IsDone);

            textBoxDescription.Text = EditedTask.Description;
            checkBoxIsDone.Checked = EditedTask.IsDone;
        }

        private void FormTaskEdit_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                MessageBox.Show(
                    "Пожалуйста, введите текст задачи.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var desc = textBoxDescription.Text.Trim();
            var doneFlag = checkBoxIsDone.Checked;
            if (EditedTask == null)
            {
                EditedTask = new TaskItem(desc, doneFlag);
            }
            else
            {
                EditedTask.Description = desc;
                EditedTask.IsDone = doneFlag;
            }

            IsSaved = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            IsSaved = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
