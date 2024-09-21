using Company.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Company.web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepoitory _departmentRepoitory;

        public DepartmentController(IDepartmentRepoitory departmentRepoitory)
        {
           _departmentRepoitory = departmentRepoitory;
        }
        public IActionResult Index()
        {
            var departments = _departmentRepoitory.GetAll();
            return View();
            //var departments = _departmentRepoitory.GetAll(); // Replace with your logic
            //ViewData["Model"] = departments; // Or ViewBag.Model = departments;
            //return View();
        }
    }
}
