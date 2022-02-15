using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        private void bDoubler_Click(object sender, EventArgs e)
        {
            using(var form = new DoublerForm())
            {
                this.Hide();
                form.ShowDialog();
            }
            this.Show();
        }

        private void bGuessNumber_Click(object sender, EventArgs e)
        {
            using (var form = new GuessNumberForm())
            {
                this.Hide();
                form.ShowDialog();
            }
            this.Show();

        }

    }
}
