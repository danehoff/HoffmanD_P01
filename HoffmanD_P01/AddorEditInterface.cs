/*
 * Author: Dane Hoffman
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoffmanD_P01
{
    /// <summary>
    /// Add/Edit alarm class
    /// </summary>
    public partial class AddOrEditInterface : Form
    {
        /// <summary>
        /// Gives reference to methods in main Userinterface
        /// </summary>
        private UserInterface alarm;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="alarmInterface"></param>
        public AddOrEditInterface(UserInterface alarmInterface)
        {

            InitializeComponent();

            alarm = alarmInterface;
            this.uxAlarmTimePicker.CustomFormat = "hh:mm";
            
        }

        /// <summary>
        /// DateTime variabel to covert our picker to so we can change it to a string.
        /// </summary>
        public DateTime timeCur = DateTime.Now;

        /// <summary>
        /// Gives whether or not the alarm is on.
        /// </summary>
        /// <returns>Bool of whether or not the alarm is on.</returns>
        public bool AlarmOn()
        {

            bool on = false;

            if(uxAlarmOnRButton.Checked == true)
            { 
                on = true;
               
            }

            return on;

        }
        
        /// <summary>
        /// When the set button is clicked it will add the value to the listbox
        /// </summary>
        private void uxSetButton_Click(object sender, EventArgs e)
        {
            string onOff = "";
            if (AlarmOn() != true)
            {

                onOff = "off";
                timeCur = uxAlarmTimePicker.Value.Date;

                alarm.SetAlarmToList(timeCur, onOff);

            }
            else
            {

                onOff = "on";

                timeCur = uxAlarmTimePicker.Value;

                alarm.SetAlarmToList(timeCur, onOff);
                alarm.StartAlarm(timeCur, onOff);
            }
        }


        /// <summary>
        /// Closes the Add/edit form on click.
        /// </summary>
        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }

}
