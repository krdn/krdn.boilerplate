// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace 단위테스트용프로젝트
{
    /// <summary>
    /// Account
    /// </summary>
    public class 계좌
    {
        // Balance
        public decimal 잔액 { get; private set; }

        // Transaction
        public void 거래추가(decimal amount)
        {
            잔액 += amount;
        }
    }
}