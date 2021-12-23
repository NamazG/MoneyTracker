using System;

namespace MoneyTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Please enter last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine($"Welcome {fname} {lname}");
            MoneyCalculation moneyCalculation = new MoneyCalculation();
            fname = moneyCalculation.FirstName;
            lname = moneyCalculation.LastName;

            //Balance
            Console.WriteLine("Total balance: ");
            string mon = Console.ReadLine();
            float money;
            while (Single.TryParse(mon, out money) == false)
            {
                Console.WriteLine("Please enter valid number");
                Console.WriteLine("Total balance: ");
                mon = Console.ReadLine();
            }

                moneyCalculation.Balance = money;

             //Selecting option
                int option = 0;
                while (option != 5)
                {
                    Console.WriteLine("Choose an option: press 1 to Add money, 2 to Spend money, 3 to view balance, 5 to exit");
                    string opt = Console.ReadLine();
                    while (int.TryParse(opt, out option) == false)
                    {
                        Console.WriteLine("Please enter valid number");
                        Console.WriteLine("Choose an option: press 1 to Add money, 2 to Spend money, 3 to view balance, 5 to exit");
                        opt = Console.ReadLine();
                    }

                    //Adding money
                    if (option == 1)
                    {
                        Console.WriteLine("Transaction label: ");
                        moneyCalculation.TagAdded = Console.ReadLine();
                        Console.WriteLine("How much would you like to add?: ");
                        string add = Console.ReadLine();
                        float added;
                        while (Single.TryParse(add, out added) == false)
                        {
                            Console.WriteLine("Please enter valid number");
                            Console.WriteLine("How much would you like to add?: ");
                            add = Console.ReadLine();
                        }
                        moneyCalculation.MoneyAdded(added);
                    }
                    //Spending money
                    else if (option == 2)
                    {
                        Console.WriteLine("Transaction label: ");
                        moneyCalculation.TagSpent = Console.ReadLine();
                        Console.WriteLine("How much would you like to spend?: ");
                        string spn = Console.ReadLine();
                        float spend;
                        while (Single.TryParse(spn, out spend) == false)
                        {
                            Console.WriteLine("Please enter valid number");
                            Console.WriteLine("How much would you like to spend?: ");
                            spn = Console.ReadLine();
                        }
                        if (spend > moneyCalculation.Balance)
                        {
                            Console.WriteLine("You don't have enough money, please select another option");
                        }
                        else
                        {
                            moneyCalculation.MoneySpent(spend);
                        }
                    }
                    //Showing balance
                    else if (option == 3)
                    {
                        moneyCalculation.ShowBalance();
                    }
                    //Exiting code
                    else if (option == 5)
                    {
                        Console.WriteLine("Have a good day!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid option");
                    }
                }
        }
    }
}
