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
* Description  : This is the StudentModel for MVC Web Application that StudentWorkerModel will inherit from 
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace FinalHamlin.Models
{
    public class StudentModel
    {

        // Properties
        private string _firstName;
        private string _lastName;
        private int _studentID;

        // constants - no magic numbers
        private const int ID_LENGTH = 9;
        private const int ID_LOW = 900000000;
        private const int ID_HIGH = 900999999;


        // constructor
        public StudentModel()
        {
            _firstName = "unknown";
            _lastName = "unknown";
            _studentID = 0;
        }

        // constructor
        public StudentModel(string firstName, string lastName, int studentID)
        {
            _firstName = firstName;
            _lastName = lastName;
            _studentID = studentID;
        }

        // setters/getters - validate form input
        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First Name must be letters only.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name can not be left blank.")]
        [StringLength(60, MinimumLength = 3)]
        public string FirstName { get => _firstName; set => _firstName = value; }

        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last Name must be letters only.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name can not be left blank.")]
        [StringLength(60, MinimumLength = 3)]
        public string LastName { get => _lastName; set => _lastName = value; }

        [Display(Name = "Student ID")]
        [Required(ErrorMessage = "Student ID can not be left blank.")]
        [Range(ID_LOW, ID_HIGH, ErrorMessage = "Student ID should conform to {1}-{2}")]
        public int? StudentID
        {
            get { return _studentID; }
            set
            {
                if (value < ID_LOW || value > ID_HIGH)
                {
                    _studentID = 0;
                }
                _studentID = Convert.ToInt32(value);
            }
        }

        // will be overloaded/override in the Student Worker Model
        public virtual decimal WeeklySalary()
        {
            return 0.0m;
        }

        // ToString override
        public override string ToString()
        {
            return base.ToString() + ": Name: " + _firstName + " " + _lastName;
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