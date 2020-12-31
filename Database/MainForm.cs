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
using Microsoft.Office.Interop.Excel;


namespace Database
{
    public partial class MainForm : System.Windows.Forms.Form
    {

        bool insert = false, print = false, delete = false, trigger = false, update = false, move, insertcity = false, updatecity = false, insertcountry = false, updatecountry = false, insertcountrylanguage = false, updatecountrylanguage = false, view_flag = false, max_flag = false, min_flag = false;
        int posX, posY, flagInsert, flagUpdate;

        readonly MySqlConnection connect = new MySqlConnection("server = address; user id = '"+Login.userText+"' ; password ='"+Login.passText+"'; database=nameofdatabse");
        readonly System.Data.DataTable dataTable = new System.Data.DataTable();
        //Variables and Connection
        public MainForm()
        {
            InitializeComponent();
            connectedPeople.Text = "Username: " + Login.userText;
        }   // Initialize Main Form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connect.Close();
            System.Windows.Forms.Application.Exit();
        }   // Close any open connection and close the application
        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application exc = new Microsoft.Office.Interop.Excel.Application();

            Workbook workbook = exc.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet worksheet = (Worksheet)exc.ActiveSheet;
            exc.Visible = true;

            for (int i = 1; i < dataGridViewData.Columns.Count + 1; i++)
                exc.Cells[1, i] = dataGridViewData.Columns[i - 1].HeaderText;

            for (int i = 0; i < dataGridViewData.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewData.Columns.Count; j++)
                    exc.Cells[i + 2, j + 1] = dataGridViewData.Rows[i].Cells[j].Value.ToString();
            }
        }   // Export to Excel the selected table
        private void Menu_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            posX = e.X;
            posY = e.Y;
        }
        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.SetDesktopLocation(MousePosition.X - posX, MousePosition.Y - posY);
        }   // Move the Main Form 
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Created by:\nΝικόλαος Μικρού \nΑΕΜ: 2563");
        }   // Information about the application
        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTable.SelectedIndex == 0)
            {
                textboxID.Enabled = true;
                textboxName.Enabled = true;
                textboxCountryCode.Enabled = true;
                textboxDistrict.Enabled = true;
                textboxPopulation.Enabled = true;
                textboxLanguage.Enabled = false;
                textboxIsOfficial.Enabled = false;
                textboxPercentage.Enabled = false;
                textboxContinent.Enabled = false;
                textboxRegion.Enabled = false;
                textboxSurfaceArea.Enabled = false;
                textboxLocalName.Enabled = false;
                textboxGovernmentForm.Enabled = false;
                textboxHeadofState.Enabled = false;
                textboxLifeExpectancy.Enabled = false;
            }
            else if (comboBoxTable.SelectedIndex == 1)
            {
                textboxID.Enabled = false;
                textboxName.Enabled = true;
                textboxCountryCode.Enabled = true;
                textboxDistrict.Enabled = false;
                textboxPopulation.Enabled = true;
                textboxLanguage.Enabled = false;
                textboxIsOfficial.Enabled = false;
                textboxPercentage.Enabled = false;
                textboxContinent.Enabled = true;
                textboxRegion.Enabled = true;
                textboxSurfaceArea.Enabled = true;
                textboxLocalName.Enabled = true;
                textboxGovernmentForm.Enabled = true;
                textboxHeadofState.Enabled = true;
                textboxLifeExpectancy.Enabled = true;
            }
            else if (comboBoxTable.SelectedIndex == 2)
            {
                textboxID.Enabled = false;
                textboxName.Enabled = false;
                textboxCountryCode.Enabled = true;
                textboxDistrict.Enabled = false;
                textboxPopulation.Enabled = false;
                textboxLanguage.Enabled = true;
                textboxIsOfficial.Enabled = true;
                textboxPercentage.Enabled = true;
                textboxContinent.Enabled = false;
                textboxRegion.Enabled = false;
                textboxSurfaceArea.Enabled = false;
                textboxLocalName.Enabled = false;
                textboxGovernmentForm.Enabled = false;
                textboxHeadofState.Enabled = false;
                textboxLifeExpectancy.Enabled = false;
            }

            Showkey();
            if (trigger)
                CreateTrigger();
        }   // Actions when selected box text is changed
        private void radioButtonInsert_Click(object sender, EventArgs e)
        {
            insert = true;
            print = false;
            delete = false;
            trigger = false;
            update = false;
            BtnAction.Enabled = true;
            radioButtonTrigger.Enabled = true;

            flagInsert = 1;
            flagUpdate = 0;

            pictureBoxID.Visible = false;
            pictureBoxCountryCode.Visible = false;
        }
        private void radioButtonPrint_Click(object sender, EventArgs e)
        {
            insert = false;
            print = true;
            delete = false;
            trigger = false;
            update = false;
            BtnAction.Enabled = true;
            radioButtonTrigger.Enabled = false;

            pictureBoxID.Visible = false;
            pictureBoxCountryCode.Visible = false;
        }
        private void radioButtonDelete_Click(object sender, EventArgs e)
        {
            insert = false;
            print = false;
            delete = true;
            trigger = false;
            update = false;
            BtnAction.Enabled = true;
            radioButtonTrigger.Enabled = false;

            pictureBoxID.Visible = false;
            pictureBoxCountryCode.Visible = false;
        }
        private void radioButtonTrigger_Click(object sender, EventArgs e)
        {
            insert = false;
            print = false;
            delete = false;
            trigger = true;
            update = false;
            BtnAction.Enabled = true;

            pictureBoxID.Visible = false;
            pictureBoxCountryCode.Visible = false;
        }
        private void radioButtonUpdate_Click(object sender, EventArgs e)
        {
            insert = false;
            print = false;
            delete = false;
            trigger = false;
            update = true;
            BtnAction.Enabled = true;
            radioButtonTrigger.Enabled = true;

            flagInsert = 0;
            flagUpdate = 1;

            Showkey();
        }
        private void radioButtonMaxPopulation_Click(object sender, EventArgs e)
        {
            Btn_Procedure.Enabled = true;
            max_flag = true;
            min_flag = false;

            string procedure = "CREATE DEFINER =`nikomikr`@`%` PROCEDURE `Disp_Max_Population`(OUT MAX_POPULATION INT) " +
                              "SELECT max(Population) into MAX_POPULATION FROM City";           

            beginTransaction(procedure);
            BtnClear1.Enabled = true;
            radioButtonMinPopulation.Enabled = false;
        }
        private void radioButtonMinPopulation_Click(object sender, EventArgs e)
        {
            Btn_Procedure.Enabled = true;
            min_flag = true;
            max_flag = false;

            string procedure = "CREATE DEFINER =`nikomikr`@`%` PROCEDURE `Disp_Min_Population`(OUT MIN_POPULATION INT) " +
                               "SELECT min(Population) into MIN_POPULATION FROM City";

            beginTransaction(procedure);
            BtnClear1.Enabled = true;
            radioButtonMaxPopulation.Enabled = false;
        }
        private void radioButtonCreateView_Click(object sender, EventArgs e)
        {
            view_flag = true;
            string view = "CREATE VIEW City_Pop AS SELECT Name FROM City WHERE Population > 10000";
            executeQuery(view);

            Btn_Create_View.Enabled = true;
            BtnClear2.Enabled = true;
        }   // Actions when radio buttons are clicked
        private void Showkey()
        {
            if (comboBoxTable.SelectedIndex == 0)
            {
                if (update)
                {
                    pictureBoxID.Visible = true;
                    pictureBoxCountryCode.Visible = false;
                }
            }
            else if (comboBoxTable.SelectedIndex == 1)
            {
                if (update)
                {
                    pictureBoxCountryCode.Visible = true;
                    pictureBoxID.Visible = false;
                }
            }
            else if (comboBoxTable.SelectedIndex == 2)
            {
                if (update)
                {
                    pictureBoxCountryCode.Visible = true;
                    pictureBoxID.Visible = false;
                }
            }
        }   // Show the picture box when update radio button is clicked
        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (insert)
                Insert();
            else if (print)
                dataGridViewData.DataSource = getTableData();
            else if (delete)
                Delete();
            else if (trigger)
                CreateTrigger();
            else if (update)
                UpdateData();     
        }   // All basic actions are called when GO button is clicked
        private void BtnClear_Click(object sender, EventArgs e)
        {
            dataGridViewData.DataSource = null;

            comboBoxTable.Text = "";
            textboxID.Text = "";
            textboxName.Text = "";
            textboxCountryCode.Text = "";
            textboxDistrict.Text = "";
            textboxPopulation.Text = "";
            textboxLanguage.Text = "";
            textboxIsOfficial.Text = "";
            textboxPercentage.Text = "";
            textboxContinent.Text = "";
            textboxRegion.Text = "";
            textboxSurfaceArea.Text = "";
            textboxLocalName.Text = "";
            textboxGovernmentForm.Text = "";
            textboxHeadofState.Text = "";
            textboxLifeExpectancy.Text = "";
            triggerLabel.Text = "";
            pictureBoxID.Visible = false;
            pictureBoxCountryCode.Visible = false;

            radioButtonInsert.Checked = false;
            radioButtonDelete.Checked = false;
            radioButtonPrint.Checked = false;
            radioButtonUpdate.Checked = false;
            radioButtonTrigger.Checked = false;
        }   // Clear the textboxs and datagridview
        private void BtnDropTriger_Click(object sender, EventArgs e)
        {
            triggerLabel.Text = "";
            if (insertcity)
            {
                insertcity = false;
                string deleteTrigger = "DROP TRIGGER nikomikr_trig1_insertcity";
                dropTrigger(deleteTrigger);
            }
            if (updatecity)
            {
                updatecity = false;
                string deleteTrigger = "DROP TRIGGER nikomikr_trig2_updatecity";
                dropTrigger(deleteTrigger);
            }
            if (insertcountry)
            {
                insertcountry = false;
                string deleteTrigger = "DROP TRIGGER nikomikr1_trig3_insertcountry";
                dropTrigger(deleteTrigger);
            }
            if (updatecountry)
            {
                updatecountry = false;
                string deleteTrigger = "DROP TRIGGER nikomikr_trig4_updatecountry";
                dropTrigger(deleteTrigger);
            }
            if (insertcountrylanguage)
            {
                insertcountrylanguage = false;
                string deleteTrigger = "DROP TRIGGER nikomikr_trig5_insertcountrylanguage";
                dropTrigger(deleteTrigger);
            }
            if (updatecountrylanguage)
            {
                updatecountrylanguage = false;
                string deleteTrigger = "DROP TRIGGER nikomikr_trig1_updatecountrylanguage";
                dropTrigger(deleteTrigger);
            }
        }   // Drop any trigger which is enabled
        private void Btn_Procedure_Click(object sender, EventArgs e)
        {
            if (radioButtonMaxPopulation.Checked)
            {
                string call = "CALL Disp_Max_Population(@'Population')";
                executeQuery(call);
            }
            else if (radioButtonMinPopulation.Checked)
            {
                string call = "CALL Disp_Min_Population(@'Population')";
                executeQuery(call);
            }
                   
            dataGridViewMaxPopulation.DataSource = printPopulation();
        }   // Make the call and print into datagridview
        private void Btn_Create_View_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = printView();
        }   // Call the function that print into the datagridview
        private void Insert()
        {
            if (comboBoxTable.SelectedIndex == 0)
            {
                string insertQuery = "INSERT INTO City(ID, Name, CountryCode, District, Population) VALUES('" + textboxID.Text + "', '" + textboxName.Text + "','" + textboxCountryCode.Text + "','" + textboxDistrict.Text + "','" + textboxPopulation.Text + "')";
                executeQuery(insertQuery);
            }
            else if (comboBoxTable.SelectedIndex == 1)
            {
                string insertQuery = "INSERT INTO Country(Code, Name, Continent, Region, SurfaceArea, Population, LifeExpectancy, LocalName, GovernmentForm, HeadOfState) VALUES('" + textboxCountryCode.Text + "', '" + textboxName.Text + "','" + textboxContinent.Text + "','" + textboxRegion.Text + "','" + textboxSurfaceArea.Text + "', '" + textboxPopulation.Text + "', '" + textboxLifeExpectancy.Text + "','" + textboxLocalName.Text + "', '" + textboxGovernmentForm.Text + "', '" + textboxHeadofState.Text + "')";
                executeQuery(insertQuery);
            }
            else if (comboBoxTable.SelectedIndex == 2)
            {
                string insertQuery = "INSERT INTO CountryLanguage(CountryCode, Language, IsOfficial, Percentage) VALUES('" + textboxCountryCode.Text + "','" + textboxLanguage.Text + "','" + textboxIsOfficial.Text + "', '" + textboxPercentage.Text + "')";
                executeQuery(insertQuery);
            }
        }   // Insert into selected table (INSERT QUERY)
        private System.Data.DataTable getTableData()
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();
            openConnection();

            if (comboBoxTable.SelectedIndex == 0)
            {
                string selectQuery = "SELECT * FROM City";

                MySqlCommand command = new MySqlCommand(selectQuery, connect);
                MySqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
            }
            else if (comboBoxTable.SelectedIndex == 1)
            {
                string selectQuery = "SELECT * FROM Country";

                MySqlCommand command = new MySqlCommand(selectQuery, connect);
                MySqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
            }
            else if (comboBoxTable.SelectedIndex == 2)
            {
                string selectQuery = "SELECT * FROM CountryLanguage";

                MySqlCommand command = new MySqlCommand(selectQuery, connect);
                MySqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
            }
            closeConnection();
            return dataTable;
        }   // Print table into datagridview (SELECT QUERY)
        private System.Data.DataTable printView()
        {
            System.Data.DataTable dataTableView = new System.Data.DataTable();
            string select = "SELECT * FROM City_Pop";
            openConnection();

            MySqlCommand command = new MySqlCommand(select, connect);
            MySqlDataReader reader2 = command.ExecuteReader();
            dataTableView.Load(reader2);

            return dataTableView;
        }   // Print view into datagridview
        private void Delete()
        {
            if (comboBoxTable.SelectedIndex == 0)
            {
                string deleteQuery = "DELETE FROM City WHERE ID=" + int.Parse(textboxID.Text);
                executeQuery(deleteQuery);
            }
            else if (comboBoxTable.SelectedIndex == 1)
            {
                string deleteQuery = "DELETE FROM Country WHERE Code='" + textboxCountryCode.Text + "' ";
                executeQuery(deleteQuery);
            }
            else if (comboBoxTable.SelectedIndex == 2)
            {
                string deleteQuery = "DELETE FROM CountryLanguage WHERE CountryCode='" + textboxCountryCode.Text + "' AND Language = '" + textboxLanguage.Text + "' ";
                executeQuery(deleteQuery);
            }
        }   // Delete one selected row from table (DELETE QUERY)
        private void CreateTrigger()
        {
            if (comboBoxTable.SelectedIndex == 0)
            {
                if (flagInsert == 1)
                {
                    insertcity = true;
                    triggerLabel.Text = "(Insert)";
                    string triger = "CREATE TRIGGER nikomikr_trig1_insertcity AFTER INSERT ON City " +
                                    "FOR EACH ROW " +
                                    "INSERT INTO Trig_Table_Mikrou (UserName,Clock,Actions,TableUse) VALUES(USER(),NOW(),'Insert', 'City') ";
                    executeTriger(triger);
                }
                else if (flagUpdate == 1)
                {
                    updatecity = true;
                    triggerLabel.Text = "(Update)";
                    string triger = "CREATE TRIGGER nikomikr_trig2_updatecity AFTER UPDATE ON City " +
                                    "FOR EACH ROW " +
                                    "INSERT INTO Trig_Table_Mikrou (UserName,Clock,Actions,TableUse) VALUES(USER(),NOW(),'Update', 'City') ";
                    executeTriger(triger);
                }
            }
            else if (comboBoxTable.SelectedIndex == 1)
            {
                if (flagInsert == 1)
                {
                    insertcountry = true;
                    triggerLabel.Text = "(Insert)";
                    string triger = "CREATE TRIGGER nikomikr_trig3_insertcountry AFTER INSERT ON Country " +
                                    "FOR EACH ROW " +
                                    "INSERT INTO Trig_Table_Mikrou (UserName,Clock,Actions,TableUse) VALUES(USER(),NOW(),'Insert', 'Country') ";
                    executeTriger(triger);
                }
                else if (flagUpdate == 1)
                {
                    updatecountry = true;
                    triggerLabel.Text = "(Update)";
                    string triger = "CREATE TRIGGER nikomikr_trig4_updatecountry AFTER UPDATE ON Country " +
                                    "FOR EACH ROW " +
                                    "INSERT INTO Trig_Table_Mikrou (UserName,Clock,Actions,TableUse) VALUES(USER(),NOW(),'Update', 'Country') ";
                    executeTriger(triger);
                }
            }
            else if (comboBoxTable.SelectedIndex == 2)
            {
                if (flagInsert == 1)
                {
                    insertcountrylanguage = true;
                    triggerLabel.Text = "(Insert)";
                    string triger = "CREATE TRIGGER nikomikr_trig5_insertcountrylanguage AFTER INSERT ON CountryLanguage " +
                                    "FOR EACH ROW " +
                                    "INSERT INTO Trig_Table_Mikrou (UserName,Clock,Actions,TableUse) VALUES(USER(),NOW(),'Insert', 'Country Language') ";
                    executeTriger(triger);
                }
                else if (flagUpdate == 1)
                {
                    updatecountrylanguage = true;
                    triggerLabel.Text = "(Update)";
                    string triger = "CREATE TRIGGER nikomikr_trig1_updatecountrylanguage AFTER UPDATE ON CountryLanguage " +
                                    "FOR EACH ROW " +
                                    "INSERT INTO Trig_Table_Mikrou (UserName,Clock,Actions,TableUse) VALUES(USER(),NOW(),'Update', 'Country Language') ";
                    executeTriger(triger);
                }
            }
        }   // Create triggers (TRIGGERS QUERY)
        private void UpdateData()
        {
            if (comboBoxTable.SelectedIndex == 0)
            {              
                string updateQuery = "UPDATE City SET Name='" + textboxName.Text + "', CountryCode='" + textboxCountryCode.Text + "', District='" + textboxDistrict.Text + "', Population='" + textboxPopulation.Text + "' WHERE ID=" + int.Parse(textboxID.Text);
                executeQuery(updateQuery);
            }
            else if (comboBoxTable.SelectedIndex == 1)
            {
                textboxCountryCode.Enabled = false;
                string updateQuery = "UPDATE Country SET Name='" + textboxName.Text + "', Continent='" + textboxContinent.Text + "', Region='" + textboxRegion.Text + "', SurfaceArea='" + textboxSurfaceArea.Text + "', Population='" + textboxPopulation.Text + "', LifeExpectancy='" + textboxLifeExpectancy.Text + "', LocalName='" + textboxLocalName.Text + "', GovernmentForm='" + textboxGovernmentForm.Text + "', HeadOfState='" + textboxHeadofState.Text + "' WHERE Code='" + textboxCountryCode.Text + "';";
                executeQuery(updateQuery);
            }
            else if (comboBoxTable.SelectedIndex == 2)
            {
                string updateQuery = "UPDATE CountryLanguage SET CountryCode='" + textboxCountryCode.Text + "', Language='" + textboxLanguage.Text + "', IsOfficial= '" + textboxIsOfficial.Text + "', Percentage= '" + textboxPercentage.Text + "' WHERE CountryCode='" + textboxCountryCode.Text + "';";
                executeQuery(updateQuery);
            }
        }   // Update columns from one selected row (UPDATE QUERY)
        private void dataGridViewData_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (comboBoxTable.SelectedIndex == 0)
            {
                textboxID.Text = dataGridViewData.CurrentRow.Cells[0].Value.ToString();
                textboxName.Text = dataGridViewData.CurrentRow.Cells[1].Value.ToString();
                textboxCountryCode.Text = dataGridViewData.CurrentRow.Cells[2].Value.ToString();
                textboxDistrict.Text = dataGridViewData.CurrentRow.Cells[3].Value.ToString();
                textboxPopulation.Text = dataGridViewData.CurrentRow.Cells[4].Value.ToString();
            }
            else if (comboBoxTable.SelectedIndex == 1)
            {
                textboxCountryCode.Text = dataGridViewData.CurrentRow.Cells[0].Value.ToString();
                textboxName.Text = dataGridViewData.CurrentRow.Cells[1].Value.ToString();
                textboxContinent.Text = dataGridViewData.CurrentRow.Cells[2].Value.ToString();
                textboxRegion.Text = dataGridViewData.CurrentRow.Cells[3].Value.ToString();
                textboxSurfaceArea.Text = dataGridViewData.CurrentRow.Cells[4].Value.ToString();
                textboxPopulation.Text = dataGridViewData.CurrentRow.Cells[6].Value.ToString();
                textboxLifeExpectancy.Text = dataGridViewData.CurrentRow.Cells[7].Value.ToString();
                textboxLocalName.Text = dataGridViewData.CurrentRow.Cells[10].Value.ToString();
                textboxGovernmentForm.Text = dataGridViewData.CurrentRow.Cells[11].Value.ToString();
                textboxHeadofState.Text = dataGridViewData.CurrentRow.Cells[12].Value.ToString();
            }
            else if (comboBoxTable.SelectedIndex == 2)
            {
                textboxCountryCode.Text = dataGridViewData.CurrentRow.Cells[0].Value.ToString();
                textboxLanguage.Text = dataGridViewData.CurrentRow.Cells[1].Value.ToString();
                textboxIsOfficial.Text = dataGridViewData.CurrentRow.Cells[2].Value.ToString();
                textboxPercentage.Text = dataGridViewData.CurrentRow.Cells[3].Value.ToString();
            }
        }   // Enable or disable textboxs when user click on datagridview
        private void openConnection()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
        }   // Function when we want to open the connection
        private void closeConnection()
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
        }   // Function when we want to close the connection
        private void executeQuery(string query)
        {
            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand(query, connect);

                if (command.ExecuteNonQuery() == 1 || view_flag || min_flag || max_flag)
                    System.Windows.Forms.MessageBox.Show("Query Executed!");
                else
                    System.Windows.Forms.MessageBox.Show("Query Not Executed!");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }   // Function which execute queries, such as insert, delete, print and update
        private void executeTriger(string trigger)
        {
            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand(trigger, connect);
                if (command.ExecuteNonQuery() == 0)
                    System.Windows.Forms.MessageBox.Show("Query Executed!");
                else
                    System.Windows.Forms.MessageBox.Show("Query Not Executed!");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }   // Function which create the triggers
        private void dropTrigger(string drop)
        {
            openConnection();

            try
            {
                MySqlCommand command = new MySqlCommand(drop, connect);
                if (command.ExecuteNonQuery() == 0)
                    System.Windows.Forms.MessageBox.Show("Query Executed!");
                else
                    System.Windows.Forms.MessageBox.Show("Query Not Executed!");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }   // Function which drop the triggers
        private void beginTransaction(string query)
        {
            try
            {
                openConnection();
                MySqlTransaction transaction = connect.BeginTransaction();
                MySqlCommand command = connect.CreateCommand();
                command.CommandText = query;

                if(command.ExecuteNonQuery() == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Procedure is created!");
                    transaction.Commit();
                }
                else
                    System.Windows.Forms.MessageBox.Show("Procedure failed!");
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }   // Function which begin transaction (PROCEDURE)
        private System.Data.DataTable printPopulation()
        {
            System.Data.DataTable dataTablePopulation = new System.Data.DataTable();
            string select_variable = "SELECT @'Population'";
            openConnection();

            MySqlCommand command = new MySqlCommand(select_variable, connect);
            MySqlDataReader reader1 = command.ExecuteReader();
            dataTablePopulation.Load(reader1);

            return dataTablePopulation;
        }   // Print procedure's results
        private void BtnClear1_Click(object sender, EventArgs e)
        {
            radioButtonMaxPopulation.Checked = false;
            radioButtonMinPopulation.Checked = false;
            radioButtonMinPopulation.Enabled = true;
            radioButtonMaxPopulation.Enabled = true;
            dataGridViewMaxPopulation.DataSource = null;
            Btn_Procedure.Enabled = false;
            BtnClear1.Enabled = false;

            if (min_flag)
            {
                string deleteProcedure = "DROP PROCEDURE Disp_Min_Population";
                executeQuery(deleteProcedure);
            }
            else if(max_flag)
            {
                string deleteProcedure = "DROP PROCEDURE Disp_Max_Population";
                executeQuery(deleteProcedure);
            }

            min_flag = max_flag = false;
        }   // Restore the form and drop the procedures
        private void BtnClear2_Click(object sender, EventArgs e)
        {
            string deleteView = "DROP VIEW City_Pop";
            executeQuery(deleteView);

            view_flag = false;
            radioButtonCreateView.Checked = false;
            dataGridView.DataSource = null;
            Btn_Create_View.Enabled = false;
            BtnClear2.Enabled = false;
        }   // Clear the view box and drop the view
    }
}