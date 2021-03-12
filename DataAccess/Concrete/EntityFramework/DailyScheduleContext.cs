using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class DailyScheduleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Daily_Schedule;Trusted_Connection=true");
        }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}