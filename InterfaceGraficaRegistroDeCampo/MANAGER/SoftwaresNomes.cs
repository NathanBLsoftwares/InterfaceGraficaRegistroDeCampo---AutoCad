namespace InterfaceGraficaRegistroDeCampo.MANAGER;

internal class SoftwaresNomes
{
    private string software;
    private string versao;
    private string chave;
    private bool ativacao;

    public string Software { get; set; }
    public string Versão { get; set; }
    public string  Chave 
    {
        get { return chave; }
        set { chave = value; } 
    }
    public bool Ativacao { get; set; }

    override public string ToString()
    {
        return $"{Software} - {Versão}";
    }

}
