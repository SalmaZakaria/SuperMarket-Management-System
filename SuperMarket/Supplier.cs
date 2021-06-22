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
using Oracle.DataAccess.Types;

namespace SuperMarket
{
    public partial class Supplier : Form
    {
        string ordb = "Data Source = orcl ; User Id = scott ; Password = tiger;";
        OracleConnection conn;
        public Supplier()
        {
            InitializeComponent();
        }
        private void Supplier_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select sid from supplier";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select name,phone,deliverydate,price from supplier where sid =:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                text_name.Text = dr[0].ToString();
                text_phone.Text = dr[1].ToString();
                date.Text = dr[2].ToString();
                text_price.Text = dr[3].ToString();
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {

            
                   
            try
            {
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "insert into supplier values(:id,:name,:deliverydate,:phone,:price)";
                c.Parameters.Add("id", comboBox1.Text);
                c.Parameters.Add("name", text_name.Text);
                c.Parameters.Add("date", Convert.ToDateTime(date.Text));
                c.Parameters.Add("phone", text_phone.Text);
                c.Parameters.Add("price", text_price.Text);
                int r = c.ExecuteNonQuery();

                if (r != -1)
                {
                    comboBox1.Items.Add(comboBox1.Text);
                    MessageBox.Show("Supplier is added");

                }
            }
            catch
            {
                MessageBox.Show("Enter another ID as this one already used");
                comboBox1.Text = "";
            }
           
            
            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "update supplier set name = :name ,deliverydate =:d,phone =:phone,price=:price where sid =:id";
            c.Parameters.Add("name", text_name.Text);
            c.Parameters.Add("d", Convert.ToDateTime(date.Text));                           
            c.Parameters.Add("phone", text_phone.Text);
            c.Parameters.Add("price", text_price.Text); 
            c.Parameters.Add("id", comboBox1.Text);


            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Supplier is modified");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "delete from supplier where sid =:id";
            c.Parameters.Add("id", comboBox1.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Supplier is removed");
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                text_name.Text = "";
                text_phone.Text = "";
                text_price.Text = "";
                date.Text = "";
               
            }
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            managerForm M = new managerForm();
            M.Show();
        }
    }
}
