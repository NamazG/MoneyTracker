using System;
namespace MoneyTracker
{
    public class MoneyCalculation
    {
        public float Balance { get; set; }
        public float Spent { get; set; }
        public float Added { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateTime { get; }
        public string TagSpent { get; set; }
        public string TagAdded { get; set; }
        public MoneyCalculation()
        {

        }
        public float MoneySpent(float spent)
        {
            Spent = spent;
            Balance = Balance - Spent;
            Console.WriteLine($"{TagSpent}: {Spent}, New balance: {Balance}");
            return Balance;
        }
        public float MoneyAdded(float added)
        {
            Added = added;
            Balance = Balance + Added;
            Console.WriteLine($"{TagAdded}: {Added}, New balance: {Balance}");
            return Balance;
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Your current balance: {Balance}");
        }
    }
}
