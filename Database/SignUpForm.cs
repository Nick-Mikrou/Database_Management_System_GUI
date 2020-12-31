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

namespace Database
{
    public partial class SignUpForm : Form
    {
        bool check_Password = false, check_Username = false, move;
        int posX, posY;

        public Form RefToLoginForm { get; set; }

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToLoginForm.Show();
        }

        private void textBoxPasswordSignUp_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPasswordSignUp.TextLength > 0)
                check_Password = true;
            else
                check_Password = false;

            check();
        }

        private void textBoxUsernameSignUp_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsernameSignUp.TextLength > 0)
                check_Username = true;
            else
                check_Username = false;

            check();   
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            posX = e.X;
            posY = e.Y;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.SetDesktopLocation(MousePosition.X - posX, MousePosition.Y - posY);
        }

        public void check()
        {
            if (check_Username && check_Password )
                BtnSubmit.Enabled = true;
            else
                BtnSubmit.Enabled = false;
        }
    }
}