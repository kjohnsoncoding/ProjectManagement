using Microsoft.AspNet.Identity;
using ProjectManagement.Models.Employee;
using ProjectManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.WebMVC.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var service = CreateEmployeeService();
            var model = service.GetEmployees();

            return View(model);
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateEmployeeService();

            if (service.CreateEmployee(model))
            {
                TempData["SaveResult"] = "Employee successfully created!";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Employee could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateEmployeeService();
            var model = svc.GetEmployeeById(id);

            return View(model);
        }

        public ActionResult Update(int id)
        {
            var service = CreateEmployeeService();
            var detail = service.GetEmployeeById(id);
            var model =
                new EmployeeUpdate
                {
                    EmployeeId = detail.EmployeeId,
                    FirstName = detail.FirstName,
                    LastName = detail.LastName,
                    Address = detail.Address,
                    City = detail.City,
                    State = detail.State,
                    PhoneNumber = detail.PhoneNumber,
                    EmailAddress = detail.EmailAddress
                };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, EmployeeUpdate model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.EmployeeId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateEmployeeService();

            if (service.UpdateEmployee(model))
            {
                TempData["SaveResult"] = "The employee has been updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Could not update the employee.");
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var svc = CreateEmployeeService();
            var model = svc.GetEmployeeById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteEmployee(int id)
        {
            var service = CreateEmployeeService();

            service.DeleteEmployee(id);

            TempData["SaveResult"] = "Employee successfully deleted.";

            return RedirectToAction("Index");
        }

        private EmployeeService CreateEmployeeService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new EmployeeService(userId);
            return service;
        }
    }
}