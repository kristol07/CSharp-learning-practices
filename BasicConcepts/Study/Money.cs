using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    public class Money
    {
        private int faceValue;
        private Currency currency;

        public Money(): this(0,Currency.RMB)
        {
            //this.faceValue = 0;
            //this.currency = Currency.RMB;
        }
        public Money(int faceValue): this(faceValue, Currency.RMB)
        {
            //this.faceValue = faceValue;
            //this.currency = Currency.RMB;
        }
        public Money(int faceValue, Currency currency)
        {
            this.faceValue = faceValue;
            this.currency = currency;
        }
    }
}
