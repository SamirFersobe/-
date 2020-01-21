﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.IO;

namespace KaihatsuEnshuu
{
    public partial class NewOrderForm : Form
    {
        string DatabaseConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString(), "OI21Database1.accdb");
       // string DatabaseConnectionString = ConfigurationManager.ConnectionStrings["KaihatsuEnshuu.Properties.Settings.OI21Database1ConnectionString"].ConnectionString;
        public NewOrderForm()
        {

            InitializeComponent();

            
        }
        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            FillComboBox("empname", "empno", comboBox1, "emp");
            FillComboBox("customerName", "customerId", comboBox2, "customers");
        }

        DataTable dt = new DataTable();
        private void newOrderButton_Click(object sender, EventArgs e)
        {
            string customerid, employeeid;
            employeeid = comboBox1.SelectedValue.ToString();
            customerid = comboBox2.SelectedValue.ToString();



           //  string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";

            string str = DatabaseConnectionString;

            OleDbConnection con = new OleDbConnection(str);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO [order](orderDate,orderEmpno,orderCustomerId) values(date(),@orderEmpno,@orderCustomerId) ";
            cmd.Parameters.AddWithValue("@orderEmpno", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@orderCustomerId", comboBox2.SelectedValue); 
            con.Open();
            //select @@identity
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
  

            var lastOrderId = cmd.ExecuteScalar();

     
            
            MessageBox.Show("注文開始しました");


            OrderForm order = new OrderForm(employeeid,customerid,lastOrderId.ToString());
            order.Show();
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void FillComboBox(String displayMember, String valueMember, ComboBox combo, String table)
        {
            
            DataTable dt = new DataTable();
            // string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";

            string str = DatabaseConnectionString;
            OleDbConnection con = new OleDbConnection(str);
            string sql1 = "SELECT "+ displayMember +  "  , "+valueMember+ " FROM "+ table ;
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);

            da.Fill(dt);

            combo.DataSource = dt.DefaultView;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            
            con.Close();
        }

        


    }
}
