using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StegProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
         
            if (!password_textBox.Text.Equals("")&& !password_textBox.Text.Equals("Введите пароль"))
            {
                if (Properties.Settings.Default.Password == password_textBox.Text)
                {
                    password_textBox.ForeColor = Color.Black;
                    password_textBox.BackColor = Color.Aquamarine;
                    this.BackgroundImage = Properties.Resources.unlck;
                    welcome_button.Enabled = true;

                }
                else
                {
                    this.BackgroundImage = Properties.Resources.lck;
                    password_textBox.ForeColor = Color.Black;
                    password_textBox.BackColor = Color.LightCoral;
                    welcome_button.Enabled = false;
                }
            }

            else
            {
                this.BackgroundImage = Properties.Resources.lck;
                password_textBox.BackColor = Color.White;
                welcome_button.Enabled = false;
            }
        }

        private void welcome_button_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Password == password_textBox.Text)
            {
                this.Hide();
                Form1 form1 = new Form1();

                form1.Show();
                
            }
        }

   

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            password_textBox.Text = "Введите пароль";
            password_textBox.ForeColor = Color.Gray;

            
            focus_textBox.Focus();
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (password_textBox.Text == "")
            {
                password_textBox.Text = "Введите пароль";
                password_textBox.ForeColor = Color.Gray;
                password_textBox.PasswordChar = '\0';
            }
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            password_textBox.Text = "";
            password_textBox.ForeColor = Color.Black;
            password_textBox.PasswordChar = '*';
        }

        private void LoginForm_MouseClick(object sender, MouseEventArgs e)
        {
            focus_textBox.Focus();
        }

        private void exit_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Выход - Стеганография", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
             Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                //...
            }
        }
    }
}
