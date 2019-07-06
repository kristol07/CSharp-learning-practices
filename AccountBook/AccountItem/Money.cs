using System;
using System.Collections.Generic;
using System.Text;

namespace AccountItem
{

    public enum Currency
    {
        RMB = 0,
        USD = 1,
        EUR = 2
    }

    public class Money
    {

        public double Value;
        public Currency currency;

        public const double CurrencyUSD = 6.93;
        public const double CurrencyEUR = 7.76;

        private double Num
        {
            get
            {
                switch (this.currency)
                {
                    case Currency.USD:
                        return Value * CurrencyUSD;
                    case Currency.EUR:
                        return Value * CurrencyEUR;
                    default:
                        return Value;
                }
            }
        }

        public Money(double val) { Value = val; currency = Currency.RMB; }
        public Money(double val, Currency currency) { Value = val; this.currency = currency; }

        public static Money operator +(Money mon1, Money mon2)
        {
            double TotalNum = mon1.Num + mon2.Num;
            return new Money(TotalNum);
        }
        public static Money operator -(Money mon1, Money mon2)
        {
            double TotalNum = mon1.Num - mon2.Num;
            return new Money(TotalNum);
        }

        public override string ToString()
        {
            if (currency != Currency.RMB)
            {
                return Value + " " + currency + " (" + Num + " RMB)";
            }
            else
            {
                return Value + " " + currency;
            }

        }
    }
}
