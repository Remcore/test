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
    public partial class FormIzmenenie : Form
    {
        string connectionString = @"Database=database1;Data Source=127.0.0.1;User Id=root;Password=";
        int _id_prod = 0;

        public FormIzmenenie()
        {
            InitializeComponent();
        }

        private void FormIzmenenie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.prodazha". При необходимости она может быть перемещена или удалена.
            this.prodazhaTableAdapter.Fill(this.database1DataSet.prodazha);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.database1DataSet.tovar);
            GridFill2();
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
                dataGridView1.DataSource = prodazha;


                dataGridView1.Columns[0].HeaderText = "Номер продажи";
                dataGridView1.Columns[1].HeaderText = "Наименование товара";
                dataGridView1.Columns[2].HeaderText = "Количество товара";
                dataGridView1.Columns[3].HeaderText = "Дата";
            }
        }

        void Clear()
        {
            comboBox1.Text = txtkol_prod.Text = "";
            button1.Text = "Сохранить";
          
                comboBox1.Text = txtkol_prod.Text = "";
                _id_prod = 0;
                //btnSave.Text = "Сохранить";
                btnDelete.Enabled = false;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Hide();
            Form3Prod form212 = new Form3Prod();
            form212.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
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
                GridFill2();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtkol_prod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                
                _id_prod = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("prodazhaDeletByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__id_prod", _id_prod);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Запись удалина");
                dataGridView1.Refresh();
                Clear();
                GridFill2();
            }
        }
    }
}
