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
    
    public partial class Order : Form
    {
        OracleDataAdapter adapter;   
        DataSet DS;
        string constr = "data source=orcl; user id=scott; password=tiger;";
        string cmdstr = "";
        string ordp = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection Conn;
        double Prices = 0;
        public static int OID = -1;
        Dictionary<string, int> ProductQuantity = new Dictionary<string, int>();
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            Conn = new OracleConnection(ordp);
            Conn.Open();           
        }
        
        private void AddOrder_Click(object sender, EventArgs e)
        {
            /*
             * 3 - Select one row from DB using Stored Procedures
             */
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "GetorderID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            int maxID;
            try
            {
                maxID = int.Parse(cmd.Parameters["id"].Value.ToString());
                OID = maxID + 1;
            }
            catch
            {
                OID = 1;
            }
            
            bool flag = false;
            int counter = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (!isSelected)
                {
                    counter++;
                    continue;
                    
                }

                OracleCommand C = new OracleCommand();
                C.Connection = Conn;
                C.CommandText = "SELECT quantity from product where name = :pname";
                C.CommandType = CommandType.Text;
                C.Parameters.Add("pname", row.Cells["Name"].Value);
                OracleDataReader DR = C.ExecuteReader();
                int Q = 0;
                if (DR.Read())
                {
                    Q = int.Parse(DR[0].ToString());
                }
                DR.Close();
                int q = int.Parse(row.Cells["Quantity"].Value.ToString());
                ProductQuantity.Add(row.Cells["Name"].Value.ToString(), Q);
                if(q > Q)
                {
                    flag = true;
                    break;
                }    
            }
            if (flag || counter == dataGridView1.RowCount)
            {
                MessageBox.Show(
                    "Invalid Order, Try Again",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductQuantity.Clear();
            }
            else
            {
                
              
                OracleCommand cmd3 = new OracleCommand();
                cmd3.Connection = Conn;
                cmd3.CommandText = "INSERT INTO customerorder Values(:OID, :CID, :Price)";
                cmd3.CommandType = CommandType.Text;
                cmd3.Parameters.Add("OID", OID);
                cmd3.Parameters.Add("CID", Customer.CustomerID);
                cmd3.Parameters.Add("Price", Prices);
                int r = cmd3.ExecuteNonQuery();
                if (r != -1)
                {                 
                    MessageBox.Show("Order Added Successfully");
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }     

        private void Products_Click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            dataGridView1.Columns.Insert(0, checkBoxColumn);
            cmdstr = "select name, price from product where quantity > 0";
            adapter = new OracleDataAdapter(cmdstr, constr);
            DS = new DataSet();
            adapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Quantity";
            column.Name = "Quantity";
            column.Width = 90;
            dataGridView1.Columns.Add(column);
        }

        private void ViewOrder_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (!isSelected)
                    continue;
         
                OracleCommand cmd2 = new OracleCommand();
                if (isSelected)
                {
                    int q = int.Parse(row.Cells["Quantity"].Value.ToString());
                    cmd2.Connection = Conn;
                    cmd2.CommandText = "Insert into Ordereditems values(:name, :OID, :quantity)";
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.Add("name", row.Cells["Name"].Value);
                    cmd2.Parameters.Add("OID", OID);
                    cmd2.Parameters.Add("quantity", row.Cells["Quantity"].Value);

                    int p = int.Parse(row.Cells["Price"].Value.ToString());
                    Prices += (p * q);
                    cmd2.ExecuteNonQuery();

                    OracleCommand cmd4 = new OracleCommand();
                    cmd4.Connection = Conn;
                    cmd4.CommandText = "UpdateQuantity";
                    cmd4.CommandType = CommandType.StoredProcedure;
                    int NewQ = ProductQuantity[row.Cells["Name"].Value.ToString()] - q;
                    if (NewQ <= 0)
                        NewQ = 0;
                    cmd4.Parameters.Add("quantity", NewQ);
                    cmd4.Parameters.Add("name", row.Cells["Name"].Value);
                    cmd4.ExecuteNonQuery();
                }
            }
            OracleCommand command = new OracleCommand();
            command.Connection = Conn;
            command.CommandText = "Select Points from customer where CID=:id";
            command.CommandType = CommandType.Text;
            command.Parameters.Add("CID", Customer.CustomerID);
            OracleDataReader DR = command.ExecuteReader();
            int OldPrice = (int)Prices;
            int Points = 0;
            try
            {
                if (DR.Read())
                {
                    Points = int.Parse(DR[0].ToString());
                    if (Points >= 10)
                    {
                        Prices -= (Prices * 0.1);
                        Points -= 10;
                    }
                    OracleCommand command1 = new OracleCommand();
                    command1.Connection = Conn;
                    command1.CommandText = "update Customer set Points=:p where CID=:id";
                    command1.CommandType = CommandType.Text;
                    command1.Parameters.Add("p", Points);
                    command1.Parameters.Add("id", Customer.CustomerID);
                    command1.ExecuteNonQuery();
                }
                if (OldPrice >= 500)
                {
                    OracleCommand command2 = new OracleCommand();
                    command2.Connection = Conn;
                    command2.CommandText = "update Customer set Points=:p where CID=:id";
                    command2.CommandType = CommandType.Text;
                    Points += 2;
                    command2.Parameters.Add("p", Points);
                    command2.Parameters.Add("CID", Customer.CustomerID);
                    command2.ExecuteNonQuery();
                }
            }
            catch
            {

            }
            
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = Conn;
            cmd3.CommandText = "UPDATE customerorder set Price=:p where OID =:id";
            cmd3.CommandType = CommandType.Text;
            cmd3.Parameters.Add("p", Prices);
            cmd3.Parameters.Add("id", OID);                    
            cmd3.ExecuteNonQuery();

            Prices = 0;
            Reciept form = new Reciept();
            form.Show();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Customer C = new Customer();
            C.Show();
        }
    }
}
