// See https://aka.ms/new-console-template for more information
using FunctionalProgram;

bool flag = true;
while(flag)
{
    Console.WriteLine("Enter Value:\n1.Fibonacci Series\n" +
        "2.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            FibonacciSeries fibonacci = new FibonacciSeries();
            fibonacci.Fibonacci();
            break;
        case 2:
            flag = false;
            break;
    }

}

