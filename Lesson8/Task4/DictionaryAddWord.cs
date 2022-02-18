using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8
{
    public partial class DictionaryAddWord : Form
    {
        public EnglishDictionaryItem NewWord;

        public DictionaryAddWord()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            dtpAddingDate.Value = DateTime.Now;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbWord.Text) || String.IsNullOrEmpty(tbTranslate.Text) || String.IsNullOrEmpty(tbThemes.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            DialogResult = DialogResult.OK;
            NewWord = new EnglishDictionaryItem(tbWord.Text, tbTranslate.Text, dtpAddingDate.Value, 
                                                tbThemes.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries));
            this.Close();
        }
    }
}
