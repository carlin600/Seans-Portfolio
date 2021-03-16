using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelClub
{
    class MySize
    {
        private int sizeNo = 0;
        private double ChargePerDay = 0.0;

        public MySize()
        {
            this.sizeNo = 0;
            this.ChargePerDay = 0.0;

        }

        public MySize(int sizeNo, double ChargePerDay)
        {
            this.sizeNo = sizeNo;
            this.ChargePerDay = ChargePerDay;
        }

        public int SizeNo// double check
        {
            get { return sizeNo; }
            set
            {
                /*if (MyValidation.validNumber())
                {
                    
                }
                else
                {
                    throw new MyException("The Size must be between 1 & 4.");
                }*/

                sizeNo = value;
            }
        }

        public double chargePerDay
        {
            get { return ChargePerDay; }
            set
            {
                //not 100% sure about this one
            }
        }

    }
}
