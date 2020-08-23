using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_IV_LAB7_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*if(textBox1.Text == "")
            {
                textBox1.Text = "wpisz nazwe strony";
                textBox1.ForeColor = Color.Gray;
            }*/
            var request = WebRequest.Create("https://ih1.redbubble.net/image.613776335.5698/flat,550x550,075,f.u12.jpg");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }
        }
      /* private void textBox1_TextChanged(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(textBox1.Text))
                {

                }
        }*/
        /*
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="Wpisz nazwe strony")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Wpisz nazwe strony";
                textBox1.ForeColor = Color.Gray;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Wpisz nazwe strony";
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            try { webBrowser1.Url = new System.Uri(textBox1.Text); }
            catch(System.UriFormatException) { label1.Visible = true; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                progressBar1.PerformStep();
            }
            else
            {
                progressBar1.PerformStep();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            //var bgcolor = colorDialog1.Color;
            BackColor = colorDialog1.Color;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(5000, "Właśnie dostałeś powiadomienie", "Oto treść tego powiadomienia", ToolTipIcon.Warning);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.ShowDialog();
            textBox1.Text = settings.Setting;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            var font = fontDialog1.Font;
            var color = fontDialog1.Color;
            richTextBox1.Font = font;
            richTextBox1.ForeColor = color;
        }
    }
}
