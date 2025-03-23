using InterfaceGraficaRegistroDeCampo.MANAGER;
using InterfaceGraficaRegistroDeCampo.PROCESSOS;
using Microsoft.Win32;

namespace InterfaceGraficaRegistroDeCampo
{
    public partial class Form1 : Form
    {
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

        private void BotaoReveterInicializa��o_Click(object sender, EventArgs e)
        {
            foreach (SoftwaresNomes software in versoes.CheckedItems)
            {
                string caminhoDoRegistryDelete = software.Chave;
                string caminhoFinalDelete = Path.Combine(caminhoDoRegistryDelete, @"ACAD-8101\Applications\PastaGenerica");

                try
                {
                    if (Directory.Exists(caminhoFinalDelete)) // Verifica se � um diret�rio
                    {
                        // Deletar o diret�rio e seu conte�do
                        Directory.Delete(caminhoFinalDelete, true);
                        MessageBox.Show("Diret�rio e seus arquivos exclu�dos com sucesso", "Reverter inicializa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (File.Exists(caminhoFinalDelete)) // Verifica se � um arquivo
                    {
                        // Deletar o arquivo
                        File.Delete(caminhoFinalDelete);
                        MessageBox.Show("Arquivo exclu�do com sucesso", "Reverter inicializa��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("O caminho especificado n�o � um arquivo ou diret�rio v�lido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BotaoDeInicializacao_Click(object sender, EventArgs e)
        {
            foreach (SoftwaresNomes software in versoes.CheckedItems)
            {
                // Obt�m o caminho base do registro
                string caminhoRegistry = software.Chave;

                // Define o caminho final dentro do registro
                string caminhoFinal = Path.Combine(caminhoRegistry, @"ACAD-8101\Applications");

                try
                {
                    // Abre ou cria a chave "Applications"
                    using (RegistryKey ChaveDeAcesso = Registry.LocalMachine.CreateSubKey(caminhoFinal))
                    {
                        if (ChaveDeAcesso != null)
                        {
                            // Cria a subpasta "PastaGenerica" no registro
                            using (RegistryKey subKey = ChaveDeAcesso.CreateSubKey("PastaGenerica"))
                            {
                                if (subKey != null)
                                {
                                    // Cria quatro valores no registro dentro de "PastaGenerica"
                                    for (int i = 1; i <= 2; i++)
                                    {
                                        string nomeChave = $"Managed";
                                        string nomeChave1 = $"LOADCTRLS";
                                        // Valor para o REG_DWORD (14)
                                        int valorDWORD = 14;
                                        // Criando ou alterando o valor do registro
                                        Registry.SetValue(subKey.ToString(), nomeChave, valorDWORD, RegistryValueKind.DWord);
                                        Registry.SetValue(subKey.ToString(), nomeChave1, valorDWORD, RegistryValueKind.DWord);
                                    }
                                    for(int i = 1; i <= 2; i++)
                                    {
                                        string arquivoTXT = "DESCRIPTION";
                                        string arquivoTXT1 = "LOADER";
                                        Registry.SetValue(subKey.ToString(), arquivoTXT, "Pasta Generica", RegistryValueKind.String);
                                        Registry.SetValue(subKey.ToString(), arquivoTXT1, caminhoFinal, RegistryValueKind.String);
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

