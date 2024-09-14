using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Logic logic = new Logic();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            logic.AddStudent(InputNameTextBox.Text, InputSpecialityTextBox.Text, InputGroupTextBox.Text);
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            logic.DeleteStudent(InputNameTextBox.Text, InputSpecialityTextBox.Text, InputGroupTextBox.Text);
        }

        private void OutputTableStudentsButton_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm(logic);
            tableForm.ShowDialog();
        }

        private void FillTableDemoDataButton_Click(object sender, EventArgs e)
        {
            logic.FillTableWithDemoData();
        }

        private void OutputGistogramOfStudentsButton_Click(object sender, EventArgs e)
        {
            GistogramForm gistogramForm = new GistogramForm(logic);
            gistogramForm.ShowDialog();
        }
    }
}
