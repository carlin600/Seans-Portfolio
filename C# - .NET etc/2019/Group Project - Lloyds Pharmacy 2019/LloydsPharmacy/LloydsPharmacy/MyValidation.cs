using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LloydsPharmacy
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

        //for integers
        public static bool validIntNumber(int num, int min, int max)
        {
            bool ok = true;
       
            if (num < min || num > max)
                ok = false;
            return ok;

        }

        public static bool validDoubleNumber(double num, double min, double max)
        {
            bool ok = true;

            if (num < min || num > max)
                ok = false;
            return ok;

        }

        public static bool validNumberLength(int num, int min, int max)
        {
            bool ok = true;
            if (num <= min || num >= max)
                ok = false;

            return ok;
        }

        public static bool validDoubleLength(double num, double min, double max)
        {
            bool ok = true;
            if (num <= min || num >= max)
                ok = false;
            return ok;
        }
        public static bool validPrice(double num, double min, double max)
        {
            bool ok = true;
            if (num < min || num >= max)
                ok = false;
            return ok;
        }

        public static bool validLetter(string txt) // allows alphabetic characters 
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

        public static bool validLetterWhitespace(string txt) // allows alphabetic characters and whitespace
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
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])))
                        ok = false;

                }
            }
            return ok;
        }

        public static bool validLetterNumberWhitespace(string txt) // allows alphabetic characters, numbers and whitespace
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
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(char.IsNumber(txt[x])))
                        ok = false;

                }
            }
            return ok;
        }




        public static bool validForename(string txt) // allows alphabetic, dash and whitespace
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

        public static bool validSurname(string txt) // allows alphabetic, dash and whitespace
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





        public static bool validEmail(string txt) // allows alphanumeric and whitespace
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
                    if (!(char.IsLetter(txt[x])) &&
                    !(char.IsNumber(txt[x])) && !((txt[x].Equals('@')))
                                             && !((txt[x].Equals('-'))) &&
                    !((txt[x].Equals('_'))) && !((txt[x].Equals('.'))))
                    {
                        ok = false;
                    }
                }
            }
            return ok;

        }
        public static String firstLetterEachWordToUpper(String word) /// not working
        {
            Char[] array = word.ToCharArray();

            if (Char.IsLower(array[0]))
            {
                array[0] = Char.ToUpper(array[0]);
            }
            // go through array and check for spaces. Make any lowercase letters after a space uppercase

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
            return new string(array);
        }

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
            return new string(array);
        }
    }

}

