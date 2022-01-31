// See https://aka.ms/new-console-template for more information
using FunctionalProgram;

bool flag = true;
while (flag)
{
    Console.WriteLine("Enter Value:\n1.Fibonacci Series\n" +
        "2.Perfect Number\n"+
        "3.Prime Number\n"+
        "4.Reverse Number\n"+
        "5.Vending Machine\n"+
        "6.Day Of Week\n"+
        "7.Exit");
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
            ReverseNumber reverse = new ReverseNumber();
            reverse.Reverse();
            break;
        case 5:
            VendingMachine note = new VendingMachine();
            note.NoteCounter();
            break;
        case 6:
            int week = Calender.DayOfWeek(31, 1, 2022);
            switch (week)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }


            break;
        case 7:
            flag = false;
            break;
    }

}

