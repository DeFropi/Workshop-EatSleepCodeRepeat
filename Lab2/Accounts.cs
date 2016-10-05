using System;

namespace eu.sig.training.ch04.v1
{
    public abstract class Accounts
    {

        public static CheckingAccount FindAcctByNumber(string number)
        {
            return new CheckingAccount();
        }
        public void EmptyCheck(string counterAccount)
        {
            if (String.IsNullOrEmpty(counterAccount) || counterAccount.Length != 9)
                throw new BusinessException("Invalid account number!");
        }
        
        public bool SumCheck(string counterAccount)
        {
            var sum = 0;
            for (var i = 0; i < 9; i++)
                sum = sum + (9 - i) * (int)Char.GetNumericValue(counterAccount[i]);
            return (sum % 11 == 0);
        }
        public Transfer Check(string counterAccount, Money amount)
        {
            CheckingAccount acct = Accounts.FindAcctByNumber(counterAccount);
            Transfer result = new Transfer(this, acct, amount);
            return result;
        }
    }
}