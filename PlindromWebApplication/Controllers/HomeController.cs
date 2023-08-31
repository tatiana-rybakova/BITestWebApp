using Microsoft.AspNetCore.Mvc;

namespace PlindromWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckPalindrom(string gotString)
        {
            gotString = gotString.ToLower();
            int length = gotString.Length;
            ViewBag.Answer = "Палиндром";

            for (int i = 0; i < length / 2; i++)
            {
                if (gotString[i] != gotString[length - 1 - i])
                {
                    ViewBag.Answer = "Не палиндром";
                    break;
                }
            }
            return View();
        }

    }
}