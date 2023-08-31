using Microsoft.AspNetCore.Mvc;
using SortWebApplication.Models;

namespace SortWebApplication.Controllers
{
    public class HomeController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        } 
        
        [HttpPost]
        public IActionResult Sort(string gotString)
        {
            MyList numbers = new MyList();

            var gotNumbers = gotString.Trim().Split(" ");

            for (int i = 0; i < gotNumbers.Length; i++)
            {              
                if (gotNumbers[i] != " ")
                {
                    int number = int.Parse(gotNumbers[i]);
                    numbers.Add(number);
                }
            }
            numbers.Sort();
            ViewBag.Numbers = numbers.ToString();
            return View();
        }
    }
}