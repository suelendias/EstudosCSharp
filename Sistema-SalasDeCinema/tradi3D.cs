using System;
public class Tradi3D : Bilhete
{
    private String tipoSala;
    private String tela;
    private String resolucao;
    private String capacidade;
    public Bilhete ingresso3;

    public string TipoSala { get => tipoSala; set => tipoSala = value; }
    public string Tela { get => tela; set => tela = value; }
    public string Resolucao { get => resolucao; set => resolucao = value; }
    public string Capacidade { get => capacidade; set => capacidade = value; }

            public Tradi3D ()
            {

            }

            public Tradi3D (string TipoSala, string Tela, string Resolucao, string Capacidade)
            {
                this.TipoSala = TipoSala;
                this.Tela = Tela;
                this.Resolucao = Resolucao;
                this.Capacidade = Capacidade;
            }  

            public void ExibirDados()
            {
                ExibirDados(ConsoleColor.Gray);
            }
            
            public void ExibirDados(ConsoleColor cor)
            {
                Console.WriteLine(ObterDados());                              
            }

            public string ObterDados()
            {
                return $"----------BILHETE---------- \n Código de Bilhete: {ingresso3.CodigoBilhete}\n Valor de Bilhete: {ingresso3.Valor}\n Data: {ingresso3.Data}\n Tipo de Sala: {TipoSala}\n Tela: {Tela}\n Resolução: {Resolucao}\n Capacidade Total: {Capacidade}\n";
            }

}