using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/Hello'>" + 
                "<input type='text' name='name' />" +
                "<select name='lang'>" + 
                    "<option value='english'>English</option>" +
                    "<option value='french'>French</option>" +
                    "<option value='spanish'>Spanish</option>" +
                    "<option value='italian'>Italian</option>" +
                    "<option value='japanese'>Japanese</option>" +
               "</select>" + 
                "<input type='submit' value='Greet me!' />" + 
                "</form>";

            return Content(html, "text/html");
        }

        // /Hello
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name, string lang)
        {
            string html = CreateMessage(name, lang);
            return Content(html, "text/html");
        }

        // Handle requests to /Hello/NAME (URL segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello, {0}!</h1>", name), "text/html");
        }

        [Route("/Hello/Goodbye")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye, World!");
        }
        
        public static string CreateMessage(string name, string language)
        {
            string html = "";
            if (language == "english")
            {
                html = string.Format("<h1>Hello, {0}!</h1>", name);
            }
            if (language == "french")
            {
                html = string.Format("<h1>Bonjour, {0}!</h1>", name);
            }
            if (language == "spanish")
            {
                html = string.Format("<h1>Hola, {0}!</h1>", name);
            }
            if (language == "italian")
            {
                html = string.Format("<h1>Ciao, {0}!</h1>", name);
            }
            if (language == "japanese")
            {
                html = string.Format("<h1>Konnichiwa, {0}!</h1>", name);
            }

            return html;
        }
    }
}
