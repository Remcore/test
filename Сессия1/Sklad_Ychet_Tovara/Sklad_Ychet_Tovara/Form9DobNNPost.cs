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
    public partial class Form9DobNNPost : Form
    {
        string connectionString = @"Database=database1;Data Source=127.0.0.1;User Id=root;Password=";
        int _id_post = 0;

        public Form9DobNNPost()
        {
            InitializeComponent();
        }

        void GridFill2()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("Postav_V", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable postavshchik = new DataTable();
                sqlDa.Fill(postavshchik);
                dataGridView1.DataSource = postavshchik;


                dataGridView1.Columns[0].HeaderText = "Код поставщика";
                dataGridView1.Columns[1].HeaderText = "Наименование компании";
                dataGridView1.Columns[2].HeaderText = "Адрес";
                dataGridView1.Columns[3].HeaderText = "Контактный номер телефона";

            }
        }

        void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            _id_post = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("postav_N", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__id_post", _id_post);
                mySqlCmd.Parameters.AddWithValue("_name_post", textBox1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_adres", textBox2.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_telefon", textBox3.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Запись добавлена");
                dataGridView1.Refresh();
                Clear();
                GridFill2();
            }
            Hide();
            Form8DobNP form8 = new Form8DobNP();
            form8.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form8DobNP form8 = new Form8DobNP();
            form8.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form9DobNNPost_Load(object sender, EventArgs e)
        {
            GridFill2();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/Asus/Documents/Visual Studio 2017/Projects/Sklad_Ychet_Tovara/Sklad_Ychet_Tovara/Справочная система.chm");
        }
    }
}
