using Group3Web3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group3Web3.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Raporti()
        {
            int numri = 10;
            Studenti st1 = new Studenti("Ardit", "Grajqevci");
            Studenti st2 = new Studenti("Muhamet", "Bersiha");
            Studenti st3 = new Studenti("Cristiano", "Ronaldo");

            List<Studenti> studentet = new List<Studenti>();
            studentet.Add(st1);
            studentet.Add(st2);
            studentet.Add(st3);


            return View(studentet);
        }

        public IActionResult MesoHtml()
        {
            return View();
        }
    }
}
