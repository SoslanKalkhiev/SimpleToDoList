using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleToDoList
{
    public partial class MainForm : Form
    {
        private List<ToDoItem> tasks = new List<ToDoItem>();
        private readonly string _filePath = Path.Combine(
           Application.StartupPath,
           "tasks.txt");
        public MainForm()
        {
            InitializeComponent();
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
            RefreshTasksList();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int idx = listBoxTasks.SelectedIndex;
            if (idx >= 0 && idx < tasks.Count)
            {
                tasks.RemoveAt(idx);
                RefreshTasksList();
            }
        }

        private void buttonToggleDone_Click(object sender, EventArgs e)
        {
            int idx = listBoxTasks.SelectedIndex;
            if (idx >= 0 && idx < tasks.Count)
            {
                tasks[idx].IsDone = !tasks[idx].IsDone;
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

        private void checkBoxDone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelDueDate_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTasksFromFile();
            RefreshTasksList();
        }
        private void SaveTasksToFile()
        {
            try
            {
                using (var writer = new StreamWriter(_filePath, false))
                {
                    foreach (var t in tasks)
                    {
                        // var safeDesc = t.Description.Replace("|", "¦");
                        // writer.WriteLine($"{safeDesc}|{t.IsDone}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не удалось сохранить задачи в файл:\n" + ex.Message,
                    "Ошибка записи",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadTasksFromFile()
        {
            tasks.Clear();
            if (!File.Exists(_filePath))
                return;

            try
            {
                var lines = File.ReadAllLines(_filePath);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    // Ожидаем формат: Description|IsDone
                    var parts = line.Split(new[] { '|' }, 2);
                    if (parts.Length < 2) continue;

                    var desc = parts[0].Replace("¦", "|");
                    if (bool.TryParse(parts[1], out bool doneFlag))
                    {
                        //tasks.Add(new TaskItem(desc, doneFlag));
                    }
                    else
                    {
                        //tasks.Add(new TaskItem(desc, false));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не удалось загрузить задачи из файла:\n" + ex.Message,
                    "Ошибка чтения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}