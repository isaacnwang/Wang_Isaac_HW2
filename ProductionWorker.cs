using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wang_Isaac_HW2
{
    class ProductionWorker : Employee
    {
        public Shifts enumShifts { get; set; }
        public Decimal decHourlyPayRate { get; set; }
        public Decimal decHoursWorked { get; set; }

        //Create a method for process production workers
        public void ProcessProdWorker()
        {
            //create a variable for input
            String strInput;

            //Get the Employee Name
            Console.Write("What is your name? ");
            strEmployeeName = Console.ReadLine();

            //Get the Employee Number
            do
            {
                Console.Write("What is your Employee Number? ");
                strInput = Console.ReadLine();
                intEmployeeNum = Validation.CheckInt(strInput);
            } while (intEmployeeNum == -1); //Checks to see if employee number is a postive integer

            //Get the type of shift
            do
            {
                Console.Write("What is your type of shift? ");
                strInput = Console.ReadLine();
                enumShifts = Validation.ValidateShift(strInput);
            } while (enumShifts == Shifts.Error); //Checks to see if shift is either day or night

            //Get the pay rate
            do
            {
                Console.Write("What your hourly pay rate? ");
                strInput = Console.ReadLine();
                decHourlyPayRate = Validation.CheckDecimal(strInput);
            } while (decHourlyPayRate == -1); //Checks to see if pay rate is a positive number

            //Get the hours worked
            do
            {
                Console.Write("How many hours did you work this week? ");
                strInput = Console.ReadLine();
                decHoursWorked = Validation.CheckDecimal(strInput);
            } while (decHoursWorked == -1); //Checks to see if hours worked is a positive number
        }

        //Create a method to calculate total pay
        public Decimal CalculateTotalPay()
        {
            return decHourlyPayRate * decHoursWorked;
        }

    }
}
