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
    public partial class Form3PROBNOERED : Form
    {
        string connectionString = @"Database=database1;Data Source=127.0.0.1;User Id=root;Password=";
        int _id_zakaza = 0;

        public Form3PROBNOERED()
        {
            InitializeComponent();
        }

        private void Form3PROBNOERED_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.database1DataSet1.tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.postavshchik". При необходимости она может быть перемещена или удалена.
            this.postavshchikTableAdapter.Fill(this.database1DataSet1.postavshchik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.postavki". При необходимости она может быть перемещена или удалена.
            this.postavkiTableAdapter.Fill(this.database1DataSet1.postavki);
            Clear();
            GridFill();
            
        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("prodazhaViewAll1", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable postavki = new DataTable();
                sqlDa.Fill(postavki);
                dataGridView1.DataSource = postavki;


                dataGridView1.Columns[0].HeaderText = "Код поставки";
                dataGridView1.Columns[1].HeaderText = "Код поставщика";
                dataGridView1.Columns[2].HeaderText = "Код товара";
                dataGridView1.Columns[3].HeaderText = "Количество товара";
                dataGridView1.Columns[4].HeaderText = "Дата поступления";

            }
        }
        
        void Clear()
        {
            
            textBox4.Text = textBox4.Text = "";
            _id_zakaza = 0;
            button1.Text = "Сохранить";
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
               
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                _id_zakaza = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                button1.Enabled = Enabled;
                //MessageBox.Show("Успешное изменение!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("postavkiAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__id_zakaza", _id_zakaza);
                mySqlCmd.Parameters.AddWithValue("__id_postav", comboBox1.SelectedValue);
                mySqlCmd.Parameters.AddWithValue("__id_tovara", comboBox2.SelectedValue);
                mySqlCmd.Parameters.AddWithValue("_kol_tovara", textBox4.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_data", dateTimePicker1.Value);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Запись изменена");
                dataGridView1.Refresh();
                Clear();
                GridFill();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form5Post form5 = new Form5Post();
            form5.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/Asus/Documents/Visual Studio 2017/Projects/Sklad_Ychet_Tovara/Sklad_Ychet_Tovara/Справочная система.chm");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("postavkiDeletByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__id_zakaza", _id_zakaza);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Запись удалина");
                dataGridView1.Refresh();
                Clear();
                GridFill();
            }
        }
    }
}
