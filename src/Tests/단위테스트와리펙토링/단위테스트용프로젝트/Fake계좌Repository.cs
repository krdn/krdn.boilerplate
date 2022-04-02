using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 단위테스트용프로젝트
{
    public class Fake계좌Repository : I계좌Repository
    {
        public Fake계좌Repository(계좌 account)
        {
            this.account = account;
        }

        public 계좌 GetByName(string accountName)
        {
            return account;
        }

        private 계좌 account;
    }
}
