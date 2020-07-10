using Microsoft.AspNet.Identity;
using ProjectManagement.Models.Project;
using ProjectManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.WebMVC.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            var service = CreateProjectService();
            var model = service.GetProjects();

            return View(model);
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProjectCreate model)
        {

            if (!ModelState.IsValid) return View(model);

            var service = CreateProjectService();

            if (service.CreateProject(model))
            {
                TempData["SaveResult"] = "Project successfully created!";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Project could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateProjectService();
            var model = svc.GetProjectById(id);

            return View(model);
        }

        public ActionResult Update(int id)
        {
            var service = CreateProjectService();
            var detail = service.GetProjectById(id);
            var model =
                new ProjectUpdate
                {
                    ProjectId = detail.ProjectId,
                    ProjectName = detail.ProjectName,
                    ProjectDetails = detail.ProjectDetails,
                    ProjectStatus = detail.ProjectStatus,
                    EmployeeId = detail.EmployeeId,
                    CustomerId = detail.CustomerId
                };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, ProjectUpdate model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.ProjectId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateProjectService();

            if (service.UpdateProject(model))
            {
                TempData["SaveResult"] = "The project has been updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Could not update the project.");
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var svc = CreateProjectService();
            var model = svc.GetProjectById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteEmployee(int id)
        {
            var service = CreateProjectService();

            service.DeleteProject(id);

            TempData["SaveResult"] = "Project successfully deleted.";

            return RedirectToAction("Index");
        }

        private ProjectService CreateProjectService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ProjectService(userId);
            return service;
        }
    }
}