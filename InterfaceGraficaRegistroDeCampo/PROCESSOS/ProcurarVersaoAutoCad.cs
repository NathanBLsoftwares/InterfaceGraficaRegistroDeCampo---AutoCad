using InterfaceGraficaRegistroDeCampo.MANAGER;
using Microsoft.Win32;

namespace InterfaceGraficaRegistroDeCampo.PROCESSOS;

internal static class ProcurarVersaoAutoCad
{
    public static void VerificarAutoCad(List<SoftwaresNomes> listasCad, string caminhoSoftware, string nomeDoSfotware)
    {
        RegistryKey ChaveDeRegistroCad = Registry.LocalMachine.OpenSubKey(caminhoSoftware);
        if(ChaveDeRegistroCad != null)
        {
            string[] versaoCad = ChaveDeRegistroCad.GetSubKeyNames();
            foreach(string versao in versaoCad)
            {
                switch (versao)
                {
                    case "R21.0":
                        listasCad.Add(new SoftwaresNomes { Software = "AutoCad", Versão = "2017", Chave = $"{caminhoSoftware}\\{versao}" });
                        break;
                    case "R22.0":
                        listasCad.Add(new SoftwaresNomes { Software = "AutoCad", Versão = "2018", Chave = $"{caminhoSoftware}\\{versao}" });
                        break;
                    case "R23.0":
                        listasCad.Add(new SoftwaresNomes { Software = "AutoCad", Versão = "2019", Chave = $"{caminhoSoftware}\\{versao}" });
                        break;
                    case "R23.1":
                        listasCad.Add(new SoftwaresNomes { Software = "AutoCad", Versão = "2020", Chave = $"{caminhoSoftware}\\{versao}" });
                        break;
                    case "R24.0":
                        listasCad.Add(new SoftwaresNomes { Software = "AutoCad", Versão = "2021", Chave = $"{caminhoSoftware}\\{versao}" });
                        break;
                    case "R24.1":
                        listasCad.Add(new SoftwaresNomes { Software = "AutoCad", Versão = "2022", Chave = $"{caminhoSoftware}\\{versao}" });
                        break;
                    case "R24.2":
                        listasCad.Add(new SoftwaresNomes { Software = "AutoCad", Versão = "2023", Chave = $"{caminhoSoftware}\\{versao}" });
                        break;
                    case "R24.3":
                        listasCad.Add(new SoftwaresNomes { Software = "AutoCad", Versão = "2024", Chave = $"{caminhoSoftware}\\{versao}" });
                        break;
                    case "R25.0":
                        listasCad.Add(new SoftwaresNomes { Software = "AutoCad", Versão = "2025", Chave = $"{caminhoSoftware}\\{versao}" });
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
