using BlazorWorkoutGen.context;
using BlazorWorkoutGen.models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWorkoutGen.Services
{
    public class ExerciseService
    {
        private IDbContextFactory<AppDbContext> _dbContextFactory;

        public ExerciseService(IDbContextFactory<AppDbContext> dbContextFactory) 
        {
            _dbContextFactory = dbContextFactory;
        }

        public void AddWorkout(Workout workout) 
        {
            using(var context = _dbContextFactory.CreateDbContext()) 
            {
                context.Workouts.Add(workout);
                context.SaveChanges();
            }
        }


        
    }
}
