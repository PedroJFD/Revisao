namespace Revisao
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            lb_sexo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Divisao divisao = new Divisao();

            divisao.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbt_a.Checked)
            {
                string sexo = rbt_a.Text;
                lb_sexo.Text = sexo;
            }
            else if (rbt_b.Checked)
            {
                string sexo = rbt_b.Text;
                lb_sexo.Text = sexo;
            }
        }
    }
}