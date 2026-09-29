//Variable names should be short yet meaningful. The choice of variable name should be mnemonic- that is designed to indicate to the casual observer the intent of its use.

//This integer variable is used to store the first number
//Ask the user to input the first number
Console.WriteLine("Type in the first number followed by the Enter Key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

//This integer variable is used to store the second number
//Ask the user to input the second number
Console.WriteLine("Type in the second number followed by the Enter Key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//Perform the calculation
int result = firstNumber + secondNumber;

//Output the answer to the console
Console.WriteLine("Adding {0} and {1} gives the answer {2}", firstNumber, secondNumber, result);