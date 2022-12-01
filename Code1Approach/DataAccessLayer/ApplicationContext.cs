using Microsoft.EntityFrameworkCore;

namespace Code1Approach.DataAccessLayer
{
	public class ApplicationContext:DbContext
	{

		public ApplicationContext() 
		{
		}
		public ApplicationContext(DbContextOptions<ApplicationContext> options): base (options)
		{
		}

		public DbSet<Employee> Employees { get; set; }
		public DbSet<Department> Departments { get; set; }
	}
}
