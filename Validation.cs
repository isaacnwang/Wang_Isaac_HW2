using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wang_Isaac_HW2
{
    //Creates the Validation Class
    static class Validation
    {
        public static Decimal CheckDecimal(String strInput)
        {
            //Declare the variable
            Decimal decResult;

            try
            {
                //Converts variable to an decimal
                decResult = Convert.ToDecimal(strInput);
            }
            catch
            {
                //This displays an error message before prompting the user to enter a valid input
                Console.WriteLine("Error: Please enter a valid number.");
                //Returns flag value
                return -1;
            }

            //Ensures input is positive
            if (decResult < 0)
            {
                Console.WriteLine("Error: The input value must be positive");
                //Returns flag value
                return -1;
            }

            //If code gets this far, returns the result
            return decResult;
        }

        public static int CheckInt(String strInput)
        {
            //Declare the variable
            int intResult;

            try
            {
                //Converts variable to an decimal
                intResult = Convert.ToInt32(strInput);
            }
            catch
            {
                //This displays an error message before prompting the user to enter a valid input
                Console.WriteLine("Error: Please enter a valid input.");
                //Returns flag value
                return -1;
            }

            //Ensures integer is positive
            if (intResult < 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return -1;
            }

            //If code gets this far, returns the result
            return intResult;
        }


        public static Shifts ValidateShift(string strInput)
        {

            //try to convert from string to enum
            try
            {
                return (Shifts)Enum.Parse(typeof(Shifts), strInput.ToUpper());
            }
            catch
            {
                Console.WriteLine("Error. Please enter day or night shift.");
                return Shifts.Error;
            }
        }
    }
}
