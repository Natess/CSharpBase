namespace Lesson8
{
    partial class EnglishWordsDictionary
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnglishWordsDictionary));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chbDate = new System.Windows.Forms.CheckBox();
            this.dtpDateFilter = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbThemes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsWordsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvDictionary = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bRemove = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.englishDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Translate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Themes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictionary)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.englishDictionaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemOpen,
            this.menuItemSave,
            this.menuItemSaveAs,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.Size = new System.Drawing.Size(112, 22);
            this.menuItemNew.Text = "New";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(112, 22);
            this.menuItemOpen.Text = "Open";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.Size = new System.Drawing.Size(112, 22);
            this.menuItemSave.Text = "Save";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItemSaveAs
            // 
            this.menuItemSaveAs.Name = "menuItemSaveAs";
            this.menuItemSaveAs.Size = new System.Drawing.Size(112, 22);
            this.menuItemSaveAs.Text = "Save as";
            this.menuItemSaveAs.Click += new System.EventHandler(this.menuItemSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(112, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.bSearch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(784, 48);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.chbDate);
            this.panel2.Controls.Add(this.dtpDateFilter);
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 30);
            this.panel2.TabIndex = 5;
            // 
            // chbDate
            // 
            this.chbDate.AutoSize = true;
            this.chbDate.Location = new System.Drawing.Point(6, 2);
            this.chbDate.Name = "chbDate";
            this.chbDate.Size = new System.Drawing.Size(55, 24);
            this.chbDate.TabIndex = 4;
            this.chbDate.Text = "Дата";
            this.chbDate.UseVisualStyleBackColor = true;
            // 
            // dtpDateFilter
            // 
            this.dtpDateFilter.Location = new System.Drawing.Point(65, 2);
            this.dtpDateFilter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dtpDateFilter.Name = "dtpDateFilter";
            this.dtpDateFilter.Size = new System.Drawing.Size(150, 25);
            this.dtpDateFilter.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.tbThemes);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(232, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 30);
            this.panel3.TabIndex = 6;
            // 
            // tbThemes
            // 
            this.tbThemes.Location = new System.Drawing.Point(64, 2);
            this.tbThemes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tbThemes.Name = "tbThemes";
            this.tbThemes.Size = new System.Drawing.Size(157, 25);
            this.tbThemes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 8, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Группы";
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(469, 8);
            this.bSearch.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bSearch.Name = "bSearch";
            this.bSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.bSearch.Size = new System.Drawing.Size(95, 30);
            this.bSearch.TabIndex = 0;
            this.bSearch.Text = "Поиск";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsWordsCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabel1.Text = "Всего слов:";
            // 
            // tsWordsCount
            // 
            this.tsWordsCount.Name = "tsWordsCount";
            this.tsWordsCount.Size = new System.Drawing.Size(13, 17);
            this.tsWordsCount.Text = "0";
            // 
            // dgvDictionary
            // 
            this.dgvDictionary.AllowUserToAddRows = false;
            this.dgvDictionary.AllowUserToDeleteRows = false;
            this.dgvDictionary.AllowUserToResizeRows = false;
            this.dgvDictionary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDictionary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word,
            this.Translate,
            this.Themes,
            this.AddingDate});
            this.dgvDictionary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDictionary.Location = new System.Drawing.Point(0, 128);
            this.dgvDictionary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDictionary.Name = "dgvDictionary";
            this.dgvDictionary.ReadOnly = true;
            this.dgvDictionary.RowHeadersVisible = false;
            this.dgvDictionary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDictionary.Size = new System.Drawing.Size(784, 611);
            this.dgvDictionary.TabIndex = 8;
            this.dgvDictionary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDictionary_CellContentClick);
            this.dgvDictionary.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDictionary_ColumnHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bRemove);
            this.panel1.Controls.Add(this.bAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 55);
            this.panel1.TabIndex = 5;
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(122, 8);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(89, 39);
            this.bRemove.TabIndex = 1;
            this.bRemove.Text = "Удалить";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(21, 8);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(95, 39);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // Word
            // 
            this.Word.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Word.FillWeight = 99.49239F;
            this.Word.HeaderText = "Слово";
            this.Word.Name = "Word";
            this.Word.ReadOnly = true;
            // 
            // Translate
            // 
            this.Translate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Translate.FillWeight = 99.49239F;
            this.Translate.HeaderText = "Перевод";
            this.Translate.Name = "Translate";
            this.Translate.ReadOnly = true;
            // 
            // Themes
            // 
            this.Themes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Themes.FillWeight = 99.49239F;
            this.Themes.HeaderText = "Группы";
            this.Themes.Name = "Themes";
            this.Themes.ReadOnly = true;
            // 
            // AddingDate
            // 
            this.AddingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AddingDate.FillWeight = 50F;
            this.AddingDate.HeaderText = "Дата добавления";
            this.AddingDate.Name = "AddingDate";
            this.AddingDate.ReadOnly = true;
            this.AddingDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AddingDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // EnglishWordsDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.dgvDictionary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "EnglishWordsDictionary";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Словарь";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictionary)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.englishDictionaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.BindingSource englishDictionaryBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dgvDictionary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpDateFilter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbThemes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsWordsCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.CheckBox chbDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Translate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Themes;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddingDate;
    }
}