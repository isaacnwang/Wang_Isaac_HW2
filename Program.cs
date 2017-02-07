using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Isaac Wang
//Date: February 7, 2016
//Assignment: Homework 2
//Description: This program displays the salary for Production Workers and Shift Supervisors.

namespace Wang_Isaac_HW2
{
    //Create enum for Shifts
    public enum Shifts { DAY, NIGHT, Error };

    class Program
    {
        static void Main(string[] args)
        {
            //create a variable for input
            String strInput;

            //create a variable for type of worker
            int intSelection;

            //Ask which type of worker to process
            do
            {
                Console.WriteLine("Please Select 1 or 2:");
                Console.WriteLine("1: Production Worker");
                Console.WriteLine("2: Shift Supervisor");
                strInput = Console.ReadLine();
                intSelection = Validation.CheckInt(strInput);
            } while((intSelection != 1) && (intSelection != 2));

            //Retrieve the object's property and displays the output for Production Workers
            if(intSelection == 1)
            {
                ProductionWorker PWObject = new ProductionWorker();
                PWObject.ProcessProdWorker();
                Console.WriteLine("Employee Name: {0}", PWObject.strEmployeeName);
                Console.WriteLine("Employee Number: {0}", PWObject.intEmployeeNum);
                Console.WriteLine("Shift: {0}", PWObject.enumShifts.ToString());
                Console.WriteLine("Hourly Pay Rate: {0:C}", PWObject.decHourlyPayRate);
                Console.WriteLine("Hours Worked: {0}", PWObject.decHoursWorked);
                Console.WriteLine("Total Pay: {0:C}", PWObject.CalculateTotalPay());
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();
            }
            //Retrieve the object's property and displays the output for Shift Supervisors
            if (intSelection == 2)
            {
                ShiftSupervisor SSObject = new ShiftSupervisor();
                SSObject.ProcessSupervisor();
                Console.WriteLine("Employee Name: {0}", SSObject.strEmployeeName);
                Console.WriteLine("Employee Number: {0}", SSObject.intEmployeeNum);
                Console.WriteLine("Annual Salary: {0:C}", SSObject.decAnnualSalary);
                Console.WriteLine("Annual Bonus: {0:C}", SSObject.decAnnualBonus);
                Console.WriteLine("Total Pay: {0:C}", SSObject.CalculateAnnualPay());
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();
            }
        }
    }
}



