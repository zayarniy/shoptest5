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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void Lastname_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            mainForm.Close();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            string message;
            message=Model.Registration(tbLogin.Text, tbPass.Text, tbFirstName.Text, tbLastName.Text,tbPhone.Text, tbEmail.Text, tbCity.Text );
            MessageBox.Show(message);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
