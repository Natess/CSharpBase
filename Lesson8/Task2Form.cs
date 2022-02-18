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

namespace Lesson8
{
    public partial class Task2Form : Form
    {

        List<string> facts = new List<string>();

        public Task2Form()
        {
            InitializeComponent();
        }

        private void Task2Form_Load(object sender, EventArgs e)
        {
            try
            {
                var lines = File.ReadAllLines(AppContext.BaseDirectory + "facts.txt").Where(x=>!String.IsNullOrEmpty(x)).ToList();
                for (int i = 0; i < lines.Count(); i+=2)
                {
                    facts.Add($"{lines[i]}. {lines[i+1]}");
                }
                numericUpDown1.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не так.\n{ex.Message}");
                this.Close();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = facts[(int)numericUpDown1.Value - 1];
            numericUpDown1.Focus();
        }
    }
}
