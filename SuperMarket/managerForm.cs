using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class managerForm : Form
    {
        public managerForm()
        {
            InitializeComponent();
        }

        private void AddEmpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();
        }

        private void AddSupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier S = new Supplier();
            S.Show();
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            products P = new products();
            P.Show();
        }

        private void managerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.Show();
        }
 
        private void managerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm L = new loginForm();
            L.Show();
        }
    }
}
