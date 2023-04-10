using EscolaDotNet_.Models;
namespace EscolaDotNet_.ViewModels;

public class ListaCursoViewModel{
    //lista de coleção
    /*
        ICollection<Card> Album {get;set;} = new List<Card>();
    */
    public ICollection<Curso> Cursos { get; set; } = new List<Curso>();

}