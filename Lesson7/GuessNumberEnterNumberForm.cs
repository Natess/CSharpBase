using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class GuessNumberEnterNumberForm : Form
    {
        public GuessNumberEnterNumberForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            tbUserNumber.TextChanged += tbUserNumber_TextChanged;
        }

        public int UserNumber { get; private set; }

        private void bTry_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUserNumber.Text))
            {
                UserNumber = int.Parse(tbUserNumber.Text);
                DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void tbUserNumber_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = Regex.Replace(textboxSender.Text, "[^0-9]", "");
            textboxSender.SelectionStart = cursorPosition;
        }
    }
}
