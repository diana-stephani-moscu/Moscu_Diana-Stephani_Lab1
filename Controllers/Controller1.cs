using Microsoft.AspNetCore.Mvc;

namespace Moscu_Diana_Stephani_Lab1.Controllers
{
    public class Controller1 : Controller
    {
        public string Index()
        {
            return "Bine ati venit!";
        }

        public string Salut()
        {
            return "Salut!";
        }

        public string MesajCuParametri(string text, int numar)
        {
            return $"Textul primit: {text}, Numarul primit: {numar}";
        }
    }
}
