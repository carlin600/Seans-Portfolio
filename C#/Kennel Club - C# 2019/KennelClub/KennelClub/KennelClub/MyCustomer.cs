using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KennelClub
{
    class MyCustomer
    {
        private int customerNo;

        private string title, surname, forename, street, town, county, postcode, telNo;

        public MyCustomer()
        {
            this.customerNo = 0;
            this.title = "";
            this.surname = "";
            this.forename = "";
            this.street = "";
            this.town = "";
            this.county = "";
            this.postcode = "";
            this.telNo = "";
        }

        public MyCustomer(int customerNo, string title, string surname, string forename, string street, string town,
            string county, string postcode, string telNo)
        {
            this.customerNo = customerNo;
            this.title = title;
            this.surname = surname;
            this.forename = forename;
            this.street = street;
            this.town = town;
            this.county = county;
            this.postcode = postcode;
            this.telNo = telNo;

        }

        public int CustomerNo
        {
            get { return customerNo; }
            set { customerNo = value; }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value.ToUpper() != "MR" && value.ToUpper() != "MRS" && value.ToUpper() != "MISS" &&
                    value.ToUpper() != "MS")
                    throw new MyException("Title must be Mr, Mrs, Miss or Ms");
                else
                    title = MyValidation.firstLetterEachWordToUpper(value);
            }
        }

        //finish surname so this works - finished surname, exact same as forename but with function name changed.
        public string Surname
        {
            get { return Surname; }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validSurname(value))
                {
                    surname = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Surname must be 2 - 15 characters long.");
                }
            }
        }

        public string Forename
        {
            get { return forename; }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validForename(value))
                {
                    forename = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Forename must be 2-15 characters long.");
                }
            }
        }


        public string Street
        {
            get { return street; }
            set
            {
                if (MyValidation.validLength(value, 5, 40) && MyValidation.validLetterNumberWhitespace(value)) // sorted validLetterNumberWhitespace
                {
                    street = MyValidation.firstLetterEachWordToUpper(value);
                }
                else

                {
                    throw new MyException("Street must be 5 - 40 characters long.");
                }

            }
        }

        public string Town
        {
            get { return town; }
            set
            {
                if (MyValidation.validLength(value, 2, 20)
                    && MyValidation.validLetterWhitespace(value))
                {
                    town = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Town must be 2 - 2- characters long.");
                }
            }
        }


        public string County
        {
            get { return county; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetter(value))
                {
                    county = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("County must be 2 - 20 characters long.");
                }
            }

        }

        public string Postcode
        {
            get { return postcode; }
            set
            {
                if (MyValidation.validLength(value, 7, 8) && MyValidation.validLetterNumberWhitespace(value))
                {
                    telNo = value;
                }
                else
                {
                    throw new MyException("Telephone number must be 11 - 15 digits.");
                }
            }
        }

        public string TelNo
        {
            get { return telNo; }
            set
            {
                if (MyValidation.validLength(value, 11, 15) && MyValidation.validNumber(value))
                {
                    telNo = value;
                }
                else
                {
                    throw new MyException("Telephone number must be 11-15 digits.");
                }
            }
        }

    }
}

