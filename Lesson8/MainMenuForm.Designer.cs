namespace Lesson8
{
    partial class MainMenuForm
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
            this.bTask1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bTask2 = new System.Windows.Forms.Button();
            this.bTask3 = new System.Windows.Forms.Button();
            this.bTask4 = new System.Windows.Forms.Button();
            this.bTask5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bTask1
            // 
            this.bTask1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTask1.Location = new System.Drawing.Point(16, 23);
            this.bTask1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.bTask1.Name = "bTask1";
            this.bTask1.Size = new System.Drawing.Size(226, 70);
            this.bTask1.TabIndex = 0;
            this.bTask1.Text = "Задание 1";
            this.bTask1.UseVisualStyleBackColor = true;
            this.bTask1.Click += new System.EventHandler(this.bTask1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bTask1);
            this.flowLayoutPanel1.Controls.Add(this.bTask2);
            this.flowLayoutPanel1.Controls.Add(this.bTask3);
            this.flowLayoutPanel1.Controls.Add(this.bTask4);
            this.flowLayoutPanel1.Controls.Add(this.bTask5);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(13, 20, 15, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(255, 511);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // bTask2
            // 
            this.bTask2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTask2.Location = new System.Drawing.Point(16, 116);
            this.bTask2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.bTask2.Name = "bTask2";
            this.bTask2.Size = new System.Drawing.Size(226, 70);
            this.bTask2.TabIndex = 8;
            this.bTask2.Text = "Задание 2";
            this.bTask2.UseVisualStyleBackColor = true;
            this.bTask2.Click += new System.EventHandler(this.bTask2_Click);
            // 
            // bTask3
            // 
            this.bTask3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTask3.Location = new System.Drawing.Point(16, 209);
            this.bTask3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.bTask3.Name = "bTask3";
            this.bTask3.Size = new System.Drawing.Size(226, 70);
            this.bTask3.TabIndex = 7;
            this.bTask3.Text = "Задание 3";
            this.bTask3.UseVisualStyleBackColor = true;
            this.bTask3.Click += new System.EventHandler(this.bTask3_Click);
            // 
            // bTask4
            // 
            this.bTask4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTask4.Location = new System.Drawing.Point(16, 302);
            this.bTask4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.bTask4.Name = "bTask4";
            this.bTask4.Size = new System.Drawing.Size(226, 70);
            this.bTask4.TabIndex = 6;
            this.bTask4.Text = "Задание 4";
            this.bTask4.UseVisualStyleBackColor = true;
            this.bTask4.Click += new System.EventHandler(this.bTask4_Click);
            // 
            // bTask5
            // 
            this.bTask5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTask5.Location = new System.Drawing.Point(16, 395);
            this.bTask5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.bTask5.Name = "bTask5";
            this.bTask5.Size = new System.Drawing.Size(226, 70);
            this.bTask5.TabIndex = 5;
            this.bTask5.Text = "Задание 5";
            this.bTask5.UseVisualStyleBackColor = true;
            this.bTask5.Click += new System.EventHandler(this.bTask5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Кузнецова Анастасия";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 511);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор задания";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bTask1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bTask2;
        private System.Windows.Forms.Button bTask3;
        private System.Windows.Forms.Button bTask4;
        private System.Windows.Forms.Button bTask5;
        private System.Windows.Forms.Label label1;
    }
}

