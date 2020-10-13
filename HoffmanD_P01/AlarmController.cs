using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoffmanD_P01
{
    public enum AlarmState
    {

        WentOff,
        Running,
        TurnedOff

    };
    public enum AlarmSound
    {

        Radar,
        Beacon,
        Chimes,
        Circuit,
        Reflection

    };
    public class AlarmController
    {

        AlarmModel model;

        UserInterface uInterface;

        public AlarmController()
        {



        }

        /*
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

            if (uxStopButton.Enabled != false)
            {
                uxStopButton.Enabled = false;
            }

            if (uxSetAlarmList.Items.Count != 0)
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



                AlarmState = "Running.";
                MessageBox.Show(statusOfAlarm);

                if (compTime.Equals(time))
                {

                    statusOfAlarm = "Alarm Went Off.";
                    MessageBox.Show(statusOfAlarm);
                }


            }

        }
        */
    }
}
