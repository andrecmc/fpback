using Microsoft.EntityFrameworkCore;

namespace FPApi.Models
{
    public class FlightPlanContext : DbContext
    {
        public FlightPlanContext(DbContextOptions<FlightPlanContext> options)
            : base(options)
        {
        }

        public DbSet<FlightPlan> TodoItems { get; set; }
    }
}