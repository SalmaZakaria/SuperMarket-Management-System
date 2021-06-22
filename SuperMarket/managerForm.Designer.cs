namespace SuperMarket
{
    partial class managerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managerForm));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.AddEmpBtn = new System.Windows.Forms.Button();
            this.AddSupBtn = new System.Windows.Forms.Button();
            this.addProdBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WelcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WelcomeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WelcomeLabel.Location = new System.Drawing.Point(173, 86);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(307, 40);
            this.WelcomeLabel.TabIndex = 2;
            this.WelcomeLabel.Text = "Welcome Manager";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEmpBtn
            // 
            this.AddEmpBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddEmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpBtn.ForeColor = System.Drawing.Color.Black;
            this.AddEmpBtn.Location = new System.Drawing.Point(213, 204);
            this.AddEmpBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddEmpBtn.Name = "AddEmpBtn";
            this.AddEmpBtn.Size = new System.Drawing.Size(232, 68);
            this.AddEmpBtn.TabIndex = 7;
            this.AddEmpBtn.Text = "Add Employee";
            this.AddEmpBtn.UseVisualStyleBackColor = false;
            this.AddEmpBtn.Click += new System.EventHandler(this.AddEmpBtn_Click);
            // 
            // AddSupBtn
            // 
            this.AddSupBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddSupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSupBtn.ForeColor = System.Drawing.Color.Black;
            this.AddSupBtn.Location = new System.Drawing.Point(213, 309);
            this.AddSupBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddSupBtn.Name = "AddSupBtn";
            this.AddSupBtn.Size = new System.Drawing.Size(232, 68);
            this.AddSupBtn.TabIndex = 8;
            this.AddSupBtn.Text = "Add Supplier";
            this.AddSupBtn.UseVisualStyleBackColor = false;
            this.AddSupBtn.Click += new System.EventHandler(this.AddSupBtn_Click);
            // 
            // addProdBtn
            // 
            this.addProdBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addProdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProdBtn.ForeColor = System.Drawing.Color.Black;
            this.addProdBtn.Location = new System.Drawing.Point(213, 404);
            this.addProdBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addProdBtn.Name = "addProdBtn";
            this.addProdBtn.Size = new System.Drawing.Size(232, 68);
            this.addProdBtn.TabIndex = 9;
            this.addProdBtn.Text = "Add Product";
            this.addProdBtn.UseVisualStyleBackColor = false;
            this.addProdBtn.Click += new System.EventHandler(this.addProdBtn_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 46);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(670, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addProdBtn);
            this.Controls.Add(this.AddSupBtn);
            this.Controls.Add(this.AddEmpBtn);
            this.Controls.Add(this.WelcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "managerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.managerForm_FormClosing);
            this.Load += new System.EventHandler(this.managerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button AddEmpBtn;
        private System.Windows.Forms.Button AddSupBtn;
        private System.Windows.Forms.Button addProdBtn;
        private System.Windows.Forms.Button button1;
    }
}