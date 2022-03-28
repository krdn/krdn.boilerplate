using Microsoft.VisualStudio.TestTools.UnitTesting;
using 단위테스트용프로젝트;

namespace 단위테스트
{
    [TestClass]
    public class 계좌Test
    {
        [TestMethod]
        public void 계좌개시_초기잔액0()
        {
            // 준비

            // 동작
            var account = new 계좌();

            // 검증
            Assert.AreEqual(0m, account.잔액);
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
            Assert.AreEqual(200m, account.잔액);
        }

        [TestMethod]
        public void 거래100추가_잔액()
        {
            // 준비
            var account = new 계좌();

            // 동작
            account.거래추가(100m);

            // 검증
            Assert.AreEqual(100m, account.잔액);
        }

        [TestMethod]
        public void 거래추가_합계잔액생성()
        {
            // 준비
            var account = new 계좌();
            account.거래추가(50m);

            // 동작
            account.거래추가(75m);
            
            // 검증
            Assert.AreEqual(125m, account.잔액);
        }
    }
}