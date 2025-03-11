using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LloydsPharmacy
{
    class MyStaff
    {
      //  private int staffNo;
        private string staffNo;
        private string staffTitle;
        private string staffForename, staffSurname, staffTown, staffPostcode, staffTelephoneNo, staffMobileNo, staffEmail, staffStreet;

        public MyStaff()
        {
            this.staffNo = "";
            this.staffForename = ""; this.staffSurname = ""; this.staffForename = ""; this.StaffTitle = "";
            this.staffPostcode = ""; this.staffTelephoneNo = ""; this.staffMobileNo = ""; this.staffEmail = "";this.staffTown = "";
            this.staffStreet = "";
        }

        public MyStaff(string staffNo, string staffTitle, string staffForename, string staffSurname, string staffPostcode, string staffTelephoneNo,
                string staffMobileNo, string staffEmail)
        {
            this.staffNo = staffNo;
            this.staffTitle = staffTitle;
            this.staffForename = staffForename; this.staffSurname = staffSurname; this.staffPostcode = staffPostcode;
            this.staffTelephoneNo = staffTelephoneNo; this.staffMobileNo = staffMobileNo; this.staffEmail = staffEmail;
            this.staffTown = staffTown;
            this.staffStreet = staffStreet;
        }

        public string StaffNo
        {
            get { return staffNo; }
            set { staffNo = value; }
        }
        public string StaffTitle
        {
            get { return staffTitle; }
            set
            {

                staffTitle = value;
               
            }
        }
        public string StaffForename
        {
            get { return staffForename; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validForename(value))
                {
                    staffForename =
                        MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Forename must be 2-20 letters");
            }
        }

        public string StaffSurname
        {
            get { return staffSurname; }
            set
            {
                if (MyValidation.validLength(value, 2, 30) && MyValidation.validSurname(value))
                {
                    staffSurname = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Surname must be 2-30 letters");
            }
        }

        public string StaffPostcode
        {
            get { return staffPostcode; }
            set
            {
                if (MyValidation.validLength(value, 8, 8) && MyValidation.validLetterNumberWhitespace(value))
                {
                    staffPostcode = MyValidation.EachLetterToUpper(value);
                }
                else
                    throw new MyException("Postcode must be 8 letters and alphanumeric only");
            }
        }
        public string StaffTown
        {
            get { return staffTown; }
            set
            {
                if (MyValidation.validLetterWhitespace(value) && MyValidation.validLength(value, 2, 15))
                {
                    staffTown =
                        MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Town must be 2-15 letters");
            }
        }
        public string StaffStreet
        {
            get { return staffStreet; }
            set
            {
                if (MyValidation.validLetterNumberWhitespace(value) && MyValidation.validLength(value, 2, 20))
                {
                    staffStreet =
                        MyValidation.firstLetterEachWordToUpper(value);
                }
                else throw new MyException("Street must be between 2-20 letters");
            }
        }

        public string StaffTelephoneNo
        {
            get { return staffTelephoneNo; }
            set
            {
                if (MyValidation.validLength(value, 11,11) && MyValidation.validNumber(value))
                {
                    staffTelephoneNo = value;
                }
                else throw new MyException("Telephone number must be 11 digits");
            }
        }

        public string StaffMobileNo
        {
            get { return staffMobileNo; }
            set
            {
                if (MyValidation.validLength(value, 11, 11) && MyValidation.validNumber(value))
                {
                    staffMobileNo = value;
                }
                else throw new MyException("Mobile number must be 11-15 digits");
            }
        }
        public string StaffEmail
        {
            get { return staffEmail; }
            set
            {
                if (MyValidation.validEmail(value) && MyValidation.validLength(value, 2, 30))
                {
                    staffEmail = value;
                }
                else throw new MyException("Invalid email");
            }
        }

    }
}