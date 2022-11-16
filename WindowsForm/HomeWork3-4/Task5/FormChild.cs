using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
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
            [XmlAttribute("Id")]
            public int Id { get; set; }
            public string SurName { get; set; }
            public string Name { get; set; }
            public string MiddleName { get; set; }
            public DateTime BirthDay { get; set; }
            public string PlaceBirth { get; set; }
            [XmlIgnore]
            public DateTime DateTimeCreateObject;

            public Employee() { }

            public Employee(int id, string surName, string name, string middleName, DateTime birthDay, string placeBirth)
            {
                this.Id = id;
                this.SurName = (surName.Length > 0) ? surName : "Нет фамилии";
                this.Name = (name.Length > 0) ? name: "Нет имени";
                this.MiddleName = (middleName.Length > 0) ? middleName : "Нет отчества";
                this.BirthDay = birthDay;
                this.PlaceBirth = (placeBirth.Length > 0) ? placeBirth : "Нет места рождения";
            }

            //Вызывется во время процесса сериализации
            private void OnSerializing(StreamingContext context)
            {
                DateTimeCreateObject = DateTimeCreateObject.ToUniversalTime();
            }

            //вызывается по завершению процесса десериализации
            [OnDeserialized]
            private void OnDeserialized(StreamingContext context)
            {
                DateTimeCreateObject = DateTime.Now;
            }
        }
        private List<Employee> employees = new List<Employee>();

        public FormChild(int numberFormChild)
        {         
            InitializeComponent();
            this.Text = "Number form child " + numberFormChild;
            this.Name += $"{ numberFormChild}";
            Employee student = new Employee(employees.Count + 1, "Тухтаров", "Марат", "Ринадович", new DateTime(1988, 3, 7), "Калининград");
            employees.Add(student);
            dataGridViewEmployees.DataSource = employees;
        }

        public void DataTransfer(List<Employee> newEmployess)
        {
            employees.Clear();
            employees.AddRange(newEmployess);
            UpdateEmployee();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee(employees.Count + 1, textBoxSurName.Text, textBoxName.Text, textBoxMiddleName.Text, dateTimePickerBirthDay.Value.Date, textBoxPlaceBirth.Text);
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
            int idEmployeeSelect = int.Parse(dataGridViewEmployees[0, dataGridViewEmployees.CurrentCell.RowIndex].Value.ToString());
            Employee removeEmployee = employees.First(Employee => Employee.Id == idEmployeeSelect);
            employees.Remove(removeEmployee);
            UpdateEmployee();

        }

        private void buttonSaveOtherXMLFile_Click(object sender, EventArgs e)
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
                    textBoxCurrentFilePath.Text = saveFileDialog.FileName;
                    MessageBox.Show("Файл успешно сохранен", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonLoadXMLFile_Click(object sender, EventArgs e)
        {
            XmlSerializer xmkFormat = new XmlSerializer(typeof(List<Employee>));
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "XML файлы|*.xml";
                openFileDialog.FilterIndex = 1;
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    employees.Clear();
                    textBoxCurrentFilePath.Text = openFileDialog.FileName;
                    using (Stream stream = File.OpenRead(openFileDialog.FileName))
                    {
                        employees = (List<Employee>)xmkFormat.Deserialize(stream);
                        UpdateEmployee();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveXMLFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBoxCurrentFilePath.Text) == false)
            {
                MessageBox.Show("Указанный путь к файлу не существует", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Employee>));
                try
                {
                    using (Stream stream = File.Create(textBoxCurrentFilePath.Text))
                    {
                        xmlFormat.Serialize(stream, employees);
                    }
                    MessageBox.Show("Файл успешно сохранен", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonGetChildForms_Click(object sender, EventArgs e)
        {
            foreach (Form forms in this.ParentForm.MdiChildren)
            {
                listBoxChildForms.Items.Add(forms.ToString());
            }
        }

        private void buttonDataTransfer_Click(object sender, EventArgs e)
        {
            if (listBoxChildForms.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите форму из списка для передачи данных", "Transfer data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FormChild form = (FormChild)this.ParentForm.MdiChildren[listBoxChildForms.SelectedIndex];
                if (form.Name == this.Name)
                {
                    MessageBox.Show("Передача данных возможна только в другую форму", "Transfer data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    form.DataTransfer(employees);
                }
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var result = from element in employees
                         where element.PlaceBirth == textBoxCitySearch.Text
                         select new { Id = element.Id,
                                      SurName = element.SurName,
                                      Name = element.Name,
                                      MiddleName = element.MiddleName,
                                      BirthDay = element.BirthDay,
                                      PlaceBirth = element.PlaceBirth,
                                      Age = DateTime.Now.Year-element.BirthDay.Year};

            string message = "";
            foreach (var item in result)
            {
                message += item.SurName + "\t" + item.Age + "\n";
            }
            MessageBox.Show(message, "Сотрудники", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show($"Количество сотрудников: { result.Count()}", "Количество сотрудников", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
