using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LloydsPharmacy
{
    class MyCourse
    {
        private string courseID, courseTypeID;
        private int  courseNoDays, courseNoPatients;
        private double coursePrice, hoursPerDay;
        private string courseDesc;
        private int minCourseNoDays = 1, maxCourseNoDays = 100;
        private int minCoursePrice = 0, maxCoursePrice = 100;
        private int minCourseNoPatients = 1, maxCourseNoPatients = 50;


        


        public MyCourse()
        {
            this.courseID = "";
            this.courseNoDays = 0;
            this.hoursPerDay = 0.0;
            this.coursePrice = 0.0;
            this.courseNoPatients = 0;
            this.courseTypeID = "";
            this.courseDesc = "";
        }

        public MyCourse(string courseID, int courseNoDays,double hoursPerDay, double coursePrice, int courseNoPatients, string courseTypeID
                        , string courseDesc)
        {
            this.courseID = courseID;
            this.courseNoDays = courseNoDays;
            this.hoursPerDay = hoursPerDay;
            this.coursePrice = coursePrice;
            this.courseNoPatients = courseNoPatients;
            this.courseTypeID = courseTypeID;
            this.courseDesc = courseDesc;
        }

        public string CourseID
        {
            get { return courseID; }
            set 
            {
                courseID = value;
            }

        }
        public int CourseNoDays
        {
            get { return courseNoDays; }
            set
            {
                if (MyValidation.validNumberLength(value, 1, 15))
                {
                    courseNoDays = value;
                }
                else throw new MyException("No Days must be between 1 and 14");
            }
        }

        public double HoursPerDay
        {
            get { return hoursPerDay; }
            set
            {
                if (MyValidation.validDoubleLength(value, 1.99, 6.00))
                {
                    hoursPerDay = value;
                }
                else throw new MyException("Hours Per Day must be between 2 and 5");
            }
        }

        public double CoursePrice
        {
            get { return coursePrice; }
            set
            { if (MyValidation.validPrice(value, 0, 100.00))
                {
                    coursePrice = value;
                }
                else throw new MyException("Course Price must be between 0 and 100");
            }
        }

        public int CourseNoPatients
        {
            get { return courseNoPatients;}

            set
            {
                if (MyValidation.validIntNumber(value, 0, 50))
                {
                    courseNoPatients = value;
                }
                else throw new MyException("No Patients must be between 1 and 50");
            }
        }

        public string CourseTypeID
        {
            get { return courseTypeID; }
            set { courseTypeID = value; }
        }

        public string CourseDesc
        {
            get { return courseDesc; }
            set
            {
                if (MyValidation.validLength(value, 2, 40) && MyValidation.validLetterWhitespace(value))
                {
                    courseDesc = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Course Desc must be 2-40 letters");
            }
        }


    }
}

