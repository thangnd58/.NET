using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace StoryWebMVC.Controllers
{
    public class Helloworld : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numTimes)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
