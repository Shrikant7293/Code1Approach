using Code1Approach.DataAccessLayer;
using Code1Approach.Models;

namespace Code1Approach.BussinessAccessLayer.EmployeeRepository
{
	public interface IEmployeeRepository
	{
		List<Department> GetAllDepartments();
        void Save(EmployeeViewModel employeeViewModel);
		List<EmployeeViewModel> GetAllEmployees();

	}

}
