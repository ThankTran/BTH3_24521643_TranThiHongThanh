using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int x = random.Next(this.Width);
            int y = random.Next(this.Height);

            Color color = Color.FromArgb(random.Next(256), 
                random.Next(256), random.Next(256));

            e.Graphics.DrawString("Paint Event", 
                new Font("Arial", 20), new SolidBrush(color), x, y);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Invalidate();
        }
    }
}