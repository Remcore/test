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
    public partial class Form6Postav : Form
    {
        string connectionString = @"Database=database1;Data Source=127.0.0.1;User Id=root;Password=";
        int _id_post = 0;

        public Form6Postav()
        {
            InitializeComponent();
        }

        private void Form6Postav_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.postavshchik". При необходимости она может быть перемещена или удалена.
            this.postavshchikTableAdapter.Fill(this.database1DataSet1.postavshchik);
            GridFill();
            GridFill2();
            GridFill3();
            Clear();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form4Glavnaz form22 = new Form4Glavnaz();
            form22.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form2Tovar form255 = new Form2Tovar();
            form255.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form5Post form225 = new Form5Post();
            form225.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("PoiskPoKodyPostav", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", textBox1.Text);
                DataTable postavshchik = new DataTable();
                sqlDa.Fill(postavshchik);
                dataGridView1.DataSource = postavshchik;
                
                dataGridView1.Columns[0].HeaderText = "Код поставщика";
                dataGridView1.Columns[1].HeaderText = "Наименование компании";
                dataGridView1.Columns[2].HeaderText = "Адрес";
                dataGridView1.Columns[3].HeaderText = "Контактный номер телефона";
                Clear();
            }
        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("postavshchikViewAll", mysqlCon);
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
        void GridFill2()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("postavshchikViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable postavshchik = new DataTable();
                sqlDa.Fill(postavshchik);
                dataGridView2.DataSource = postavshchik;


                dataGridView2.Columns[0].HeaderText = "Код поставщика";
                dataGridView2.Columns[1].HeaderText = "Наименование компании";
                dataGridView2.Columns[2].HeaderText = "Адрес";
                dataGridView2.Columns[3].HeaderText = "Контактный номер телефона";

            }
        }
        void GridFill3()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("postavshchikViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable postavshchik = new DataTable();
                sqlDa.Fill(postavshchik);
                dataGridView3.DataSource = postavshchik;
                
                dataGridView3.Columns[0].HeaderText = "Код поставщика";
                dataGridView3.Columns[1].HeaderText = "Наименование компании";
                dataGridView3.Columns[2].HeaderText = "Адрес";
                dataGridView3.Columns[3].HeaderText = "Контактный номер телефона";

            }
        }

        void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            _id_post = 0;
            button7.Text = "Добавить";
            button8.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("PoiskPoTelefony", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", textBox2.Text);
                DataTable postavshchik = new DataTable();
                sqlDa.Fill(postavshchik);
                dataGridView1.DataSource = postavshchik;

                dataGridView1.Columns[0].HeaderText = "Код поставщика";
                dataGridView1.Columns[1].HeaderText = "Наименование компании";
                dataGridView1.Columns[2].HeaderText = "Адрес";
                dataGridView1.Columns[3].HeaderText = "Контактный номер телефона";
                Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("PoiskPoName", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", textBox3.Text);
                DataTable postavshchik = new DataTable();
                sqlDa.Fill(postavshchik);
                dataGridView1.DataSource = postavshchik;

                dataGridView1.Columns[0].HeaderText = "Код поставщика";
                dataGridView1.Columns[1].HeaderText = "Наименование компании";
                dataGridView1.Columns[2].HeaderText = "Адрес";
                dataGridView1.Columns[3].HeaderText = "Контактный номер телефона";
                Clear();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GridFill();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow.Index != -1)
            {
               
                _id_post = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                button8.Enabled = Enabled;
            }
        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow.Index != -1)
            {
                textBox9.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
                textBox8.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
                textBox7.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
                _id_post = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value.ToString());
               
            }            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("postav_N", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__id_post", _id_post);
                mySqlCmd.Parameters.AddWithValue("_name_post", textBox4.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_adres", textBox5.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_telefon", textBox6.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Запись добавлена");
                dataGridView1.Refresh();
                Clear();
                GridFill2();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("Postav_DeletByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__id_post", _id_post);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Запись удалина");
                dataGridView1.Refresh();
                Clear();
                GridFill2();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("postav_N", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__id_post", _id_post);
                mySqlCmd.Parameters.AddWithValue("_name_post", textBox9.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_adres", textBox8.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_telefon", textBox7.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Изменения внесены");
                dataGridView3.Refresh();
                Clear();
                GridFill3();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GridFill2();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/Asus/Documents/Visual Studio 2017/Projects/Sklad_Ychet_Tovara/Sklad_Ychet_Tovara/Справочная система.chm");
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch !=8)
            {
                e.Handled = true;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
