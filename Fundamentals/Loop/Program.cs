using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //************  for &&  foreach  && array  **************

                         // array
            string[] courses = new string[] {"HTML","CSS","JS","ES6","REACT" };

            // in real project  string[] courses = new Courses();



                        // for

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine("course :" + courses[i]);
            }

                       
                      // foreach

            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}
