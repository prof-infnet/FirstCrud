using FirstCrud.Models;
using FirstCrud.Repository;
using Microsoft.AspNetCore.Mvc;


namespace FirstCrud.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // HTTP GET VERSION
        public IActionResult Create()
        {
            return View();
        }





        // HTTP POST VERSION
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            EmployeeRepository.Create(employee);

            return View("Thanks", employee);
        }


    }
}
