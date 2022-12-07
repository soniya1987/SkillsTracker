using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            string title =
            "<h1>Skills Tracker</h1>" +
            "<h2>Coding skills to learn:</h2>" +
            "<ol>" +
            "<li>C#</li>" +
            "<li>Javascript</li>" +
            "<li>Python</>" +
            "<ol>";

            
            
            return Content(title,"text/html");
        }
        [HttpGet]
        public IActionResult Form()
        {
            return Content("<form action= '/skills/form' method= 'post'>" +
                "<label for= 'date'>Date:</label>" +
                "<input type= 'date' name= 'date'/>" +
                "<label for= 'csharp'> C#:</label>" +
                "<select name= 'csharp'>" +
                     "<option value= 'learningbasics'>learning Basics</option>" +
                     "<option value= 'makingapps'>making apps</option>" +
                     "<option value= 'mastercoder'>master coder</option>" +
                     "</select>" +
                "<label for= 'javascript'> Javascript:</label>" +
                "<select name= 'javascript'>" +
                     "<option value= 'learningbasics'>learning Basics</option>" +
                     "<option value= 'makingapps'>making apps</option>" +
                     "<option value= 'mastercoder'>master coder</option>" +
                     "</select>" +
                "<label for= 'python'> Python:</label>" +
                "<select name= 'python'>" +
                "<option value= 'learningbasics'>learning Basics</option>" +
                "<option value= 'makingapps'>making apps</option>" +
                "<option value= 'mastercoder'>master coder</option>" +
                "</select><br/>" +
                "<input type='submit' value='submit'/>", "text/html");
        }

        [HttpPost]
        public IActionResult Form(string date, string csharp, string javascript, string python)
        {
            return Content("<h1>" + date + "</h1>" +
                "<br/>" +
                "<ol><li> C#: " + GetLearningLevel(csharp) + "</li>" +
                "<li> Javascript: " + GetLearningLevel(javascript) + "</li>" +
                "<li> Python: " + GetLearningLevel(python) + "</li><ol>", "text/html");
        }

        private string GetLearningLevel(string option)
        {
            if (option == "learningbasics")
            {
                return "learning Basics";
            }
            else if (option == "makingapps")
            {
                return "making apps";
            }
            else
            {
                return "master coder";
            }
        }
    }
}
