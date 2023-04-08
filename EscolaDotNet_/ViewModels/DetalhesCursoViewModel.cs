using EscolaDotNet_.Models;
namespace EscolaDotNet_.ViewModels;

//criei a classe
public class DetalheCursoViewModel{
    //.NET 5
    // criar uma referência ("Curso" o primeiro é uma classe 'Curso') os dois são propriedades automaticas
    // execução pra criar é prop e o Tab
    public Curso Curso { get; set; } = null!; // tem que adicionar o (null)
    public string? TituloPagina { get; set; } //atribuir uma string vazio = string.Empty;
}

