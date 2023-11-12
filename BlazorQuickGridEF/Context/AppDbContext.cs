using BlazorQuickGridEF.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorQuickGridEF.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Time> Times { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Time>().HasData(
            new Time
            {
                Id = 1,
                Nome = "Botafogo",
                Jogos = 32,
                Pontos = 59,
                Vitorias = 18,
                Empates = 5,
                Derrotas = 9,
                GolsPro = 51,
                SaldoGols = 23,
                TemMundial = false,
                Status = "Libertadores"
            },
            new Time
            {
                Id = 2,
                Nome = "Grêmio",
                Jogos = 33,
                Pontos = 59,
                Vitorias = 18,
                Empates = 5,
                Derrotas = 10,
                GolsPro = 57,
                SaldoGols = 8,
                TemMundial = true,
                Status = "Libertadores"
            },
            new Time
            {
                Id = 3,
                Nome = "Palmeiras",
                Jogos = 33,
                Pontos = 59,
                Vitorias = 17,
                Empates = 8,
                Derrotas = 8,
                GolsPro = 53,
                SaldoGols = 23,
                TemMundial = false,
                Status = "Libertadores"
            },
            new Time
            {
                Id = 4,
                Nome = "Red Bull Bragantino",
                Jogos = 32,
                Pontos = 58,
                Vitorias = 16,
                Empates = 10,
                Derrotas = 6,
                GolsPro = 44,
                SaldoGols = 17,
                TemMundial = false,
                Status = "Libertadores"
            },
             new Time
             {
                 Id = 5,
                 Nome = "Flamengo",
                 Jogos = 32,
                 Pontos = 56,
                 Vitorias = 16,
                 Empates = 8,
                 Derrotas = 8,
                 GolsPro = 49,
                 SaldoGols = 13,
                 TemMundial = true,
                 Status = "Libertadores"
             },
            new Time
            {
                Id = 6,
                Nome = "Atlético-MG",
                Jogos = 33,
                Pontos = 54,
                Vitorias = 15,
                Empates = 9,
                Derrotas = 9,
                GolsPro = 41,
                SaldoGols = 15,
                TemMundial = false,
                Status = "Libertadores"
            },
             new Time
             {
                 Id = 7,
                 Nome = "Athlético-PR",
                 Jogos = 33,
                 Pontos = 50,
                 Vitorias = 13,
                 Empates = 11,
                 Derrotas = 9,
                 GolsPro = 46,
                 SaldoGols = 8,
                 TemMundial = false,
                 Status = "Pré-Libertadores"
             },
            new Time
            {
                Id = 8,
                Nome = "Fluminense",
                Jogos = 32,
                Pontos = 46,
                Vitorias = 13,
                Empates = 7,
                Derrotas = 12,
                GolsPro = 42,
                SaldoGols = 1,
                TemMundial = false,
                Status = "Pré-Libertadores"
            },
             new Time
             {
                 Id = 9,
                 Nome = "São Paulo",
                 Jogos = 32,
                 Pontos = 45,
                 Vitorias = 12,
                 Empates = 9,
                 Derrotas = 11,
                 GolsPro = 37,
                 SaldoGols = 2,
                 TemMundial = true,
                 Status = "Sul-Americana"
             },
            new Time
            {
                Id = 10,
                Nome = "Cuiabá",
                Jogos = 33,
                Pontos = 44,
                Vitorias = 12,
                Empates = 8,
                Derrotas = 13,
                GolsPro = 34,
                SaldoGols = 0,
                TemMundial = false,
                Status = "Sul-Americana"
            }
        );
    }
}