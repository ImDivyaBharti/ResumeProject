using DemoResume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoResume.Controllers
{
    public class HomeController : Controller
    {
        ResumeDB3Entities dbEntities = new ResumeDB3Entities();

        public ActionResult Index()
        {
            var tables = new ResumeViewModel
            {
                personalDetails = dbEntities.Personal_Details.ToList(),
                objectives = dbEntities.Objectives.ToList(),
                educationalInfos = dbEntities.EducationalInfoes.ToList(),
                technicalInfos = dbEntities.TechnicalInfoes.ToList(),
                workExperience = dbEntities.WorkExperiences.ToList(),
                summaries = dbEntities.Summaries.ToList(),
                projectInfos = dbEntities.ProjectInfoes.ToList(),
                Declartions = dbEntities.Declartaions.ToList()
            };
            return View(tables);
        }



    }
}
