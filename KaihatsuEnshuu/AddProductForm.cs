﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KaihatsuEnshuu
{
    public partial class AddProductForm : template.Form1
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'oI21Database1DataSet.サイズ' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.サイズTableAdapter.Fill(this.oI21Database1DataSet.サイズ);
            // TODO: このコード行はデータを 'oI21Database1DataSet.色' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.色TableAdapter.Fill(this.oI21Database1DataSet.色);
            // TODO: このコード行はデータを 'oI21Database1DataSet.商品' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.商品TableAdapter.Fill(this.oI21Database1DataSet.商品);

        }
    }
}
