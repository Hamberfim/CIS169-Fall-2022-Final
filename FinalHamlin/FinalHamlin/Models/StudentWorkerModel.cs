using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
/***************************************************************
* Name         : FinalHamlin
* Author       : Anthony Hamlin
* Created      : 11/28/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program is an MVC Web Application with a StudentWorkerModel that inherits from Student
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace FinalHamlin.Models
{
    // inherit from the Student Model
    public class StudentWorkerModel : StudentModel
    {
        // properties
        private decimal _pay = 0.0m;
        private decimal _hours = 0m;

        // constants - no magic numbers
        private const decimal PAY_RATE_LOW = 7.25m;
        private const decimal PAY_RATE_HIGH = 14.75m;
        private const decimal HOURS_LOW = 1.0m;
        private const decimal HOURS_HIGH = 15.0m;


        // constructor
        public StudentWorkerModel()
        {
            _pay = 0.0m;
            _hours = 0.0m;
        }

        // constructor with base model
        public StudentWorkerModel(decimal pay, decimal hours, string firstName2, string lastName2, int studentID2) : base(firstName2, lastName2, studentID2)
        {
            if (pay < PAY_RATE_LOW || pay > PAY_RATE_HIGH)
            {
                _pay = 0m;
            }
            else
            {
                _pay = pay;
            }


            if (hours < HOURS_LOW || hours > HOURS_HIGH)
            {
                _hours = 0.0m;
            }
            else
            {
                _hours = hours;
            }

        }

        // I'm not throwing errors 
        // setters/getters - validate form input
        [Required(ErrorMessage = "Enter a pay rate. Must be between 7.25 - 14.75.")]
        [Display(Name = "Pay Rate")]
        [Range(7.25, 14.75)]  // data type requires double for CONSTANT use in 'Range' rather than decimal 
        public decimal? Pay
        {
            get { return _pay; }
            set
            {
                if (value < PAY_RATE_LOW || value > PAY_RATE_HIGH)
                {
                    _pay = 0m;
                }
                else
                {
                    _pay = Convert.ToDecimal(value);
                }

            }
        }

        [Required(ErrorMessage = "Enter hours worked. Must be between 1 - 15.")]
        [Display(Name = "Hours Worked")]
        [Range(1.0, 15.0)]
        public decimal? Hours
        {
            get { return _hours; }
            set
            {
                if (value < HOURS_LOW || value > HOURS_HIGH)
                {
                    _hours = 0m;
                }
                else
                {
                    _hours = Convert.ToDecimal(value);
                }

            }
        }

        // overloaded/override the StudentModel
        public override decimal WeeklySalary()
        {
            return Convert.ToDecimal(Pay) * Convert.ToDecimal(Hours);
        }

        // override the ToString in theStudentModel
        public override string ToString()
        {
            return base.ToString() + " Weakly Salary: " + WeeklySalary();
        }
    }
}

/** 
 * 
Final Project Specifications
    Complete the project
        MVC Web App Class is StudentWorkerModel (inherited from Student) with properties name, id, hourly pay, hours worked, and method weeklySalary(). Notes some properties might belong in the Student class. Make sure your method calculates the weekly salary using the class methods, there is no need to pass any values to the method. Set the values in the code, and on the page, display student name and the weekly salary.
            Must be a Web Application
                GUI components:
                    Button
                    Clear
                    User Input for necessary information in your model
                Model should include input validation and print to GUI when non-numeric input or invalid input is input
            Documentation
                Comments
                Header must include problem description
            Must include at least 2 classes
                Demonstrate inheritance
                Demonstrate method overloading
                Demonstrate method overriding
                Follow naming conventions
                Follw our class style (Constructors, Properties, methods, etc) 
            Must include Unit tests with good coverage (include edge cases and use cases)
Test your StudentWorker Model:
Business logic: Workers can work 1 to 15 per week and pay rate starts at $7.25 and can be up to $14.75 per hour. If there is an issue, pay should be returned as zero. The administrator will check for zero paychecks to fix errors and re-run payroll for those individuals. NOTE: Think about if it makes sense to throw exceptions in the class. Do you know how to handle those in the Web App view? It might be better to avoid them and use input validation to handle input. What can you set the salary to if there is bad input? 
Add Unit Tests:
    Use appropiate test names
    Follow Unit Testing style shown in class
        Use variables actual and expected (when needed)
        Use comments to create code blocks appropriately
            // Arrange
            // Act
            // Assert 
    Test 1. Invalid hours worked (too low)
    Test 2. Invalid hours worked (too high)
    Test 3. Invalid hourly salary (too low)
    Test 4. Invalid hourly salary (too high)
    Test 5. Valid test 
Submit a zip file of the Solution (There should be a two projects) names FinalYourLastName.zip
 */