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
    public partial class FormEdit : Form
    {
        private readonly ToDoItem _item;
        public FormEdit(ToDoItem item)
        {
            InitializeComponent();
            _item = item;
            textBoxText.Text = _item.Title;
            dateTimePickerDue.Value = _item.DueDate;
            buttonOK.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
        }
        

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            _item.Title = textBoxText.Text;
            _item.DueDate = dateTimePickerDue.Value;
        }
    }
}
