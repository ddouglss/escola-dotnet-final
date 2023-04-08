using EscolaDotNet_.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EscolaDotNet_.EntityConfigs;


public class CursoEntityConfig : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        //ocorrer o mapeamento
        builder.ToTable("Curso");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
                .HasColumnName("Id");

        builder.Property(c => c.Nome)
                .HasColumnName("nome")
                .HasColumnType("nvarchar(100)")
                .IsRequired();

        builder.Property(c => c.Titulo)
                .HasColumnName("titulo")
                .HasColumnType("nvarchar(100)")
                .IsRequired();

        builder.Property(c => c.Descricao)
                .HasColumnName("descicao")
                .HasColumnType("nvarchar(100)")
                .IsRequired();

        builder.Property(c => c.Perfil)
                .HasColumnName("prefil")
                .HasColumnType("nvarchar(100)")
                .IsRequired();

        builder.Property(c => c.PreRequisitos)
                .HasColumnName("requisitos")
                .HasColumnType("nvarchar(100)")
                .IsRequired();

        builder.Property(c => c.Conteudo)
                .HasColumnName("conteudo")
                .HasColumnType("text") //fluent API
                .IsRequired();

        builder.Property(c => c.Recursos)
                .HasColumnName("recursos")
                .HasColumnType("nvarchar(100)")
                .IsRequired();

        builder.Property(c => c.CargaHoraria)
                .HasColumnName("ch")
                .HasColumnType("int")
                .IsRequired();

        builder.Property(c => c.PrazoMeses)
                .HasColumnName("prazo")
                .HasColumnType("int")
                .IsRequired();
    }
}

