//Create a variable called x which equals 5
int age = 5;

/*
 * note blocks
 */
//if(x==1) 
{

}

//declaring variables
int money;
//initialize variable
money = 5;
//combined
bool hungry = true;

//constant (wont let you change) const*
const double taxRate = 0.06;
//Console.WriteLine(taxRate);

//mini code problem
Console.WriteLine("please enter a radius");
//string entry = Console.ReadLine();
//double value = double.Parse(entry);
double value = double.Parse(Console.ReadLine());
double area = Math.PI * Math.Pow(value, 2);
Console.WriteLine(area);

//increment
/*age++;          same thing
age = age + 1;
odd or even %
    */

Console.WriteLine("Please enter a number");
int input = int.Parse(Console.ReadLine());
int oddCheck = input % 2;
if(oddCheck == 0)
{
    Console.WriteLine("even");
}
else if (oddCheck == 1)
{
    Console.WriteLine("odd");
}

//assignment
//value = 0;
// = age * 100 - Math.PI;

int assign = 0;
Console.WriteLine(assign);
assign = 5;
Console.WriteLine(assign);
assign += 2;
Console.WriteLine(assign);
assign -= 5;
Console.WriteLine(assign);

//null
string catName = null;
Console.WriteLine(catName);
catName = "Felony";
Console.WriteLine(catName);

string y = null;

if (y == null);
{
    y = "asdfjkh";
}
//nonnullable (int)
//int z = null;

//exercises
//exercise 1

Console.WriteLine("Say something");
string response = Console.ReadLine();
Console.WriteLine(response);

//exercise 2

Console.WriteLine("Give me a number");
double userNumber = double.Parse(Console.ReadLine());
double compNumber = userNumber + 1;
Console.WriteLine(compNumber);

//exercise 3
Console.WriteLine("Give me a number");
double newUserNumber = double.Parse(Console.ReadLine());
double newCompNumber = newUserNumber + 0.5;
Console.WriteLine(newCompNumber);

//exercise 4

Console.WriteLine("enter a whole number");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("enter another whole number");
int secondNum = int.Parse(Console.ReadLine());
Console.WriteLine(firstNum + secondNum);

//exercise 5
Console.WriteLine("enter a whole number");
int thirdNum =  int.Parse(Console.ReadLine());
Console.WriteLine("enter another whole number");
int fourthNum = int.Parse(Console.ReadLine());
Console.WriteLine(thirdNum * fourthNum);

//exercise 6
int c = 0;
do while
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Would you like to continue? (y/n)");
        if (c == 0)
    }