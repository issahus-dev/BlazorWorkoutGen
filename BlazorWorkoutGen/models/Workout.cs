using System.ComponentModel.DataAnnotations;

namespace BlazorWorkoutGen.models
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }
        public string ExerciseName { get; set; }

        public int Sets { get; set; }

        public int Reps { get; set; }

        public double Weight { get; set; }


    }
}
