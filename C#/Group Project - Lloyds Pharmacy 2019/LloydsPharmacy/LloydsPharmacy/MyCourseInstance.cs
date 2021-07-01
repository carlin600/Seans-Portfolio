using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LloydsPharmacy
{
    class MyCourseInstance
    {

        private string courseInstanceID = "", courseID = "", staffID = "";
        private double courseStartTime = 0.0;
        private DateTime courseStartDate;


        public MyCourseInstance()
        {
            this.courseInstanceID = "";
            this.courseID = "";
            this.courseStartDate = new DateTime();
            this.courseStartTime = 0.0;
            this.staffID = "";
        }
        public MyCourseInstance(string courseInstanceID = "", string courseID = "", string staffID = "", double courseStartTime = 0.0,
                                    DateTime courseStartDate = new DateTime())
        {
            this.courseInstanceID = courseInstanceID;
            this.courseID = courseID;
            this.staffID = staffID;
            this.courseStartTime = courseStartTime;
            this.courseStartDate = courseStartDate;
        }

        public string CourseInstanceID
        {
            get { return courseInstanceID; }
            set
            {
                courseInstanceID = value;
            }
        }
        public string CourseID
        {
            get { return courseID; }
            set
            {
                courseID = value;
            }
        }
        public string StaffID
        {
            get { return staffID; }
            set
            {
                staffID = value;
            }
        }
        public DateTime CourseStartDate
        {
            get { return courseStartDate; }
            set
            {
                courseStartDate = value;
            }
        }
        public double CourseStartTime
        {
            get { return courseStartTime; }
            set
            {
                if (!MyValidation.validDoubleLength(value, 8.99, 17.01))
                {
                    throw new MyException("Courses must start between 9am and 4pm");
                }
                else
                {
                    courseStartTime = value;
                }
            }
        }


     }



    }

