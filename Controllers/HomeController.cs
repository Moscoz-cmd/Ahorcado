using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ahorcado.Models;

namespace Ahorcado.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        JuegoAhorcado.iniciarGrupo();
        ViewBag.PalabraSecreta = JuegoAhorcado.PalabraSecreta;
        ViewBag.tablero = JuegoAhorcado.PalabraAdivinada;
        return View();
    }
    public IActionResult arriesgoLetra(string Letra)
    {
        int num = JuegoAhorcado.arriesgoLetra(Letra);
        ViewBag.Num = num;

        ViewBag.tablero = JuegoAhorcado.PalabraAdivinada;
        return View("index");
    }
    public IActionResult arriesgoPalabra(string arriesgo)
    {
        int num = JuegoAhorcado.arriesgoPalabra(arriesgo);
        ViewBag.Num = num;
        ViewBag.PalabraSecreta = JuegoAhorcado.PalabraSecreta;
        ViewBag.tablero = JuegoAhorcado.PalabraAdivinada;
        return View("index");
    } 
}
