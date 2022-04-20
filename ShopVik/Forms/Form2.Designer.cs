
namespace ShopVik
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Firstname = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPass2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.mtbEmail = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Firstname
            // 
            this.Firstname.AutoSize = true;
            this.Firstname.Location = new System.Drawing.Point(123, 36);
            this.Firstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(27, 13);
            this.Firstname.TabIndex = 0;
            this.Firstname.Text = "имя";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(100, 86);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(50, 13);
            this.PhoneNumber.TabIndex = 1;
            this.PhoneNumber.Text = "телефон";
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Location = new System.Drawing.Point(97, 62);
            this.Lastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(53, 13);
            this.Lastname.TabIndex = 2;
            this.Lastname.Text = "фамилия";
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(161, 250);
            this.btnRegistration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(124, 19);
            this.btnRegistration.TabIndex = 3;
            this.btnRegistration.Text = "зарегистрироваться";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(169, 31);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(95, 20);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Text = "1";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(169, 57);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(95, 20);
            this.tbLastName.TabIndex = 1;
            this.tbLastName.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "регистрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "логин";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(169, 176);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(95, 20);
            this.tbLogin.TabIndex = 5;
            this.tbLogin.Text = "l";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(169, 200);
            this.tbPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(95, 20);
            this.tbPass.TabIndex = 6;
            this.tbPass.Text = "p";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "подтвердить пароль";
            // 
            // tbPass2
            // 
            this.tbPass2.Enabled = false;
            this.tbPass2.Location = new System.Drawing.Point(169, 229);
            this.tbPass2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPass2.Name = "tbPass2";
            this.tbPass2.Size = new System.Drawing.Size(95, 20);
            this.tbPass2.TabIndex = 7;
            this.tbPass2.Text = "p";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(169, 143);
            this.tbCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(95, 20);
            this.tbCity.TabIndex = 4;
            this.tbCity.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "город";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(169, 86);
            this.mtbPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbPhone.Mask = "+9(999) 000-00-00";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(95, 20);
            this.mtbPhone.TabIndex = 18;
            this.mtbPhone.Text = "1111111111";
            // 
            // mtbEmail
            // 
            this.mtbEmail.Location = new System.Drawing.Point(169, 112);
            this.mtbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbEmail.Name = "mtbEmail";
            this.mtbEmail.Size = new System.Drawing.Size(95, 20);
            this.mtbEmail.TabIndex = 19;
            this.mtbEmail.Text = "mail@mail.com";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 292);
            this.Controls.Add(this.mtbEmail);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPass2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Firstname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPass2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.MaskedTextBox mtbEmail;
    }
}