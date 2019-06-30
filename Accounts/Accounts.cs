using System;
using System.Collections.Generic;
using System.Text;
using AccountItem;
using AccountItem.Extensions;

namespace AccountsApp
{

    public delegate bool FilterHandler(Item item);

    public class Accounts
    {
        private List<Item> accounts = new List<Item>();

        public Item this [int index]
        {
            get
            {
                return accounts[index];
            }
            set
            {
                accounts[index] = value;
            }
        }

        public void AddItem(Item item)
        {
            accounts.Add(item);
        }

        public Money TotalRevenue(DateTime time)
        {
            Money revenue = new Money(0);

            foreach (Item item in accounts)
            {
                if ( time.IsSameMonthOfSameYear(item.OccuredTime) )
                {
                    if (item.category == Category.Spending)
                    {
                        revenue -= item.Amount;
                    }
                    else
                    {
                        revenue += item.Amount;
                    }
                }
            }

            return revenue;
        }

        public void DisplayTotalRevenue(DateTime time)
        {
            Money TotalRevenue = this.TotalRevenue(time);
            Console.WriteLine("Revenue(" + time.ToString("MMMM") + "): " + TotalRevenue);
        }

        //public Money TotalExpenditure(DateTime time)
        //{
        //    Money expend = new Money(0);

        //    foreach (Item item in accounts)
        //    {
        //        if ( time.IsSameMonthOfSameYear(item.OccuredTime) && item.IsSpending() )
        //        {
        //                expend += item.Amount;
        //        }
        //    }

        //    return expend;
        //}

        public void DisplayTotalExpenditure(DateTime time)
        {
            Money TotalExpenditure = this.TotalExpenditure(time);
            Console.WriteLine("Expend(" + time.ToString("MMMM") + "): " + TotalExpenditure);
        }

        //public Money TotalIncome(DateTime time)
        //{
        //    Money income = new Money(0);

        //    foreach (Item item in accounts)
        //    {
        //        if ( time.IsSameMonthOfSameYear(item.OccuredTime) && item.IsIncome() )
        //        {
        //                income += item.Amount;
        //        }
        //    }

        //    return income;
        //}

        public Money TotalIncome(DateTime time)
        {
            return Calculate(item => time.IsSameMonthOfSameYear(item.OccuredTime) && item.IsIncome());
        }

        public Money TotalExpenditure(DateTime time)
        {
            return Calculate(item => time.IsSameMonthOfSameYear(item.OccuredTime) && item.IsSpending());
        }

        private Money Calculate(FilterHandler filter)
        {
            Money total = new Money(0);

            foreach (Item item in accounts)
            {
                if (filter(item))
               {
                    total += item.Amount;
                }
            }

            return total;
        }

        public void DisplayTotalIncome(DateTime time)
        {
            Money TotalIncome = this.TotalIncome(time);
            Console.WriteLine("Income(" + time.ToString("MMMM") + "): " + TotalIncome);
        }

        public IEnumerable<Item> Display(DateTime time)
        {
            foreach (Item item in accounts)
            {
                if ( time.IsSameMonthOfSameYear(item.OccuredTime) )
                {
                    yield return item;
                }
            }
        }

        public void DisplayAllItems()
        {
            foreach (Item item in accounts)
            {
                Console.WriteLine(item);
            }
        }



    }
}
