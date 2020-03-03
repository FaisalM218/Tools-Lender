using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToolLending.Models;

namespace ToolLending.Controllers
{
    public class ToolsController : Controller
    {
        // GET: Tools/
        public ActionResult Index()
        {
            Tool tool = new Tool() { Id = 0, Name = "Screw Driver"};
            return View(tool);
        }
    }
}