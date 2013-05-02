using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Course
    {
        private static String name;

        public static String Name
        {
            get { return name; }
            set { name = value; }
        }
        private static List<Level> courseLevel = new List<Level>();

        static internal List<Level> CourseLevel
        {
            get { return courseLevel; }
        }
    }
}
