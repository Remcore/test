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
    public partial class Form7DobNT : Form
    {
        string connectionString = @"Database=database1;Data Source=127.0.0.1;User Id=root;Password=";
        int _id_tovara = 0;

        public Form7DobNT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                int _kol_tovara = 0;

                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("tovar1AddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__id_tovara", _id_tovara);
                mySqlCmd.Parameters.AddWithValue("_name", textBox1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("__id_otdela", comboBox1.SelectedValue);
                mySqlCmd.Parameters.AddWithValue("_kol_tovara", _kol_tovara);
                mySqlCmd.Parameters.AddWithValue("_edinica_izmereniay", textBox4.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_cena_na_prod", textBox3.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Запись добавлена");
                Clear();
                //GridFill();

                Hide();
                Form8DobNP form8 = new Form8DobNP();
                form8.ShowDialog();
            }

            
        }


        void Clear()
        {
            //textBox2.Text = textBox2.Text = "";
            textBox1.Text = textBox1.Text = "";
            textBox3.Text = textBox3.Text = "";
            textBox4.Text = textBox4.Text = "";
            
            _id_tovara = 0;
            button1.Text = "Сохранить";
            //button2.Enabled = false;
        }


        void GridFill()
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
                dataGridView1.Columns[2].HeaderText = "Отдел";
                dataGridView1.Columns[3].HeaderText = "Еденица измерения";
                dataGridView1.Columns[4].HeaderText = "Колличество товара";
                dataGridView1.Columns[5].HeaderText = "Цена товара";
            }
        }

        private void Form7DobNT_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.opisanie". При необходимости она может быть перемещена или удалена.
            this.opisanieTableAdapter.Fill(this.database1DataSet1.opisanie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.database1DataSet1.tovar);
            GridFill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form5Post form9 = new Form5Post();
            form9.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form5Post form9 = new Form5Post();
            form9.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                int _kol_tovara = 0;

                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("tovar1AddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__id_tovara", _id_tovara);
                mySqlCmd.Parameters.AddWithValue("_name", textBox1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("__id_otdela", comboBox1.SelectedValue);
                mySqlCmd.Parameters.AddWithValue("_kol_tovara", _kol_tovara);
                mySqlCmd.Parameters.AddWithValue("_edinica_izmereniay", textBox4.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_cena_na_prod", textBox3.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Запись добавлена");
                Clear();
                GridFill();

                Hide();
                Form8DobNP form8 = new Form8DobNP();
                form8.ShowDialog();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void свойстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/Asus/Documents/Visual Studio 2017/Projects/Sklad_Ychet_Tovara/Sklad_Ychet_Tovara/Справочная система.chm");
        }
    }
}
