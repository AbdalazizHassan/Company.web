using Company.Repository.Interfaces;
using Company.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Company.web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService )
        {
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            var departments = _departmentService.GetAll();
            return View();
            //var departments = _departmentRepoitory.GetAll(); // Replace with your logic
            //ViewData["Model"] = departments; // Or ViewBag.Model = departments;
            //return View();
        }
    }
}
