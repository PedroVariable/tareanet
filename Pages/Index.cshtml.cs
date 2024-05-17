using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CalculadoraIMC.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public double Peso { get; set; }

        [BindProperty]
        public double Altura { get; set; }

        public double IMC { get; set; }
        public string Clasificacion { get; set; }
        public string Imagen { get; set; }

        public void OnPost()
        {
            IMC = Peso / (Altura * Altura); 
            switch (IMC)
            {
                case < 18:
                    Clasificacion = "Peso Bajo";
                    Imagen = "/img/peso-bajo.png"; 
                    break;
                case < 25:
                    Clasificacion = "Peso Normal";
                    Imagen = "/img/peso-normal.png"; 
                    break;
                case < 27:
                    Clasificacion = "Sobrepeso";
                    Imagen = "/img/sobrepeso.png"; 
                    break;
                case < 30:
                    Clasificacion = "Obesidad grado I";
                    Imagen = "/img/obesidad-grado-I.png"; 
                    break;
                case < 40:
                    Clasificacion = "Obesidad grado II";
                    Imagen = "/img/obesidad-grado-II.png"; 
                    break;
                default:
                    Clasificacion = "Obesidad grado III";
                    Imagen = "/img/obesidad-grado-III.png"; 
                    break;
            }
        }

    }
}
