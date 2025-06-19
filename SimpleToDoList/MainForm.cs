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
    public partial class MainForm : Form
    {
        private List<ToDoItem> tasks = new List<ToDoItem>();
        public MainForm()
        {
            InitializeComponent();
            tasks = ToDoStorage.Load();
            RefreshTasksList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
        string title = textBoxTitle.Text.Trim();
            DateTime due = dateTimePickerDue.Value.Date;
            if (string.IsNullOrEmpty(title))
            {
                return;
            }
            var newItem = new ToDoItem(title, due)
            {
                IsDone = checkBoxDone.Checked
            };

            tasks.Add(newItem);
            textBoxTitle.Text = "";
            checkBoxDone.Checked = false;
            dateTimePickerDue.Value = DateTime.Today;
            ToDoStorage.Save(tasks);    
            RefreshTasksList();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int idx = listBoxTasks.SelectedIndex;
            if (idx >= 0 && idx < tasks.Count)
            {
                tasks.RemoveAt(idx);
                ToDoStorage.Save(tasks);
                RefreshTasksList();
            }
        }

        private void buttonToggleDone_Click(object sender, EventArgs e)
        {
            int idx = listBoxTasks.SelectedIndex;
            if (idx >= 0 && idx < tasks.Count)
            {
                tasks[idx].IsDone = !tasks[idx].IsDone;
                ToDoStorage.Save(tasks);
                RefreshTasksList();
            }
        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                buttonToggleDone.Enabled = true;
                checkBoxDone.Checked = tasks[listBoxTasks.SelectedIndex].IsDone;
            }
            else
            {
                buttonToggleDone.Enabled = false;
                checkBoxDone.Checked = false;
            }
        }

        private void RefreshTasksList()
        {
            listBoxTasks.Items.Clear();
            foreach (var t in tasks)
            {
                listBoxTasks.Items.Add(t);
            }
            for (int i = 0; i < tasks.Count; i++)
            {
                if (!tasks[i].IsDone && tasks[i].DueDate < DateTime.Today)
                {
                    listBoxTasks.ForeColor = Color.Black; 
                    listBoxTasks.ForeColor = Color.Red;
                    break;
                }
                else
                {
                    listBoxTasks.ForeColor = Color.Black;
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem is ToDoItem item)
            {
             
                using (var editForm = new FormEdit(item))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        ToDoStorage.Save(tasks);
                        RefreshTasksList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите дело из списка.", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
