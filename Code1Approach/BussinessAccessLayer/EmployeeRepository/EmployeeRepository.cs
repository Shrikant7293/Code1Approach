using Code1Approach.DataAccessLayer;
using Code1Approach.Models;

namespace Code1Approach.BussinessAccessLayer.EmployeeRepository
{
	public class EmployeeRepository:IEmployeeRepository
	{
		public readonly ApplicationContext db;

		public EmployeeRepository(ApplicationContext _db)
		{
			this.db = _db;
		}
		 
		public List<Department> GetAllDepartments()
		{
			var departments=db.Departments.ToList();
			return departments;
		}

		public void Save(EmployeeViewModel employeeViewmodel)
		{
			Employee employee = new Employee();

			employee.Name= employeeViewmodel.Name;
			employee.Email = employeeViewmodel.Email;
			employee.DepartmentId= employeeViewmodel.DepartmentId;

			db.Employees.Add(employee);
			db.SaveChanges();
		}

		public List<EmployeeViewModel> GetAllEmployees()
		{
			List<Employee> employees=db.Employees.ToList();
			List<EmployeeViewModel> employeeViewModels=new List<EmployeeViewModel>();

			foreach (var employee in employees) 
			{ 
			EmployeeViewModel employeeViewModel=new EmployeeViewModel();
			employeeViewModel.Id=employeeViewModel.Id;
			employeeViewModel.Name=employeeViewModel.Name;
			employeeViewModel.Email=employeeViewModel.Email;
			employeeViewModel.DepartmentId=employeeViewModel.DepartmentId;

				employeeViewModels.Add(employeeViewModel);
			}

			return employeeViewModels;
		}
	}
}
