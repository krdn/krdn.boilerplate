using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 단위테스트용프로젝트
{
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
