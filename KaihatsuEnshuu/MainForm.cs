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
            template.Form1 fomulae = new template.Form1();
            fomulae.Show();
        }

        private void openProductForm_Click(object sender, EventArgs e)
        {
                

        }
    }
}
