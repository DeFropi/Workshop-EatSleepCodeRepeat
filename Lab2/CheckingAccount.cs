
namespace eu.sig.training.ch04.v1
{
    public class CheckingAccount : Accounts
    {
        private int transferLimit = 100;
        private void CheckWithdrawalLimit(Money amount)
        {
            // 1. Check withdrawal limit:
            if (amount.GreaterThan(this.transferLimit))
                throw new BusinessException("Limit exceeded!");
        }
        public Transfer MakeTransfer(string counterAccount, Money amount)
        {
            CheckWithdrawalLimit(amount);
            EmptyCheck(counterAccount);
            if (SumCheck(counterAccount))
            {
                return Check(counterAccount, amount);
            }
            throw new BusinessException("Invalid account number!");
        }
    }
}