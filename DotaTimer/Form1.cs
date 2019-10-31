using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace DotaTimer
{
    public partial class Form1 : Form
    {


        BetterTimer aegis = new BetterTimer(300);
        BetterTimer roshan = new BetterTimer(480);
        BetterTimer roshanAdditional = new BetterTimer(180);

        BetterTimer[] buybacks = new BetterTimer[5];

        BetterTimer glyph = new BetterTimer(300);


        BetterTimer blackhole = new BetterTimer(160);
        BetterTimer global = new BetterTimer(130);


        private GlobalKeyboardHook hook;



        public Form1()
        {
            InitializeComponent();

            hook = new GlobalKeyboardHook();
            hook.KeyboardPressed += OnKeyPressed;

            for (int i = 0; i < buybacks.Length; i++)
            {
                buybacks[i] = new BetterTimer(480);

            }
            aegis.TimeUpdated += AegisTick;
            roshan.TimeUpdated += RoshanTick;
            roshan.Finished += RoshanAdditional;

            buybacks[0].TimeUpdated += Pos1Tick;
            buybacks[1].TimeUpdated += Pos2Tick;
            buybacks[2].TimeUpdated += Pos3Tick;
            buybacks[3].TimeUpdated += Pos4Tick;
            buybacks[4].TimeUpdated += Pos5Tick;
            glyph.TimeUpdated += GlyphTick;

            blackhole.TimeUpdated += BlackholeTick;
            global.TimeUpdated += GlobalTick;
            button10_Click(null, null);
        }

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e)
        {


            //Text = e.KeyboardData.VirtualCode.ToString();

            switch (e.KeyboardData.VirtualCode)
            {
                case 97:
                    buybacks[0].Start();
                    break;
                case 98:
                    buybacks[1].Start();
                    break;
                case 99:
                    buybacks[2].Start();
                    break;
                case 100:
                    buybacks[3].Start();
                    break;
                case 101:
                    buybacks[4].Start();
                    break;
                case 102:
                    aegis.Start();
                    roshan.Start();
                    break;
                case 103:
                    glyph.Start();
                    break;
                case 104:
                    blackhole.Start();
                    break;
                case 105:
                    global.Start();
                    break;
                default:
                    break;
            }

        }



        private void AegisTick(string time)
        {
            aegisLabel.Text = time;
        }
        private void RoshanTick(string time)
        {
            roshanMainLabel.Text = time;
        }

        private void RoshanAdditional()
        {
            roshanMainLabel.Text = "0:00";
            roshanAdditional.Start();
            roshanAdditional.TimeUpdated += RoshanAdditionalTick;

        }

        private void RoshanAdditionalTick(string time)
        {
            roshanAdditionalLabel.Text = time;
        }

        private void Pos1Tick(string time)
        {
            pos1Label.Text = time;
        }
        private void Pos2Tick(string time)
        {
            pos2Label.Text = time;
        }
        private void Pos3Tick(string time)
        {
            pos3Label.Text = time;
        }
        private void Pos4Tick(string time)
        {
            pos4Label.Text = time;
        }
        private void Pos5Tick(string time)
        {
            pos5Label.Text = time;
        }

        private void GlyphTick(string time)
        {
            glyphLabel.Text = time;
        }





        private void BlackholeTick(string time)
        {
            blackHoleLabel.Text = time;
        }

        private void GlobalTick(string time)
        {
            globalLabel.Text = time;
        }






        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            blackhole.Start();
        }
        OverlayForm f;
        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
            f = new OverlayForm();
            f.Show();
            f.Visible = false;

        }

        [DllImport("user32.dll")]
        internal static extern IntPtr GetForegroundWindow();

        [DllImport("user32", SetLastError = true)]
        internal static extern int GetWindowThreadProcessId([In]IntPtr hwnd, [Out]out int lProcessId);

        public string test()
        {
            string test;
            IntPtr hWnd = GetForegroundWindow();
            int pid;
            GetWindowThreadProcessId(hWnd, out pid);
            System.Diagnostics.Process p = System.Diagnostics.Process.GetProcessById(pid);
            test = p.ProcessName;
            hWnd = IntPtr.Zero;
            return test;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string dataToDisplay = $"AEGIS: {aegisLabel.Text}(NUMPAD6)\nROSHAN: {roshanMainLabel.Text} {roshanAdditionalLabel.Text}\n";
                dataToDisplay += $"GLYPH: {glyphLabel.Text}(NUMPAD7)\nP1:  {pos1Label.Text}\n";
                dataToDisplay += $"P2: {pos2Label.Text}\nP3: {pos3Label.Text}\n";
                dataToDisplay += $"P4: {pos4Label.Text}\nP5: {pos5Label.Text}\n";


                f.Update(dataToDisplay);
                if ((test() == "dota2" && checkBox1.Checked) || checkBox2.Checked)
                {
                    f.Visible = true;
                }
                else
                {
                    f.Visible = false;
                }
            }
            catch { }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            aegis.Stop();
            roshan.Stop();
            roshanAdditional.Stop();
            glyph.Stop();
            blackhole.Stop();
            global.Stop();

            foreach (var item in buybacks)
            {
                item.Stop();
            }
            aegisLabel.Text = "5:00";
            roshanMainLabel.Text = "8:00";
            roshanAdditionalLabel.Text = "3:00";
            pos1Label.Text = "8:00";
            pos2Label.Text = "8:00";
            pos3Label.Text = "8:00";
            pos4Label.Text = "8:00";
            pos5Label.Text = "8:00";
            glyphLabel.Text = "5:00";
            blackHoleLabel.Text = "2:40";
            globalLabel.Text = "2:10";
        }
    }
}
