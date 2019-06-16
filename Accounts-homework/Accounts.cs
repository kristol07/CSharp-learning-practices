using System;
using System.Collections.Generic;
using System.Text;
using AccountItem;

namespace AccountsApp
{
    public class Accounts
    {
        private List<Item> accounts = new List<Item>();

        public void AddItem(Item item)
        {
            accounts.Add(item);
        }

        public Money TotalRevenue(DateTime time)
        {
            Money revenue = new Money(0);

            foreach (Item item in accounts)
            {
                if (item.OccuredTime.Month == time.Month)
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

        public Money TotalExpenditure(DateTime time)
        {
            Money expend = new Money(0);

            foreach (Item item in accounts)
            {
                if (item.OccuredTime.Month == time.Month)
                {
                    if (item.category == Category.Spending)
                    {
                        expend += item.Amount;
                    }
                }
            }

            return expend;
        }

        public void DisplayTotalExpenditure(DateTime time)
        {
            Money TotalExpenditure = this.TotalExpenditure(time);
            Console.WriteLine("Expend(" + time.ToString("MMMM") + "): " + TotalExpenditure);
        }

        public Money TotalIncome(DateTime time)
        {
            Money income = new Money(0);

            foreach (Item item in accounts)
            {
                if (item.OccuredTime.Month == time.Month)
                {
                    if (item.category == Category.Income)
                    {
                        income += item.Amount;
                    }
                }
            }

            return income;
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
                if (item.OccuredTime.Month == time.Month)
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
