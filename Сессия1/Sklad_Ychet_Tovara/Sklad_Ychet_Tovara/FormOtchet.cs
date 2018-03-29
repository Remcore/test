using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using Microsoft.SqlServer;
using Microsoft.Win32;
using Microsoft.Reporting;
using Microsoft.ReportingServices;
using FastReport;
using System.Data.SqlClient;

namespace Sklad_Ychet_Tovara
{
    public partial class FormOtchet : Form
    {
        string connectionString = @"Database=database1;Data Source=127.0.0.1;User Id=root;Password=";
        int _id_tovara = 0;

        public FormOtchet()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TfrxReportClass report;
            report = new TfrxReportClass();
            report.ReportOptions.ConnectionName = @"Database=database1;Data Source=127.0.0.1;User Id=root;Password=";
            report.LoadReportFromFile("C:/Users/Asus/Desktop/1.fr3");
            // report.DesignReport(); редактирование отчета
            report.ShowReport();
            report.PrintOptions.PageNumbers = "";
            report.ExportToPDF("export1.txt", true, true, true, true,"","");

           
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
            Form3Prod form3 = new Form3Prod();
            form3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form5Post form5 = new Form5Post();
            form5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TfrxReportClass report;
            report = new TfrxReportClass();
            report.ReportOptions.ConnectionName = @"Database=database1;Data Source=127.0.0.1;User Id=root;Password=";
            report.LoadReportFromFile("C:/Users/Asus/Desktop/3.fr3");
            // report.DesignReport(); редактирование отчета
            report.ShowReport();
            report.PrintOptions.PageNumbers = "";
            report.ExportToTXT("export3.txt", true, true, true, true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TfrxReportClass report;
            report = new TfrxReportClass();
            report.ReportOptions.ConnectionName = @"Database=database1;Data Source=127.0.0.1;User Id=root;Password=";
            report.LoadReportFromFile("C:/Users/Asus/Desktop/2.fr3");
            // report.DesignReport(); редактирование отчета
            report.ShowReport();
            report.PrintOptions.PageNumbers = "";
            report.ExportToTXT("export2.txt", true, true, true, true);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/Asus/Documents/Visual Studio 2017/Projects/Sklad_Ychet_Tovara/Sklad_Ychet_Tovara/Справочная система.chm");
        }
    }
}
