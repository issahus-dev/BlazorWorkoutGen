using System.Diagnostics.CodeAnalysis;

namespace BlazorWorkoutGen.models
{
    public class Exercise
    {
        public  string? Name  { get; set; }

        public List<SetInfo> Sets { get; set; }

        public Exercise()
        {
            Sets = new List<SetInfo>();
        }
        
    }

    public class SetInfo
    {
        public int SetNumber { get; set; }
        public int Reps { get; set; }

        public double Weight { get; set; }
    }
}

