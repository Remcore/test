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
    public partial class Form3Prod : Form
    {
        string connectionString = @"Database=database1;Data Source=127.0.0.1;User Id=root;Password=";
        int _id_prod = 0;


        public Form3Prod()
        {
            InitializeComponent();
        }

        private void Form3Prod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.database1DataSet.tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.prodazha". При необходимости она может быть перемещена или удалена.

            this.prodazhaTableAdapter.Fill(this.database1DataSet.prodazha);
           // comboBox1.Clear();
            txtkol_prod.Clear();
            Clear();
            GridFill();
            GridFill2();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

                MySqlCommand mySqlCmd = new MySqlCommand("prodazhaAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__id_prod", _id_prod);
                mySqlCmd.Parameters.AddWithValue("__id_tovara", comboBox1.SelectedValue);
                mySqlCmd.Parameters.AddWithValue("_kol_prod", txtkol_prod.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_data", dateTimePicker1.Value);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Запись добавлена");
                dataGridView1.Refresh();
                Clear();
                GridFill();
            }
            //textBox1.Visible = false;
            txtkol_prod.Visible = false;
            label1.Visible = false;            
            label2.Visible = false;
            btnSave.Visible = false;
            dateTimePicker1.Visible = false;
            label4.Visible = false;
            button6.Visible = false;
         //   dataGridView3.Visible = false;
        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("prodazhaViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable prodazha = new DataTable();
                sqlDa.Fill(prodazha);
                dataGridView1.DataSource = prodazha;
                

                dataGridView1.Columns[0].HeaderText = "Номер продажи";
                dataGridView1.Columns[1].HeaderText = "Наименование товара";
                dataGridView1.Columns[2].HeaderText = "Количество товара";
                dataGridView1.Columns[3].HeaderText = "Дата";
            }
        }
        void GridFill2()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("prodazhaViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable prodazha = new DataTable();
                sqlDa.Fill(prodazha);
                dataGridView2.DataSource = prodazha;


                dataGridView2.Columns[0].HeaderText = "Номер продажи";
                dataGridView2.Columns[1].HeaderText = "Наименование товара";
                dataGridView2.Columns[2].HeaderText = "Количество товара";
                dataGridView2.Columns[3].HeaderText = "Дата";
            }
        }

        void Clear()
        {
            comboBox1.Text = txtkol_prod.Text = "";
            _id_prod = 0;
            btnSave.Text = "Сохранить";
            //btnDelete.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("prodazhaSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable prodazha = new DataTable();
                sqlDa.Fill(prodazha);
                dataGridView1.DataSource = prodazha;               
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                //comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //txtkol_prod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                _id_prod = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                btnSave.Text = "Сохранить";
                //1btnDelete.Enabled = Enabled;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form4Glavnaz form22 = new Form4Glavnaz();
            form22.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            label1.Visible = true;
            txtkol_prod.Visible = true;
            label2.Visible = true;
            btnSave.Visible = true;
            dateTimePicker1.Visible = true;
            label4.Visible = true;
            button6.Visible = true;
            //dataGridView3.Visible = true;
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form41 form27 = new Form41();
            form27.ShowDialog();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            txtkol_prod.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            btnSave.Visible = false;
            dateTimePicker1.Visible = false;
            label4.Visible = false;
            button6.Visible = false;
            //dataGridView3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form2Tovar form2T = new Form2Tovar();
            form2T.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("prodazhaSearch", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", dateTimePicker1.Value);
                DataTable prodazha = new DataTable();
                sqlDa.Fill(prodazha);
                dataGridView1.DataSource = prodazha;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GridFill();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow.Index != -1)
            {
                _id_prod = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                // MessageBox.Show("Успешное изменение!");
                //btnDelete.Enabled = Enabled;
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/Asus/Documents/Visual Studio 2017/Projects/Sklad_Ychet_Tovara/Sklad_Ychet_Tovara/Справочная система.chm");
        }
    }
}
