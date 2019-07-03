namespace AccountWPFApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addNewItem = new System.Windows.Forms.Button();
            this.importAccountBook = new System.Windows.Forms.Button();
            this.saveAccountBook = new System.Windows.Forms.Button();
            this.moneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimeExtensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.itemCategory = new System.Windows.Forms.ComboBox();
            this.itemNote = new System.Windows.Forms.TextBox();
            this.itemContent = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.TextBox();
            this.itemAmount = new System.Windows.Forms.TextBox();
            this.itemCurrency = new System.Windows.Forms.ComboBox();
            this.savePathName = new System.Windows.Forms.TextBox();
            this.totalSpending = new System.Windows.Forms.TextBox();
            this.totalIncome = new System.Windows.Forms.TextBox();
            this.totalRevenue = new System.Windows.Forms.TextBox();
            this.importPathName = new System.Windows.Forms.TextBox();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.itemOccuredTime = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.itemList = new System.Windows.Forms.ListView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeExtensionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewItem
            // 
            this.addNewItem.Location = new System.Drawing.Point(81, 392);
            this.addNewItem.Name = "addNewItem";
            this.addNewItem.Size = new System.Drawing.Size(75, 23);
            this.addNewItem.TabIndex = 0;
            this.addNewItem.Text = "添加新账目";
            this.addNewItem.UseVisualStyleBackColor = true;
            this.addNewItem.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // importAccountBook
            // 
            this.importAccountBook.Location = new System.Drawing.Point(502, 62);
            this.importAccountBook.Name = "importAccountBook";
            this.importAccountBook.Size = new System.Drawing.Size(75, 23);
            this.importAccountBook.TabIndex = 1;
            this.importAccountBook.Text = "导入账本";
            this.importAccountBook.UseVisualStyleBackColor = true;
            this.importAccountBook.Click += new System.EventHandler(this.ImportAccountBook_Click);
            // 
            // saveAccountBook
            // 
            this.saveAccountBook.Location = new System.Drawing.Point(502, 398);
            this.saveAccountBook.Name = "saveAccountBook";
            this.saveAccountBook.Size = new System.Drawing.Size(75, 23);
            this.saveAccountBook.TabIndex = 2;
            this.saveAccountBook.Text = "保存账本";
            this.saveAccountBook.UseVisualStyleBackColor = true;
            this.saveAccountBook.Click += new System.EventHandler(this.SaveAccountBook_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM-yyyy";
            this.dateTimePicker.Location = new System.Drawing.Point(655, 139);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(162, 21);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // itemCategory
            // 
            this.itemCategory.FormattingEnabled = true;
            this.itemCategory.Items.AddRange(new object[] {
            "支出",
            "收入"});
            this.itemCategory.Location = new System.Drawing.Point(143, 65);
            this.itemCategory.Name = "itemCategory";
            this.itemCategory.Size = new System.Drawing.Size(58, 20);
            this.itemCategory.TabIndex = 5;
            // 
            // itemNote
            // 
            this.itemNote.Location = new System.Drawing.Point(40, 212);
            this.itemNote.Name = "itemNote";
            this.itemNote.Size = new System.Drawing.Size(161, 21);
            this.itemNote.TabIndex = 6;
            // 
            // itemContent
            // 
            this.itemContent.Location = new System.Drawing.Point(40, 262);
            this.itemContent.Multiline = true;
            this.itemContent.Name = "itemContent";
            this.itemContent.Size = new System.Drawing.Size(161, 115);
            this.itemContent.TabIndex = 7;
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(40, 64);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(66, 21);
            this.itemName.TabIndex = 8;
            // 
            // itemAmount
            // 
            this.itemAmount.Location = new System.Drawing.Point(40, 112);
            this.itemAmount.Name = "itemAmount";
            this.itemAmount.Size = new System.Drawing.Size(66, 21);
            this.itemAmount.TabIndex = 9;
            this.itemAmount.TextChanged += new System.EventHandler(this.ItemAmount_TextChanged);
            // 
            // itemCurrency
            // 
            this.itemCurrency.FormattingEnabled = true;
            this.itemCurrency.Items.AddRange(new object[] {
            "RMB",
            "USD",
            "EUR"});
            this.itemCurrency.Location = new System.Drawing.Point(143, 113);
            this.itemCurrency.Name = "itemCurrency";
            this.itemCurrency.Size = new System.Drawing.Size(58, 20);
            this.itemCurrency.TabIndex = 10;
            // 
            // savePathName
            // 
            this.savePathName.Location = new System.Drawing.Point(285, 399);
            this.savePathName.Name = "savePathName";
            this.savePathName.Size = new System.Drawing.Size(194, 21);
            this.savePathName.TabIndex = 11;
            // 
            // totalSpending
            // 
            this.totalSpending.Location = new System.Drawing.Point(705, 230);
            this.totalSpending.Name = "totalSpending";
            this.totalSpending.Size = new System.Drawing.Size(112, 21);
            this.totalSpending.TabIndex = 12;
            // 
            // totalIncome
            // 
            this.totalIncome.Location = new System.Drawing.Point(705, 273);
            this.totalIncome.Name = "totalIncome";
            this.totalIncome.Size = new System.Drawing.Size(112, 21);
            this.totalIncome.TabIndex = 13;
            // 
            // totalRevenue
            // 
            this.totalRevenue.Location = new System.Drawing.Point(705, 319);
            this.totalRevenue.Name = "totalRevenue";
            this.totalRevenue.Size = new System.Drawing.Size(112, 21);
            this.totalRevenue.TabIndex = 14;
            // 
            // importPathName
            // 
            this.importPathName.Location = new System.Drawing.Point(285, 63);
            this.importPathName.Name = "importPathName";
            this.importPathName.Size = new System.Drawing.Size(194, 21);
            this.importPathName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "保存路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "导入路径";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "总支出";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "总收入";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "余额";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(701, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "概览";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "类型";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "金额";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "货币";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "备注";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "内容";
            // 
            // itemOccuredTime
            // 
            this.itemOccuredTime.Location = new System.Drawing.Point(40, 162);
            this.itemOccuredTime.Name = "itemOccuredTime";
            this.itemOccuredTime.Size = new System.Drawing.Size(161, 21);
            this.itemOccuredTime.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 29;
            this.label13.Text = "时间";
            // 
            // itemList
            // 
            this.itemList.HideSelection = false;
            this.itemList.Location = new System.Drawing.Point(264, 102);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(334, 268);
            this.itemList.TabIndex = 30;
            this.itemList.UseCompatibleStateImageBehavior = false;
            this.itemList.View = System.Windows.Forms.View.Details;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(653, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 31;
            this.label14.Text = "选择时间";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(654, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "当月";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(70, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 12);
            this.label16.TabIndex = 33;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(172, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 34;
            this.label17.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(70, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 12);
            this.label18.TabIndex = 35;
            this.label18.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(40, 423);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 8);
            this.label19.TabIndex = 36;
            this.label19.Text = "* 为必填/选项";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(856, 465);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.itemOccuredTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.importPathName);
            this.Controls.Add(this.totalRevenue);
            this.Controls.Add(this.totalIncome);
            this.Controls.Add(this.totalSpending);
            this.Controls.Add(this.savePathName);
            this.Controls.Add(this.itemCurrency);
            this.Controls.Add(this.itemAmount);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.itemContent);
            this.Controls.Add(this.itemNote);
            this.Controls.Add(this.itemCategory);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.saveAccountBook);
            this.Controls.Add(this.importAccountBook);
            this.Controls.Add(this.addNewItem);
            this.Name = "MainForm";
            this.Text = "账本应用";
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeExtensionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewItem;
        private System.Windows.Forms.Button importAccountBook;
        private System.Windows.Forms.Button saveAccountBook;
        private System.Windows.Forms.BindingSource dateTimeExtensionBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox itemCategory;
        private System.Windows.Forms.TextBox itemNote;
        private System.Windows.Forms.TextBox itemContent;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.TextBox itemAmount;
        private System.Windows.Forms.ComboBox itemCurrency;
        private System.Windows.Forms.TextBox savePathName;
        private System.Windows.Forms.TextBox totalSpending;
        private System.Windows.Forms.TextBox totalIncome;
        private System.Windows.Forms.TextBox totalRevenue;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.BindingSource moneyBindingSource;
        private System.Windows.Forms.TextBox importPathName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox itemOccuredTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView itemList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}