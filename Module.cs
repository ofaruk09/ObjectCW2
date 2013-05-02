using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Module
    {
        private String code;

        public String Code
        {
            get { return code; }
            set { code = value; }
        }
        private int credits;

        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        private int semester;

        public int Semester
        {
            get { return semester; }
            set { semester = value; }
        }
        private List<Assessment> moduleAssessment = new List<Assessment>();

        internal List<Assessment> ModuleAssessment
        {
            get { return moduleAssessment; }

        }
        private float moduleAverage;

        public float ModuleAverage
        {
            get { return moduleAverage; }
            set { moduleAverage = value; }
        }
    }
}
