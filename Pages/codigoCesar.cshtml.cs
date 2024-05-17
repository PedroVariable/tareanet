using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using codigoCesar.Utils; 
namespace codigoCesarP.Pages
{
    public class CesarModel : PageModel
    {
        [BindProperty]
        public string Message { get; set; }
        [BindProperty]
        public int Shift { get; set; }
        public string Result { get; set; }

        public void OnPost(string Action)
        {
            if (Action == "Cifrar")
            {
                Result = encriptacionCesar.Cifrar(Message, Shift);
            }
            else if (Action == "Descifrar")
            {
                Result = encriptacionCesar.Descifrar(Message, Shift);
            }
        }
    }
}
