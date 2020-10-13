/*
 * Author: Dane Hoffman
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;


namespace HoffmanD_P01
{

    /// <summary>
    /// Main Alarm class
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Timer that is connected to the system time to compare to the alarm time.
        /// </summary>
        public System.Timers.Timer compTime = new System.Timers.Timer();

        /// <summary>
        /// String holding the status of our alarm.
        /// </summary>
        private string statusOfAlarm;
  

        public string StatusOfAlarm { get => statusOfAlarm; set => statusOfAlarm = value; }

        /// <summary>
        /// Reference to other form
        /// </summary>
        private AddOrEditInterface addEdit;


        /// <summary>
        /// String to combine our datetime and the on or off string
        /// </summary>
        private string combo;

        /// <summary>
        /// Name of the path to the file that holds our saved alarms
        /// </summary>
        private string path = "SaveAlarms.txt";
        /// <summary>
        /// Constructor
        /// </summary>
        public UserInterface(/*AddOrEditInterface aoeInterface*/)
        {
            InitializeComponent();
            ///aoeI = aoeInterface;
           
            uxStopButton.Enabled = false;
            uxSnoozeButton.Enabled = false;
            uxEditButton.Enabled = false;
            uxAddAlarmButton.Enabled = true;
            
        }

        /// <summary>
        /// Upon closing the app it will write to all of the listbox to a text file to be saved
        /// </summary>
        private void ClosingApp(object sender, CancelEventArgs e)
        {

            StreamWriter saveAlarm = new StreamWriter(path);
            foreach(var s in uxSetAlarmList.Items)
            {

                saveAlarm.WriteLine(s.ToString());

            }

            saveAlarm.Close();

            MessageBox.Show("Alarms Saved.");

        }
        
        
        /// <summary>
        /// Adds the time and whether the alarm is on or off to the listbox
        /// </summary>
        /// <param name="time">DateTime to be added to list</param>
        /// <param name="setOn">String to add to teh datetime for the list box</param>
        public void SetAlarmToList(DateTime time, string setOn)
        {
            
            if (!time.Equals(null))
            {
                
                combo = time.ToString("h:mm tt") + " " + setOn;
                uxSetAlarmList.Items.Add(combo);       
                
            }

            if(uxStopButton.Enabled != false)
            {
                uxStopButton.Enabled = false;
            }

            if(uxSetAlarmList.Items.Count != 0)
            {

                uxEditButton.Enabled = true;

            }
            
        }

        /// <summary>
        /// Starts the alarm if the switch is turned to on. Compares to system time.
        /// </summary>
        /// <param name="time">DateTime alarm time to be compared to</param>
        /// <param name="alarmOn">bool that tells whether or not the alarm is on or off.</param>
        public void StartAlarm(DateTime time, string alarmOn)
        {

            if (alarmOn.Equals("on"))
            {

                uxSnoozeButton.Enabled = true;
                uxStopButton.Enabled = true;



                statusOfAlarm = "Running.";
                MessageBox.Show(statusOfAlarm);

                if (compTime.Equals(time))
                {

                    statusOfAlarm = "Alarm Went Off.";
                    MessageBox.Show(statusOfAlarm);
                }


            }

        }

        /// <summary>
        /// This button snoozes the selected alarm a total of 30 secs
        /// </summary>
        private void uxSnoozeButton_Click(object sender, EventArgs e)
        {

           
            
        }

        /// <summary>
        /// This button stops the alarm from ringing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStopButton_Click(object sender, EventArgs e)
        {
            if(statusOfAlarm.Equals("Alarm Went Off."))
            {

                statusOfAlarm = "*Alarm quits ringing*\n Alarm Stopped.";

                MessageBox.Show(statusOfAlarm);

            }
            else
            {

                statusOfAlarm = "Stopped";

                MessageBox.Show(statusOfAlarm);

            }


        }

        /// <summary>
        /// This button opens up the Add or edit form so you can choose a time and add it to the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddAlarmButton_Click(object sender, EventArgs e)
        {
            addEdit= new AddOrEditInterface(this);
            addEdit.Show();
            
        }

        /// <summary>
        /// This button is used to edit the time of a alarm
        /// </summary>
        private void uxEditButton_Click(object sender, EventArgs e)
        {

            addEdit = new AddOrEditInterface(this);
            addEdit.Show();
            uxSetAlarmList.SelectedItem = combo;
  
        }


    }
}
