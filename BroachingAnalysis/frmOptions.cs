using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


/*
 * 
 * BroachingAnalysis
 * 
 * */


namespace BroachingAnalysis
{
    public partial class frmOptions : Form
    {

        static List<string[]> parts;

        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            //Set the default size and statuses
            gbAdvanced.Visible = false;
            this.Width = 300;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;

            //Populate the dropdown list from csv
            populateDropdown();

            //Populate other things from current variables
            txtRingcount.Text = GlobVar.setRingsize.ToString();

            //check to see if we have already started a process
            if (GlobVar.started == true)
            {
                cbPartNo.Enabled = false;
            }

        }

        /// <summary>
        /// Populate the drop down lists on the form from the csv file
        /// </summary>
        private void populateDropdown()
        {
            cbPartNo.Items.Clear();
            cbPartSelect.Items.Clear();

            parts = parseCSV("parts.csv");
            foreach (string[] row in parts)
            {
                cbPartNo.Items.Add(row[0]);
                cbPartSelect.Items.Add(row[0]);
            }
        }


        private void llblOptionsAdv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //load the password form
            Form FormPassword = new frmPassword();
            //if the form has returned okay (password is right)
            if (FormPassword.ShowDialog() == DialogResult.OK)
            {
                 //make the form bigger so that advanced options can be seen
                this.Width = 410;
                gbAdvanced.Visible = true;
                llblOptionsAdv.Visible = false;

            }
            //Load advanced options
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            //Ask for confirmation so nothing stupid happens
            if (MessageBox.Show("Really Zero your values?", "Confirm the zeroing of values", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Move our last offset back one incase we want to undo this
                GlobVar.zeroOffset2 = GlobVar.zeroOffset1;
                //Set the new offset
                GlobVar.zeroOffset1 = GlobVar.locationSensor;
                //Work out the new calc value
                GlobVar.locationCalc = GlobVar.locationSensor - GlobVar.zeroOffset1;
                //Say that we have zeroed the values
            }

        }
        public List<string[]> parseCSV(string path)
        {
            List<string[]> parsedData = new List<string[]>();

            try
            {
                using (StreamReader readFile = new StreamReader(path))
                {
                    string line;
                    string[] row;

                    while ((line = readFile.ReadLine()) != null)
                    {
                        row = line.Split(',');
                        parsedData.Add(row);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return parsedData;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //Apply the settings
            GlobVar.setRingsize = int.Parse(txtRingcount.Text);
            GlobVar.partNumber = cbPartNo.SelectedItem.ToString();
            foreach (string[] row in parts)
            {
                //if the row in csv is equal to the selected part number
                if( row[0] == GlobVar.partNumber)
                {
                    //set the other attributes to global variable
                    GlobVar.partSlots = Convert.ToInt32(row[1]);
                    GlobVar.partSteels = Convert.ToInt32(row[3]);
                    GlobVar.partTollerance = Convert.ToDecimal(row[2])*GlobVar.setRingsize/360;
                }
            }
            //close the form
            this.Close();

        }

        private void btnUnzero_Click(object sender, EventArgs e)
        {
            //Ask for confirmation so nothing stupid happens
            if (MessageBox.Show("Really Zero your values?", "Confirm the zeroing of values", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //switch the offset back to the last one
                GlobVar.zeroOffset1 = GlobVar.zeroOffset2;
                //clear the old variable
                GlobVar.zeroOffset2 = 0;
                //Work out the new calc value
                GlobVar.locationCalc = GlobVar.locationSensor - GlobVar.zeroOffset1;
            }
        }

        private void cbPartSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
                parts = parseCSV("parts.csv");
                foreach (string[] row in parts)
                {
                    //Set the text boxes
                    if (cbPartSelect.SelectedItem.ToString() == row[0].ToString())
                    {
                        txtPartno.Text = row[0];
                        txtSlots.Text = row[1];
                        txtSteel.Text = row[3];
                        txtTolerance.Text = row[2];
                    }
                }
        }

        /// <summary>
        /// Triggered for steels, partno, slots, tollerance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPart_TextChanged(object sender, EventArgs e)
        {
            //if all boxes have a value
            if (txtPartno.Text.Length > 0 && txtSlots.Text.Length > 0 && txtSteel.Text.Length > 0 && txtTolerance.Text.Length > 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }

            //check to see if the partno entered is in the list
            //if it is then we shoukld be able to delete
            if (cbPartSelect.Text == txtPartno.Text)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //If part number already exists
            if (cbPartNo.Items.Contains(txtPartno.Text))
            {
                MessageBox.Show("This part number already exists");
            }
            else
            {

                //Write the new item to the file
                using (StreamWriter w = File.AppendText("parts.csv"))
                {
                    w.WriteLine(txtPartno.Text + "," + txtSlots.Text + "," + txtTolerance.Text + "," + txtSteel.Text);
                    w.Flush();
                    w.Close();
                }
                //Clear all of the txt boxes so we know it has happened
                txtPartno.Text = "";
                txtSlots.Text = "";
                txtSteel.Text = "";
                txtTolerance.Text = "";

                //Refresh the cb list
                populateDropdown();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string line = null;
            string line_start_to_delete = txtPartno.Text+",";

            File.Move("parts.csv", "parts.csv.tmp");

            using (StreamReader reader = new StreamReader("parts.csv.tmp"))
            {
                using (StreamWriter writer = new StreamWriter("parts.csv"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.StartsWith(line_start_to_delete) == true)
                            continue;

                        writer.WriteLine(line);
                    }
                }
            }

            //Rename the temp file
            //But only if our new file has actually being created
            if (File.Exists("parts.csv"))
            {
                File.Delete("parts.csv.tmp");
            }
            else
            {
                File.Move("parts.csv.tmp", "parts.csv");
                MessageBox.Show("Something went wrong");
            }

            //Populate the cb list
            populateDropdown();
        }

        private void txtPartno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtSlots_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow numbers to be entered here
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTolerance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtSteel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow numbers to be entered here
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRingcount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow numbers to be entered here
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
