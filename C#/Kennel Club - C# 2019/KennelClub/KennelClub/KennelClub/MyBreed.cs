using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelClub
{


    class MyBreed
    {

        private int breedNo;

        private string breedName, sizeB;

        public MyBreed()
        {
            this.breedNo = 0;
            this.breedName = "";
            this.sizeB = "";

        }

        public MyBreed(int breedNo, string breedName, string sizeB)
        {
            this.breedNo = breedNo;
            this.breedName = breedName; //validletterwhitespace
            this.sizeB = sizeB;//has to be between one and four
            //validate these then
        }

        public int BreedNo
        {
            get { return breedNo; }
            set { breedNo = value; }
        }


        public string BreedName
        {
            get { return breedName; }
            set
            {
                if (MyValidation.validLength(value, 3, 20) && MyValidation.validLetter(value))
                {
                    breedName = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                {
                    throw new MyException("Breed must be 3 - 30 characters long.");
                }
            }
        }

        public string SizeB
        {
            get { return sizeB; }
            set
            {
                if (MyValidation.validLength(value, 1, 4))
                {
                    sizeB = value;
                }
                else
                {
                    throw new MyException("The Size must be between 1 & 4.");
                }
            }
        }
    }
}
