namespace HotelPets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Pega todos o s dados necessários
            decimal quantidade = numAnimais.Value;
            decimal consumo = numRacao.Value;
            decimal dias = numHospedagem.Value;

            decimal racao = quantidade * consumo * dias;

            //Coloca o resultado na legenda
            lblresultado.Text = racao.ToString("N2");
        }
    }
}