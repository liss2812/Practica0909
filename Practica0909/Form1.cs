using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica0909
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetNames_Click(object sender, EventArgs e)
        {
           
            selectName();
        }
  
        private void selectName()
        {
        
            List<string> query = (
                from student in Student.GetStudents()
                select student.firstName
                ).ToList();
          
            foreach (var name in query)
            {   
                lstNames.Items.Add(name);
            }
        }

        private void btnGetData_Click_1(object sender, EventArgs e)
        {
            dgData.Columns.Add("idStudent", "CODIGO");
            dgData.Columns.Add("firstName", "NOMBRE");
            dgData.Columns.Add("lastName", "APELLIDO");
            dgData.Columns.Add("age", "EDAD");
            dgData.Columns.Add("nacionalidades", "NACIONALIDAD");
            foreach (var student in selectAllData())
            {
                dgData.Rows.Add(student.idStudent, student.firstName, student.lastName, student.age, student.nacionalidades);

            }
        }
                private List<Student> selectAllData()
                {
                    List<Student> query = (
                        from student in Student.GetStudents()
                        select new Student()
                        {
                            idStudent = student.idStudent,
                            firstName = student.firstName,
                            lastName = student.lastName,
                            age = student.age,
                            nacionalidades = student.nacionalidades
                        }
                        ).ToList();
                    return query;
                }
            }
        }
    
    