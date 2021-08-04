using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Bonus
{
    public class ProfessorCourse
    {
        public int ProfessorId { get; set; }

        public int CourseId { get; set; }

        public List<Course> Courses { get; set; }
    }
}
