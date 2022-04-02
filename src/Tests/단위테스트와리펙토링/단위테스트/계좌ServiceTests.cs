using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using 단위테스트용프로젝트;

namespace 단위테스트
{
    [TestClass]
    public class 계좌ServiceTests
    {
        // 계정 인스턴스에 계정 위임자에 트랜잭션 추가
        // AddingTransactionToAccountDelegatesToAccountInstance
        [TestMethod]
        public void AddingTransactionToAccountDelegatesToAccountInstance()
        {
            // 준비
            var account = new 계좌();
            var fakeRepository = new Fake계좌Repository(account);
            var sut = new 계좌Service(fakeRepository);

            // 동작
            sut.계좌에거래추가("예금 계좌", 200m);

            // 검증
            Assert.AreEqual(200m, account.잔액);


        }
    }
}
