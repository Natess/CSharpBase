namespace Lesson8.Task5
{
    partial class TransferStudentdFileToXML
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
            this.tbStudents = new System.Windows.Forms.TextBox();
            this.bLoad = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.lStudentsCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbStudents
            // 
            this.tbStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStudents.Location = new System.Drawing.Point(16, 16);
            this.tbStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStudents.Multiline = true;
            this.tbStudents.Name = "tbStudents";
            this.tbStudents.ReadOnly = true;
            this.tbStudents.Size = new System.Drawing.Size(705, 408);
            this.tbStudents.TabIndex = 0;
            // 
            // bLoad
            // 
            this.bLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLoad.Location = new System.Drawing.Point(89, 480);
            this.bLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(159, 68);
            this.bLoad.TabIndex = 1;
            this.bLoad.Text = "Загрузить";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Location = new System.Drawing.Point(274, 480);
            this.bSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(159, 68);
            this.bSave.TabIndex = 2;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.Location = new System.Drawing.Point(454, 480);
            this.bClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(159, 68);
            this.bClear.TabIndex = 3;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // lStudentsCount
            // 
            this.lStudentsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lStudentsCount.AutoSize = true;
            this.lStudentsCount.Location = new System.Drawing.Point(13, 438);
            this.lStudentsCount.Name = "lStudentsCount";
            this.lStudentsCount.Size = new System.Drawing.Size(132, 17);
            this.lStudentsCount.TabIndex = 4;
            this.lStudentsCount.Text = "Записей в файле: ";
            // 
            // TransferStudentdFileToXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.lStudentsCount);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.tbStudents);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(750, 600);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "TransferStudentdFileToXML";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Преобразователь из CSV в XML-файл с информацией о студентах";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStudents;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label lStudentsCount;
    }
}