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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pas = "krol";
            if (textBox1.Text == pas)
            {
                Hide();
                TovarIzmenenie form2 = new TovarIzmenenie();
                form2.ShowDialog();
            }
            else
                MessageBox.Show("Неверный пароль");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2Tovar form2 = new Form2Tovar();
            form2.ShowDialog();
        }
    }
}
