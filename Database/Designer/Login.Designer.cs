namespace Database
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BtnConnect = new System.Windows.Forms.Button();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.textBoxUsename = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.PanelMove = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.LabelSignUp = new System.Windows.Forms.Label();
            this.pictureBoxPeople = new System.Windows.Forms.PictureBox();
            this.PanelMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.BtnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.BtnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnect.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnect.Location = new System.Drawing.Point(8, 307);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(285, 35);
            this.BtnConnect.TabIndex = 3;
            this.BtnConnect.Text = "Login";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLogin.Font = new System.Drawing.Font("Gabriola", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.Location = new System.Drawing.Point(8, 29);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(285, 56);
            this.LabelLogin.TabIndex = 2;
            this.LabelLogin.Text = "Sign In";
            this.LabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(5, 178);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(88, 18);
            this.LabelUsername.TabIndex = 3;
            this.LabelUsername.Text = "Username :";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(5, 230);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(88, 18);
            this.LabelPassword.TabIndex = 4;
            this.LabelPassword.Text = "Password :";
            // 
            // textBoxUsename
            // 
            this.textBoxUsename.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsename.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUsename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsename.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsename.Location = new System.Drawing.Point(99, 174);
            this.textBoxUsename.Name = "textBoxUsename";
            this.textBoxUsename.Size = new System.Drawing.Size(194, 22);
            this.textBoxUsename.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(99, 226);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(194, 22);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPassword.Location = new System.Drawing.Point(99, 267);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(194, 24);
            this.checkBoxShowPassword.TabIndex = 2;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // PanelMove
            // 
            this.PanelMove.BackColor = System.Drawing.Color.White;
            this.PanelMove.Controls.Add(this.pictureBoxExit);
            this.PanelMove.Location = new System.Drawing.Point(0, 0);
            this.PanelMove.Name = "PanelMove";
            this.PanelMove.Size = new System.Drawing.Size(600, 31);
            this.PanelMove.TabIndex = 5;
            this.PanelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMove_MouseDown);
            this.PanelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelMove_MouseMove);
            this.PanelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelMove_MouseUp);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(565, 3);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(32, 20);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 0;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.BtnSignUp);
            this.panel1.Controls.Add(this.LabelSignUp);
            this.panel1.ForeColor = System.Drawing.Color.MistyRose;
            this.panel1.Location = new System.Drawing.Point(299, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 336);
            this.panel1.TabIndex = 6;
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.BtnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignUp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.ForeColor = System.Drawing.Color.Black;
            this.BtnSignUp.Location = new System.Drawing.Point(22, 206);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(267, 35);
            this.BtnSignUp.TabIndex = 4;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // LabelSignUp
            // 
            this.LabelSignUp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSignUp.ForeColor = System.Drawing.Color.Black;
            this.LabelSignUp.Location = new System.Drawing.Point(18, 116);
            this.LabelSignUp.Name = "LabelSignUp";
            this.LabelSignUp.Size = new System.Drawing.Size(271, 87);
            this.LabelSignUp.TabIndex = 0;
            this.LabelSignUp.Text = "You have to register before use the database.\r\nPlease fill the form!\r\n";
            this.LabelSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPeople
            // 
            this.pictureBoxPeople.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPeople.Image")));
            this.pictureBoxPeople.Location = new System.Drawing.Point(8, 88);
            this.pictureBoxPeople.Name = "pictureBoxPeople";
            this.pictureBoxPeople.Size = new System.Drawing.Size(285, 74);
            this.pictureBoxPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPeople.TabIndex = 7;
            this.pictureBoxPeople.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 363);
            this.Controls.Add(this.pictureBoxPeople);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMove);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsename);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.BtnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.PanelMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox textBoxUsename;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Panel PanelMove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxPeople;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label LabelSignUp;
        private System.Windows.Forms.Button BtnSignUp;
    }
}