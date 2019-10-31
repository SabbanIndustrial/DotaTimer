using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DotaTimer
{
    class BetterTimer
    {

        private Timer timer = new Timer();

        public event Action Finished;
        public event Action<string> TimeUpdated;

        private int currentTime = 0;
        private int targetTime = 0;


        public BetterTimer(int seconds)
        {
            timer.Interval = 1000;
            targetTime = seconds;
            timer.Tick += OnTick;
        }

         
        private void OnTick(object sender, EventArgs e)
        {
            try
            {
                currentTime++;
                try
                {
                    TimeUpdated(GetString());
                }
                catch { }

                if (currentTime >= targetTime)
                {
                    TimeUpdated("Ready");
                    Finished();
                    timer.Stop();
                    currentTime = 0;
                }
            }
            catch { }
        }

        public string GetString()
        {
            return SecondsToTimeString(targetTime - currentTime);
        }

        public void SetInterval(int interval)
        {
            targetTime = interval;
        }
        public void Start()
        {
            timer.Interval = 1000;
            currentTime = 0;
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
            currentTime = 0;
            
        }

        private string SecondsToTimeString(int seconds)
        {
            string resulting = "";
            resulting += seconds / 60;
            resulting += ":";
            if (seconds % 60 < 10)
            {
                resulting += "0";
            }
            resulting += seconds % 60;
            return resulting;
        }



    }
}
