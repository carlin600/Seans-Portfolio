using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelClub
{
    class MyException : Exception
    {
        private String message;

        public MyException(String message)
        {
            this.message = message;
        }

        public String toString()
        {
            return String.Format("Error: {0} ", message);
        }
    }
}
