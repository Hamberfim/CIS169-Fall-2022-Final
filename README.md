# CIS169 - C# Programing - Fall 2022 - Final
**Recieved an 'A' for my Final Project**
### Final Project Specifications
**Create a MVC Web App**
* Class Model should be called StudentWorkerModel and inherited from a Student class with properties of (app must include at least two class): 
  - name, 
  - id, 
  - hourly pay, 
  - hours worked, and 
  - a method weeklySalary()
  
  *Notes some properties might belong in the Student class. Make sure your method calculates the weekly salary using the class method and validate user input. App should display student name and the weekly salary.*

* GUI components:
  - Button
  - Clear
  - User Input validation and output to GUI for invalid input 

* Documentation: 
  - Comments
  - Header must include problem description

* App must demonstrate:
  - inheritance
  - method overloading
  - method overriding
  - follow naming conventions
  - follow our class style (Constructors, Properties, methods, etc)

* Unit tests with good coverage that includes edge cases/use cases
  - Follow Unit Testing style
      - Use variables actual and expected (when needed)
      - Use comments to create appropriate code blocks, i.e., 
        - // Arrange
        - // Act
        - // Assert
    - Test 1. Invalid hours worked (too low)
    - Test 2. Invalid hours worked (too high)
    - Test 3. Invalid hourly salary (too low)
    - Test 4. Invalid hourly salary (too high)
    - Test 5. Valid test 
