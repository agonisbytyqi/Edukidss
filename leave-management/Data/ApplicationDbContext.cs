using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using leave_management.Models;
using EduKids.Models;

namespace leave_management.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        public DbSet<leave_management.Models.LeaveRequestVM> LeaveRequestVM { get; set; }
        public DbSet<leave_management.Models.Student> Student { get; set; }
        public DbSet<leave_management.Models.HomeWork> HomeWork { get; set; }
        public DbSet<EduKids.Models.Roles> Roles { get; set; }
        public DbSet<leave_management.Models.LeaveTypeVM> LeaveTypeVM { get; set; }
        public DbSet<leave_management.Models.EmployeeVM> EmployeeVM { get; set; }
    }
}