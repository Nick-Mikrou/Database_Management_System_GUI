namespace Database
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.connectedUser = new System.Windows.Forms.Label();
            this.connectedPeople = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Actions_Box = new System.Windows.Forms.GroupBox();
            this.BtnDropTriger = new System.Windows.Forms.Button();
            this.pictureBoxCountryCode = new System.Windows.Forms.PictureBox();
            this.pictureBoxID = new System.Windows.Forms.PictureBox();
            this.triggerLabel = new System.Windows.Forms.Label();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAction = new System.Windows.Forms.Button();
            this.textboxCountryCode = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textboxDistrict = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textboxPopulation = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textboxPercentage = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textboxContinent = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textboxRegion = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textboxLanguage = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textboxSurfaceArea = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textboxLocalName = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textboxGovernmentForm = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textboxHeadofState = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textboxLifeExpectancy = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textboxIsOfficial = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textboxName = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textboxID = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.radioButtonPrint = new System.Windows.Forms.RadioButton();
            this.radioButtonTrigger = new System.Windows.Forms.RadioButton();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert = new System.Windows.Forms.RadioButton();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.Tables = new System.Windows.Forms.Label();
            this.Data_View = new System.Windows.Forms.GroupBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.radioButtonMaxPopulation = new System.Windows.Forms.RadioButton();
            this.Calculate_Box = new System.Windows.Forms.GroupBox();
            this.radioButtonMinPopulation = new System.Windows.Forms.RadioButton();
            this.BtnClear1 = new System.Windows.Forms.Button();
            this.dataGridViewMaxPopulation = new System.Windows.Forms.DataGridView();
            this.Btn_Procedure = new System.Windows.Forms.Button();
            this.View_Box = new System.Windows.Forms.GroupBox();
            this.viewlabel = new System.Windows.Forms.Label();
            this.radioButtonCreateView = new System.Windows.Forms.RadioButton();
            this.BtnClear2 = new System.Windows.Forms.Button();
            this.Btn_Create_View = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Menu.SuspendLayout();
            this.Actions_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountryCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxID)).BeginInit();
            this.Data_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.Calculate_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaxPopulation)).BeginInit();
            this.View_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // connectedUser
            // 
            this.connectedUser.AutoSize = true;
            this.connectedUser.Location = new System.Drawing.Point(545, 182);
            this.connectedUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectedUser.Name = "connectedUser";
            this.connectedUser.Size = new System.Drawing.Size(0, 17);
            this.connectedUser.TabIndex = 0;
            // 
            // connectedPeople
            // 
            this.connectedPeople.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedPeople.Location = new System.Drawing.Point(867, 0);
            this.connectedPeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectedPeople.Name = "connectedPeople";
            this.connectedPeople.Size = new System.Drawing.Size(200, 30);
            this.connectedPeople.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1067, 28);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menuStrip1";
            this.Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.Menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.Menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.exportToolStripMenuItem.Text = "&Export";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.excelToolStripMenuItem.Text = "Ex&cel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.aboutUsToolStripMenuItem.Text = "&About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // Actions_Box
            // 
            this.Actions_Box.BackColor = System.Drawing.Color.White;
            this.Actions_Box.Controls.Add(this.BtnDropTriger);
            this.Actions_Box.Controls.Add(this.pictureBoxCountryCode);
            this.Actions_Box.Controls.Add(this.pictureBoxID);
            this.Actions_Box.Controls.Add(this.triggerLabel);
            this.Actions_Box.Controls.Add(this.radioButtonUpdate);
            this.Actions_Box.Controls.Add(this.BtnClear);
            this.Actions_Box.Controls.Add(this.BtnAction);
            this.Actions_Box.Controls.Add(this.textboxCountryCode);
            this.Actions_Box.Controls.Add(this.textboxDistrict);
            this.Actions_Box.Controls.Add(this.textboxPopulation);
            this.Actions_Box.Controls.Add(this.textboxPercentage);
            this.Actions_Box.Controls.Add(this.textboxContinent);
            this.Actions_Box.Controls.Add(this.textboxRegion);
            this.Actions_Box.Controls.Add(this.textboxLanguage);
            this.Actions_Box.Controls.Add(this.textboxSurfaceArea);
            this.Actions_Box.Controls.Add(this.textboxLocalName);
            this.Actions_Box.Controls.Add(this.textboxGovernmentForm);
            this.Actions_Box.Controls.Add(this.textboxHeadofState);
            this.Actions_Box.Controls.Add(this.textboxLifeExpectancy);
            this.Actions_Box.Controls.Add(this.textboxIsOfficial);
            this.Actions_Box.Controls.Add(this.textboxName);
            this.Actions_Box.Controls.Add(this.textboxID);
            this.Actions_Box.Controls.Add(this.radioButtonPrint);
            this.Actions_Box.Controls.Add(this.radioButtonTrigger);
            this.Actions_Box.Controls.Add(this.radioButtonDelete);
            this.Actions_Box.Controls.Add(this.radioButtonInsert);
            this.Actions_Box.Controls.Add(this.comboBoxTable);
            this.Actions_Box.Controls.Add(this.Tables);
            this.Actions_Box.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actions_Box.Location = new System.Drawing.Point(16, 58);
            this.Actions_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Actions_Box.Name = "Actions_Box";
            this.Actions_Box.Padding = new System.Windows.Forms.Padding(4);
            this.Actions_Box.Size = new System.Drawing.Size(1031, 218);
            this.Actions_Box.TabIndex = 3;
            this.Actions_Box.TabStop = false;
            this.Actions_Box.Text = "Actions";
            // 
            // BtnDropTriger
            // 
            this.BtnDropTriger.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDropTriger.Location = new System.Drawing.Point(259, 181);
            this.BtnDropTriger.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDropTriger.Name = "BtnDropTriger";
            this.BtnDropTriger.Size = new System.Drawing.Size(89, 28);
            this.BtnDropTriger.TabIndex = 27;
            this.BtnDropTriger.Text = "&Drop";
            this.BtnDropTriger.UseVisualStyleBackColor = true;
            this.BtnDropTriger.Click += new System.EventHandler(this.BtnDropTriger_Click);
            // 
            // pictureBoxCountryCode
            // 
            this.pictureBoxCountryCode.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCountryCode.Image")));
            this.pictureBoxCountryCode.Location = new System.Drawing.Point(533, 110);
            this.pictureBoxCountryCode.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCountryCode.Name = "pictureBoxCountryCode";
            this.pictureBoxCountryCode.Size = new System.Drawing.Size(37, 28);
            this.pictureBoxCountryCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCountryCode.TabIndex = 26;
            this.pictureBoxCountryCode.TabStop = false;
            this.pictureBoxCountryCode.Visible = false;
            // 
            // pictureBoxID
            // 
            this.pictureBoxID.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxID.Image")));
            this.pictureBoxID.Location = new System.Drawing.Point(533, 38);
            this.pictureBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxID.Name = "pictureBoxID";
            this.pictureBoxID.Size = new System.Drawing.Size(37, 28);
            this.pictureBoxID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxID.TabIndex = 25;
            this.pictureBoxID.TabStop = false;
            this.pictureBoxID.Visible = false;
            // 
            // triggerLabel
            // 
            this.triggerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.triggerLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triggerLabel.Location = new System.Drawing.Point(169, 186);
            this.triggerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.triggerLabel.Name = "triggerLabel";
            this.triggerLabel.Size = new System.Drawing.Size(81, 21);
            this.triggerLabel.TabIndex = 24;
            this.triggerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(259, 79);
            this.radioButtonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(84, 24);
            this.radioButtonUpdate.TabIndex = 6;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "Update";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            this.radioButtonUpdate.Click += new System.EventHandler(this.radioButtonUpdate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(259, 145);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(89, 28);
            this.BtnClear.TabIndex = 23;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAction
            // 
            this.BtnAction.Enabled = false;
            this.BtnAction.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAction.Location = new System.Drawing.Point(259, 110);
            this.BtnAction.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(89, 28);
            this.BtnAction.TabIndex = 22;
            this.BtnAction.Text = "&Go";
            this.BtnAction.UseVisualStyleBackColor = true;
            this.BtnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // textboxCountryCode
            // 
            this.textboxCountryCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxCountryCode.Enabled = false;
            this.textboxCountryCode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxCountryCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxCountryCode.Location = new System.Drawing.Point(356, 110);
            this.textboxCountryCode.Margin = new System.Windows.Forms.Padding(4);
            this.textboxCountryCode.Name = "textboxCountryCode";
            this.textboxCountryCode.Size = new System.Drawing.Size(172, 27);
            this.textboxCountryCode.TabIndex = 9;
            this.textboxCountryCode.WaterMark = "Country Code";
            this.textboxCountryCode.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.textboxCountryCode.WaterMarkFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxCountryCode.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // textboxDistrict
            // 
            this.textboxDistrict.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxDistrict.Enabled = false;
            this.textboxDistrict.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDistrict.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxDistrict.Location = new System.Drawing.Point(356, 145);
            this.textboxDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.textboxDistrict.Name = "textboxDistrict";
            this.textboxDistrict.Size = new System.Drawing.Size(172, 27);
            this.textboxDistrict.TabIndex = 10;
            this.textboxDistrict.WaterMark = "District";
            this.textboxDistrict.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.textboxDistrict.WaterMarkFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDistrict.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // textboxPopulation
            // 
            this.textboxPopulation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxPopulation.Enabled = false;
            this.textboxPopulation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPopulation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxPopulation.Location = new System.Drawing.Point(356, 181);
            this.textboxPopulation.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPopulation.Name = "textboxPopulation";
            this.textboxPopulation.Size = new System.Drawing.Size(172, 27);
            this.textboxPopulation.TabIndex = 11;
            this.textboxPopulation.WaterMark = "Population";
            this.textboxPopulation.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.textboxPopulation.WaterMarkFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPopulation.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // textboxPercentage
            // 
            this.textboxPercentage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxPercentage.Enabled = false;
            this.textboxPercentage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPercentage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxPercentage.Location = new System.Drawing.Point(583, 110);
            this.textboxPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPercentage.Name = "textboxPercentage";
            this.textboxPercentage.Size = new System.Drawing.Size(172, 27);
            this.textboxPercentage.TabIndex = 14;
            this.textboxPercentage.WaterMark = "Percentage";
            this.textboxPercentage.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.textboxPercentage.WaterMarkFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPercentage.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // textboxContinent
            // 
            this.textboxContinent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxContinent.Enabled = false;
            this.textboxContinent.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxContinent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxContinent.Location = new System.Drawing.Point(583, 145);
            this.textboxContinent.Margin = new System.Windows.Forms.Padding(4);
            this.textboxContinent.Name = "textboxContinent";
            this.textboxContinent.Size = new System.Drawing.Size(172, 27);
            this.textboxContinent.TabIndex = 15;
            this.textboxContinent.WaterMark = "Continent";
            this.textboxContinent.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.textboxContinent.WaterMarkFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxContinent.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // textboxRegion
            // 
            this.textboxRegion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxRegion.Enabled = false;
            this.textboxRegion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxRegion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxRegion.Location = new System.Drawing.Point(583, 181);
            this.textboxRegion.Margin = new System.Windows.Forms.Padding(4);
            this.textboxRegion.Name = "textboxRegion";
            this.textboxRegion.Size = new System.Drawing.Size(172, 27);
            this.textboxRegion.TabIndex = 16;
            this.textboxRegion.WaterMark = "Region";
            this.textboxRegion.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.textboxRegion.WaterMarkFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxRegion.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // textboxLanguage
            // 
            this.textboxLanguage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxLanguage.Enabled = false;
            this.textboxLanguage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxLanguage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxLanguage.Location = new System.Drawing.Point(583, 38);
            this.textboxLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.textboxLanguage.Name = "textboxLanguage";
            this.textboxLanguage.Size = new System.Drawing.Size(172, 27);
            this.textboxLanguage.TabIndex = 12;
            this.textboxLanguage.WaterMark = "Language";
            this.textboxLanguage.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.textboxLanguage.WaterMarkFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxLanguage.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // textboxSurfaceArea
            // 
            this.textboxSurfaceArea.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxSurfaceArea.Enabled = false;
            this.textboxSurfaceArea.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSurfaceArea.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxSurfaceArea.Location = new System.Drawing.Point(811, 38);
            this.textboxSurfaceArea.Margin = new System.Windows.Forms.Padding(4);
            this.textboxSurfaceArea.Name = "textboxSurfaceArea";
            this.textboxSurfaceArea.Size = new System.Drawing.Size(172, 27);
            this.textboxSurfaceArea.TabIndex = 17;
            this.textboxSurfaceArea.WaterMark = "Surface Area";
            this.textboxSurfaceArea.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.textboxSurfaceArea.WaterMarkFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSurfaceArea.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // textboxLocalName
            // 
            this.textboxLocalName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxLocalName.Enabled = false;
            this.textboxLocalName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxLocalName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxLocalName.Location = new System.Drawing.Point(811, 74);
            this.textboxLocalName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxLocalName.Name = "textboxLocalName";
            this.textboxLocalName.Size = new System.Drawing.Size(172, 27);
            this.textboxLocalName.TabIndex = 18;
            this.textboxLocalName.WaterMark = "Local Name";
            this.textboxLocalName.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.textboxLocalName.WaterMarkFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxLocalName.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // textboxGovernmentForm
            // 
            this.textboxGovernmentForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxGovernmentForm.Enabled = false;
            this.textboxGovernmentForm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxGovernmentForm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxGovernmentForm.Location = new System.Drawing.Point(811, 110);
            this.textboxGovernmentForm.Margin = new System.Windows.Forms.Padding(4);
            this.textboxGovernmentForm.Name = "textboxGovernmentForm";
            this.textboxGovernmentForm.Size = new System.Drawing.Size(172, 27);
            this.textboxGovernmentForm.TabIndex = 19;
            this.textboxGovernmentForm.WaterMark = "Government Form";
            this.textboxGovernmentForm.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.textboxGovernmentForm.WaterMarkFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxGovernmentForm.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // textboxHeadofState
            // 
            this.textboxHeadofState.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxHeadofState.Enabled = false;
            this.textboxHeadofState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxHeadofState.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxHeadofState.Location = new System.Drawing.Point(811, 145);
            this.textboxHeadofState.Margin = new System.Windows.Forms.Padding(4);
            this.textboxHeadofState.Name = "textboxHeadofState";
            this.textboxHeadofState.Size = new System.Drawing.Size(172, 27);
            this.textboxHeadofState.TabIndex = 20;
            this.textboxHeadofState.WaterMark = "Head of State";
            this.textboxHeadofState.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.textboxHeadofState.WaterMarkFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxHeadofState.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // textboxLifeExpectancy
            // 
            this.textboxLifeExpectancy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxLifeExpectancy.Enabled = false;
            this.textboxLifeExpectancy.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxLifeExpectancy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxLifeExpectancy.Location = new System.Drawing.Point(811, 181);
            this.textboxLifeExpectancy.Margin = new System.Windows.Forms.Padding(4);
            this.textboxLifeExpectancy.Name = "textboxLifeExpectancy";
            this.textboxLifeExpectancy.Size = new System.Drawing.Size(172, 27);
            this.textboxLifeExpectancy.TabIndex = 21;
            this.textboxLifeExpectancy.WaterMark = "Life Expectancy";
            this.textboxLifeExpectancy.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.textboxLifeExpectancy.WaterMarkFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxLifeExpectancy.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // textboxIsOfficial
            // 
            this.textboxIsOfficial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxIsOfficial.Enabled = false;
            this.textboxIsOfficial.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxIsOfficial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxIsOfficial.Location = new System.Drawing.Point(583, 74);
            this.textboxIsOfficial.Margin = new System.Windows.Forms.Padding(4);
            this.textboxIsOfficial.Name = "textboxIsOfficial";
            this.textboxIsOfficial.Size = new System.Drawing.Size(172, 27);
            this.textboxIsOfficial.TabIndex = 13;
            this.textboxIsOfficial.WaterMark = "Is Official";
            this.textboxIsOfficial.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.textboxIsOfficial.WaterMarkFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxIsOfficial.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // textboxName
            // 
            this.textboxName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxName.Enabled = false;
            this.textboxName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxName.Location = new System.Drawing.Point(356, 74);
            this.textboxName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(172, 27);
            this.textboxName.TabIndex = 8;
            this.textboxName.WaterMark = "Name";
            this.textboxName.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.textboxName.WaterMarkFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxName.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // textboxID
            // 
            this.textboxID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textboxID.Enabled = false;
            this.textboxID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxID.Location = new System.Drawing.Point(356, 38);
            this.textboxID.Margin = new System.Windows.Forms.Padding(4);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(172, 27);
            this.textboxID.TabIndex = 7;
            this.textboxID.WaterMark = "ID";
            this.textboxID.WaterMarkActiveForeColor = System.Drawing.Color.Black;
            this.textboxID.WaterMarkFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxID.WaterMarkForeColor = System.Drawing.Color.Gray;
            // 
            // radioButtonPrint
            // 
            this.radioButtonPrint.AutoSize = true;
            this.radioButtonPrint.Location = new System.Drawing.Point(8, 112);
            this.radioButtonPrint.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPrint.Name = "radioButtonPrint";
            this.radioButtonPrint.Size = new System.Drawing.Size(75, 24);
            this.radioButtonPrint.TabIndex = 3;
            this.radioButtonPrint.TabStop = true;
            this.radioButtonPrint.Text = "Print";
            this.radioButtonPrint.UseVisualStyleBackColor = true;
            this.radioButtonPrint.Click += new System.EventHandler(this.radioButtonPrint_Click);
            // 
            // radioButtonTrigger
            // 
            this.radioButtonTrigger.AutoSize = true;
            this.radioButtonTrigger.Enabled = false;
            this.radioButtonTrigger.Location = new System.Drawing.Point(8, 182);
            this.radioButtonTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonTrigger.Name = "radioButtonTrigger";
            this.radioButtonTrigger.Size = new System.Drawing.Size(156, 24);
            this.radioButtonTrigger.TabIndex = 5;
            this.radioButtonTrigger.TabStop = true;
            this.radioButtonTrigger.Text = "Enable Trigger";
            this.radioButtonTrigger.UseVisualStyleBackColor = true;
            this.radioButtonTrigger.Click += new System.EventHandler(this.radioButtonTrigger_Click);
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(8, 148);
            this.radioButtonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(84, 24);
            this.radioButtonDelete.TabIndex = 4;
            this.radioButtonDelete.TabStop = true;
            this.radioButtonDelete.Text = "Delete";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            this.radioButtonDelete.Click += new System.EventHandler(this.radioButtonDelete_Click);
            // 
            // radioButtonInsert
            // 
            this.radioButtonInsert.AutoSize = true;
            this.radioButtonInsert.Location = new System.Drawing.Point(8, 81);
            this.radioButtonInsert.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonInsert.Name = "radioButtonInsert";
            this.radioButtonInsert.Size = new System.Drawing.Size(84, 24);
            this.radioButtonInsert.TabIndex = 2;
            this.radioButtonInsert.TabStop = true;
            this.radioButtonInsert.Text = "Insert";
            this.radioButtonInsert.UseVisualStyleBackColor = true;
            this.radioButtonInsert.Click += new System.EventHandler(this.radioButtonInsert_Click);
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Items.AddRange(new object[] {
            "City",
            "Country",
            "Country Language"});
            this.comboBoxTable.Location = new System.Drawing.Point(89, 38);
            this.comboBoxTable.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(257, 27);
            this.comboBoxTable.TabIndex = 1;
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxTable_SelectedIndexChanged);
            // 
            // Tables
            // 
            this.Tables.AutoSize = true;
            this.Tables.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tables.Location = new System.Drawing.Point(7, 49);
            this.Tables.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(64, 18);
            this.Tables.TabIndex = 0;
            this.Tables.Text = "Table :";
            // 
            // Data_View
            // 
            this.Data_View.BackColor = System.Drawing.Color.White;
            this.Data_View.Controls.Add(this.dataGridViewData);
            this.Data_View.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_View.Location = new System.Drawing.Point(16, 283);
            this.Data_View.Margin = new System.Windows.Forms.Padding(4);
            this.Data_View.Name = "Data_View";
            this.Data_View.Padding = new System.Windows.Forms.Padding(4);
            this.Data_View.Size = new System.Drawing.Size(1031, 245);
            this.Data_View.TabIndex = 4;
            this.Data_View.TabStop = false;
            this.Data_View.Text = "Data";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(8, 27);
            this.dataGridViewData.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new System.Drawing.Size(1015, 210);
            this.dataGridViewData.TabIndex = 0;
            this.dataGridViewData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewData_MouseClick);
            // 
            // radioButtonMaxPopulation
            // 
            this.radioButtonMaxPopulation.AutoSize = true;
            this.radioButtonMaxPopulation.Location = new System.Drawing.Point(8, 25);
            this.radioButtonMaxPopulation.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMaxPopulation.Name = "radioButtonMaxPopulation";
            this.radioButtonMaxPopulation.Size = new System.Drawing.Size(183, 24);
            this.radioButtonMaxPopulation.TabIndex = 22;
            this.radioButtonMaxPopulation.TabStop = true;
            this.radioButtonMaxPopulation.Text = "Max Population  :";
            this.radioButtonMaxPopulation.UseVisualStyleBackColor = true;
            this.radioButtonMaxPopulation.Click += new System.EventHandler(this.radioButtonMaxPopulation_Click);
            // 
            // Calculate_Box
            // 
            this.Calculate_Box.BackColor = System.Drawing.Color.White;
            this.Calculate_Box.Controls.Add(this.radioButtonMinPopulation);
            this.Calculate_Box.Controls.Add(this.BtnClear1);
            this.Calculate_Box.Controls.Add(this.dataGridViewMaxPopulation);
            this.Calculate_Box.Controls.Add(this.Btn_Procedure);
            this.Calculate_Box.Controls.Add(this.radioButtonMaxPopulation);
            this.Calculate_Box.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate_Box.Location = new System.Drawing.Point(16, 535);
            this.Calculate_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Calculate_Box.Name = "Calculate_Box";
            this.Calculate_Box.Padding = new System.Windows.Forms.Padding(4);
            this.Calculate_Box.Size = new System.Drawing.Size(508, 126);
            this.Calculate_Box.TabIndex = 5;
            this.Calculate_Box.TabStop = false;
            this.Calculate_Box.Text = "Calculate";
            // 
            // radioButtonMinPopulation
            // 
            this.radioButtonMinPopulation.AutoSize = true;
            this.radioButtonMinPopulation.Location = new System.Drawing.Point(8, 55);
            this.radioButtonMinPopulation.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMinPopulation.Name = "radioButtonMinPopulation";
            this.radioButtonMinPopulation.Size = new System.Drawing.Size(183, 24);
            this.radioButtonMinPopulation.TabIndex = 23;
            this.radioButtonMinPopulation.TabStop = true;
            this.radioButtonMinPopulation.Text = "Min Population  :";
            this.radioButtonMinPopulation.UseVisualStyleBackColor = true;
            this.radioButtonMinPopulation.Click += new System.EventHandler(this.radioButtonMinPopulation_Click);
            // 
            // BtnClear1
            // 
            this.BtnClear1.Enabled = false;
            this.BtnClear1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear1.Location = new System.Drawing.Point(104, 86);
            this.BtnClear1.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClear1.Name = "BtnClear1";
            this.BtnClear1.Size = new System.Drawing.Size(89, 28);
            this.BtnClear1.TabIndex = 25;
            this.BtnClear1.Text = "C&lear";
            this.BtnClear1.UseVisualStyleBackColor = true;
            this.BtnClear1.Click += new System.EventHandler(this.BtnClear1_Click);
            // 
            // dataGridViewMaxPopulation
            // 
            this.dataGridViewMaxPopulation.AllowUserToAddRows = false;
            this.dataGridViewMaxPopulation.AllowUserToDeleteRows = false;
            this.dataGridViewMaxPopulation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaxPopulation.Location = new System.Drawing.Point(211, 27);
            this.dataGridViewMaxPopulation.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMaxPopulation.Name = "dataGridViewMaxPopulation";
            this.dataGridViewMaxPopulation.ReadOnly = true;
            this.dataGridViewMaxPopulation.RowHeadersWidth = 51;
            this.dataGridViewMaxPopulation.Size = new System.Drawing.Size(289, 87);
            this.dataGridViewMaxPopulation.TabIndex = 25;
            // 
            // Btn_Procedure
            // 
            this.Btn_Procedure.Enabled = false;
            this.Btn_Procedure.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Procedure.Location = new System.Drawing.Point(8, 86);
            this.Btn_Procedure.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Procedure.Name = "Btn_Procedure";
            this.Btn_Procedure.Size = new System.Drawing.Size(89, 28);
            this.Btn_Procedure.TabIndex = 24;
            this.Btn_Procedure.Text = "G&o";
            this.Btn_Procedure.UseVisualStyleBackColor = true;
            this.Btn_Procedure.Click += new System.EventHandler(this.Btn_Procedure_Click);
            // 
            // View_Box
            // 
            this.View_Box.BackColor = System.Drawing.Color.White;
            this.View_Box.Controls.Add(this.viewlabel);
            this.View_Box.Controls.Add(this.radioButtonCreateView);
            this.View_Box.Controls.Add(this.BtnClear2);
            this.View_Box.Controls.Add(this.Btn_Create_View);
            this.View_Box.Controls.Add(this.dataGridView);
            this.View_Box.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Box.Location = new System.Drawing.Point(539, 535);
            this.View_Box.Margin = new System.Windows.Forms.Padding(4);
            this.View_Box.Name = "View_Box";
            this.View_Box.Padding = new System.Windows.Forms.Padding(4);
            this.View_Box.Size = new System.Drawing.Size(508, 126);
            this.View_Box.TabIndex = 6;
            this.View_Box.TabStop = false;
            this.View_Box.Text = "Create View";
            // 
            // viewlabel
            // 
            this.viewlabel.Location = new System.Drawing.Point(28, 54);
            this.viewlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewlabel.Name = "viewlabel";
            this.viewlabel.Size = new System.Drawing.Size(167, 25);
            this.viewlabel.TabIndex = 29;
            this.viewlabel.Text = "Population>10000";
            // 
            // radioButtonCreateView
            // 
            this.radioButtonCreateView.AutoSize = true;
            this.radioButtonCreateView.Location = new System.Drawing.Point(8, 27);
            this.radioButtonCreateView.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCreateView.Name = "radioButtonCreateView";
            this.radioButtonCreateView.Size = new System.Drawing.Size(165, 24);
            this.radioButtonCreateView.TabIndex = 26;
            this.radioButtonCreateView.TabStop = true;
            this.radioButtonCreateView.Text = "View for Cities";
            this.radioButtonCreateView.UseVisualStyleBackColor = true;
            this.radioButtonCreateView.Click += new System.EventHandler(this.radioButtonCreateView_Click);
            // 
            // BtnClear2
            // 
            this.BtnClear2.Enabled = false;
            this.BtnClear2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear2.Location = new System.Drawing.Point(105, 86);
            this.BtnClear2.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClear2.Name = "BtnClear2";
            this.BtnClear2.Size = new System.Drawing.Size(89, 28);
            this.BtnClear2.TabIndex = 28;
            this.BtnClear2.Text = "C&lear";
            this.BtnClear2.UseVisualStyleBackColor = true;
            this.BtnClear2.Click += new System.EventHandler(this.BtnClear2_Click);
            // 
            // Btn_Create_View
            // 
            this.Btn_Create_View.Enabled = false;
            this.Btn_Create_View.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Create_View.Location = new System.Drawing.Point(8, 86);
            this.Btn_Create_View.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Create_View.Name = "Btn_Create_View";
            this.Btn_Create_View.Size = new System.Drawing.Size(89, 28);
            this.Btn_Create_View.TabIndex = 27;
            this.Btn_Create_View.Text = "G&o";
            this.Btn_Create_View.UseVisualStyleBackColor = true;
            this.Btn_Create_View.Click += new System.EventHandler(this.Btn_Create_View_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(203, 27);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(297, 87);
            this.dataGridView.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1067, 679);
            this.Controls.Add(this.View_Box);
            this.Controls.Add(this.Calculate_Box);
            this.Controls.Add(this.Data_View);
            this.Controls.Add(this.Actions_Box);
            this.Controls.Add(this.connectedPeople);
            this.Controls.Add(this.connectedUser);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Actions_Box.ResumeLayout(false);
            this.Actions_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountryCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxID)).EndInit();
            this.Data_View.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.Calculate_Box.ResumeLayout(false);
            this.Calculate_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaxPopulation)).EndInit();
            this.View_Box.ResumeLayout(false);
            this.View_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label connectedUser;
        private System.Windows.Forms.Label connectedPeople;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.GroupBox Actions_Box;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.Label Tables;
        private System.Windows.Forms.RadioButton radioButtonTrigger;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioButtonInsert;
        private System.Windows.Forms.RadioButton radioButtonPrint;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxCountryCode;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxDistrict;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxPopulation;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxPercentage;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxContinent;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxRegion;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxLanguage;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxSurfaceArea;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxLocalName;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxGovernmentForm;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxHeadofState;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxLifeExpectancy;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxIsOfficial;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxName;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxID;
        private System.Windows.Forms.GroupBox Data_View;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.Label triggerLabel;
        private System.Windows.Forms.PictureBox pictureBoxCountryCode;
        private System.Windows.Forms.PictureBox pictureBoxID;
        private System.Windows.Forms.Button BtnDropTriger;
        private System.Windows.Forms.RadioButton radioButtonMaxPopulation;
        private System.Windows.Forms.GroupBox Calculate_Box;
        private System.Windows.Forms.Button Btn_Procedure;
        private System.Windows.Forms.DataGridView dataGridViewMaxPopulation;
        private System.Windows.Forms.Button BtnClear1;
        private System.Windows.Forms.RadioButton radioButtonMinPopulation;
        private System.Windows.Forms.GroupBox View_Box;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button BtnClear2;
        private System.Windows.Forms.Button Btn_Create_View;
        private System.Windows.Forms.RadioButton radioButtonCreateView;
        private System.Windows.Forms.Label viewlabel;
    }
}