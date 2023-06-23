//Homework - Primitive Data Types and Variables

//Float or Double? 
/*Which of the following values can be assigned to a variable of type float and which
to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program
to assign the numbers in variables and print them to ensure no precision is lost.*/

using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Xml;

double firstNumber = 34.567839023;
Console.WriteLine(firstNumber);

float secondNumber = 12.345F;
Console.WriteLine(secondNumber);

double thirdNumber = 8923.1234857;
Console.WriteLine(thirdNumber);

float fourthNumber = 3456.091F; 
Console.WriteLine(fourthNumber);

//Boolean Variable

/*Declare a Boolean variable called "isFemale" and assign an appropriate value corresponding
to your gender.Print it on the console. */

bool isFemale = false;
Console.WriteLine($"The statement that Andrei Alexa is a female is {isFemale }.");

//Strings and Objects

/*Declare two string variables and assign them with Hello and World. Declare an object 
 * variable and assign it with the concatenation of the first two variables (mind adding 
 * an interval between). Declare a third string variable and initialize it with the value 
 * of the object variable (you should perform type casting).*/

string firstString = "Hello";
string secondString = "World";
object greetings = firstString + " " + secondString;
string thirdString = greetings.ToString();
Console.WriteLine(thirdString);


//Quotes in Strings

/*Declare two string variables and assign them with following value:
The "use" of quotations causes difficulties. Do the above in two different ways: with and 
without using quoted strings. Print the variables to ensure that their value was correctly 
defined.*/

string firstVariable = "The \"use\" of quotations causes difficulties";
string secondVariable = firstVariable;
Console.WriteLine(firstVariable);
Console.WriteLine(secondVariable);


//Exchange Variable Values

/*Declare two integer variables a and b and assign them with 5 and 10 and after that 
 * exchange their values by using some programming logic.Print the variable values before 
 * and after the exchange.*/

int a = 5;
int b = 10;
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
//found out about tuples in this exercise
(a, b) = (b, a);
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);


//Employee Data

/*A marketing company wants to keep record of its employees. Each record would have the 
 * following characteristics:

    First name
    Last name
    Age (0...100)
    Gender(m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate 
primitive data types. Use descriptive names. Print the data at the console.*/

string firstName = "Andrei";
string lastName = "Alexa";
int employeeAge = 33;
char gender = 'm';
long personalID = 098726134511234;
long employeeNum = 8766662881991236516;

Console.WriteLine("First Name: " + firstName);
Console.WriteLine("Last Name: " + lastName);
Console.WriteLine("Age: " + employeeAge);
Console.WriteLine("Gender: " +  gender);
Console.WriteLine("Personal ID: " + personalID);
Console.WriteLine("Unique Employee ID: " + employeeNum);
