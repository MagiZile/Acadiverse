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
    public partial class DigitalTimeDisplay : UserControl
    {
        public DigitalTimeDisplay()
        {
            InitializeComponent();
        }
        const int POS_INCREMENT = 1;
        const int NEG_INCREMENT = -1;
        const int TIMER_MIN = 0;
        const int SECONDS_MAX = 59;
        const int MINUTES_MAX = 59;
        const int MAX_HOURS_VALUE = 72;
        public TimerMode timerMode = TimerMode.NoTimer;
        public int hours = 0;
        public int minutes = 0;
        public int seconds = 0;
        public int maximumHours = 48;
        public int initialTime = 600;

        public event EventHandler TimeExpired;

        public int InitialTime
        {
            get
            {
                return initialTime;
            }
            set
            {
                initialTime = value;
                hours = initialTime / 3600;
                minutes = initialTime % 60;
                seconds = minutes % 60;
            }
        }

        public TimerMode Mode
        {
            get
            {
                return timerMode;
            }
            set
            {
                timerMode = value;
            }
        }

        public int MaxHours
        {
            get
            {
                return maximumHours;
            }
            set
            {
                if (value > MAX_HOURS_VALUE)
                {
                    throw new ArgumentException("Maximum hours exceeded.");
                }
                else
                {
                    maximumHours = value;
                }
            }
        }

        private void tmrUpdateTimer_Tick(object sender, EventArgs e)
        {
            Increment();
        }

        void Increment()
        {
            int amount;
            if (timerMode == TimerMode.Countdown)
            {
                amount = NEG_INCREMENT;
            }
            else
            {
                amount = POS_INCREMENT;
            }
            if (CheckSeconds())
            {
                ResetSeconds();
                minutes += amount;
            }
            if (CheckMinutes())
            {
                ResetMinutes();
                hours += amount;
            }
            if (CheckHours())
            {
                ResetHours();
                tmrUpdateTimer.Stop();
            }
            seconds += amount;
            if (CheckTimeLeft())
            {
                TimeExpired?.Invoke(this, new EventArgs());
            }
            UpdateLabel();
        }

        bool CheckTimeLeft()
        {
            return hours <= 0 && minutes <= 0 && seconds <= 0 && timerMode != TimerMode.Countdown;
        }

        bool CheckHours()
        {
            if (timerMode == TimerMode.Countdown)
            {
                return hours < 0;
            }
            else
            {
                return hours > maximumHours;
            }
        }

        bool CheckMinutes()
        {
            if (timerMode == TimerMode.Countdown)
            {
                return minutes < TIMER_MIN;
            }
            else
            {
                return minutes > MINUTES_MAX;
            }
        }

        bool CheckSeconds()
        {
            if (timerMode == TimerMode.Countdown)
            {
                return seconds < TIMER_MIN;
            }
            else
            {
                return seconds > SECONDS_MAX;
            }
        }

        void ResetSeconds()
        {
            if (timerMode == TimerMode.Countdown)
            {
                seconds = SECONDS_MAX;
            }
            else
            {
                seconds = TIMER_MIN;
            }
        }

        void ResetMinutes()
        {
            if (timerMode == TimerMode.Countdown)
            {
                minutes = MINUTES_MAX;
            }
            else
            {
                minutes = TIMER_MIN;
            }
        }

        void ResetHours()
        {
            if (hours < 0)
            {
                hours = 0;
            }
            if (hours > maximumHours)
            {
                hours = maximumHours;
            }
        }

        public void StartTimer()
        {
            tmrUpdateTimer.Start();
        }

        public void StopTimer()
        {
            tmrUpdateTimer.Stop();
        }

        void UpdateLabel()
        {
            string hourString = "";
            string minuteString = "";
            string secondString = "";

            if (hours < 10)
            {
                hourString = "0" + hours;
            }
            else
            {
                hourString = hours.ToString();
            }

            if (minutes < 10)
            {
                minuteString = "0" + minutes;
            }
            else
            {
                minuteString = minutes.ToString();
            }

            if (seconds < 10)
            {
                secondString = "0" + seconds;
            }
            else
            {
                secondString = seconds.ToString();
            }

            lblTime.Text = hourString + ":" + minuteString + ":" + secondString;
        }
    }
}
