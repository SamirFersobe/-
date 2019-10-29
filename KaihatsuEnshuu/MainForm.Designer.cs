﻿namespace KaihatsuEnshuu
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
            this.AddProductButton = new System.Windows.Forms.Button();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.AddMakerButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(35, 150);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(201, 108);
            this.AddProductButton.TabIndex = 0;
            this.AddProductButton.Text = "商品登録";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.openProductForm_Click);
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(259, 150);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(201, 108);
            this.AddClientButton.TabIndex = 1;
            this.AddClientButton.Text = "顧客登録";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.addStock_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(418, 282);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(201, 108);
            this.AddEmployeeButton.TabIndex = 2;
            this.AddEmployeeButton.Text = "社員登録";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployee_Button_Click);
            // 
            // AddMakerButton
            // 
            this.AddMakerButton.Location = new System.Drawing.Point(161, 282);
            this.AddMakerButton.Name = "AddMakerButton";
            this.AddMakerButton.Size = new System.Drawing.Size(201, 108);
            this.AddMakerButton.TabIndex = 3;
            this.AddMakerButton.Text = "メーカー登録";
            this.AddMakerButton.UseVisualStyleBackColor = true;
            this.AddMakerButton.Click += new System.EventHandler(this.AddMakerButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 108);
            this.button1.TabIndex = 4;
            this.button1.Text = "営業所登録";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddMakerButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.AddProductButton);
            this.Name = "MainForm";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button AddMakerButton;
        private System.Windows.Forms.Button button1;
    }
}