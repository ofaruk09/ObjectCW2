using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Assessment
    {
        private String assessmentType;

        public String AssessmentType
        {
            get { return assessmentType; }
            set { assessmentType = value; }
        }
        private float assessmentWeighting;

        public float AssessmentWeighting
        {
            get { return assessmentWeighting; }
            set { assessmentWeighting = value; }
        }
        private String assessmentName;

        public String AssessmentName
        {
            get { return assessmentName; }
            set { assessmentName = value; }
        }
        private float assessmentResult;

        public float AssessmentResult
        {
            get { return assessmentResult; }
            set { assessmentResult = value; }
        }
    }
}
