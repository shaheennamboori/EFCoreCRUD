using EmployeeAdminPortal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Employee> Employees { get; set; }
}
