﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaihatsuEnshuu
{
    public partial class MainForm : Form
    {
        //このフォームはすべてのプロセスから始まるところです。
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void addStock_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomer = new AddCustomerForm();
            addCustomer.Show();
     
        }

        private void openProductForm_Click(object sender, EventArgs e)
        {
            AddProductForm AddProduct = new AddProductForm();
            AddProduct.Show();

        }

        private void AddEmployee_Button_Click(object sender, EventArgs e)
        {
            AddEmployeeForm AddEmployee = new AddEmployeeForm();
            AddEmployee.Show();
        }

        private void AddMakerButton_Click(object sender, EventArgs e)
        {
            AddMakerForm addMakerForm = new AddMakerForm();
            addMakerForm.Show();
        }

        private void AddBusinessPlaceButton_Click(object sender, EventArgs e)
        {

        }
    }
}
