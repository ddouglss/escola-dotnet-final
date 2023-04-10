using EscolaDotNet_.Contexts;
using EscolaDotNet_.ViewModels;
using Microsoft.AspNetCore.Mvc;//importando do "Controller"
//divisão logica
namespace EscolaDotNet_.Controllers;//determinar umm namespace

public class CursoController:Controller{ //processo de herança e pra herdar é preciso dos ":" 

private readonly AppDbContext _context;

public CursoController(AppDbContext context){
//Injeção de dependência: você vai deixar o framework resolver a questão da injeção
//AppDbContext c = new AppDbContext(); --> A injeção de dependência em síntese fica responsável pelo new
    _context = context;

}

    public IActionResult Index(){
        //lista de Cursos
        var cursos = _context.Cursos.ToList();

        //já tenho o ViewModel
        var ViewModel = new ListaCursoViewModel{Cursos = cursos};
        return View(ViewModel);
    }
}