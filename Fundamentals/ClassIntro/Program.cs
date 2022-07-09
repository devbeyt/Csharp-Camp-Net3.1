using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseId = 1;
            course1.CourseName = "HTML";
            course1.CourseTeacher = "TEACH1";

            Course course2 = new Course();
            course2.CourseId = 2;
            course2.CourseName = "CSS";
            course2.CourseTeacher = "TEACH2";

            // or
            Course course3 = new Course { CourseId = 3, CourseName = "JS", CourseTeacher = "TEACH3" };

            // convert to Array
            Course[] courses = new Course[] {course1,course2,course3 };

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName);
            }
             
            Console.WriteLine("**************************");
        }
    }
}
