using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopVik.Forms
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
        }

        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            DataTable dataTable = Service.GetPurchase(dtpStart.Value, dtpFinish.Value);
            double sum = 0;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(dataTable.Rows[i]["Sum"]);
            }

            double avg=sum/dataTable.Rows.Count;
            tbProfit.Text = sum.ToString();
            tbReceiptAvg.Text = avg.ToString();
            tbItem.Text = Service.GetMaxProduct(dtpStart.Value, dtpFinish.Value);
            PaintGraph(dataTable);
        }

        private void PaintGraph(DataTable dataTable)
        {
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine(dataTable.Rows[i]["Sum"]);
                chart1.Series[0].Points.AddXY(Convert.ToString(dataTable.Rows[i]["FullName"]), Convert.ToInt32(dataTable.Rows[i]["Sum"]));
            }

        }
    }
}
