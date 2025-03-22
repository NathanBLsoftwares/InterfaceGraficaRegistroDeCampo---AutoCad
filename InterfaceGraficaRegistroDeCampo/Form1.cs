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
            foreach (SoftwaresNomes software in versoes.CheckedItems)
            {
                // Obtém o caminho base do registro
                string caminhoRegistry = software.Chave;

                // Define o caminho final dentro do registro
                string caminhoFinal = Path.Combine(caminhoRegistry, @"ACAD-8101\Applications");

                try
                {
                    // Abre ou cria a chave "Applications"
                    using (RegistryKey key = Registry.LocalMachine.CreateSubKey(caminhoFinal))
                    {
                        if (key != null)
                        {
                            // Cria a subpasta "PastaGenerica" no registro
                            using (RegistryKey subKey = key.CreateSubKey("PastaGenerica"))
                            {
                                if (subKey != null)
                                {
                                    // Cria quatro valores no registro dentro de "PastaGenerica"
                                    for (int i = 1; i <= 4; i++)
                                    {
                                        subKey.SetValue($"D_Drow_{i}", $"Valor de teste {i}");
                                    }
                                }
                            }
                        }
                    }

                    MessageBox.Show($"Pasta e valores criados no registro para {software.Software}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao modificar o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

