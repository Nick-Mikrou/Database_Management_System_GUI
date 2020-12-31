namespace Database
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.panelSignUp = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxPasswordSignUp = new System.Windows.Forms.TextBox();
            this.textBoxUsernameSignUp = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.White;
            this.BtnSubmit.Enabled = false;
            this.BtnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.BtnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(12, 219);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(230, 35);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // panelSignUp
            // 
            this.panelSignUp.BackColor = System.Drawing.Color.White;
            this.panelSignUp.Controls.Add(this.pictureBox1);
            this.panelSignUp.Controls.Add(this.textBoxPasswordSignUp);
            this.panelSignUp.Controls.Add(this.textBoxUsernameSignUp);
            this.panelSignUp.Controls.Add(this.LabelPassword);
            this.panelSignUp.Controls.Add(this.LabelUsername);
            this.panelSignUp.Location = new System.Drawing.Point(12, 41);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.Size = new System.Drawing.Size(230, 172);
            this.panelSignUp.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxPasswordSignUp
            // 
            this.textBoxPasswordSignUp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPasswordSignUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPasswordSignUp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordSignUp.Location = new System.Drawing.Point(97, 126);
            this.textBoxPasswordSignUp.Name = "textBoxPasswordSignUp";
            this.textBoxPasswordSignUp.Size = new System.Drawing.Size(119, 22);
            this.textBoxPasswordSignUp.TabIndex = 6;
            this.textBoxPasswordSignUp.UseSystemPasswordChar = true;
            this.textBoxPasswordSignUp.TextChanged += new System.EventHandler(this.textBoxPasswordSignUp_TextChanged);
            // 
            // textBoxUsernameSignUp
            // 
            this.textBoxUsernameSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsernameSignUp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUsernameSignUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsernameSignUp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameSignUp.Location = new System.Drawing.Point(97, 80);
            this.textBoxUsernameSignUp.Name = "textBoxUsernameSignUp";
            this.textBoxUsernameSignUp.Size = new System.Drawing.Size(119, 22);
            this.textBoxUsernameSignUp.TabIndex = 5;
            this.textBoxUsernameSignUp.TextChanged += new System.EventHandler(this.textBoxUsernameSignUp_TextChanged);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(3, 130);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(88, 18);
            this.LabelPassword.TabIndex = 8;
            this.LabelPassword.Text = "Password :";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(3, 84);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(88, 18);
            this.LabelUsername.TabIndex = 7;
            this.LabelUsername.Text = "Username :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sign Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(254, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSignUp);
            this.Controls.Add(this.BtnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.panelSignUp.ResumeLayout(false);
            this.panelSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Panel panelSignUp;
        private System.Windows.Forms.TextBox textBoxPasswordSignUp;
        private System.Windows.Forms.TextBox textBoxUsernameSignUp;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}