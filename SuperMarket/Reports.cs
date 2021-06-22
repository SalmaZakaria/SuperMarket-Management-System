using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace SuperMarket
{
    public partial class Reports : Form
    {
        CrystalReport1 CR;
        CrystalReport3 CR3;
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            label1.Hide();
            combo_PName.Hide();
            button1.Hide();
        }

        private void viewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
            crystalReportViewer1.ReportSource = CR;
            label1.Hide();
            combo_PName.Hide();
            button1.Hide();
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CR3 = new CrystalReport3();
            foreach (ParameterDiscreteValue V in CR3.ParameterFields[0].DefaultValues)
            {
                combo_PName.Items.Add(V.Value);

            }
            label1.Show();
            combo_PName.Show();
            button1.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            CR3.SetParameterValue(0, combo_PName.Text);
            crystalReportViewer1.ReportSource = CR3;
        }
        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            employeeForm E = new employeeForm();
            E.Show();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
