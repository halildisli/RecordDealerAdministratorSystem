using RecordDealer.BLL;
using RecordDealer.DAL.Entity;
using RecordDealer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordDealer.UI
{
    public partial class SignUpForm : Form
    {
        RecordDealerEntities context = new RecordDealerEntities();
        public SignUpForm()
        {
            InitializeComponent();
            chkShowPassword.Checked = false;
            txtPassword.PasswordChar = '*';
            txtPasswordSecond.PasswordChar = '*';
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '*';
                txtPasswordSecond.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = default;
                txtPasswordSecond.PasswordChar = default;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string password2 = txtPasswordSecond.Text.Trim();
            if (password == password2)
            {
                if (RecordController.CheckSignUp(username, password))
                {
                    password=RecordController.PasswordHash(password);
                    User user = new User();
                    user.Username = username;
                    user.Password = password;
                    user.DateOfRegistration = DateTime.Today;
                    context.Users.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("User registered! You are going to the login screen.");
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalide username or password! Please read password rules.");
                }
            }
            else
            {
                MessageBox.Show("The two passwords entered are not the same! Please enter the same passwords.");
            }
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            context.SaveChanges();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Password Rules:\n\n--Password must be at least 8 characters.\n--Password must contain at least two capital letters.\n--Password must contain at least three lowercase letters.\n--The password must contain at least two '!:+*' characters.");
        }
    }
}
