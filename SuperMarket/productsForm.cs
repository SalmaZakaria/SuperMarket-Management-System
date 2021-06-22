using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace SuperMarket
{
    public partial class products : Form
    {
        string constr = "User Id=scott;Password=tiger;Data Source=orcl";
        string cmdstr;
        string catstr;
        string substr;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataTable dt;
        public products()
        {
            InitializeComponent();
        }
        private void productsForm_Load(object sender, EventArgs e)
        {
            cmdstr = "select * from product";
            adapter = new OracleDataAdapter(cmdstr, constr);
            dt = new DataTable();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;

            cmbo_name.DataSource = dt;
            cmbo_name.DisplayMember = "Name";
            cmbo_name.ValueMember = "Name";

            cmbo_category.Text = "";
            cmbo_sup.Text = "";

            catstr = "select * from category";
            adapter = new OracleDataAdapter(catstr, constr);
            dt = new DataTable();
            adapter.Fill(dt);
            cmbo_category.DataSource = dt;
            cmbo_category.DisplayMember = "name";
            cmbo_category.ValueMember = "name";

            substr = "select * from supplier";
            adapter = new OracleDataAdapter(substr, constr);
            dt = new DataTable();
            adapter.Fill(dt);
            cmbo_sup.DataSource = dt;
            cmbo_sup.DisplayMember = "sid";
            cmbo_sup.ValueMember = "sid";

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void Cmbo_sup_click(object sender, EventArgs e)
        {
           /* cmbo_category.Text = "";
            cmbo_sup.DroppedDown = true;
            cmbo_sup.DataSource = dt;
            cmbo_sup.DisplayMember = "supplierid";
            cmbo_sup.ValueMember = "supplierid";*/
        }
        private void cmbo_category_click(object sender, EventArgs e)
        {

            /*cmbo_sup.Text = "";
            cmbo_category.DroppedDown = true;
            cmbo_category.DataSource = dt;
            cmbo_category.DisplayMember = "categoryid";
            cmbo_category.ValueMember = "categoryid";*/
        }
        private void btn_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(dt);
            MessageBox.Show("Saved Successfully");
        }
        private void btn_showAll_Click(object sender, EventArgs e)
        {
            cmdstr = "select * from product";
            adapter = new OracleDataAdapter(cmdstr, constr);
            dt = new DataTable();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
        }
        private void cmbo_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbo_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbo_sup.Text = "";
            cmbo_name.Text = "";
            try
            {
                cmdstr = @"select * from product where categoryid = (select id from category where name=:c)";
                adapter = new OracleDataAdapter(cmdstr, constr);
                adapter.SelectCommand.Parameters.Add("c", cmbo_category.Text);
                dt = new DataTable();
                adapter.Fill(dt);
                builder = new OracleCommandBuilder(adapter);
                DataGridView1.DataSource = dt;
            }
            catch
            {

            }
            

        }

        private void cmbo_sup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbo_category.Text = "";

            try
            {
                cmdstr = @"select * from product where supplierid=:s";
                adapter = new OracleDataAdapter(cmdstr, constr);
                adapter.SelectCommand.Parameters.Add("s", (cmbo_sup.Text));
                dt = new DataTable();
                adapter.Fill(dt);
                builder = new OracleCommandBuilder(adapter);
                DataGridView1.DataSource = dt;
            }
            catch
            {

            }
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerForm M = new managerForm();
            M.Show();
        }
    }


}