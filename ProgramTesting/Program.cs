// See https://aka.ms/new-console-template for more information

Sum(750,715);

//Calling a Method
Console.Write("Feet: ");
float feet = Convert.ToSingle(Console.ReadLine());
FeetToMeter(feet);

//User Input
static void userInput()
{
    Console.Write("First Value : ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Second Value: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    //Console.Write("First Value : ");
    //float num1 = Convert.ToSingle(Console.ReadLine());
    //Console.Write("Second Value: ");
    //float num2 = Convert.ToSingle(Console.ReadLine());
}

//Prog#1: Hello,World
static void Introduce()
{
    Console.WriteLine("Hello, World!");
}

//Prog#2: Adding Two Integers 
static int Sum(int num1, int num2)
{
    Console.Write("First Value  : ");
    int firstValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Second Value : ");
    int secondValue = Convert.ToInt32(Console.ReadLine());
    int answer = firstValue + secondValue;
    Console.WriteLine("The answer is {0}.", answer);
    return answer;
}

//Prog#3: Swapping of Variables
static void Swap()
{
    Console.WriteLine("Before Swap");
    Console.Write("Value 1: ");
    string value1 = Console.ReadLine();
    Console.Write("Value 2: ");
    string value2 = Console.ReadLine();
    Console.WriteLine("After Swap");
    Console.WriteLine("Value 1: {0}", value2);
    Console.WriteLine("Value 2: {0}", value1);
}


//Prog#4: Multiplication of Two Floating Numbers
static float Multiplication(float x, float y)
{
    float answer = x * y;
    Console.WriteLine($"The answer is {answer}.");
    return answer;
}

//Prog#5: Arithmetic Operations
static void Arithmetic(float num1, float num2)
{
    Console.WriteLine("{1} + {2} is {0}.", num1 + num2, num1, num2);
    Console.WriteLine("{1} - {2} is {0}.", num1 - num2, num1, num2);
    Console.WriteLine("{1} * {2} is {0}.",num1 * num2, num1, num2);
    Console.WriteLine("{1} / {2} is {0}.", num1 / num2, num1, num2);
}

//Prog#6: Feet to Meter
static float FeetToMeter(float x)
{
    try
    {
        float answer = x * 0.3048f;
        Console.WriteLine($"Meter: {answer}");
        return answer;
    }
    catch
    {
        return 0;
    }
}

//Prog#7: Celcius to Fahrenhiet and vice versa
//static float TemperatureConvertion()
//{
//    try
//    {

//    }
//}

//Console.WriteLine("Celcius to Fahrenhiet and vice versa");
//try
//{
//    int i = 1;
//    while(i >0)
//    {
//        Console.Write("C->F or F->C ? 0/1 : ");
//        int choose = Convert.ToInt32(Console.ReadLine());
//        bool isChoose = false;
//        if (choose == 0)
//        {
//            isChoose = true;
//            Console.Write("Temperature in Celcius : ");
//            float celcius = Convert.ToSingle(Console.ReadLine());
//            float fahrenheit = (celcius * 1.8f) + 32.00f;
//            Console.WriteLine("The answer is {0} degree Fahrenheit.", fahrenheit);
//            break;
//        }
//        if (!isChoose && choose == 1)
//        {
//            Console.Write("Temperature in Fahrenheit : ");
//            float fahrenheit = Convert.ToSingle(Console.ReadLine());
//            float celcius = (fahrenheit - 32.00f) / 1.8f;
//            Console.WriteLine("The answer is {0} degree Celcius.", celcius);
//            break;
//        }
//        else i++;
//    }
//}
//catch
//{
//    Console.WriteLine("Error. Restart the program.");
//}

//Prog#7 Find the size of the data type
//Console.WriteLine("Size of char    : {0}", sizeof(char));
//Console.WriteLine("Size of byte    : {0}", sizeof(byte));
//Console.WriteLine("Size of int     : {0}", sizeof(int));
//Console.WriteLine("Size of long    : {0}", sizeof(long));
//Console.WriteLine("Size of double  : {0}", sizeof(double));
//Console.WriteLine("Size of float   : {0}", sizeof(float));
//Console.WriteLine("Size of decimal : {0}", sizeof(decimal));

//Prog#8 Printing ASCII Value
//Console.Write("Enter a character: ");
//char character = Convert.ToChar(Console.ReadLine());
//int value = (char) character;
//Console.WriteLine("ASCII Value is {0}",value);

//Prog#9: Area of a Circle
//Console.Write("Radius: ");
//int radius = Convert.ToInt32(Console.ReadLine());
//float area = 3.14159f * Convert.ToSingle(Math.Pow(Convert.ToSingle(radius), 2));
//Console.WriteLine("The area of the circle is {0}", area);\

//Prog#10: Area of Square
//Console.Write("Side: ");
//int side = Convert.ToInt32(Console.ReadLine());
//int area = side * side;
//Console.WriteLine("The answer is {0}.", area);

//Prog#10: Area of Rectangle
//Console.Write("Length: ");
//int length = Convert.ToInt32(Console.ReadLine());
//Console.Write("Width : ");
//int width = Convert.ToInt32(Console.ReadLine());
//int area = length * width;
//Console.WriteLine("The answer is {0}.", area);

//Prog#11: Convert Days to Years, Months, Weeks and Days
//Console.Write("Overall Days: ");
//int overallDays = Convert.ToInt32(Console.ReadLine());
//int years = overallDays / 365;  // not leap year
//int months = (overallDays * 31) / 12;
//Console.WriteLine("Year/s : {0}", years);
//Console.WriteLine("Month/s: {0}", months);

//Prog#12: Even or Odd Number
//int number = 234523;
//Console.Write("Enter a number: ");
//int number = Convert.ToInt32(Console.ReadLine());
//bool isEven = (number % 2) == 0 ? true : false;
//if (isEven) Console.WriteLine("This number is a Even Number.");
//else Console.WriteLine("This number is a Odd Number.");

//Prog#13: Largest Number Among Three Numbers
//int number1 = 13, number2 = 9, number3 = 10;
//Console.Write("First Number : ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Second Number: ");
//int number2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Third Number :");
//int number3 = Convert.ToInt32(Console.ReadLine());
//if (number1 > number2 && number1 > number3) 
//    Console.WriteLine("The First Number is the Greatest Among Three");
//else if (number2 > number1 && number2 > number3)
//    Console.WriteLine("The Second Number is the Greatest Among Three");
//else Console.WriteLine("The Third Number is the Greatest Among Three");
////int temp = Math.Max(number1, number2);
////bool isMax = temp < number3;
////if (isMax) Console.WriteLine("The max number is {0}", number3);
////else Console.WriteLine("The max is {0}", temp);

//int num1 = 3, num2 = 3, num3 = 2;
//int max = num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
//Console.WriteLine(max);


//Prog#13: Check Leap Year
//int year = 1600;
////Console.Write("Enter a year: ");
////int year = Convert.ToInt32(Console.ReadLine());
//bool isLeapYear = (year % 4 == 0) ? (year % 100 != 0) : (year % 100 == 0);
//if (isLeapYear) Console.WriteLine("{0} is a leap yar.", year);
//if (!isLeapYear)
//{
//    if (year % 400 == 0) Console.WriteLine("{0} is a leap yar.", year);
//    else Console.WriteLine("{0} is not a leap yar.", year);
//}

//Prog#14: Summation Method
//Console.WriteLine(Summation(new int[] { 3, 4565, 568, 2 }));
//static int Summation(int[] numbers)
//{
//    int overallSum = 0;
//    int i = 0;
//    while (i < numbers.Length)
//    {
//        overallSum += numbers[i];
//        i++;
//    }
//    return overallSum;
//}