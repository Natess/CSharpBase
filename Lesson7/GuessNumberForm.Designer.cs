namespace Lesson7
{
    partial class GuessNumberForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbComputerAnswer = new System.Windows.Forms.TextBox();
            this.lStepCount = new System.Windows.Forms.Label();
            this.bTry = new System.Windows.Forms.Button();
            this.llBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbComputerAnswer
            // 
            this.tbComputerAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbComputerAnswer.Location = new System.Drawing.Point(23, 42);
            this.tbComputerAnswer.Multiline = true;
            this.tbComputerAnswer.Name = "tbComputerAnswer";
            this.tbComputerAnswer.ReadOnly = true;
            this.tbComputerAnswer.Size = new System.Drawing.Size(357, 115);
            this.tbComputerAnswer.TabIndex = 0;
            this.tbComputerAnswer.TabStop = false;
            // 
            // lStepCount
            // 
            this.lStepCount.AutoSize = true;
            this.lStepCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStepCount.Location = new System.Drawing.Point(19, 256);
            this.lStepCount.Name = "lStepCount";
            this.lStepCount.Size = new System.Drawing.Size(155, 20);
            this.lStepCount.TabIndex = 3;
            this.lStepCount.Text = "Количество шагов:";
            // 
            // bTry
            // 
            this.bTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTry.Location = new System.Drawing.Point(100, 190);
            this.bTry.Name = "bTry";
            this.bTry.Size = new System.Drawing.Size(206, 31);
            this.bTry.TabIndex = 4;
            this.bTry.Text = "Попытаться угадать";
            this.bTry.UseVisualStyleBackColor = true;
            this.bTry.Click += new System.EventHandler(this.bTry_Click);
            // 
            // llBack
            // 
            this.llBack.AutoSize = true;
            this.llBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llBack.Location = new System.Drawing.Point(12, 5);
            this.llBack.Name = "llBack";
            this.llBack.Size = new System.Drawing.Size(49, 16);
            this.llBack.TabIndex = 11;
            this.llBack.TabStop = true;
            this.llBack.Text = "Назад";
            this.llBack.VisitedLinkColor = System.Drawing.Color.Blue;
            this.llBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llBack_LinkClicked);
            // 
            // GuessNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 299);
            this.Controls.Add(this.llBack);
            this.Controls.Add(this.bTry);
            this.Controls.Add(this.lStepCount);
            this.Controls.Add(this.tbComputerAnswer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GuessNumberForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число";
            this.Load += new System.EventHandler(this.GuessNumberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbComputerAnswer;
        private System.Windows.Forms.Label lStepCount;
        private System.Windows.Forms.Button bTry;
        private System.Windows.Forms.LinkLabel llBack;
    }
}