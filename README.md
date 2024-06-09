## Background

This solution is a specflow project that uses the page object model design pattern. The project is a simple test automation project that tests the login functionality of the website https://www.saucedemo.com/.
The project is written in C# and uses the following tools and frameworks:
- .net 6.0
- Specflow
- Selenium
- NUnit
- Page Object Model

## Installation
If using Visual Studio, you can clone the project and open the solution file. 
Install Specflow using the Extensions in Visual Studio.
This will install the necessary packages for the project.

## Test Cases
The test cases are written in the feature files in the Features folder.
The test cases are written in Gherkin language and are easy to read and understand.

## Assumptions
Test can be ran in any order, I have added clean up steps to the addToCart feature.
BDD is simple, this separates the business language from the implementation.

## Page Object Model
The project uses the Page Object Model design pattern.
The pages are defined in the PageObjects folder.
Page objects are used to define the elements and methods on the page and are used in the step definitions.
This makes the code more readable and maintainable.

## Running the tests
Build the solution in Visual Studio.
To run the tests, you can use the Test Explorer in Visual Studio.
You can run the tests individually or run all the tests at once.
Right click on the test(s) and select Run Selected Tests.

## Test Results
The test results are displayed in the Test Explorer.

## Living Documentation
The living documentation is generated using Specflow+LivingDoc.
A copy has been generated and is available in the root folder of the project.

### Installation
Install livingdoc using the following command:
```dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI```

### Generate Living Documentation
To generate the living documentation, specify the test assembly and the output file.
For example:
```livingdoc test-assembly C:\repos\sauceDemoAutomation\sauceLabsTest\bin\Debug\net6.0\sauceDemoTest.dll -t C:\repos\sauceDemoAutomation\sauceLabsTest\bin\Debug\net6.0\TestExecution.json```

## Coverage
This project covers 
- The login functionality of the website https://www.saucedemo.com/.
- Products are displayed after successful login.
- The user can add products to the cart.
- The user can checkout.
- The user can logout.

### Future Enhancements
Add more test cases to cover more functionality of the website.
- Such as adding more products to the cart, removing products from the cart, etc.
- Add more scenarios to cover different test cases.
- Add more selectors to the page objects.

### Author
S Kelly 2024

