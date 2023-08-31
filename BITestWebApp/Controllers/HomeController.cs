using Microsoft.AspNetCore.Mvc;

namespace BITestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetSum(string s)
        {
            var numbers = s.Trim().Split(" ");
            var isSecond = false;
            var sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number;
                var isNumber = int.TryParse(numbers[i], out number);

                if (isNumber && number % 2 != 0)
                {

                    if (isSecond)
                    {
                        sum += number;
                    }

                    isSecond = !isSecond;
                }
            }
            return View(Math.Abs(sum));
        }
    }
}