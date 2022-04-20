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
    public partial class Form6 : Form
    {

        public List<int> list;
        public Form6()
        {
            InitializeComponent();
            list = new List<int>();
            for (int i = 0; i < 10; i++)
                list.Add(i);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            for(int i=0;i<list.Count;i++)
            {
                chart1.Series[0].Points.Add(list[i]);
            }
        }

        private void btnBuildGraph_Click(object sender, EventArgs e)
        {
            DataTable dataTable=Service.GetPurchase(monthCalendar1.SelectionStart,monthCalendar1.SelectionEnd);
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
