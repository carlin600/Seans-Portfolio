using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LloydsPharmacy
{
    class MyMinorAilments
    {
        private String ailmentID, ailmentDesc, ailmentTypeID;

        public MyMinorAilments()
        {
            this.ailmentID = ""; this.ailmentDesc = ""; this.ailmentTypeID = "";
        }

        public MyMinorAilments(String ailmentID, String ailmentDesc, String ailmentTypeID)
        {
            this.ailmentID = ailmentID; this.ailmentDesc = ailmentDesc; this.ailmentTypeID = ailmentTypeID;
        }

        public String AilmentID
        {
            get { return ailmentID; }
            set
            {
                if (MyValidation.validLength(value, 7, 8) && MyValidation.validLetterNumberWhitespace(value))
                {
                    ailmentID = MyValidation.EachLetterToUpper(value);
                }
                else
                    throw new MyException("Ailment ID must be formatted as 'MIA[0-9][0-9][0-9][0-9]");
            }
        }

        public String AilmentDesc
        {
            get { return ailmentDesc; }
            set
            {
                if (MyValidation.validLength(value, 2, 25) && MyValidation.validLetter(value))
                {
                    ailmentDesc = MyValidation.firstLetterEachWordToUpper(value);
                }
                else
                    throw new MyException("Ailment Description must be 2-25 letters");
            }
        }

        public String AilmentTypeID
        {
            get { return ailmentTypeID; }
            set { ailmentTypeID = value; }

            /*get { return ailmentTypeID; }
            set
            {
                
                if (MyValidation.validLength(value, 2, 8) && MyValidation.validLetterNumberWhitespace(value))
                {
                    ailmentTypeID = MyValidation.EachLetterToUpper(value);
                }
                else
                    throw new MyException("Ailment Type ID must be formatted as 'AITY[0-9][0-9][0-9]");
            }*/
        }
    }
}
