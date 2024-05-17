using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ecuacionControlador.Utils;

namespace EcuacionPages.Pages
{
    public class ExpresionModel : PageModel
    {
        [BindProperty]
        public double A { get; set; }
        [BindProperty]
        public double B { get; set; }
        [BindProperty]
        public double X { get; set; }
        [BindProperty]
        public double Y { get; set; }
        [BindProperty]
        public int N { get; set; }
        public double Result { get; set; }
        
        public void OnPost()
        {
            Result = MathUtilities.ComputeBinomialExpression(A, B, X, Y, N);
        }
    }
}

