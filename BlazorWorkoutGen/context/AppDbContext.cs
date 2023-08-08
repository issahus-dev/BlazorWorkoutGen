using BlazorWorkoutGen.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BlazorWorkoutGen.context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        

        }
        public DbSet<Workout> Workouts { get; set; }

    }
}
