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
    //Используя полученные знания и класс TrueFalse в качестве шаблона, 
    //    разработать собственную утилиту хранения данных(Например: Дни рождения, Траты, Напоминалка, Английские слова и другие)
    public partial class EnglishWordsDictionary : Form
    {
        private EnglishDictionary englishDictionary; 

        public EnglishWordsDictionary()
        {
            InitializeComponent();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    englishDictionary = new EnglishDictionary(dlg.FileName);
                    englishDictionary.Save();
                    tsWordsCount.Text = englishDictionary.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    englishDictionary = new EnglishDictionary(dlg.FileName);
                    englishDictionary.Load();
                    Draw();
                    tsWordsCount.Text = englishDictionary.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (englishDictionary == null)
                {
                    NoSourseMessageShow();
                    return;
                } 
                englishDictionary.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (englishDictionary == null)
                {
                    NoSourseMessageShow();
                    return;
                }

                SaveFileDialog dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    englishDictionary = new EnglishDictionary(dlg.FileName, englishDictionary);
                    englishDictionary.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NoSourseMessageShow()
        {
            MessageBox.Show("Выберите или создайте файл!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (englishDictionary == null)
            {
                NoSourseMessageShow();
                return;
            }
            using (var f = new DictionaryAddWord())
            {
                f.ShowDialog();
                if (f.DialogResult == DialogResult.OK)
                {
                    englishDictionary.Add(f.NewWord);

                    dgvDictionary.Rows.Add();
                    dgvDictionary.Rows[dgvDictionary.Rows.Count - 1].Tag = f.NewWord;
                    dgvDictionary.Rows[dgvDictionary.Rows.Count - 1].Cells["Word"].Value = f.NewWord.Word;
                    dgvDictionary.Rows[dgvDictionary.Rows.Count - 1].Cells["Translate"].Value = f.NewWord.Translate;
                    dgvDictionary.Rows[dgvDictionary.Rows.Count - 1].Cells["Themes"].Value = String.Join(", ", f.NewWord.Themes);
                    dgvDictionary.Rows[dgvDictionary.Rows.Count - 1].Cells["AddingDate"].Value = f.NewWord.AddingDate.ToString("dd.MM.yy");
                }
            }
            tsWordsCount.Text = englishDictionary.Count.ToString();
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            if (englishDictionary == null)
            {
                NoSourseMessageShow();
                return;
            }
            foreach (DataGridViewRow item in dgvDictionary.SelectedRows)
            {
                englishDictionary.Remove((EnglishDictionaryItem)item.Tag);
                dgvDictionary.Rows.Remove(item);
            }
            tsWordsCount.Text = englishDictionary.Count.ToString();
        }

        private void Draw()
        {
            dgvDictionary.Rows.Clear();
            dgvDictionary.Rows.AddRange(GetRows());
        }

        private DataGridViewRow[] GetRows()
        {
            var rows = new DataGridViewRow[englishDictionary.Count];
            for (int i = 0; i < englishDictionary.Count; i++)
            {
                rows[i] = new DataGridViewRow();
                rows[i].Tag = englishDictionary[i];
                rows[i].Cells.Add(new DataGridViewTextBoxCell() { Value = englishDictionary[i].Word });
                rows[i].Cells.Add(new DataGridViewTextBoxCell() { Value = englishDictionary[i].Translate });
                rows[i].Cells.Add(new DataGridViewTextBoxCell() { Value = String.Join(", ", englishDictionary[i].Themes) });
                rows[i].Cells.Add(new DataGridViewTextBoxCell() { Value = englishDictionary[i].AddingDate.ToString("dd.MM.yy") });
                //rows[i].Cells["Word"].Value = englishDictionary[i].Word;
                //rows[i].Cells["Translate"].Value = englishDictionary[i].Translate;
                //rows[i].Cells["Themes"].Value = String.Join(", ", englishDictionary[i].Themes);
                //rows[i].Cells["AddingDate"].Value = englishDictionary[i].AddingDate.ToString("dd.MM.yy");
            }
            return rows;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if (englishDictionary.Count == 0)
                return;
            var rows = GetRows();
            if (chbDate.Checked)
            {
                rows = rows.Where(x=>((EnglishDictionaryItem)x.Tag).AddingDate.ToShortDateString() == dtpDateFilter.Value.ToShortDateString())
                            .ToArray();
            }
            if(!String.IsNullOrEmpty(tbThemes.Text))
            {
                var themes = tbThemes.Text.ToLower().Split(new char []{ ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                rows = rows.Where(x => themes.All(y => ((EnglishDictionaryItem)x.Tag).Themes.Select(z=>z.ToLower()).Contains(y)))
                            .ToArray();
            }
            dgvDictionary.Rows.Clear();
            dgvDictionary.Rows.AddRange(rows);
        }

        private void dgvDictionary_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvDictionary.Columns[e.ColumnIndex].Name == "AddingDate")
            {
                var rows = dgvDictionary.Rows.Cast<DataGridViewRow>().OrderBy(x => ((EnglishDictionaryItem)x.Tag).AddingDate).ToArray();
                dgvDictionary.Rows.Clear();
                dgvDictionary.Rows.AddRange(rows);
            }
        }

        private void dgvDictionary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
