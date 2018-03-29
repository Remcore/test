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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            string pas = "parol";
            if (textBox1.Text == pas)
            {
                Hide();
                Form4Glavnaz form2 = new Form4Glavnaz();
                form2.ShowDialog();
            }
            else
                MessageBox.Show("Неверный пароль");
                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
