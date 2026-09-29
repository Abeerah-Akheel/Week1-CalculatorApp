//Declare the variables and initilaise them to 0 
int firstNumber = 0;
int secondNumber = 0;
int result = 0;
int choice = 0;

//This integer variable is used to store the first number
//Ask the user to input the first number
Console.WriteLine("Type in the first number followed by the Enter Key");
firstNumber = Convert.ToInt32(Console.ReadLine());

//This integer variable is used to store the second number
//Ask the user to input the second number
Console.WriteLine("Type in the second number followed by the Enter Key");
secondNumber = Convert.ToInt32(Console.ReadLine());

//Use a loop to make the relvelant decision and perofrm the request math operation.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("1 - Add");
Console.WriteLine("2 - Subtract");
Console.WriteLine("3 - Divide");
Console.WriteLine("4 - Multiply");

//Convert string to integer.
choice = Convert.ToInt32(Console.ReadLine());

//Use an IF statement to perform selcted maths operations.
if (choice == 1)
{
    result = firstNumber + secondNumber;
    Console.WriteLine($"Adding {firstNumber} and {secondNumber} equals {result}");
}
else if (choice == 2)
{
    result = firstNumber - secondNumber;
    Console.WriteLine($"Subtracting {firstNumber} and {secondNumber} equals {result}");
}
else if (choice == 3)
{
    result = firstNumber / secondNumber;
    Console.WriteLine($"Dividing {firstNumber} by {secondNumber} equals {result}");
}
else if (choice == 4)
{
    result = firstNumber * secondNumber;
    Console.WriteLine($"Multiplying {firstNumber} by {secondNumber} equals {result}");
}
else
{
    Console.WriteLine("You did not select a valid number between 1-4");
}