using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 단위테스트용프로젝트
{
    public class 계좌Service : I계좌Service
    {
        private readonly  I계좌Repository repository;

        public 계좌Service(I계좌Repository repository)
        {
            this.repository = repository;
        }

        public void 계좌에거래추가(string uniqueAccountName, decimal transactionAmount)
        {
            var account = repository.GetByName(uniqueAccountName);
            account.거래추가(transactionAmount);
        }


    }
}
