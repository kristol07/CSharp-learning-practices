using System;
using System.Collections.Generic;
using AccountItem;

namespace AccountConsoleApp
{

    delegate void Summary(DateTime time);
    class Program
    {
        static void Main(string[] args)
        {

            Item item1 = new Item("eat1", Category.Spending, 220);
            Item item2 = new Item("cash", Category.Income, "Salary of this month.", 1000);
            Item item3 = new Item("rent", Category.Spending, "Rent a house for one month.", 220, Currency.EUR);
            Item item4 = new Item("eat2", Category.Spending, 20, Currency.USD);
            Item item5 = new Item("web", Category.Income, "Web sold to big company", 50000);
            Item item6 = new Item("clothes", Category.Spending, 500, new DateTime(2019, 5, 5));
            Item item7 = new Item("cash", Category.Income, 1000, new DateTime(2019, 03, 15));


            Accounts ac = new Accounts();
            ac.AddItem(item1);
            ac.AddItem(item2);
            ac.AddItem(item3);
            ac.AddItem(item4);
            ac.AddItem(item5);
            ac.AddItem(item6);
            ac.AddItem(item7);


            //Money revenue = ac.TotalRevenue(DateTime.Now);
            //Console.WriteLine("Revenue: " + revenue);

            //Money expend = ac.TotalExpenditure(DateTime.Now);
            //Console.WriteLine("Expend: " + expend);

            //Money income = ac.TotalIncome(DateTime.Now);
            //Console.WriteLine("Income: " + income);

            Summary summary = ac.DisplayTotalRevenue;
            summary += ac.DisplayTotalExpenditure;
            summary += ac.DisplayTotalIncome;
            summary(DateTime.Now);

            foreach (Item item in ac.Display(DateTime.Now))
            {
                Console.WriteLine(item);
            }

            // Test
            Console.WriteLine("\n----ALL ITEMS----\n");
            ac.DisplayAllItems();

            // Test accessor
            ac[3] = new Item("eat2", Category.Spending, 30, Currency.USD);
            Console.WriteLine(ac[3]);

            //ac.SaveAccountBook("test.txt");
            //ac.LoadAccountBook("test.txt");
            //ac.DisplayAllItems();

            Console.ReadKey();
        }
    }
}
