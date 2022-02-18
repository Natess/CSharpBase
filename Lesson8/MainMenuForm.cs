using Lesson8.Task5;
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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        // 1. С помощью рефлексии выведите все свойства структуры DateTime.
        private void bTask1_Click(object sender, EventArgs e)
        {
            using (var form = new Task1Form())
            {
                this.Hide();
                form.ShowDialog();
            }
            this.Show();
        }

        //2. Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown.
        private void bTask2_Click(object sender, EventArgs e)
        {
            using (var form = new Task2Form())
            {
                this.Hide();
                form.ShowDialog();
            }
            this.Show();
        }

        //3.
        //    а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок(не создана база данных,
        //    обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
        //    б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
        //    в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия, авторские права и др.).
        //    г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных(элемент SaveFileDialog).
        private void bTask3_Click(object sender, EventArgs e)
        {
            using (var form = new TrueFalseEditor())
            {
                this.Hide();
                form.ShowDialog();
            }
            this.Show();
        }

        //Используя полученные знания и класс TrueFalse в качестве шаблона, 
        //    разработать собственную утилиту хранения данных(Например: Дни рождения, Траты, Напоминалка, Английские слова и другие)
        private void bTask4_Click(object sender, EventArgs e)
        {
            using (var form = new EnglishWordsDictionary())
            {
                this.Hide();
                form.ShowDialog();
            }
            this.Show();
        }

        //5. **Написать программу-преобразователь из CSV в XML-файл с информацией о студентах(6 урок).
        private void bTask5_Click(object sender, EventArgs e)
        {
            using (var form = new TransferStudentdFileToXML())
            {
                this.Hide();
                form.ShowDialog();
            }
            this.Show();

        }
    }
}
