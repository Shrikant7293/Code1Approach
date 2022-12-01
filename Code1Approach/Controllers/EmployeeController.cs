using Code1Approach.BussinessAccessLayer.EmployeeRepository;
using Code1Approach.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code1Approach.Controllers
{
	public class EmployeeController : Controller
	{
		public readonly IEmployeeRepository employeeRepository;
		public EmployeeController(IEmployeeRepository _employeeRepository)
		{
			this.employeeRepository = _employeeRepository;
		}

		public IActionResult Index()
		{
			List<EmployeeViewModel> employeeViewModels= employeeRepository.GetAllEmployees();
			return View(employeeViewModels);
		}

		[HttpGet]
		public IActionResult Create()
		{
			ViewBag.Departments=employeeRepository.GetAllDepartments();
			EmployeeViewModel employeeViewModel = new EmployeeViewModel();
			return View("CreateEmployee",employeeViewModel);
		}

		[HttpPost]
		public IActionResult Create(EmployeeViewModel employeeViewModel)
		{
            employeeRepository.Save(employeeViewModel);
			return RedirectToAction("Index");
		}

		
	}
}
