using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    private static List<EstudanteViewModel> estudates = new List<EstudanteViewModel>{
      new EstudanteViewModel(1, "Jess", "Rua Jd.Primavera, n.42", true),   
      new EstudanteViewModel(2, "Jobas", "Rua João amado, n.51", false),   
      new EstudanteViewModel(3, "Marcos", "Rua Macetava, n.32", true)      
    };

    public IActionResult Index()
    {
        
        return View(estudates);


        
    }

    public IActionResult Show(int id)
    {
        return View(estudates[id-1]);
    }


}