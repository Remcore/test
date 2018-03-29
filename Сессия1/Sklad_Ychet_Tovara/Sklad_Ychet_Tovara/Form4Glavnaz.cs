using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklad_Ychet_Tovara
{
    public partial class Form4Glavnaz : Form
    {
        public Form4Glavnaz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form3Prod form3 = new Form3Prod();
            form3.ShowDialog();
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
            Form5Post form5 = new Form5Post();
            form5.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/Asus/Documents/Visual Studio 2017/Projects/Sklad_Ychet_Tovara/Sklad_Ychet_Tovara/Справочная система.chm");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            FormOtchet form2 = new FormOtchet();
            form2.ShowDialog();
        }
    }
}
