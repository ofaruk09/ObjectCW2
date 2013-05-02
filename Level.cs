using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Level
    {
        private int name;

        public int Name
        {
            get { return name; }
            set { name = value; }
        }
        private float levelAverage;

        public float LevelAverage
        {
            get { return levelAverage; }
            set { levelAverage = value; }
        }

        private List<Module> modules = new List<Module>();

        public List<Module> Modules
        {
            get { return modules; }
        }
    }
}
