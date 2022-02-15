namespace Lesson7
{
    partial class EnterForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bDoubler = new System.Windows.Forms.Button();
            this.bGuessNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите игру:";
            // 
            // bDoubler
            // 
            this.bDoubler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDoubler.Location = new System.Drawing.Point(62, 93);
            this.bDoubler.Name = "bDoubler";
            this.bDoubler.Size = new System.Drawing.Size(189, 69);
            this.bDoubler.TabIndex = 1;
            this.bDoubler.Text = "Удвоитель";
            this.bDoubler.UseVisualStyleBackColor = true;
            this.bDoubler.Click += new System.EventHandler(this.bDoubler_Click);
            // 
            // bGuessNumber
            // 
            this.bGuessNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bGuessNumber.Location = new System.Drawing.Point(62, 191);
            this.bGuessNumber.Name = "bGuessNumber";
            this.bGuessNumber.Size = new System.Drawing.Size(189, 87);
            this.bGuessNumber.TabIndex = 2;
            this.bGuessNumber.Text = "Угадай число";
            this.bGuessNumber.UseVisualStyleBackColor = true;
            this.bGuessNumber.Click += new System.EventHandler(this.bGuessNumber_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(320, 342);
            this.Controls.Add(this.bGuessNumber);
            this.Controls.Add(this.bDoubler);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EnterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bDoubler;
        private System.Windows.Forms.Button bGuessNumber;
    }
}

