using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningBlazor.Data
{
    
    public partial class Guest
    {
        public Guid GuestId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }

    public partial class Session
    {
        public Guid SessionId { get; set; }
        public IEnumerable<Exercise> Exercises { get; set; }
        public Instructor Instructor { get; set; }
        public IEnumerable<Guest> Guests { get; set; }
        public DateTime StartingDateTime { get; set; }
        public int Minutes { get; set; }
    }

    public partial class Instructor
    {
        public Guid InstructorId { get; set; }
        public string Name { get; set; }
        public decimal HourlyRate { get; set; }
    }

    public partial class Exercise
    {
        public Guid ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public string ExerciseDescription { get; set; }
        public string ExerciseDuration { get; set; }
    }
}
