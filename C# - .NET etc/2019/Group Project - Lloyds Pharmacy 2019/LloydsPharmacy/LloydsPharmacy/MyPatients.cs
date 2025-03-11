using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LloydsPharmacy
{
    class MyPatients
    {
        private String patientID, forename, surname, telNo, email, street, town, county, postcode;

        public MyPatients()
        {
            this.patientID = ""; this.forename = ""; this.surname = ""; this.telNo = ""; this.email = ""; this.street = ""; this.town = ""; this.county = ""; this.postcode = "";
        }

        public MyPatients(String patientID, String forename, String surname, String telNo, String email, String street, String town, String county, String postcode)
        {
            this.patientID = patientID; this.forename = forename; this.surname = surname; this.telNo = telNo; this.email = email; this.street = street; this.town = town; this.county = county; this.postcode = postcode;
        }

        public String PatientID
        {
            get { return patientID; }
            set
            {
                if (MyValidation.validLength(value, 7, 8) && MyValidation.validLetterNumberWhitespace(value))
                {
                    patientID = MyValidation.EachLetterToUpper(value);
                }
                else
                    throw new MyException("Patient ID must be formatted as 'PAT[0-9][0-9][0-9][0-9]");
            }
        }

        public String Forename
        {
            get { return forename; }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validForename(value))
                {
                    forename = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Forename must be 2-15 letters");
            }
        }

        public String Surname
        {
            get { return surname; }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validSurname(value))
                {
                    surname = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Surname must be 2-15 letters");
            }
        }

        public String TelNo
        {
            get { return telNo; }
            set
            {
                if (MyValidation.validLength(value, 4, 8) && MyValidation.validNumber(value))
                {
                    telNo = value;
                }
                else
                    throw new MyException("Telephone Number must be 4-8 digits");
            }
        }

        public String Email
        {
            get { return email; }
            set
            {
                if (MyValidation.validLength(value, 10, 23) && MyValidation.validEmail(value))
                {
                    email = value;
                }
                else
                    throw new MyException("Email must be 10-23 digits");
            }
        }

        public String Street
        {
            get { return street; }
            set
            {
                if (MyValidation.validLength(value, 5, 20) && MyValidation.validLetterNumberWhitespace(value))
                {
                    street = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Street must be 5-20 letters");
            }
        }

        public String Town
        {
            get { return town; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetterWhitespace(value))
                {
                    town = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Town must be 2-20 letters");
            }
        }

        public String County
        {
            get { return county; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetterWhitespace(value))
                {
                    county = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("County must be 2-20 letters");
            }
        }

        public String Postcode
        {
            get { return postcode; }
            set
            {
                if (MyValidation.validLength(value, 7, 8) && MyValidation.validLetterNumberWhitespace(value))
                {
                    postcode = MyValidation.EachLetterToUpper(value);
                }
                else
                    throw new MyException("Postcode must be formatted as 'BT[0-9][0-9] [0-9][A-Z][A-Z]'");
            }
        }
    }
}