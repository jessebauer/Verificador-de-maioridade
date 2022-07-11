namespace maiorDeIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resposta.Visible = false;
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            try { 
            int idade;
            idade = Convert.ToInt16(txtIdade.Text);
            if (idade >= 18)
            {
                MessageBox.Show($"Sua idade é {idade}, logo você é MAIOR de idade!");
                    resposta.Text = $"idade {idade}";
                    resposta.Visible = true;

            } else if (idade > 0)
            {
                MessageBox.Show($"Sua idade é {idade}, logo você é MENOR de idade");
                    resposta.Text = $"idade {idade}";
                    resposta.Visible = true;
                } else
            {
                MessageBox.Show("Número inválido");
            }
            } catch
            {
                MessageBox.Show("Erro, tente novamente","Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            
        }
    }
}