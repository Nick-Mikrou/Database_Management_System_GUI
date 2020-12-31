using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Database
{
    public partial class Login : Form
    {
        int  posX, posY;
        bool move;
        public static string userText, passText;

        public Login()
        {
            InitializeComponent();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            _ = checkBoxShowPassword.Checked == true ? textBoxPassword.UseSystemPasswordChar = false : textBoxPassword.UseSystemPasswordChar = true;
        }

        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            posX = e.X;
            posY = e.Y;
        }

        private void PanelMove_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.SetDesktopLocation(MousePosition.X - posX, MousePosition.Y - posY);
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm
            {
                RefToLoginForm = this
            };

            this.Visible = false;
            signUpForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection connect = new MySqlConnection("server = address; user id = '" + textBoxUsename.Text + "'; password = '" + textBoxPassword.Text + "'; database = nameofdatabase");
                connect.Open();

                if (connect.State == ConnectionState.Open)
                {
                    DrawForm();
                    Security();
                }

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void DrawForm()
        {
            passText = textBoxPassword.Text;
            userText = textBoxUsename.Text;
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void Security()
        {
            string path = "C:/Users/User/Desktop/Database/Log.txt";
            string time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            File.AppendAllText(path, " Time:" + time + " Username:" + textBoxUsename.Text);
        }
    }
}
