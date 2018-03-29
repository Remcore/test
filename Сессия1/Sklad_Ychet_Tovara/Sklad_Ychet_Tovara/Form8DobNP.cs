using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Sklad_Ychet_Tovara
{
    public partial class Form8DobNP : Form
    {
        string connectionString = @"Database=database1;Data Source=127.0.0.1;User Id=root;Password=";
        int _id_zakaza = 0;

        public Form8DobNP()
        {
            InitializeComponent();
        }

        private void Form8DobNP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.postavshchik". При необходимости она может быть перемещена или удалена.
            this.postavshchikTableAdapter.Fill(this.database1DataSet1.postavshchik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.database1DataSet1.tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.postavki". При необходимости она может быть перемещена или удалена.
            this.postavkiTableAdapter.Fill(this.database1DataSet1.postavki);
            GridFill3();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("postavkiAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__id_zakaza", _id_zakaza);
                mySqlCmd.Parameters.AddWithValue("__id_postav", textBox6.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("__id_tovara", textBox7.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_kol_tovara", textBox5.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_data", dateTimePicker1.Value);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Запись добавлена");
                dataGridView1.Refresh();
                Clear();
                GridFill3();
            }
        }
        void Clear()
        {
            textBox5.Text = textBox6.Text = "";
            
            
            textBox7.Text = textBox7.Text = "";

            _id_zakaza = 0;
            //button1.Text = "Сохранить";
            //button2.Enabled = false;
        }

        void GridFill3()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("tovarViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable tovar = new DataTable();
                sqlDa.Fill(tovar);
                dataGridView1.DataSource = tovar;


                dataGridView1.Columns[0].HeaderText = "Код товара";
                dataGridView1.Columns[1].HeaderText = "Наименование товара";
                dataGridView1.Columns[2].HeaderText = "Oтдел";
                dataGridView1.Columns[3].HeaderText = "Еденица измерения";
                dataGridView1.Columns[4].HeaderText = "Колличество товара";
                dataGridView1.Columns[5].HeaderText = "Цена товара";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("postavkiAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__id_zakaza", _id_zakaza);
                mySqlCmd.Parameters.AddWithValue("__id_postav", textBox6.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("__id_tovara", textBox7.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_kol_tovara", textBox5.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_data", dateTimePicker1.Value);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Запись добавлена");
                dataGridView1.Refresh();
                Clear();
                GridFill3();
            }
            Hide();
            Form5Post form9 = new Form5Post();
            form9.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form9DobNNPost form91 = new Form9DobNNPost();
            form91.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/Asus/Documents/Visual Studio 2017/Projects/Sklad_Ychet_Tovara/Sklad_Ychet_Tovara/Справочная система.chm");
        }
    }
}
