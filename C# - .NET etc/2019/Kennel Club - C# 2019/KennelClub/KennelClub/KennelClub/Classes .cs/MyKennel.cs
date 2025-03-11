using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelClub
{

    //create the forms then copy the code from breed and change all the names etc to get it to work. finish off the forms once you have the classes built for them to work efficiently. 
    //REMEMBER TO NAME THE FORM PROPERLY
    class MyKennel
    {

        private int kennelNo;

        private string sizeK;

        public MyKennel()
        {
            this.kennelNo = 0;
            this.sizeK = "";

        }

        public MyKennel(int kennelNo, string sizeK)
        {
            this.kennelNo = kennelNo;
            this.sizeK = sizeK;//has to be between one and four
            //validate these then
        }

        public int KennelNo
        {
            get { return kennelNo; }
            set { kennelNo = value; }
        }


        public string SizeK
        {
            get { return sizeK; }
            set
            {
                if (MyValidation.validLength(value, 1, 4))
                {
                    sizeK = value;
                }
                else
                {
                    throw new MyException("The Size must be between 1 & 4.");
                }
            }
        }
    }
}
