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
    //    2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100,
    //    а человек пытается его угадать за минимальное число попыток.Компьютер говорит, больше или меньше загаданное число введенного.
    //  a) Для ввода данных от человека используется элемент TextBox;
    //    б) ** Реализовать отдельную форму c TextBox для ввода числа.
    public partial class GuessNumberForm : Form
    {
        private Random random = new Random();
        private int guessedNumber;
        private int stepCount;

        public GuessNumberForm()
        {
            InitializeComponent();

            bTry.Focus();
            ResetGame();
        }

        private void ResetGame()
        {
            guessedNumber = random.Next(1, 100);
            tbComputerAnswer.Text = "Компьютер загадал число от 1 до 100. Вы вводите число, компьютер отвечает меньше или больше загаданное число. \n" +
                "Вам нужно отгадать число за минимальное чило шагов.";
            lStepCount.Text = $"Число шагов: {stepCount = 0}";
        }

        private void UpdateGameState(int userNumber)
        {
            tbComputerAnswer.Text = $"Вы ввели число {userNumber}. \n" +
                "Компьютер говорит, что его число " +
                (userNumber > guessedNumber ? "меньше." : (userNumber < guessedNumber ? "больше." : "равно."));
            lStepCount.Text = $"Число шагов: {++stepCount}";
            CheckWin(userNumber);
        }

        private void bTry_Click(object sender, EventArgs e)
        {
            using (var form = new GuessNumberEnterNumberForm())
            {
                if(form.ShowDialog() == DialogResult.OK)
                    UpdateGameState(form.UserNumber);
            }
        }

        private void CheckWin(int userNumber)
        {
            if (guessedNumber == userNumber)
            {
                MessageBox.Show("Вы успешно завершили игру", "Угадай число",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Желаете сыграть еще раз?", "Угадай число",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResetGame();
                }
                else
                {
                    Close();
                }
            }
        }

        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void GuessNumberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
