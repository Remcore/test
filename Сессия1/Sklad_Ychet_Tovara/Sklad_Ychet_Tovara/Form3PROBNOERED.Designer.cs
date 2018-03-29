namespace Sklad_Ychet_Tovara
{
    partial class Form3PROBNOERED
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idzakazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpostavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koltovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.postavkiTableAdapter = new Sklad_Ychet_Tovara.database1DataSetTableAdapters.postavkiTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.postavshchikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshchikTableAdapter = new Sklad_Ychet_Tovara.database1DataSetTableAdapters.postavshchikTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new Sklad_Ychet_Tovara.database1DataSetTableAdapters.tovarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshchikBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzakazaDataGridViewTextBoxColumn,
            this.idpostavDataGridViewTextBoxColumn,
            this.idtovaraDataGridViewTextBoxColumn,
            this.koltovaraDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postavkiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(542, 328);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // idzakazaDataGridViewTextBoxColumn
            // 
            this.idzakazaDataGridViewTextBoxColumn.DataPropertyName = "_id_zakaza";
            this.idzakazaDataGridViewTextBoxColumn.HeaderText = "_id_zakaza";
            this.idzakazaDataGridViewTextBoxColumn.Name = "idzakazaDataGridViewTextBoxColumn";
            this.idzakazaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpostavDataGridViewTextBoxColumn
            // 
            this.idpostavDataGridViewTextBoxColumn.DataPropertyName = "_id_postav";
            this.idpostavDataGridViewTextBoxColumn.HeaderText = "_id_postav";
            this.idpostavDataGridViewTextBoxColumn.Name = "idpostavDataGridViewTextBoxColumn";
            this.idpostavDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idtovaraDataGridViewTextBoxColumn
            // 
            this.idtovaraDataGridViewTextBoxColumn.DataPropertyName = "_id_tovara";
            this.idtovaraDataGridViewTextBoxColumn.HeaderText = "_id_tovara";
            this.idtovaraDataGridViewTextBoxColumn.Name = "idtovaraDataGridViewTextBoxColumn";
            this.idtovaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // koltovaraDataGridViewTextBoxColumn
            // 
            this.koltovaraDataGridViewTextBoxColumn.DataPropertyName = "kol_tovara";
            this.koltovaraDataGridViewTextBoxColumn.HeaderText = "kol_tovara";
            this.koltovaraDataGridViewTextBoxColumn.Name = "koltovaraDataGridViewTextBoxColumn";
            this.koltovaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postavkiBindingSource
            // 
            this.postavkiBindingSource.DataMember = "postavki";
            this.postavkiBindingSource.DataSource = this.database1DataSet1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Дата поставки ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(567, 180);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Поставщик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Товар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество";
            // 
            // postavkiTableAdapter
            // 
            this.postavkiTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(567, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(567, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Завершить измененя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // postavshchikBindingSource
            // 
            this.postavshchikBindingSource.DataMember = "postavshchik";
            this.postavshchikBindingSource.DataSource = this.database1DataSet1;
            // 
            // postavshchikTableAdapter
            // 
            this.postavshchikTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postavkiBindingSource, "_id_postav", true));
            this.comboBox1.DataSource = this.postavshchikBindingSource;
            this.comboBox1.DisplayMember = "name_post";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(567, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "_id_post";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.postavkiBindingSource, "_id_tovara", true));
            this.comboBox2.DataSource = this.tovarBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(567, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.ValueMember = "_id_tovara";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(567, 332);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "tovar";
            this.tovarBindingSource.DataSource = this.database1DataSet1;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // Form3PROBNOERED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sklad_Ychet_Tovara.Properties.Resources.warehouse;
            this.ClientSize = new System.Drawing.Size(708, 367);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3PROBNOERED";
            this.Text = "Изменение поставки";
            this.Load += new System.EventHandler(this.Form3PROBNOERED_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshchikBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private database1DataSet database1DataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource postavkiBindingSource;
        private database1DataSetTableAdapters.postavkiTableAdapter postavkiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzakazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpostavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koltovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource postavshchikBindingSource;
        private database1DataSetTableAdapters.postavshchikTableAdapter postavshchikTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private database1DataSetTableAdapters.tovarTableAdapter tovarTableAdapter;
    }
}