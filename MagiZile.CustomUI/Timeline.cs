using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.CustomUI
{
    public partial class Timeline : UserControl
    {
        public Timeline()
        {
            InitializeComponent();
        }

        int day = 1;
        int month = 1;
        int year = 2014;
        int hour = 12;
        int minute = 0;
        bool paused = false;
        string suffix = "AM";
        string monthString = "01";
        string dayString = "01";
        string hourString = "12";
        string minuteString = "00";

        public DateTime startdate = new DateTime(2014, 1, 1);
        public DateTime enddate = new DateTime(9998, 12, 31);
        enum TimeView { Years, Months, Days, Hours, Minutes };

        TimeView view = TimeView.Years;

        public DateTime StartDate
        {
            get
            {
                return startdate;
            }
            set
            {
                startdate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return enddate;
            }
            set
            {
                enddate = value;
            }
        }

        public bool Paused
        {
            get
            {
                return paused;
            }
            set
            {
                paused = value;
            }
        }

        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboView.SelectedIndex)
            {
                case 0: //Years
                    trkTimeSlider.Maximum = enddate.Year;
                    trkTimeSlider.Minimum = startdate.Year;
                    view = TimeView.Years;
                    break;
                case 1: //Months
                    trkTimeSlider.Minimum = 0;
                    trkTimeSlider.Maximum = (startdate.Year + enddate.Year) * 12;
                    view = TimeView.Months;
                    break;
                case 2: //Days
                    trkTimeSlider.Minimum = 0;
                    trkTimeSlider.Maximum = (startdate.Year + enddate.Year) * 365;
                    view = TimeView.Days;
                    break;
            }
        }

        private void Timeline_Load(object sender, EventArgs e)
        {
            cboView.SelectedIndex = 0;
        }

        private void trkTimeSlider_Scroll(object sender, EventArgs e)
        {
            switch (view)
            {
                case TimeView.Days:
                    day = Convert.ToInt32(trkTimeSlider.Value);
                    break;
                case TimeView.Hours:
                    hour = Convert.ToInt32(trkTimeSlider.Value);
                    break;
                case TimeView.Minutes:
                    minute = Convert.ToInt32(trkTimeSlider.Value);
                    break;
                case TimeView.Months:
                    month = Convert.ToInt32(trkTimeSlider.Value);
                    break;
                case TimeView.Years:
                    year = Convert.ToInt32(trkTimeSlider.Value);
                    break;
            }
            if (minute >= 60)
            {
                minute = 0;
                hour += 1;
            }
            if (hour >= 12)
            {
                if (suffix == "AM")
                {
                    suffix = "PM";
                }
                else
                {
                    suffix = "AM";
                    day += 1;
                }
                hour = 1;
            }
            switch (month)
            {
                case 1: //January
                    if (day >= 31)
                    {
                        month += 1;
                        day = 1;
                    }
                    else
                    {

                    }
                    break;
                case 2: //February
                    if (year % 4 == 0) //If it is a leap year...
                    {
                        if (day >= 29)
                        {
                            month += 1;
                            day = 1;
                        }
                        else
                        {
                            day = 1;
                        }
                    }
                    else
                    {
                        if (day >= 28)
                        {
                            month += 1;
                            day = 1;
                        }
                        else
                        {

                        }
                    }
                    break;
                case 3: //March
                    if (day >= 31)
                    {
                        month += 1;
                        day = 1;
                    }
                    else
                    {

                    }
                    break;
                case 4: //April
                    if (day >= 30)
                    {
                        month += 1;
                        day = 1;
                    }
                    else
                    {

                    }
                    break;
                case 5: //May
                    if (day >= 31)
                    {
                        month += 1;
                        day = 1;
                    }
                    else
                    {

                    }
                    break;
                case 6: //June
                    if (day >= 30)
                    {
                        month += 1;
                        day = 1;
                    }
                    else
                    {

                    }
                    break;
                case 7: //July
                    if (day >= 31)
                    {
                        month += 1;
                        day = 1;
                    }
                    else
                    {

                    }
                    break;
                case 8: //August
                    if (day >= 31)
                    {
                        month += 1;
                        day = 1;
                    }
                    else
                    {

                    }
                    break;
                case 9: //September
                    if (day >= 30)
                    {
                        month += 1;
                        day = 1;
                    }
                    else
                    {

                    }
                    break;
                case 10: //October
                    if (day >= 31)
                    {
                        month += 1;
                        day = 1;
                    }
                    else
                    {

                    }
                    break;
                case 11: //November
                    if (day >= 30)
                    {
                        month += 1;
                        day = 1;
                    }
                    else
                    {

                    }
                    break;
                case 12: //December
                    if (day >= 31)
                    {
                        year += 1;
                        month = 1;
                        day = 1;
                    }
                    else
                    {

                    }
                    break;
            }
            if (month < 10)
            {
                monthString = "0" + month;
            }
            else
            {
                monthString = month.ToString();
            }
            if (day < 10)
            {
                dayString = "0" + day;
            }
            else
            {
                dayString = day.ToString();
            }
            if (hour < 10)
            {
                hourString = "0" + hour;
            }
            else
            {
                hourString = hour.ToString();
            }
            if (minute < 10)
            {
                minuteString = "0" + minute;
            }
            else
            {
                minuteString = minute.ToString();
            }
            lblCurrentTime.Text = monthString + "/" + dayString + "/" + year + " " + hourString + ":" + minuteString + " " + suffix;
        }
    }
}
