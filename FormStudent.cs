using StudentManagementSQLite.Data;
using StudentManagementSQLite.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagementSQLite
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void LoadStudents()
        {
            using (var context = new AppDbContext())
            {
                dataGridViewStudents.DataSource = context.Students.ToList();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var student = new Student
                {
                    Name = textBoxName.Text,
                    Age = int.Parse(textBoxAge.Text),
                    Course = textBoxCourse.Text
                };

                context.Students.Add(student);
                context.SaveChanges();
            }

            MessageBox.Show("Student Added Successfully!");
            LoadStudents();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells["Id"].Value);

                using (var context = new AppDbContext())
                {
                    var student = context.Students.Find(id);
                    if (student != null)
                    {
                        student.Name = textBoxName.Text;
                        student.Age = int.Parse(textBoxAge.Text);
                        student.Course = textBoxCourse.Text;

                        context.SaveChanges();
                        MessageBox.Show("Student Updated Successfully!");
                        LoadStudents();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells["Id"].Value);

                using (var context = new AppDbContext())
                {
                    var student = context.Students.Find(id);
                    if (student != null)
                    {
                        context.Students.Remove(student);
                        context.SaveChanges();
                        MessageBox.Show("Student Deleted Successfully!");
                        LoadStudents();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxName.Text = dataGridViewStudents.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                textBoxAge.Text = dataGridViewStudents.Rows[e.RowIndex].Cells["Age"].Value.ToString();
                textBoxCourse.Text = dataGridViewStudents.Rows[e.RowIndex].Cells["Course"].Value.ToString();
            }
        }
    }
}
