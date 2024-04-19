using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        public string Test(string name, int num = 1)
        {
            return $"{name} -------  {num * 10}";
        }

    }
}
