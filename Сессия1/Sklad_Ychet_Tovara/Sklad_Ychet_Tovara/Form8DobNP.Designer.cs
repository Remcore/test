namespace Sklad_Ychet_Tovara
{
    partial class Form8DobNP
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
            this.database1DataSet1 = new Sklad_Ychet_Tovara.database1DataSet();
            this.postavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavkiTableAdapter = new Sklad_Ychet_Tovara.database1DataSetTableAdapters.postavkiTableAdapter();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new Sklad_Ychet_Tovara.database1DataSetTableAdapters.tovarTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idpostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavshchikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idtovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.postavshchikTableAdapter = new Sklad_Ychet_Tovara.database1DataSetTableAdapters.postavshchikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshchikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postavkiBindingSource
            // 
            this.postavkiBindingSource.DataMember = "postavki";
            this.postavkiBindingSource.DataSource = this.database1DataSet1;
            // 
            // postavkiTableAdapter
            // 
            this.postavkiTableAdapter.ClearBeforeFill = true;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "tovar";
            this.tovarBindingSource.DataSource = this.database1DataSet1BindingSource;
            // 
            // database1DataSet1BindingSource
            // 
            this.database1DataSet1BindingSource.DataSource = this.database1DataSet1;
            this.database1DataSet1BindingSource.Position = 0;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 258);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Добавить поставщика";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Дата поставки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Количество товара";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Код поставщика";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Код товара";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpostDataGridViewTextBoxColumn,
            this.namepostDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.postavshchikBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(147, 109);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(183, 91);
            this.dataGridView3.TabIndex = 22;
            // 
            // idpostDataGridViewTextBoxColumn
            // 
            this.idpostDataGridViewTextBoxColumn.DataPropertyName = "_id_post";
            this.idpostDataGridViewTextBoxColumn.HeaderText = "Код поставщика";
            this.idpostDataGridViewTextBoxColumn.Name = "idpostDataGridViewTextBoxColumn";
            this.idpostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namepostDataGridViewTextBoxColumn
            // 
            this.namepostDataGridViewTextBoxColumn.DataPropertyName = "name_post";
            this.namepostDataGridViewTextBoxColumn.HeaderText = "Наименование компании";
            this.namepostDataGridViewTextBoxColumn.Name = "namepostDataGridViewTextBoxColumn";
            this.namepostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postavshchikBindingSource
            // 
            this.postavshchikBindingSource.DataMember = "postavshchik";
            this.postavshchikBindingSource.DataSource = this.database1DataSet1BindingSource;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtovaraDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.tovarBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(147, 27);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(183, 76);
            this.dataGridView4.TabIndex = 21;
            // 
            // idtovaraDataGridViewTextBoxColumn
            // 
            this.idtovaraDataGridViewTextBoxColumn.DataPropertyName = "_id_tovara";
            this.idtovaraDataGridViewTextBoxColumn.HeaderText = "Код товара";
            this.idtovaraDataGridViewTextBoxColumn.Name = "idtovaraDataGridViewTextBoxColumn";
            this.idtovaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 219);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 20);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(9, 125);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 20);
            this.textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(9, 54);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(132, 20);
            this.textBox7.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(255, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Завершить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(336, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(351, 251);
            this.dataGridView1.TabIndex = 30;
            // 
            // postavshchikTableAdapter
            // 
            this.postavshchikTableAdapter.ClearBeforeFill = true;
            // 
            // Form8DobNP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sklad_Ychet_Tovara.Properties.Resources.warehouse;
            this.ClientSize = new System.Drawing.Size(699, 283);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form8DobNP";
            this.Text = "Добавление данных о поставщике нового товара";
            this.Load += new System.EventHandler(this.Form8DobNP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshchikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource postavkiBindingSource;
        private database1DataSetTableAdapters.postavkiTableAdapter postavkiTableAdapter;
        private System.Windows.Forms.BindingSource database1DataSet1BindingSource;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private database1DataSetTableAdapters.tovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource postavshchikBindingSource;
        private database1DataSetTableAdapters.postavshchikTableAdapter postavshchikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepostDataGridViewTextBoxColumn;
    }
}