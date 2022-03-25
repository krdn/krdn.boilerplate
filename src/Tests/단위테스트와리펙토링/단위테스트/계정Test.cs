using Microsoft.VisualStudio.TestTools.UnitTesting;
using 단위테스트용프로젝트;

namespace 단위테스트
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void 계정의초기잔액은0()
        {
            // 준비

            // 동작
            var account = new Account();

            // 검증
            Assert.AreEqual(0m, account.Balance);
        }

        [TestMethod]
        public void AddingTransactionChangesBalance()
        {
            // 준비(Arrangement)
            var account = new Account();

            // 동작(Action)
            account.AddTransaction(200m);

            // 검증(Assertion)
            Assert.AreEqual(200m, account.Balance);
        }
    }
}