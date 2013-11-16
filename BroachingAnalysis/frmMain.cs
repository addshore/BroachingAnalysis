using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace BroachingAnalysis
{

    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            //Create the thread for our port connection
            Thread t = new Thread(new ThreadStart(workerConnection_DoWork));
            //make sure it is in the background
            t.IsBackground = true;
            //Start it
            t.Start();

            //Check to see if our runs folder exists , if not then create it
            if(Directory.Exists("runs") == false)
            {
                Directory.CreateDirectory("runs");
            }

            //Check to see if the parts file exists (if not make it)
            if (File.Exists("parts.csv") == false)
            {
                File.Create("parts.csv").Dispose();
            }

            //Set instruction
            lblInstructions.Text = "Please select a part from the options menu";

        }

        /// <summary>
        /// On form close close the stuff we need to close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //dispose of the worker
            this.Dispose();
            workerConnection.Dispose();
        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            //Check if we are ready
            checkIfReady();
        }

        //If debug then we need to watch the text box for changes
#if DEBUG
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                GlobVar.locationSensor = int.Parse(textBox1.Text);
                sensorLocationUpdated();//run the stuff we need to in the function
            }
        }
#endif

        private void txtSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow numbers to be entered here
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Invoke if required used for cross thread stuff
        /// </summary>
        /// <param name="target"></param>
        /// <param name="methodToInvoke"></param>
        /// http://stackoverflow.com/questions/11842373/changing-a-form-from-a-separate-background-worker
        private void InvokeIfRequired(Control target, Delegate methodToInvoke)
        {
            if (target.InvokeRequired)
                target.Invoke(methodToInvoke);
            else
                methodToInvoke.DynamicInvoke();
        }

        /// <summary>
        /// Loads the Options form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void btnOptions_Click(object sender, EventArgs e)
         {
             //Keep the current part in a temp variable
             string partCurrent = GlobVar.partNumber;
             //Load the options form
             Form FormOptions = new frmOptions();
             FormOptions.ShowDialog();

             //When the dialog returns if the part number has changed
             if (partCurrent != GlobVar.partNumber)
             {
                 //Reset the data values in the form
                 lblPartnoValue.Text = GlobVar.partNumber;
                 lblSlotnoValue.Text = GlobVar.partSlots.ToString();
                 lblSteelnoValue.Text = GlobVar.partSteels.ToString();
                 //Set the max positions
                 lblSlotnoMax.Text = GlobVar.partSlots.ToString();
                 lblSteelnoMax.Text = GlobVar.partSteels.ToString();
             }
             //Check if we are ready to go!
             checkIfReady();
         }

        /// <summary>
        /// Either advance the process or start the process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void btnAdvance_Click(object sender, EventArgs e)
         {
             //TODO on start add titles
             if (txtSerial.Visible == true)
             {
                 if(File.Exists("runs/"+txtSerial.Text+".csv") == true)
                 {
                     MessageBox.Show("Part with this serial has already been created");
                 }
                 else
                 {
                     //On first run we need to save the serial
                     lblInstructions.Text = "Please put the part into the first position";
                     btnAdvance.Text = "Advance";
                     GlobVar.started = true;
                     GlobVar.partSerial = txtSerial.Text;
                     lblSerialnoValue.Text = GlobVar.partSerial;
                     txtSerial.Visible = false;

                     //reset and show our current position
                     GlobVar.currentSlot = 1;
                     lblSlotnoValue.Text = GlobVar.currentSlot.ToString();
                     GlobVar.currentSteel = 1;
                     lblSteelnoValue.Text = GlobVar.currentSteel.ToString();


                     //Set the bands for our progress bars
                     pbLower.Maximum = GlobVar.setRingsize / GlobVar.partSlots;
                     pbUpper.Maximum = GlobVar.setRingsize / GlobVar.partSlots;
                     pbInLower.Maximum = (int)GlobVar.partTollerance;
                     pbInUpper.Maximum = (int)GlobVar.partTollerance;

                     //Start our file
                     File.Create("runs/"+GlobVar.partSerial + ".csv").Dispose();

                     //open the file
                     using (StreamWriter w = File.AppendText("runs/" + GlobVar.partSerial + ".csv"))
                     {
               
                         //Write the headings
                         w.WriteLine("DateTime,Part No,Part Tolerance,Part Steels,Part Slots,"
                         + "Steel Actual,Slot Actual,Lower Bound,Upper Bound,Nominal Position,Actual Position");

                         w.Flush();
                         w.Close();
                    }

                 }
             }
             else
             {
                 //Normal advance
                 lblInstructions.Text = "Please put the part into the next position";

                 //Write the advance to the run file
                 //Write the new item to the file
                 using (StreamWriter w = File.AppendText("runs/" + GlobVar.partSerial + ".csv"))
                 {
               
                     //Copied from sensor refresh
                     //GlobVar.locationCalc = GlobVar.locationSensor - GlobVar.zeroOffset1;
                     //eachpoint was GlobVar.setRingsize / GlobVar.partSlots

                     //FIX 1 Location is calculated as a decimal before it is converted to an int
                     //FIX on 28/09/2012 - 12:53
                     decimal currslotlocdec = (decimal)GlobVar.setRingsize / (decimal)GlobVar.partSlots * (decimal)GlobVar.currentSlot;
                     int currslotloc = (int)Math.Round(currslotlocdec, 0, MidpointRounding.AwayFromZero); 

                     int lower = currslotloc - (Convert.ToInt32(Math.Round(GlobVar.partTollerance,1,MidpointRounding.AwayFromZero)));
                     int higher = currslotloc + ( Convert.ToInt32(Math.Truncate(GlobVar.partTollerance)));

                     w.WriteLine(DateTime.Now + "," +
                         GlobVar.partNumber.ToString() + "," +
                         GlobVar.partTollerance.ToString() + "," +
                         GlobVar.partSteels.ToString() + "," +
                         GlobVar.partSlots.ToString() + "," +
                         GlobVar.currentSteel.ToString() + "," +
                         GlobVar.currentSlot.ToString() + "," +
                         lower.ToString() + "," +
                         higher.ToString() + "," +
                         currslotloc.ToString() + "," +
                         GlobVar.locationCalc.ToString());

                     w.Flush();
                     w.Close();

                 }

                 //If we have just done the last slot
                 if (GlobVar.currentSlot == GlobVar.partSlots)
                 {
                     //If we still have steel sets to go
                     if (GlobVar.currentSteel != GlobVar.partSteels)
                     {
                         //Advance by one
                         GlobVar.currentSlot = 1;
                         GlobVar.currentSteel = GlobVar.currentSteel + 1;
                         lblInstructions.Text = "Please load new steel before locating the next slot";
                     }
                     else
                     {
                         //Show that we are done and dont let them advance
                         MessageBox.Show("Done");
                         btnAdvance.Enabled = false;
                         lblInstructions.Text = "Part complete";
                     }
                 }
                 else
                 {
                     //Do a regular + 1 to the slot
                     GlobVar.currentSlot = GlobVar.currentSlot + 1;
                 }

                 //If this is now the last slot
                 if(GlobVar.currentSlot == GlobVar.partSlots && GlobVar.currentSteel == GlobVar.partSteels)
                 {
                     btnAdvance.Text = "Complete";
                     lblInstructions.Text = "Please locate the final slot before saving the position";
                 }

                 //Update the UI
                 lblSlotnoValue.Text = GlobVar.currentSlot.ToString();
                 lblSteelnoValue.Text = GlobVar.currentSteel.ToString();

                 sensorLocationUpdated();
             }

         }

         private void checkIfReady()
         {
             //if there is a serial then enable the advance button (or start)
             if (txtSerial.Text.Length != 0 && GlobVar.partNumber != "")
             {
                 //We are ready to go
                 btnAdvance.Enabled = true;
                 lblInstructions.Text = "Click the start button to start the process";
             }
             else
             {
                 //We probably still the need S/N or part
                 btnAdvance.Enabled = false;
                 lblInstructions.Text = "Please ensure you have selected a part number and entered a S/N";
             }
         }

         /// <summary>
         /// Work to be done in the thread, called directly from thread
         /// Tries to find device and then connects requestion location
         /// </summary>
         private void workerConnection_DoWork()
         {
             //Try to find our device in a new thread
             tsStatus.Text = "Searching for device...";

             //While the port connection is not started
             while (portConnection.PortName == "NULL")
             {
                 try
                 {
                     //Search for the COM port in our list
                     ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_SerialPort");
                     //For each port in the list
                     foreach (ManagementObject queryObj in searcher.Get())
                     {
                         //If the description matches that of the sensor
                         if (queryObj["Description"].ToString() == "STMicroelectronics Virtual COM Port")
                         {
                             //Then its the port we want to use so add it to the connection
                             portConnection.PortName = queryObj["DeviceID"].ToString();
                             //Open the port
                             portConnection.Open();
                             tsStatus.Text = "Connected to " + portConnection.PortName.ToString();

                         }
                     }
                 }

                 catch (Exception ex)
                 {
                     //catch the error if we cant connect to the device on the port or something went wrong
                     MessageBox.Show("An error occoured while querying for WMI data: " + ex.Message);
                 }
             }

             //Once we have connected to a COM PORT we will reach this point

             //While the aplication is running
             while (GlobVar.running == true)
             {
                 try
                 {
                     //Request the status of the device
                     portConnection.Write("?");
                     //And wait a while so that we dont go mad
                     Thread.Sleep(50);
                 }
                 //If it fails then lets just not do anything this time
                 catch { }
             }
         }

         /// <summary>
         /// When data is received from the com port connection
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         private void portConnection_DataReceived(object sender, SerialDataReceivedEventArgs e)
         {
             //When we receive data we want to give the rest of the program access to this
             string received = portConnection.ReadExisting();
             //If it contains a : then it is probably one of the strings that we want
             if (received.Contains(":") && GlobVar.started == true)
             {
                 //Try to split the data using : and find the location
                 try
                 {
                     //Get the first part of the string (location)
                     string[] parts = received.Split(':');
                     GlobVar.locationSensor = int.Parse(parts[0]);

                     //If the program is running
                     if (GlobVar.running == true)
                     {
                         //Invoke the location update
                         InvokeIfRequired(this, new MethodInvoker(delegate() { this.sensorLocationUpdated(); }));
                     }
                 }
                 //If this fails just dont do anything
                 catch { };
             }
         }

         /// <summary>
         /// This is run everytime a new value is received for the sensor position
         /// This is invoked from the device thread
         /// </summary>
         private void sensorLocationUpdated()
         {
             //Set the global Var for where we think the sensor is with the offset
             GlobVar.locationCalc = GlobVar.locationSensor - GlobVar.zeroOffset1;
             //Work out how how far around the circle each point is
             int eachpoint = GlobVar.setRingsize / GlobVar.partSlots;

             //FIX 1 Location is calculated as a decimal before it is converted to an int
             //FIX on 28/09/2012 - 12:53
             decimal currslotlocdec = (decimal)GlobVar.setRingsize / (decimal)GlobVar.partSlots * (decimal)GlobVar.currentSlot;
             int currslotloc = (int)Math.Round(currslotlocdec, 0, MidpointRounding.AwayFromZero); 

             //THE BELOW 2 LINES WERE REMOVED in FIX 1
             //Work out where the current slot is we are working on
             //int currslotloc = (eachpoint * GlobVar.currentSlot);

             //Set the two bounds for this slot
             int lower = currslotloc - (Convert.ToInt32(Math.Round(GlobVar.partTollerance, 1, MidpointRounding.AwayFromZero)));
             int higher = currslotloc + (Convert.ToInt32(Math.Truncate(GlobVar.partTollerance)));

             //If we are in dDEBUG mode then we want to see our extra debug data
#if DEBUG
             label1.Text = currslotloc.ToString();
             label2.Text = higher.ToString();
             label3.Text = lower.ToString();
             label4.Text = GlobVar.locationCalc.ToString();
             //Auto fill the text box with the correct value
             textBox1.Text = currslotloc.ToString(); //SAVES TIME
#endif

             //If we havent started yet (current slot is 0)
             if (GlobVar.currentSlot == 0)
             {
                 //Do nothing... (TODO: Not sure why this is here)
             }
             //Else we have started
             else
             {
                 //If we are inbetween the bands
                 if (GlobVar.locationCalc <= higher && GlobVar.locationCalc >= lower)
                 {
                     //Enable the advance button
                     btnAdvance.Enabled = true;

                     //If we are below the value but in the bounds
                     if (GlobVar.locationCalc <= currslotloc)
                     {
                         //Set the progress bars
                         pbLower.Value = 0;
                         //FIX 1 This is also part of FIX 1
                         //as sometimes something is rounded up the value can be 1 above the max
                         if ((GlobVar.locationCalc - lower) > pbInLower.Maximum)
                         {
                             pbInLower.Value = pbInLower.Maximum;
                         }
                         else
                         {
                             pbInLower.Value = GlobVar.locationCalc - lower;
                         }
                         pbInUpper.Value = 0;
                         pbUpper.Value = 0;
                         trackBar.Value = 12;

                         //If we are dead on make it look gooood (light up both central bars)
                         if (currslotloc == GlobVar.locationCalc)
                         {
                             pbInUpper.Value = pbInUpper.Maximum;
                             trackBar.Value = 19;
                         }
                         else
                             //If the value is exactly on the lower bound make sure the trackbar makes this obvious
                             //This is as no progress bar will be filled
                             if (GlobVar.locationCalc == lower)
                             {
                                 trackBar.Value = 5;
                             }
                     }
                     //If we are above value but in bounds
                     else if (GlobVar.locationCalc > currslotloc)
                     {
                         //Set the progress bars
                         pbLower.Value = 0;
                         pbInLower.Value = 0;
                         pbInUpper.Value = Convert.ToInt32(GlobVar.partTollerance) - (GlobVar.locationCalc - currslotloc);
                         pbUpper.Value = 0;
                         trackBar.Value = 26;
                         //If the value is exactly on the upper bound make the trackbar make it obvious
                         //This is as no progress bar will be filled
                         if (GlobVar.locationCalc == higher)
                         {
                             trackBar.Value = 32;
                         }
                     }
                 }
                 //Else are we above the bounds?
                 else if (GlobVar.locationCalc > higher)
                 {
                     //Turn the button off as we dont want to advance
                     btnAdvance.Enabled = false;

                     //Set the progress bar values
                     pbLower.Value = 0;
                     pbInLower.Value = 0;
                     pbInUpper.Value = 0;
                     trackBar.Value = 35;

                     //Make sure that we dont set the value of the prog bar to greater than its maximum
                     if ((GlobVar.locationCalc - currslotloc) > pbUpper.Maximum)
                     {
                         //If we try to then just set the bar to be full
                         pbUpper.Value = pbUpper.Maximum;
                     }
                     //else we can give it a real value
                     else
                     {
                         pbUpper.Value = GlobVar.locationCalc - currslotloc;
                     }

                 }
                 //Else if we are below the bounds
                 else if (GlobVar.locationCalc < lower)
                 {
                     //Turn the button off as we dont want to advance
                     btnAdvance.Enabled = false;

                     //Set the progress bar values
                     pbInLower.Value = 0;
                     pbInUpper.Value = 0;
                     pbUpper.Value = 0;
                     trackBar.Value = 3;

                     //Make sure that we dont set the value of the prog bar to greater than its maximum
                     if ((currslotloc - GlobVar.locationCalc) > pbLower.Maximum)
                     {
                         //If we do then just set it to be full
                         pbLower.Value = pbLower.Maximum;
                     }
                     //else we can give it a real value
                     else
                     {
                         pbLower.Value = currslotloc - GlobVar.locationCalc;
                     }

                 }
             }

         }

         /// <summary>
         /// parse a file as a csv into a list
         /// </summary>
         /// <param name="path"></param>
         /// <returns></returns>
         public List<string[]> parseCSV(string path)
         {
             //create the list for the data that has been parsed
             List<string[]> parsedData = new List<string[]>();

             try
             {
                 //read the file
                 using (StreamReader readFile = new StreamReader(path))
                 {
                     string line;
                     string[] row;

                     //while there are lines to read
                     while ((line = readFile.ReadLine()) != null)
                     {
                         row = line.Split(','); //split at the commas
                         parsedData.Add(row); //add to the list
                     }
                 }
             }
             //catch and show the exceptions
             catch (Exception e)
             {
                 MessageBox.Show(e.Message);
             }

             //return the data as the list
             return parsedData;
         }


    }

    public static class GlobVar
    {
        //Auto updated values
        public static string PortName = ""; // The name of the COM port we want to connect to
        public static int locationSensor = 0; // The given location of the sensor
        public static int locationCalc = 0;

        //current details
        public static int currentSlot = 1;
        public static int currentSteel = 1;
        public static bool started = false;
        public static bool running = true;

        //part details
        public static string partNumber = "";
        public static int partSlots = 1;
        public static int partSteels = 1;
        public static decimal partTollerance = 1;
        public static string partSerial = "";

        /// <summary>
        /// Current zero offset
        /// </summary>
        public static int zeroOffset1 = 0;
        /// <summary>
        /// Last zero offset
        /// </summary>
        public static int zeroOffset2 = 0;

        //Settings
        public static int setRingsize = 944000;
    }

}
