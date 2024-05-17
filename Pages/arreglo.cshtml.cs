using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using controladorArreglo.Utils;
namespace arregloP.Pages
{
    public class aritmeticaModel : PageModel
    {
         public int[] ListaAleatoria { get; private set; }
        public (int sumaArreglo, double mediaAritmetica, int moda, double mediana) Resultados { get; private set; }
       
        public IActionResult OnPost()
        {
            ListaAleatoria = Aritmetica.NewArreglo();           
            Resultados = Aritmetica.Operacion(ListaAleatoria);
            return Page();
        }
    }
}