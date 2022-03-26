using Microsoft.VisualStudio.TestTools.UnitTesting;
using 단위테스트용프로젝트;

namespace 단위테스트
{
    [TestClass]
    public class 계좌Test
    {
        [TestMethod]
        public void 계좌개시_잔고0()
        {
            // 준비

            // 동작
            var account = new 계좌();

            // 검증
            Assert.AreEqual(0m, account.잔고);
        }

        /// <summary>
        /// 거래추가하여 잔액 변경
        /// </summary>
        [TestMethod]
        public void 거래추가_잔액변경()
        {
            // 준비(Arrangement)
            var account = new 계좌();

            // 동작(Action)
            account.거래추가(200m);

            // 검증(Assertion)
            Assert.AreEqual(200m, account.잔고);
        }

        [TestMethod]
        public void Adding100TransactionBalance()
        {
            // 준비
            var account = new 계좌();

            // 동작

            // 검증

        }
    }
}