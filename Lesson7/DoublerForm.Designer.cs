namespace Lesson7
{
    partial class DoublerForm
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
            this.lbUserNumber = new System.Windows.Forms.Label();
            this.lbComputerNumber = new System.Windows.Forms.Label();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.llBack = new System.Windows.Forms.LinkLabel();
            this.lStepCount = new System.Windows.Forms.Label();
            this.bStepCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUserNumber
            // 
            this.lbUserNumber.AutoSize = true;
            this.lbUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserNumber.Location = new System.Drawing.Point(35, 171);
            this.lbUserNumber.Name = "lbUserNumber";
            this.lbUserNumber.Size = new System.Drawing.Size(140, 20);
            this.lbUserNumber.TabIndex = 9;
            this.lbUserNumber.Text = "Текущее число:";
            // 
            // lbComputerNumber
            // 
            this.lbComputerNumber.AutoSize = true;
            this.lbComputerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbComputerNumber.Location = new System.Drawing.Point(35, 89);
            this.lbComputerNumber.Name = "lbComputerNumber";
            this.lbComputerNumber.Size = new System.Drawing.Size(151, 20);
            this.lbComputerNumber.TabIndex = 8;
            this.lbComputerNumber.Text = "Получите число:";
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiply.Location = new System.Drawing.Point(254, 174);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(111, 57);
            this.btnMultiply.TabIndex = 7;
            this.btnMultiply.Text = "x2";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(254, 93);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(111, 57);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(254, 17);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 57);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Новая игра";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // llBack
            // 
            this.llBack.AutoSize = true;
            this.llBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llBack.Location = new System.Drawing.Point(12, 9);
            this.llBack.Name = "llBack";
            this.llBack.Size = new System.Drawing.Size(49, 16);
            this.llBack.TabIndex = 10;
            this.llBack.TabStop = true;
            this.llBack.Text = "Назад";
            this.llBack.VisitedLinkColor = System.Drawing.Color.Blue;
            this.llBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llBack_LinkClicked);
            // 
            // lStepCount
            // 
            this.lStepCount.AutoSize = true;
            this.lStepCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStepCount.Location = new System.Drawing.Point(36, 295);
            this.lStepCount.Name = "lStepCount";
            this.lStepCount.Size = new System.Drawing.Size(95, 16);
            this.lStepCount.TabIndex = 11;
            this.lStepCount.Text = "Число шагов: ";
            // 
            // bStepCancel
            // 
            this.bStepCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStepCancel.Location = new System.Drawing.Point(254, 254);
            this.bStepCancel.Name = "bStepCancel";
            this.bStepCancel.Size = new System.Drawing.Size(111, 57);
            this.bStepCancel.TabIndex = 12;
            this.bStepCancel.Text = "Отмена";
            this.bStepCancel.UseVisualStyleBackColor = true;
            this.bStepCancel.Click += new System.EventHandler(this.bStepCancel_Click);
            // 
            // DoublerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 337);
            this.Controls.Add(this.bStepCancel);
            this.Controls.Add(this.lStepCount);
            this.Controls.Add(this.llBack);
            this.Controls.Add(this.lbUserNumber);
            this.Controls.Add(this.lbComputerNumber);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DoublerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserNumber;
        private System.Windows.Forms.Label lbComputerNumber;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.LinkLabel llBack;
        private System.Windows.Forms.Label lStepCount;
        private System.Windows.Forms.Button bStepCancel;
    }
}