using System;

namespace AccountItem
{
    public enum Category : int
    {
        Spending = 0,
        Income = 1
    }

    public class Item
    {
        public string Name
        {
            get; set;
        }
        public string Content
        {
            get; set;
        }
        public string Note
        {
            get; set;
        }


        public Category category;
        private string type
        {
            get => category == Category.Spending
                ? "-"
                : "+";
        }


        public Money Amount;

        public DateTime OccuredTime;
        //public string Month
        //{
        //    get => OccuredTime.ToString("MMMM");
        //}

        public Item(string name, Category category, double amount) : this(name, category, "None", "None", amount, Currency.RMB, DateTime.Now) { }
        public Item(string name, Category category, double amount, DateTime occuredTime) : this(name, category, "None", "None", amount, Currency.RMB, occuredTime) { }
        public Item(string name, Category category, string content, double amount) : this(name, category, content, "None", amount, Currency.RMB, DateTime.Now) { }
        public Item(string name, Category category, double amount, Currency currency) : this(name, category, "None", "None", amount, currency, DateTime.Now) { }
        public Item(string name, Category category, string content, double amount, Currency currency) : this(name, category, content, "None", amount, currency, DateTime.Now) { }
        public Item(string name, Category category, string content, string note, double amount, Currency currency, DateTime occuredTime)
        {
            if (name.Equals(""))
            {
                ArgumentException myEx = new ArgumentException("Input a valid name!");
                throw myEx;
            }

            this.Name = name;
            this.category = category;
            this.Content = content;
            this.Note = note;
            this.Amount = new Money(amount, currency);
            this.OccuredTime = occuredTime;
        }

        public bool IsSpending()
        {
            return category == Category.Spending;
        }

        public bool IsIncome()
        {
            return category == Category.Income;
        }

        public override string ToString()
        {
            return $"{Name} ({OccuredTime.ToString("MMMM dd, yyyy")}): {type}{Amount.ToString()}. | Content: {Content} | Note: {Note}";
        }

        public string Save()
        {
            return $"{Name}|{OccuredTime}|{category}|{Amount.Value}|{Amount.currency}|{Content}|{Note}";
        }

        public static Item String2Item(string itemString)
        {
            string[] s = itemString.Split('|');

            string name = s[0];
            DateTime occuredTime = DateTime.Parse(s[1]);
            Category category = (Category)Enum.Parse(typeof(Category), s[2]);
            double amountValue = Double.Parse(s[3]);
            Currency currency = (Currency)Enum.Parse(typeof(Currency), s[4]);
            string content = s[5];
            string note = s[6];

            return new Item(name, category, content, note, amountValue, currency, occuredTime);
        }

    }
}
