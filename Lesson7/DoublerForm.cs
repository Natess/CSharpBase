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
    //1.
    //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
    //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
    //в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте библиотечный обобщенный класс System.Collections.Generic.Stack<int> Stack.
    //Вся логика игры должна быть реализована в классе с удвоителем.
    public partial class DoublerForm : Form
    {
        private Random random = new Random();
        private int computerNumber;
        private Stack<int> steps;

        public DoublerForm()
        {
            InitializeComponent();

            ResetGame();
        }

        private void ResetGame()
        {
            computerNumber = random.Next(50);
            steps = new Stack<int>();
            steps.Push(0);

            lbUserNumber.Text = $"Текущее число: {steps.Peek()}";
            lStepCount.Text = $"Число шагов: {steps.Count() - 1}";

            lbComputerNumber.Text = $"Получите число: {computerNumber}";
            MessageBox.Show($"Вы должны получить {computerNumber}", "Удвоитель",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void UpdateGameState()
        {
            lbUserNumber.Text = $"Текущее число: {steps.Peek()}";
            lStepCount.Text = $"Число шагов: {steps.Count() - 1}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            steps.Push(steps.Peek() + 1);
            UpdateGameState();
            CheckWin();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            steps.Push(steps.Peek() * 2);
            UpdateGameState();
            CheckWin();
        }

        private void bStepCancel_Click(object sender, EventArgs e)
        {
            if(steps.Count == 1)
                return;
            steps.Pop();
            UpdateGameState();
        }

        private void CheckWin()
        {
            if (computerNumber == steps.Peek())
            {
                MessageBox.Show("Вы успешно завершили игру", "Удвоитель",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Желаете сыграть еще раз?", "Удвоитель",
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

    }
}
