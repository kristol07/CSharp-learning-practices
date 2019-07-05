using AccountConsoleApp;
using AccountItem;
using System;
using System.IO;
using System.Windows.Forms;

namespace AccountWPFApp
{
    public delegate bool Validator();

    public partial class MainForm : Form
    {
        private Accounts ac;
        public MainForm()
        {
            InitializeComponent();

            ac = new Accounts();

            itemList.Columns.Add("选择");
            itemList.Columns.Add("名称");
            itemList.Columns.Add("金额");
            itemList.Columns.Add("时间");
            itemList.Columns.Add("备注");
            itemList.Columns.Add("内容");
            itemList.Columns.Add("类型");

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

            SetDefaultValue();

            Item item = GenerateNewItem();
            ac.AddItem(item);

            itemList.Items.Add(GenerateListViewItem(item));
            //itemList.Items.Add(item.ToString());

            ClearItem();

        }

        private void ImportAccountBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(importPathName.Text))
            {
                MessageBox.Show("请输入路径！");
                return;
            }

            if (ac.LoadAccountBook(importPathName.Text))
            {
                itemList.Items.Clear();
                foreach (Item item in ac.accounts)
                {
                    itemList.Items.Add(GenerateListViewItem(item));
                    //itemList.Items.Add(item.ToString());
                }
            }
            else
            {
                MessageBox.Show("无法导入账本，请检查导入路径及文件的正确性。");
            }

        }

        private void SaveAccountBook_Click(object sender, EventArgs e)
        {
            string pathName = savePathName.Text;
            if (string.IsNullOrEmpty(pathName))
            {
                pathName = Directory.GetCurrentDirectory();
            }
            if (ac.SaveAccountBook(pathName))
            {
                MessageBox.Show("成功保存账本。");
            }
            else
            {
                MessageBox.Show("保存账本失败，请检查保存路径是否正确。");
            }
        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem it in itemList.CheckedItems)
            {
                ac.accounts.RemoveAt(itemList.Items.IndexOf(it));
                itemList.Items.Remove(it);
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime time = dateTimePicker.Value;
            totalRevenue.Text = $"{ac.TotalRevenue(time)}";
            totalIncome.Text = $"{ac.TotalIncome(time)}";
            totalSpending.Text = $"{ac.TotalExpenditure(time)}";
        }

        private void ItemOccuredTime_TextChanged(object sender, EventArgs e)
        {
            ValidateInputWithColor(itemOccuredTime, IsValidInputOccuredTime);
        }

        private void ItemAmount_TextChanged(object sender, EventArgs e)
        {
            ValidateInputWithColor(itemAmount, IsValidInputAmount);
        }

        private void ImportPathName_TextChanged(object sender, EventArgs e)
        {
            ValidateInputWithColor(importPathName, IsValidImportPath);
        }

        //private void SavePathName_TextChanged(object sender, EventArgs e)
        //{
        //    ValidateInputWithColor(savePathName, IsValidSavePath);
        //}

        private string categoryName2Enum(string category)
        {
            if (category == "支出") { return "Spending"; }
            if (category == "收入") { return "Income"; }
            return "";
        }

        private bool IsValidInput()
        {
            if (string.IsNullOrEmpty(itemName.Text)) { return false; }
            if (itemCategory.SelectedItem == null) { return false; }
            if (!IsValidInputAmount() || string.IsNullOrEmpty(itemAmount.Text)) { return false; }

            if (!string.IsNullOrEmpty(itemOccuredTime.Text))
            {
                if (!IsValidInputOccuredTime()) { return false; }
            }

            return true;
        }

        private void ValidateInputWithColor(TextBox textBox, Validator validator)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (validator())
                {
                    textBox.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    textBox.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private bool IsValidInputAmount()
        {
            return Double.TryParse(itemAmount.Text, out double amountResult);
        }

        private bool IsValidInputOccuredTime()
        {
            return DateTime.TryParse(itemOccuredTime.Text, out DateTime occuredTime);
        }

        //private bool IsValidSavePath()
        //{
        //    return File.Exists(savePathName.Text);
        //}

        private bool IsValidImportPath()
        {
            //return Directory.Exists(importPathName.Text) || File.Exists(importPathName.Text);
            return File.Exists(importPathName.Text);
        }

        private void SetDefaultValue()
        {
            if (itemCurrency.SelectedItem == null)
            {
                itemCurrency.SelectedItem = itemCurrency.Items[0];
            }

            if (string.IsNullOrEmpty(itemOccuredTime.Text))
            {
                itemOccuredTime.Text = DateTime.Now.ToString();
            }

            if (string.IsNullOrEmpty(itemNote.Text)) { itemNote.Text = "无。"; }
            if (string.IsNullOrEmpty(itemContent.Text)) { itemContent.Text = "无。"; }
        }

        private Item GenerateNewItem()
        {
            string name = itemName.Text;
            Category category = (Category)Enum.Parse(typeof(Category), categoryName2Enum(itemCategory.SelectedItem.ToString()));
            DateTime occuredTime = DateTime.Parse(itemOccuredTime.Text);
            double amountValue = Double.Parse(itemAmount.Text);
            Currency currency = (Currency)Enum.Parse(typeof(Currency), itemCurrency.SelectedItem.ToString());
            string content = itemContent.Text;
            string note = itemNote.Text;

            return new Item(name, category, content, note, amountValue, currency, occuredTime);
        }

        private void ClearItem()
        {
            itemName.Clear();
            itemCategory.SelectedIndex = -1;
            itemOccuredTime.Clear();
            itemAmount.Clear();
            itemCurrency.SelectedIndex = -1;
            itemContent.Clear();
            itemNote.Clear();
        }

        private ListViewItem GenerateListViewItem(Item item)
        {
            ListViewItem it = new ListViewItem();

            it.SubItems.Add(item.Name);
            it.SubItems.Add(item.Amount.ToString());
            it.SubItems.Add(item.OccuredTime.ToString("yyyy/MM/dd"));
            it.SubItems.Add(item.Note);
            it.SubItems.Add(item.Content);
            it.SubItems.Add(item.category.ToString());

            return it;
        }
    }
}
