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
    //3.
    //    а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок(не создана база данных,
    //    обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
    //    б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
    //    в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия, авторские права и др.).
    //    г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных(элемент SaveFileDialog).
    public partial class TrueFalseEditor : Form
    {
        private TrueFalse database;

        public TrueFalseEditor()
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
                    database = new TrueFalse(dlg.FileName);
                    database.Add("Зeмля круглая?", true);
                    database.Save();
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = 1;
                    nudNumber.Value = 1;
                    lQuestionsCount.Text = $"Всего вопросов: {database.Count}";
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
                    database = new TrueFalse(dlg.FileName);
                    database.Load();
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = database.Count;
                    nudNumber.Value = 1;
                    lQuestionsCount.Text = $"Всего вопросов: {database.Count}";
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
                if (database == null)
                {
                    NoSourseMessageShow();
                    return;
                }
                database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
                database[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
                database.Save();
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
                if (database == null)
                {
                    NoSourseMessageShow();
                    return;
                }
                database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
                database[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;

                SaveFileDialog dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    database = new TrueFalse(dlg.FileName, database);
                    database.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void menuItemAboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа разработана для курса \"Основы языка C#\" на портале GeekBrains.\n" +
                "Авторы: Станислав Байраковский, Кузнецова Анастасия\n" +
                "Версия: 2.0");
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (database == null)
            {
                NoSourseMessageShow();
                nudNumber.Value = 0;
                return;
            }
            tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            cbTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                NoSourseMessageShow();
                return;
            }
            database.Add($"#{database.Count + 1}", true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
            lQuestionsCount.Text = $"Всего вопросов: {database.Count}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                NoSourseMessageShow();
                return;
            }
            if (database.Count == 1)
                return;
            
            database.Remove((int)nudNumber.Value - 1);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1)
                nudNumber.Value--;
            else
                tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;

            lQuestionsCount.Text = $"Всего вопросов: {database.Count}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                NoSourseMessageShow();
                return;
            }
            database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
            database[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
        }

        private void NoSourseMessageShow()
        {
            MessageBox.Show("Выберите или создайте файл!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
