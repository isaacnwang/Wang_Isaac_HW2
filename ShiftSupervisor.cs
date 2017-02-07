using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wang_Isaac_HW2
{
    class ShiftSupervisor :  Employee
    {
        public Decimal decAnnualSalary { get; set; }
        public Decimal decAnnualBonus { get; set; }

        //Create a method to process supervisor
        public void ProcessSupervisor()
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

            //Get the annual salary
            do
            {
                Console.Write("What is your annual salary? ");
                strInput = Console.ReadLine();
                decAnnualSalary = Validation.CheckDecimal(strInput);
            } while (decAnnualSalary == -1); //Checks to see if the annual salary is valid

            //Get the annual bonus
            do
            {
                Console.Write("What your annual bonus? ");
                strInput = Console.ReadLine();
                decAnnualBonus = Validation.CheckDecimal(strInput);
            } while (decAnnualBonus == -1); //Checks to see if the annual bonus is valid
        }

        //Create a method to calculate total annual pay
        public Decimal CalculateAnnualPay()
        {
            return decAnnualSalary + decAnnualBonus;
        }

    }
}
