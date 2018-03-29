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
    public partial class Form5Post : Form
    {
        string connectionString = @"Database=database1;Data Source=127.0.0.1;User Id=root;Password=";
        int _id_zakaza = 0;
        
        public Form5Post()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form4Glavnaz form22 = new Form4Glavnaz();
            form22.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2Tovar form2 = new Form2Tovar();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form6Postav form6 = new Form6Postav();
            form6.ShowDialog();
        }

        
        //void GridFill2()
        //{
        //    using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
        //    {
        //        mysqlCon.Open();
        //        MySqlDataAdapter sqlDa = new MySqlDataAdapter("postavkiViewAll", mysqlCon);
        //        sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        DataTable postavki = new DataTable();
        //        sqlDa.Fill(postavki);
        //        dataGridView2.DataSource = postavki;


        //        dataGridView2.Columns[0].HeaderText = "Код поставки";
        //        dataGridView2.Columns[1].HeaderText = "Товар";
        //        dataGridView2.Columns[2].HeaderText = "Поставщик";
        //        dataGridView2.Columns[3].HeaderText = "Количество товара";
        //        dataGridView2.Columns[4].HeaderText = "Дата поступления";

        //    }
        //}

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("postavkiViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable postavki = new DataTable();
                sqlDa.Fill(postavki);
                dataGridView1.DataSource = postavki;


                dataGridView1.Columns[0].HeaderText = "Код поставки";
                dataGridView1.Columns[1].HeaderText = "Товар";
                dataGridView1.Columns[2].HeaderText = "Поставщик";
                dataGridView1.Columns[3].HeaderText = "Количество товара";
                dataGridView1.Columns[4].HeaderText = "Дата поступления";

            }
        }
        void GridFill4()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("postavki_VV", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable postavki = new DataTable();
                sqlDa.Fill(postavki);
                dataGridView2.DataSource = postavki;


                dataGridView2.Columns[0].HeaderText = "Код поставки";
                dataGridView2.Columns[1].HeaderText = "Товар";
                dataGridView2.Columns[2].HeaderText = "Поставщик";
                dataGridView2.Columns[3].HeaderText = "Количество товара";
                dataGridView2.Columns[4].HeaderText = "Дата поступления";

            }
        }

        void Clear()
        {
            
            textBox4.Text = textBox4.Text = "";
           
            _id_zakaza = 0;
            //button6.Text = "Сохранить";
            
        }

        private void Form5Post_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.database1DataSet1.tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.postavshchik". При необходимости она может быть перемещена или удалена.
            this.postavshchikTableAdapter.Fill(this.database1DataSet1.postavshchik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.postavki". При необходимости она может быть перемещена или удалена.
            this.postavkiTableAdapter.Fill(this.database1DataSet1.postavki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.postavki". При необходимости она может быть перемещена или удалена.
            this.postavkiTableAdapter.Fill(this.database1DataSet1.postavki);
           
            textBox4.Clear();
            Clear();
            GridFill();
            //GridFill2();
            GridFill4();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("postavkiSearchByValueZAKAZ", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", textBox1.Text);
                DataTable postavki = new DataTable();
                sqlDa.Fill(postavki);
                dataGridView1.DataSource = postavki;

                dataGridView1.Columns[0].HeaderText = "Код поставки";
                dataGridView1.Columns[1].HeaderText = "Товар";
                dataGridView1.Columns[2].HeaderText = "Поставщик";
                dataGridView1.Columns[3].HeaderText = "Количество товара";
                dataGridView1.Columns[4].HeaderText = "Дата поступления";
            }

        }

       

        private void button6_Click(object sender, EventArgs e)
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
                MessageBox.Show("Запись добавлена");
                dataGridView2.Refresh();
                Clear();
                GridFill4();

                comboBox2.Visible = false;
                comboBox1.Visible = false;
                textBox4.Visible = false;
                dateTimePicker1.Visible = false;

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label6.Visible = false;

                button6.Visible = false;
                button10.Visible = false;

               
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            //if (dataGridView2.CurrentRow.Index != -1)
            //{              
            //    _id_zakaza = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            //   // button6.Text = "Успешное изменение!";
            //    button5.Enabled = Enabled;
            //    //MessageBox.Show("Успешное изменение!");
            //}
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            Form7DobNT form7 = new Form7DobNT();
            form7.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            Form42 form2 = new Form42();
            form2.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            textBox4.Visible = true;
            dateTimePicker1.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;

            button6.Visible = true;
            button10.Visible = true;

            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            comboBox2.Visible = false;
            textBox4.Visible = false;
            dateTimePicker1.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;

            button6.Visible = false;
            button10.Visible = false;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GridFill();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/Asus/Documents/Visual Studio 2017/Projects/Sklad_Ychet_Tovara/Sklad_Ychet_Tovara/Справочная система.chm");
        }
    }
}
