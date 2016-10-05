using System;

namespace eu.sig.training.ch04.v1
{
    public class SavingsAccount : Accounts
    {
        public CheckingAccount RegisteredCounterAccount { get; set; }

        public Transfer makeTransfer(string counterAccount, Money amount)
        {
            EmptyCheck(counterAccount);
            if (SumCheck(counterAccount))
            {
                var result = Check(counterAccount, amount);
                if (result.CounterAccount.Equals(this.RegisteredCounterAccount))
                    return result;
                else
                    throw new BusinessException("Counter-account not registered!");
            }
            else
                throw new BusinessException("Invalid account number!!");
        }
    }
}
