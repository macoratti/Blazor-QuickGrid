namespace BlazorQuickGridEF.Entities;

public class Time
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public int Pontos { get; set; }
    public int Jogos { get; set; }
    public int Vitorias { get; set; }
    public int Empates { get; set; }
    public int Derrotas { get; set; }
    public int SaldoGols { get; set; }
    public int GolsPro { get; set; }
    public string Status { get; set; } = string.Empty;
    public bool TemMundial { get; set; }
}
