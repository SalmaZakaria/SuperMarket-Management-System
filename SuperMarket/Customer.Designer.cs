﻿
namespace SuperMarket
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.label1 = new System.Windows.Forms.Label();
            this.Cust_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cust_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cust_Address = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CustIDs = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Cust_Name
            // 
            this.Cust_Name.Location = new System.Drawing.Point(288, 202);
            this.Cust_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cust_Name.Name = "Cust_Name";
            this.Cust_Name.Size = new System.Drawing.Size(241, 26);
            this.Cust_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cust_Phone
            // 
            this.Cust_Phone.Location = new System.Drawing.Point(288, 280);
            this.Cust_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cust_Phone.Name = "Cust_Phone";
            this.Cust_Phone.Size = new System.Drawing.Size(241, 26);
            this.Cust_Phone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // Cust_Address
            // 
            this.Cust_Address.Location = new System.Drawing.Point(288, 365);
            this.Cust_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cust_Address.Name = "Cust_Address";
            this.Cust_Address.Size = new System.Drawing.Size(241, 26);
            this.Cust_Address.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(124, 466);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(116, 36);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(320, 466);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(124, 36);
            this.Update.TabIndex = 7;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(514, 466);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(115, 36);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 82);
            this.label4.TabIndex = 9;
            this.label4.Text = "Customers";
            // 
            // CustIDs
            // 
            this.CustIDs.FormattingEnabled = true;
            this.CustIDs.Location = new System.Drawing.Point(288, 135);
            this.CustIDs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustIDs.Name = "CustIDs";
            this.CustIDs.Size = new System.Drawing.Size(241, 28);
            this.CustIDs.TabIndex = 10;
            this.CustIDs.SelectedIndexChanged += new System.EventHandler(this.CustIDs_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(652, 48);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(104, 115);
            this.AddOrder.TabIndex = 12;
            this.AddOrder.Text = "AddOrder";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(-1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 45);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustIDs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Cust_Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cust_Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cust_Name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customer_FormClosing);
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cust_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cust_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cust_Address;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CustIDs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Button button1;
    }
}