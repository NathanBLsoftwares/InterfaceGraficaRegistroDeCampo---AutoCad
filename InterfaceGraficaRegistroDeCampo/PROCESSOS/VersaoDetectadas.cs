using InterfaceGraficaRegistroDeCampo.MANAGER;
using Microsoft.Win32;

namespace InterfaceGraficaRegistroDeCampo.PROCESSOS;

internal static class VersaoDetectadas
{
    
    public static string ValidarVersao(string nomeDoSoftware)
    {
        if (nomeDoSoftware.StartsWith("Z", StringComparison.OrdinalIgnoreCase))
        {
            return string.Empty;
        } else if (nomeDoSoftware.StartsWith("V", StringComparison.OrdinalIgnoreCase))
        {
            return nomeDoSoftware.Replace("V", "20");
        } else if (nomeDoSoftware.StartsWith("R", StringComparison.OrdinalIgnoreCase))
        {
            return nomeDoSoftware.Replace("R", "20");
        }
        else
        {
            return nomeDoSoftware;
        }
    }


    public static void AdicionarVersaoLista (List<SoftwaresNomes> listaDasVersoes, string CaminhoDoRegistry, string nomeDoSoftware)
    {
        RegistryKey? chaveDeRegistro = Registry.LocalMachine.OpenSubKey(CaminhoDoRegistry);
        if(chaveDeRegistro != null)
        {
            string[] nomeDasSubChaves = chaveDeRegistro.GetSubKeyNames();
            foreach(string subChave in nomeDasSubChaves)
            {
                string validarNome = ValidarVersao(subChave);
                if(validarNome != string.Empty)
                {
                    listaDasVersoes.Add(new SoftwaresNomes { Software = nomeDoSoftware, Versão = validarNome, Chave = $"{CaminhoDoRegistry}\\{nomeDoSoftware}" });
                }
                else
                {
                    listaDasVersoes.RemoveAll(elementosComz => elementosComz.Software == string.Empty);
                }
            }
            chaveDeRegistro.Close();
        }
    }


    public static List<SoftwaresNomes> MostrarVersao()
    {
        List<SoftwaresNomes> lista = new List<SoftwaresNomes>();
        AdicionarVersaoLista(lista, @"SOFTWARE\ZWSOFT\ZWCAD", "Zwcad");
        AdicionarVersaoLista(lista, @"SOFTWARE\GSTARSOFT\GSTARCAD", "Gstarcad");
        AdicionarVersaoLista(lista, @"SOFTWARE\Bricsys\Bricscad", "Bricscad");
        ProcurarVersaoAutoCad.VerificarAutoCad(lista, @"SOFTWARE\AUTODESK\AUTOCAD", "AutoCad");

        return lista;
    }

    public static void CaminhosParaCriacaoDasPastas(string caminhoDoRegistry)
    {
        string caminhoFinal = Path.Combine(caminhoDoRegistry, @"ACAD-8101\Applications");
        if (Directory.Exists(caminhoFinal) != true)
        {
            Directory.CreateDirectory(caminhoFinal);
        }
    }
}
