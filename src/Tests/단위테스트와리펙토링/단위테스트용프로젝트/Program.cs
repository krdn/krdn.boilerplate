// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace 단위테스트용프로젝트
{
    public class Account
    {
        public Account()
        {
            
        }

        public decimal Balance { get; private set; }

        public void AddTransaction(decimal @decimal)
        {
            Balance = 200m;
        }
    }
}