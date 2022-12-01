using Code1Approach.DataAccessLayer;

namespace Code1Approach.Models
{
	public class EmployeeViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public int DepartmentId { get; set; }
		public Department Department { get; set; }

	}
}
