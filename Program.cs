// See https://aka.ms/new-console-template for more information
using FunctionalProgram;

bool flag = true;
while (flag)
{
    Console.WriteLine("Enter Value:\n1.Fibonacci Series\n" +
        "2.Perfect Number\n"+
        "3.Prime Number\n"+
        "4.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            FibonacciSeries fibonacci = new FibonacciSeries();
            fibonacci.Fibonacci();
            break;
        case 2:
            PerfectNumber perfect = new PerfectNumber();
            perfect.Perfect();
            break;
        case 3:
            PrimeNumber prime = new PrimeNumber();
            prime.PrimeCheck();
            break;
        case 4:
            flag = false;
            break;
    }

}

