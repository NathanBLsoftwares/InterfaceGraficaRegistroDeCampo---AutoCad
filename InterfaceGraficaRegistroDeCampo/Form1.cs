using InterfaceGraficaRegistroDeCampo.MANAGER;
using InterfaceGraficaRegistroDeCampo.PROCESSOS;
using Microsoft.Win32;

namespace InterfaceGraficaRegistroDeCampo
{
    public partial class Form1 : Form
    {
        private string novocaminho;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<SoftwaresNomes> lista = VersaoDetectadas.MostrarVersao();
            foreach (var software in lista)
            {
                versoes.Items.Add(software);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotaoReveterInicialização_Click(object sender, EventArgs e)
        {

        }

        private void BotaoDeInicializacao_Click(object sender, EventArgs e)
        {
           
        }
    }    
}
