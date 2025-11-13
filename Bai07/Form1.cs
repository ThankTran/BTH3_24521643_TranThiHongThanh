using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        private List<Button> gheList = new List<Button>();
        private Dictionary<Button, int> giaVe = new Dictionary<Button, int>();

        public Form1()
        {
            InitializeComponent();
            KhoiTaoGhe();
        }

        private void KhoiTaoGhe()
        {
            foreach (var control in groupBox1.Controls)
            {
                if (control is Button ghe)
                {
                    gheList.Add(ghe);
                    ghe.Click += Ghe_Click; 

                    int so = int.Parse(ghe.Text);
                    if (so <= 5)
                        giaVe[ghe] = 5000;   
                    else if (so <= 10)
                        giaVe[ghe] = 6500;  
                    else
                        giaVe[ghe] = 8000;   

                    ghe.BackColor = Color.White; 
                }
            }
        }

        private void Ghe_Click(object sender, EventArgs e)
        {
            Button ghe = sender as Button;

            if (ghe.BackColor == Color.Yellow)
            {
                MessageBox.Show($"Ghế {ghe.Text} đã được bán!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ghe.BackColor == Color.Green)
                ghe.BackColor = Color.White;
            else
                ghe.BackColor = Color.Green;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int tongTien = 0;

            foreach (Button ghe in gheList)
            {
                if (ghe.BackColor == Color.Green)
                {
                    ghe.BackColor = Color.Yellow; 
                    tongTien += giaVe[ghe];
                }
            }

            textBox2.Text = tongTien.ToString();
        }


        private void button18_Click(object sender, EventArgs e)
        {
            foreach (Button ghe in gheList)
            {
                if (ghe.BackColor == Color.Green)
                    ghe.BackColor = Color.White;
            }

            textBox2.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
