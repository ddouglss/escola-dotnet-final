using EscolaDotNet_.EntityConfigs;
using EscolaDotNet_.Models;
using Microsoft.EntityFrameworkCore;
 
namespace EscolaDotNet_.Contexts;

public class AppDbContext : DbContext
{ //representa o banco

    public DbSet<Curso> Cursos => Set<Curso>();//representa a tabela

    //E a Conexão?
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {

        builder.UseSqlServer("Server=DESKTOP-7BKR55I;Database=EscolaDotNet_;User Id=sa;Password=senai@123;TrustServerCertificate=True;");

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new CursoEntityConfig());
    }
}