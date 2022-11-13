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
using System.Xml.Serialization;

namespace Task5
{



    public partial class FormChild : Form
    {
        [Serializable]
        public class Employee
        {
            private int id;
            public string SurName { get; set; }
            public string Name { get; set; }
            public string MiddleName { get; set; }
            public DateTime BirthDay { get; set; }
            public string PlaceBirth { get; set; }
            [NonSerialized]
            private string DateTimeCreateObject = DateTime.Now.ToShortDateString();

            public Employee() { }

            public Employee(int id, string surName, string name, string middleName, DateTime birthDay, string placeBirth)
            {
                this.id = id;
                this.SurName = surName ?? "Нет фамилии";
                this.Name = name ?? "Нет имени";
                this.MiddleName = middleName ?? "Нет отчества";
                this.BirthDay = birthDay;
                this.PlaceBirth = placeBirth ?? "Нет места рождения";
            }

            public int Id
            {
                get
                {
                    return id;
                }
            }
        }

        public List<Employee> employees = new List<Employee>();

        public FormChild(int numberFormChild)
        {         
            InitializeComponent();
            this.Text = "Number form child " + numberFormChild;
            this.Name += $"{ numberFormChild}";
            Employee student = new Employee(employees.Count + 1, "Тухтаров", "Марат", "Ринадович", new DateTime(1988, 3, 7), "Калининград");
            employees.Add(student);
            dataGridViewEmployees.DataSource = employees;
        }



        private void FormChild_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee(employees.Count + 1, textBoxSurName.Text, textBoxName.Text, textBoxMiddleName.Text, dateTimePickerBirthDay.Value, textBoxPlaceBirth.Text);
            employees.Add(newEmployee);
            UpdateEmployee();
        }

        private void UpdateEmployee()
        {
            dataGridViewEmployees.DataSource = null;
            dataGridViewEmployees.DataSource = employees;
        }

        private void buttonRemoveEmployee_Click(object sender, EventArgs e)
        {
            int idEmployeeSelect = int.Parse(dataGridViewEmployees[5, dataGridViewEmployees.CurrentCell.RowIndex].Value.ToString());
            Employee removeEmployee = employees.First(Employee => Employee.Id == idEmployeeSelect);
            employees.Remove(removeEmployee);
            UpdateEmployee();

        }

        private void buttonSaveXMLFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML файлы|*.xml";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Employee>));
                try
                {
                    using(Stream stream = File.Create(saveFileDialog.FileName))
                    {
                        xmlFormat.Serialize(stream, employees);
                    }
                    MessageBox.Show("XmlSerialize OK!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
