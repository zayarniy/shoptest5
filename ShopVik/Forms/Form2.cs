using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopVik
{
    public partial class Form2 : Form
    {
        Form mainForm;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form form)
        {
            InitializeComponent();
            mainForm = form;
        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            mainForm.Close();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Service.User user = null;
            string message;
            bool flag=ShopVik.Service.Registration(tbLogin.Text, tbPass.Text, tbFirstName.Text, tbLastName.Text,tbPhone.Text, tbEmail.Text, tbCity.Text,out message,ref Service.CurrentUser);
            MessageBox.Show(message);
            if (flag)
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
