using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (!isValid(mtbEmail.Text))
            {
                MessageBox.Show("Invalid email!", "Error");
            }
            else
            {
                MessageBox.Show("ok");
            }
            Service.User user = null;
            string message;
            bool flag=ShopVik.Service.Registration(tbLogin.Text, tbPass.Text, tbFirstName.Text, tbLastName.Text,mtbPhone.Text, mtbEmail.Text, tbCity.Text,out message,ref Service.CurrentUser);
            MessageBox.Show(message);
            if (flag)
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
            }
        }

        public static bool isValid(string email)//.iv\anov3@mail.yandex.ru
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            return Regex.Match(email, pattern, RegexOptions.IgnoreCase).Success;
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
