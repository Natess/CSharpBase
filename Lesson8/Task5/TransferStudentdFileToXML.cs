using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8.Task5
{
    public partial class TransferStudentdFileToXML : Form
    {
        TransformerFromCSVToXML<Student> transformer = new TransformerFromCSVToXML<Student>();
        List<Student> students;

        public TransferStudentdFileToXML()
        {
            InitializeComponent();
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    students = transformer.LoadFromFile(dlg.FileName);
                    tbStudents.Lines = students.Select(x => x.ToString()).ToArray();
                    lStudentsCount.Text = $"Записей в файле: {students.Count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        { 
            try
            {
                if (students?.Any() != true)
                    return;
                SaveFileDialog dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    transformer.SaveToXMLFile(dlg.FileName, students);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if (students?.Any() != true)
                return;
            tbStudents.Clear();
            students.Clear();
            lStudentsCount.Text = "Записей в файле: ";
        }
    }
}
