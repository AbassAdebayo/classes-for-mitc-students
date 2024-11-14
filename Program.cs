// Console.Write("Enter the day of the month(1-31): ");
// int q = int.Parse(Console.ReadLine());

// Console.Write("Enter month(1-12): ");
// int m = int.Parse(Console.ReadLine());

// Console.Write("Enter year (e.g. 2012): ");
// int year = int.Parse(Console.ReadLine());

// if(m == 1)
// {
//     m = 13;
//     year--;
// }
// if(m == 2)
// {
//     m = 14;
//     year--;
// }

// int j = year / 100;
// int k = year % 100;

// int a1 = 26 * (m + 1) / 10;
// int a2 = k / 4;
// int a3 = j / 4;
// int a4 = 5 * j;

// int h = (q + a1 + k + a2 + a3 + a4) % 7;

// string day = "";

// switch (h)
// {
//     case 0:
//     day = "Saturday";
//     break;
//     case 1:
//     day = "Sunday";
//     break;
//     case 2:
//     day = "Monday";
//     break;
//     case 3:
//     day = "Tuesday";
//     break;
//     case 4:
//     day = "Wednesday";
//     break;
//     case 5:
//     day = "Thursday";
//     break;
//     case 6:
//     day = "Friday";
//     break;
//     default:
//     day = "Invalid day!";
//     break;
// }

// Console.WriteLine($"Day of the week is {day}, {q} {m} {year}");

// Console.Write("Enter the value of n: ");
// int n = Convert.ToInt32(Console.ReadLine());


// for (int i = 1; i <= n; i++)
// {
//     if (i % 3 != 0 && i % 7 != 0)
//     {
//         Console.WriteLine(i);
//     }
//     
// }

// int smallest = int.MaxValue;
// int biggest = int.MinValue;
//
// for (int i = 0; i < n; i++)
// {
//     Console.Write($"Enter integer number {i + 1}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     
//     if(num < smallest) smallest = num;
//     if(num > biggest) biggest = num;
// }
// Console.WriteLine($"Smallest number is {smallest}");
// Console.WriteLine($"Biggest number is {biggest}");

//N!/K!

Console.Write("Enter the value of N!: ");
int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter the value of K!: ");
// int k = Convert.ToInt32(Console.ReadLine());


// Console.Write($"{n}!/{k}! = ");
long nFactorial = 1;
int i = n;

int counter = 0;
while (i > 0)
{
    nFactorial *= i;
    counter += n / (int)Math.Pow(5, i);
    i--;
    
}


Console.WriteLine(counter);

// long kFactorial = 1;

// while (k > 0)
// {
//     kFactorial *= k;
//     k--;
// }

//Console.WriteLine($"{nFactorial} / {kFactorial} = {nFactorial/kFactorial}");

string firstName = "Abass";
string lastName = "Adebayo";

string c = $"{firstName} {lastName}";

Console.WriteLine(c);




