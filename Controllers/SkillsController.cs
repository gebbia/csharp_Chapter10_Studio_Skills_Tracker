using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills")]
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                          "<h2>Programming Languages</h2>" +
                          "<ol>" +
                          "<li>C#</li>" +
                          "<li>JavaScript</li>" +
                          "<li>Python</li>" +
                          "</ol>";


            return Content(html, "text/html");
        }


        //[HttpGet]
        [Route("/skills/form")]
        public IActionResult Form()
        {
            string html = "<form method='post' action= '/skills/form/display'>" +
                "<label for='date'>Date: </label><br />" +
                "<input type='date' id='date' name='date'><br />" +

                "<label for='csharp'>C#: </label>" +
                "<select name='csharp' id='csharp'>" +
                    "<option value='basics' selected>Learning Basics</option>" +
                    "<option value='apps'>Making Apps</option>" +
                    "<option value='master'>Master Coder</option>" +
                    "<option value='elite'>Elite Hacker</option>" +
                    "</select><br />" +

                "<label for='javascript'>JavaScript: </label>" +
                "<select name='javascript' id='javascript'>" +
                    "<option value='basics' selected>Learning Basics</option>" +
                    "<option value='apps'>Making Apps</option>" +
                    "<option value='master'>Master Coder</option>" +
                    "<option value='elite'>Elite Hacker</option>" +
                    "</select><br />" +

                "<label for='python'>Python: </label>" +
                "<select name='python'>" +
                    "<option value='basics' selected>Learning Basics</option>" +
                    "<option value='apps'>Making Apps</option>" +
                    "<option value='master'>Master Coder</option>" +
                    "<option value='elite'>Elite Hacker</option>" +
                    "</select><br />" +

                "<input type='submit' value='Submit' />" +
                "</form>";


            return Content(html, "text/html");
        }


        [HttpPost]
        [Route("skills/form/display")]
        public IActionResult FormDisplay(DateTime date, string csharp, string javascript, string python) 
        {
            string html =
                "<h1>" + date.ToShortDateString() + "</h1>" +
                "<ol>" +
                "<li>C#: " + GetSkillLevel(csharp) + "</li><br />" +
                "<li>JavaScript: " + GetSkillLevel(javascript) + "</li><br />" +
                "<li>Python: " + GetSkillLevel(python) + "</li><br />" +
                "</ol>";

            return Content(html, "text/html");
        }
    

        public static string GetSkillLevel(string level)
        {
            string skillLevel;


            if (level == "basics")
            {
                skillLevel = "Learning Basics";
            }
            else if (level == "apps")
            {
                skillLevel = "Making Programs";
            }
            else if (level == "master")
            {
                skillLevel = "Master Coder";
            }
            else if (level == "elite")
            {
                skillLevel = "Elite Hacker";
            }
            else
            {
                skillLevel = "No Skill Level Entered";
            } 
            return skillLevel;
             
        }

    }
}