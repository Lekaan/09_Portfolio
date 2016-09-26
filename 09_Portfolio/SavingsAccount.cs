using System;

namespace _09_Portfolio
{
    internal class SavingsAccount : IAsset
    {
        public string Account { get; set; }
        public double InterestRate { get; set; }
        public double Value { get; set; }

        public SavingsAccount(string Account, int Value, double InterestRate)
        {
            this.Account = Account;
            this.Value = Value;
            this.InterestRate = InterestRate;
        }

        public override string ToString()
        {
            string value = Value.ToString("F1").Replace(",", ".");
            string interestRate = InterestRate.ToString("F1").Replace(",", ".");

            return "SavingsAccount[value=" + value + ",interestRate=" + interestRate + "]";
        }

        public double GetValue()
        {
            return Value;
        }

        internal void ApplyInterest()
        {
            Value = Value*((InterestRate/100)+1);
        }
    }
}