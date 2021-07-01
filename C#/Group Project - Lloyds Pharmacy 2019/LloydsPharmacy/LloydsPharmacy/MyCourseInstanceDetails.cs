using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LloydsPharmacy
{
    class MyCourseInstanceDetails
    {
        private string patientID = "", courseInstanceID = "";

        public MyCourseInstanceDetails()
        {
            this.patientID = "";
            this.courseInstanceID = "";
        }
        public MyCourseInstanceDetails(string patientID = "", string courseInstanceID = "")
        {
            this.patientID = patientID;
            this.courseInstanceID = courseInstanceID;
        }

        public string PatientID
        {
            get { return patientID; }
            set
            {
                patientID = value;
            }
        }


        public string CourseInstanceID
        {
            get { return courseInstanceID; }
            set
            {
                courseInstanceID = value;
            }
        }
    }
}
