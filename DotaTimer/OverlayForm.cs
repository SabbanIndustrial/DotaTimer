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

namespace DotaTimer
{
    public partial class OverlayForm : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern UInt32 GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, UInt32 dwNewLong);

        Brush dotaColor = (Brush)new SolidBrush(Color.FromArgb(160, 170, 180));
        Font dotaFont = new Font("Bahnschrift", 10.5F, FontStyle.Regular);
        public OverlayForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            AllowTransparency = true;
            BackColor = Color.White;
            TransparencyKey = BackColor;
            uint initialStyle = GetWindowLong(Handle, -20);
            SetWindowLong(Handle, -20, initialStyle | 0x80000 | 0x20);
            Location = new Point(0, 0);
        }

        public static string data = "TEST\nTEST";
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.Empty);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            g.DrawString(data, dotaFont, dotaColor, new Point(8, (int)(Screen.PrimaryScreen.Bounds.Size.Height / 7.1)));

            e.Graphics.DrawImage(bitmap, new Point(0, 0));
        }
        public void Update(string state)
        {
            data = state;
            Refresh();

        }
        
    }
}
