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

Console.WriteLine("Please enter a numg=ber");
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

