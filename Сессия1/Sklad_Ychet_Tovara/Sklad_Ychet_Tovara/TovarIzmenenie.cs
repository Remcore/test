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
    public partial class TovarIzmenenie : Form
    {
        string connectionString = @"Database=database1;Data Source=127.0.0.1;User Id=root;Password=";
        int _id_tovara = 0;

        public TovarIzmenenie()
        {
            InitializeComponent();
        }

        private void TovarIzmenenie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.opisanie". При необходимости она может быть перемещена или удалена.
            this.opisanieTableAdapter.Fill(this.database1DataSet.opisanie);
            GridFill2();
        }

        void GridFill2()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("openIzmenenieTovara", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable tovar = new DataTable();
                sqlDa.Fill(tovar);
                dataGridView1.DataSource = tovar;


                dataGridView1.Columns[0].HeaderText = "Код товара";
                dataGridView1.Columns[1].HeaderText = "Наименование товара";
                dataGridView1.Columns[2].HeaderText = "Номер отдела";
                dataGridView1.Columns[4].HeaderText = "Еденица измерения";
                dataGridView1.Columns[3].HeaderText = "Колличество товара";
                dataGridView1.Columns[5].HeaderText = "Цена товара";
            }
        }

        void Clear()
        {
            textBox2.Text = textBox2.Text = "";
            textBox6.Text = textBox6.Text = "";
            textBox3.Text = textBox3.Text = "";
            textBox4.Text = textBox4.Text = "";
            textBox5.Text = textBox5.Text = "";
            _id_tovara = 0;
            button1.Text = "Сохранить";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                textBox6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                _id_tovara = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                textBox6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                _id_tovara = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                //button2.Text = "Успешное изменение!";
                button1.Enabled = Enabled;
                //MessageBox.Show("Успешное изменение!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2Tovar form3 = new Form2Tovar();
            form3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("tovarAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__id_tovara", _id_tovara);
                mySqlCmd.Parameters.AddWithValue("_name", textBox6.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("__id_otdela", textBox2.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_kol_tovara", textBox3.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_edinica_izmereniay", textBox4.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_cena_na_prod", textBox5.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Изменения сохранены");
                dataGridView1.Refresh();
                Clear();
                GridFill2();
            }
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
                MySqlCommand mySqlCmd = new MySqlCommand("tovarDeletByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__id_tovara", _id_tovara);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Запись удалина");
                dataGridView1.Refresh();
                Clear();
                GridFill2();
            }
        }
    }
}
