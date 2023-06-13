using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisao
{
    public partial class Divisao : Form
    {
        public Divisao()
        {
            InitializeComponent();
            lb_resultado.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int txvalor1 = Convert.ToInt32(tx_valor1.Text);
                int txvalor2 = Convert.ToInt32(tx_valor2.Text);

                int c = txvalor1 / txvalor2;

                lb_resultado.Text = c.ToString();

            }
            catch { }

        }
    }
}
