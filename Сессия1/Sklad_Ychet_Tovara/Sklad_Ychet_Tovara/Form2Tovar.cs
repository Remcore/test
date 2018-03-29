using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.SqlServer;
using Microsoft.Win32;
using Microsoft.Reporting;
using Microsoft.ReportingServices;
using FastReport;



namespace Sklad_Ychet_Tovara
{
    public partial class Form2Tovar : Form
    {

        string connectionString = @"Database=database1;Data Source=127.0.0.1;User Id=root;Password=";
        int _id_tovara = 0;

        public Form2Tovar()
        {
            InitializeComponent();
        }

        private void Form2Tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.opisanie". При необходимости она может быть перемещена или удалена.
            this.opisanieTableAdapter.Fill(this.database1DataSet1.opisanie);
            GridFill();
            GridFill2();
            //GridFill3();
            textBox6.Clear();
            
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            Clear();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GridFill2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("tovarAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("__id_tovara",_id_tovara);
                mySqlCmd.Parameters.AddWithValue("_name", textBox6.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("__id_otdela", comboBox1.SelectedValue);
                mySqlCmd.Parameters.AddWithValue("_kol_tovara", textBox3.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_edinica_izmereniay", textBox4.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_cena_na_prod", textBox5.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Запись добавлена");
                dataGridView2.Refresh();
                Clear();
                GridFill2();

                comboBox1.Visible = false;
                label1.Visible = false;
                textBox3.Visible = false;
                label2.Visible = false;
                button2.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                label5.Visible = false;
                button10.Visible = false;
            }
        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("tovar_obnovlenie", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable tovar = new DataTable();
                sqlDa.Fill(tovar);
                dataGridView1.DataSource = tovar;

                dataGridView1.Columns[0].HeaderText = "Код товара";
                dataGridView1.Columns[1].HeaderText = "Наименование товара";
                dataGridView1.Columns[2].HeaderText = "Номер отдела";
                dataGridView1.Columns[3].HeaderText = "Еденица измерения";
                dataGridView1.Columns[4].HeaderText = "Колличество товара";
                dataGridView1.Columns[5].HeaderText = "Цена товара";
            }
        }
        
        void GridFill2()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("tovarViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable tovar = new DataTable();
                sqlDa.Fill(tovar);
                dataGridView2.DataSource = tovar;


                dataGridView2.Columns[0].HeaderText = "Код товара";
                dataGridView2.Columns[1].HeaderText = "Наименование товара";
                dataGridView2.Columns[2].HeaderText = "Номер отдела";
                dataGridView2.Columns[3].HeaderText = "Еденица измерения";
                dataGridView2.Columns[4].HeaderText = "Колличество товара";
                dataGridView2.Columns[5].HeaderText = "Цена товара";
            }
        }


        void Clear()
        {
            //textBox2.Text = textBox2.Text = "";
            textBox6.Text = textBox6.Text = "";
            textBox3.Text = textBox3.Text = "";
            textBox4.Text = textBox4.Text = "";
            textBox5.Text = textBox5.Text = "";
            comboBox1.Text = comboBox1.Text = "";
            _id_tovara = 0;
            button2.Text = "Сохранить";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form4Glavnaz form4 = new Form4Glavnaz();
            form4.ShowDialog();
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

        private void tabPage1_Click(object sender, EventArgs e)
        {           
                                                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("tovarSearchByValueNAME", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", textBox1.Text);
                DataTable tovar = new DataTable();
                sqlDa.Fill(tovar);
                dataGridView1.DataSource = tovar;
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow.Index != -1)
            {
                //textBox6.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                //textBox2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                //textBox3.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                //textBox4.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                //textBox5.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();

                _id_tovara = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                //button2.Text = "Успешное изменение!";
                //button5.Enabled = Enabled;
                //MessageBox.Show("Успешное изменение!");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView2.CurrentRow.Index != -1)
            //{
            //    textBox6.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            //    textBox2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            //    textBox3.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            //    textBox4.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            //    textBox5.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            //    _id_tovara = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //   // MessageBox.Show("Успешное изменение!");
            //    //btnSave.Text = "Успешное изменение!";
               
            //}
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("tovar_obnovlenie", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable tovar = new DataTable();
                sqlDa.Fill(tovar);
                dataGridView1.DataSource = tovar;

                dataGridView1.Columns[0].HeaderText = "Код товара";
                dataGridView1.Columns[1].HeaderText = "Наименование товара";
                dataGridView1.Columns[2].HeaderText = "Номер отдела";
                dataGridView1.Columns[3].HeaderText = "Еденица измерения";
                dataGridView1.Columns[4].HeaderText = "Колличество товара";
                dataGridView1.Columns[5].HeaderText = "Цена товара";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form3Prod form3 = new Form3Prod();
            form3.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            label1.Visible = true;
            textBox3.Visible = true;
            label2.Visible = true;
            button2.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            button10.Visible = true;
        }

        private void dataGridView2_MouseHover(object sender, EventArgs e)
        {

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            //button5.BackColor = System.Drawing.Color.Blue;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            TfrxReportClass report;
            report = new TfrxReportClass();
            report.ReportOptions.ConnectionName = @"Database=database1;Data Source=127.0.0.1;User Id=root;Password=";
            report.LoadReportFromFile("C:/Users/Asus/Desktop/1.fr3");
           // report.DesignReport();
            report.ShowReport();
            report.PrintOptions.PageNumbers = "";
            
            report.ExportToTXT("export.txt", true, true, true,true);
            //report.ExportToPDF("export.pdf", true, true, true);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Hide();
            // form24 = new ();
            //form24.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            FileStream File = new FileStream(@"C:/Users/Asus/Documents/Visual Studio 2017/Projects/Sklad_Ychet_Tovara/Sklad_Ychet_Tovara/bin/Debug/export.txt", FileMode.Open);
            textBox1.Text = File.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form5Post form241 = new Form5Post();
            form241.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            label1.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;
            button2.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
           
            button10.Visible = false;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/Asus/Documents/Visual Studio 2017/Projects/Sklad_Ychet_Tovara/Sklad_Ychet_Tovara/Справочная система.chm");
        }
    }
}
