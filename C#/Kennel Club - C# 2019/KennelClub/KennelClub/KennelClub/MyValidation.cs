using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace KennelClub
{
    class MyValidation
    {
        public static bool validLength(string txt, int min, int max)
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txt))
                ok = false;

            else if (txt.Length < min || txt.Length > max)
                ok = false;

            return ok;

        }

        public static bool validNumber(string txt)
        {
            bool ok = true;

            for (int x = 0; x < txt.Length; x++)
            {
                if (!(char.IsNumber(txt[x])))
                {
                    ok = false;
                }
            }

            return ok;
        }

        public static bool validLetter(string txt) //allows aplhabetical characters
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])))

                        ok = false;
                }

            }
            return ok;

        }



        public static bool validLetterWhitespace(string txt) //allows alphabetical characters and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x]))
                        && !(char.IsWhiteSpace(txt[x])))

                        ok = false;
                }
            }

            return ok;
        }


        //validletternumberwhitespace goes here - probably copy paste and slight alteration?
        public static bool validLetterNumberWhitespace(string txt) //allows alphabetical characters, numbers and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x]))
                     && !(char.IsWhiteSpace(txt[x]))
                     && !(char.IsNumber(txt[x])) // theres also IsDigit, im not sure if thats the same as IsNumber.
                        )
                        ok = false;
                }
            }

            return ok;
        }


        public static bool validForename(string txt) //allows alphabetical characters, dash and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-')))

                        ok = false;
                }
            }

            return ok;
        }


        //validsurname will go here, basically exact same as forename - done 
        public static bool validSurname(string txt) //allows alphabetical characters, dash and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x]))
                        && !(char.IsWhiteSpace(txt[x]))
                        && !(char.IsPunctuation(txt[x]))//i dont know if this helps with the ' in surnames, wont let me add it in the Equals ' ' 
                        && !(txt[x].Equals('-')))


                        ok = false;
                }
            }

            return ok;
        }


        public static bool validEmail(string txt) //allows alphanumeric and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x]))
                        && !(char.IsNumber(txt[x]))
                        && !((txt[x].Equals('@')))
                        && !((txt[x].Equals('-')))
                        && !((txt[x].Equals('_')))
                        && !((txt[x].Equals('.'))))
                    {
                        ok = false;
                    }
                }
            }

            return ok;

        }

        public static bool validDogDOB(string txt) // checks if the dog is atleast 8 weeks old 
        {
            DateTime currentDate = DateTime.Now;
            DateTime dogDOB = Convert.ToDateTime(txt);

            TimeSpan t = currentDate - dogDOB;
            double NoOfDays = t.TotalDays;

            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                if (NoOfDays <= 56) // 56 days = 8 weeks obviously
                    ok = false;

            }

            return ok;

        }

        //put the new dog dob checker here. -- see sheet
        public static bool validDogDOB2(DateTime dogDOB)
        {
            DateTime currentDate = DateTime.Now;

            TimeSpan t = currentDate - dogDOB;
            double NoOfDays = t.TotalDays;

            bool ok = true;

            if (NoOfDays <= 56)
            {
                ok = false;
            }

            return ok;
        }





        public static String firstLetterEachWordToUpper(String word) // this doesnt work - How does this not work? sc
        {
            Char[] array = word.ToCharArray();

            if (Char.IsLower(array[0]))
            {
                array[0] = Char.ToUpper(array[0]);
            }

            //go through array and check for spaces. Make any lowercase letters after a space uppercase

            for (int x = 1; x < array.Length; x++)
            {
                if (array[x - 1] == ' ')
                {
                    if (Char.IsLower(array[x]))
                    {
                        array[x] = Char.ToUpper(array[x]);
                    }
                }
                else
                    array[x] = Char.ToLower(array[x]);
            }
            return new String(array);
        }

        ///////////////////////////////////check this afte^^^^^^^^


        public static String EachLetterToUpper(String word)
        {
            Char[] array = word.ToCharArray();

            for (int x = 0; x < array.Length; x++)
            {
                if (Char.IsLower(array[x]))
                {
                    array[x] = Char.ToUpper(array[x]);
                }
            }

            return new String(array);
        }

    }
}
