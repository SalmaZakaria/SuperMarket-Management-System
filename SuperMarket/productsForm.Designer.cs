
namespace SuperMarket
{
    partial class products
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(products));
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCategpry = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.cmbo_sup = new System.Windows.Forms.ComboBox();
            this.cmbo_category = new System.Windows.Forms.ComboBox();
            this.cmbo_name = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(124, 216);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.RowTemplate.Height = 25;
            this.DataGridView1.Size = new System.Drawing.Size(824, 315);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(214, 106);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(156, 48);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save Changes";
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 38);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            // 
            // labelCategpry
            // 
            this.labelCategpry.AutoSize = true;
            this.labelCategpry.Location = new System.Drawing.Point(258, 38);
            this.labelCategpry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategpry.Name = "labelCategpry";
            this.labelCategpry.Size = new System.Drawing.Size(91, 20);
            this.labelCategpry.TabIndex = 10;
            this.labelCategpry.Text = "category ID";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Location = new System.Drawing.Point(550, 38);
            this.labelSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(67, 20);
            this.labelSupplier.TabIndex = 13;
            this.labelSupplier.Text = "Supplier";
            this.labelSupplier.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_showAll);
            this.groupBox1.Controls.Add(this.cmbo_sup);
            this.groupBox1.Controls.Add(this.cmbo_category);
            this.groupBox1.Controls.Add(this.cmbo_name);
            this.groupBox1.Controls.Add(this.labelSupplier);
            this.groupBox1.Controls.Add(this.labelCategpry);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Location = new System.Drawing.Point(124, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(824, 182);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_showAll
            // 
            this.btn_showAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_showAll.Location = new System.Drawing.Point(438, 106);
            this.btn_showAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(159, 48);
            this.btn_showAll.TabIndex = 18;
            this.btn_showAll.Text = "Show All";
            this.btn_showAll.UseVisualStyleBackColor = true;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // cmbo_sup
            // 
            this.cmbo_sup.FormattingEnabled = true;
            this.cmbo_sup.Location = new System.Drawing.Point(627, 34);
            this.cmbo_sup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbo_sup.Name = "cmbo_sup";
            this.cmbo_sup.Size = new System.Drawing.Size(180, 28);
            this.cmbo_sup.TabIndex = 17;
            this.cmbo_sup.SelectedIndexChanged += new System.EventHandler(this.cmbo_sup_SelectedIndexChanged);
            this.cmbo_sup.DropDownClosed += new System.EventHandler(this.btn_showAll_Click);
            this.cmbo_sup.Click += new System.EventHandler(this.Cmbo_sup_click);
            // 
            // cmbo_category
            // 
            this.cmbo_category.FormattingEnabled = true;
            this.cmbo_category.Location = new System.Drawing.Point(352, 34);
            this.cmbo_category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbo_category.Name = "cmbo_category";
            this.cmbo_category.Size = new System.Drawing.Size(162, 28);
            this.cmbo_category.TabIndex = 16;
            this.cmbo_category.SelectedIndexChanged += new System.EventHandler(this.cmbo_category_SelectedIndexChanged);
            this.cmbo_category.DropDownClosed += new System.EventHandler(this.btn_showAll_Click);
            this.cmbo_category.Click += new System.EventHandler(this.cmbo_category_click);
            // 
            // cmbo_name
            // 
            this.cmbo_name.FormattingEnabled = true;
            this.cmbo_name.Location = new System.Drawing.Point(78, 38);
            this.cmbo_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbo_name.Name = "cmbo_name";
            this.cmbo_name.Size = new System.Drawing.Size(162, 28);
            this.cmbo_name.TabIndex = 15;
            this.cmbo_name.SelectedIndexChanged += new System.EventHandler(this.cmbo_name_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 45);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(991, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.productsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCategpry;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbo_ID;
        private System.Windows.Forms.ComboBox cmbo_name;
        private System.Windows.Forms.ComboBox cmbo_sup;
        private System.Windows.Forms.ComboBox cmbo_category;
        private System.Windows.Forms.Button btn_showAll;
        private System.Windows.Forms.Button button1;
    }
}

