using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EscolaDotNet_.Models;
using EscolaDotNet_.ViewModels;

namespace EscolaDotNet_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   //var - declaração da variável
        //new - operador de instanciação
        //Curso( ) - chamada ao Construtor da classe Curso
        //Construtor - construir o objeto na memória.

        var curso = new Curso()
        { // 
          //Mock (dados de teste - fictício)
          //Propriedades automáticas do 25 ao 33 e é definida na pasta models
            Id = 1,
            Nome = "Introdução a programação",
            Titulo = "Primeiros passos na programação",
            Descricao = "Domine a programação com nosso curso completo - aprenda desde o básico até o avançado e desenvolva suas próprias aplicações com confiança!",
            Perfil = "estudantes e aprendizes no geral",
            PreRequisitos = "informática básica",
            Conteudo = "1-introdução 2-lógica 3-estruturas 4-vetores 5-funções 6-matrizes 7-estruturas de dados 8-registros",
            CargaHoraria = 40,
            PrazoMeses = 1

        };

        //ViewDataDictionary
        //chave - valor
        // ViewData["curso"] = curso; // recurso de chave : valor //atribuir um objeto
        ViewBag.Curso = curso;
        TempData["mensagem"] = "Mensagem vindo da Action Index";
        //string interpolada
        /*  int ch =40;
       //Dicionário (ViewDataDictionary)
       ViewData["nome"] ="TI Essencial";
       ViewData["titulo"] ="Uma visão geral da TI"; 
       ViewData ["ch"] = $"Termos {ch} horas de imersão nos fundametos da TI";
       ViewData ["descricao"] ="Nesse curso você vai aprender os primeiros passos da tecnologia da informação, conhecer o hardware, software, redes, protocolos e conhecimentos básicos para depois mergulhar no mundo do desenvolvimento de software da Microsoft ";

          Para transporta dados de um controller para uma View 
          Podemos usar ViewData, Viewbag e TempData

          Competência ViewData 
          Competência Viewbag
          Competência TempData
       */

        /* 
        TempData[] - a diferença dp TemmData para ViewData[] e ViewBag é que a primeira mantém o valor dentro da sessão.

           *Bradesco
           *ToTvs
           *Itau


       */



        return View(); //View página web (objeto de resposta)
    }

    public IActionResult Mensagem()
    {
        return View();
    }

    public IActionResult ViewModel()
    {
        var curso = new Curso()
        {
            Id = 1,
            Nome = "Introdução a programação",
            Titulo = "Primeiros passos na programação",
            Descricao = "Domine a programação com nosso curso completo - aprenda desde o básico até o avançado e desenvolva suas próprias aplicações com confiança!",
            Perfil = "estudantes e aprendizes no geral",
            PreRequisitos = "informática básica",
            Conteudo = "1-introdução 2-lógica 3-estruturas 4-vetores 5-funções 6-matrizes 7-estruturas de dados 8-registros",
            CargaHoraria = 40,
            PrazoMeses = 1
        };
        var ViewModel = new DetalheCursoViewModel
        {
            Curso = curso,
           TituloPagina = "Detalhes do Curso"
        };
        return View(ViewModel); //passar um objeto pra View
        //ViewData[] - não precisa 
        //Viewbag - não precisa
        //TempData[] - não precisa
        //ViewModel - usamos eleee
    }
}  

