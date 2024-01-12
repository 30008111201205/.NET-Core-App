using Company.Models;
using Microsoft.EntityFrameworkCore;

namespace Company.Entity
{
    public class DataBase:DbContext
    {
        public virtual DbSet<Employee> Employees{ get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
     
           
            optionsBuilder.UseSqlServer("Server=DESKTOP-TPS8C9C;DataBase=HR;User Id=sa;Password=123456;Trusted_Connection=True;Trust Server Certificate=True;");
       }
       
    }
}
