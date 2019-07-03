using AccountConsoleApp;
using AccountItem;
using System;
using System.IO;
using System.Windows.Forms;

namespace AccountWPFApp
{
    public partial class MainForm : Form
    {
        private Accounts ac;
        public MainForm()
        {
            InitializeComponent();

            //Item item1 = new Item("eat1", Category.Spending, 220);

            ac = new Accounts();
            //ac.AddItem(item1);

            itemList.Columns.Add("名称");
            itemList.Columns.Add("类型");
            itemList.Columns.Add("金额");
            itemList.Columns.Add("时间");
            itemList.Columns.Add("备注");
            itemList.Columns.Add("内容");

            //foreach (Item item in ac.accounts)
            //{
            //    ListViewItem it = new ListViewItem();
            //    it.SubItems.Add(item.Name);
            //    it.SubItems.Add(item.category.ToString());
            //    it.SubItems.Add(item.Amount.ToString());
            //    it.SubItems.Add(item.OccuredTime.ToString());
            //    it.SubItems.Add(item.Note);
            //    it.SubItems.Add(item.Content);
            //    itemList.Items.Add(it);
            //    //itemList.Items.Add(item.ToString());
            //}

            DateTime time = DateTime.Now;
            totalRevenue.Text = $"{ac.TotalRevenue(time)}";
            totalIncome.Text = $"{ac.TotalIncome(time)}";
            totalSpending.Text = $"{ac.TotalExpenditure(time)}";

        }

        private void AddNewItem_Click(object sender, EventArgs e)
        {

            if (!IsValidInput())
            {
                MessageBox.Show("Invalid Input!");
                return;
            }

            string name = itemName.Text;

            Category category = (Category)Enum.Parse(typeof(Category), categoryName2Enum(itemCategory.SelectedItem.ToString()));
            DateTime occuredTime = DateTime.Parse(itemOccuredTime.Text);
            double amountValue = Double.Parse(itemAmount.Text);
            Currency currency = (Currency)Enum.Parse(typeof(Currency), itemCurrency.SelectedItem.ToString());
            string content = itemContent.Text;
            string note = itemNote.Text;

            Item item = new Item(name, category, content, note, amountValue, currency, occuredTime);
            ac.AddItem(item);
            ListViewItem it = new ListViewItem();
            it.SubItems.Add(item.Name);
            it.SubItems.Add(item.category.ToString());
            it.SubItems.Add(item.Amount.ToString());
            it.SubItems.Add(item.OccuredTime.ToString());
            it.SubItems.Add(item.Note);
            it.SubItems.Add(item.Content);
            itemList.Items.Add(it);
            //itemList.Items.Add(item.ToString());

            clearItem();

        }

        private void ImportAccountBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(importPathName.Text))
            {
                MessageBox.Show("Input the path to import!");
                return;
            }

            ac.LoadAccountBook(importPathName.Text);
            itemList.Items.Clear();
            foreach(Item item in ac.accounts)
            {
                ListViewItem it = new ListViewItem();
                it.SubItems.Add(item.Name);
                it.SubItems.Add(item.category.ToString());
                it.SubItems.Add(item.Amount.ToString());
                it.SubItems.Add(item.OccuredTime.ToString());
                it.SubItems.Add(item.Note);
                it.SubItems.Add(item.Content);
                itemList.Items.Add(it);
                //itemList.Items.Add(item.ToString());
            }
        }

        private void SaveAccountBook_Click(object sender, EventArgs e)
        {
            string pathName = savePathName.Text;
            if (string.IsNullOrEmpty(pathName))
            {
                pathName = Directory.GetCurrentDirectory();
            }
            ac.SaveAccountBook(pathName);
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime time = dateTimePicker.Value;
            totalRevenue.Text = $"{ac.TotalRevenue(time)}";
            totalIncome.Text = $"{ac.TotalIncome(time)}";
            totalSpending.Text = $"{ac.TotalExpenditure(time)}";
        }

        private bool IsValidInput()
        {
            if (string.IsNullOrEmpty(itemName.Text)) { return false; }
            if (itemCategory.SelectedItem == null) { return false; }
            if (!IsValidInputAmount() && string.IsNullOrEmpty(itemAmount.Text)) { return false; }

            if (itemCurrency.SelectedItem == null)
            {
                itemCurrency.SelectedItem = itemCurrency.Items[0];
            }

            if (!string.IsNullOrEmpty(itemOccuredTime.Text))
            {
                if (!DateTime.TryParse(itemOccuredTime.Text, out DateTime occuredTime)) { return false; }
            }
            else
            {
                itemOccuredTime.Text = DateTime.Now.ToString();
            }

            if (string.IsNullOrEmpty(itemNote.Text)) { itemNote.Text = "无。"; }
            if (string.IsNullOrEmpty(itemContent.Text)) { itemContent.Text = "无。"; }

            return true;
        }

        private bool IsValidInputAmount()
        {
            if (!Double.TryParse(itemAmount.Text, out double amountResult)) { return false; }

            return true;
        }

        private void ItemAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(itemAmount.Text))
            {
                if (!IsValidInputAmount())
                {
                    itemAmount.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    itemAmount.BackColor = System.Drawing.Color.White;
                }
            }

        }

        private string categoryName2Enum(string category)
        {
            if (category == "支出") { return "Spending"; }
            if (category == "收入") { return "Income"; }
            return "";
        }

        private void clearItem()
        {
            itemName.Clear();
            itemCategory.SelectedIndex = -1;
            itemOccuredTime.Clear();
            itemAmount.Clear();
            itemCurrency.SelectedIndex = -1;
            itemContent.Clear();
            itemNote.Clear();
        }

    }
}
