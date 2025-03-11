using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelClub
{
    class MyDog
    {
        private int DogNo, BreedNo, CustomerNo;
        private String name, colour;
        private DateTime dogDOB;
        private char gender;

        public MyDog()
        {
            this.DogNo = 0;
            this.Name = "";
            this.BreedNo = 0;
            this.dogDOB = DateTime.Today;
            this.gender =' ';
            this.colour = "";
            this.CustomerNo = 0;
        }

        public MyDog(int DogNo, int BreedNo, int CustomerNo, String name, DateTime dogDOB, char gender, String colour)
        {
            this.DogNo = DogNo;
            this.Name = Name;
            this.BreedNo = BreedNo;
            this.dogDOB = dogDOB;
            this.gender = gender;
            this.colour = colour;
            this.CustomerNo = CustomerNo;
        }

        public int dogNo
        {
            get { return DogNo; }
            set { DogNo = value; }
        }

        public int breedNo
        {
            get { return BreedNo; }
            set { BreedNo = value; }
        }
        public int customerNo
        {
            get { return CustomerNo; }
            set { CustomerNo = value; }
        }


        

        public string Name
        {
            get { return name; }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validForename(value))
                {
                    name = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("The dogs Name must be 2-15 characters long.");
                }
            }
        }


    



        public DateTime DogDOB //---------------------------------------------------------------------------------------
        {
            get { return dogDOB; }
            set
            {
                if (MyValidation.validDogDOB2(value))
                {
                    dogDOB = value;
                }
                else
                {
                    throw new MyException("Dog's Date Of Birth must be more than 8 weeks! (56 Days)");

                }
            }
        }

        public char Gender // this is a combo box 
        {
            get { return gender; }
            set { Gender = value; }

        }


        public string Colour
        {
            get { return colour; }
            set
            {
                if (MyValidation.validLength(value, 3, 20) && MyValidation.validLetter(value))
                {
                    colour = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Colour must be 3 - 20 characters long.");
                }
            }

        }

        
    }
}
