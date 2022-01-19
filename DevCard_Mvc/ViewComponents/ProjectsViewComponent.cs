using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_Mvc.Models;

namespace DevCard_Mvc.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Project = new List<Project>
            {
                new Project(1,"تاکسی","تاکسی درون شهری","blog-post-thumb-1.jpg","snap"),
                new Project(2,"اتوبوس","اتوبوس درون شهری","blog-post-thumb-2.jpg","vahed"),
                new Project(3,"فست قود","انواع پیتزا و ساندویچ","blog-post-thumb-3.jpg","zapa"),
                new Project(4,"الکل","انواع الکل های طبی","blog-post-thumb-4.jpg","taviar"),
            };
            return View("_project",Project);
        }
    }
}
