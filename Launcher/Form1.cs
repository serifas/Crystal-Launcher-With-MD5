using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Net;
using System.Web;
using System.Runtime.Remoting.Channels;
using System.Security.Policy;

namespace UpdateTest
{
    public partial class Form1 : Form
    {

        private bool mouseDown;
        private Point lastLocation;
        private string content;
        public Form1()
        {
            WebClient client = new WebClient();
            try
            {
                Stream stream = client.OpenRead(CrystalUpdater.Config.NewsURL);
                StreamReader reader = new StreamReader(stream);
                content = reader.ReadToEnd();
            }
            catch
            {

            }
           
            InitializeComponent();
            this.TransparencyKey = Color.Green;
            button1.ForeColor = Color.Transparent;
            button1.BackColor = Color.Transparent;

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;


            button2.ForeColor = Color.Transparent;
            button2.BackColor = Color.Transparent;

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;

            button3.ForeColor = Color.Transparent;
            button3.BackColor = Color.Transparent;

            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            pictureBox2.MouseDown += new MouseEventHandler(pictureBox2_MouseDown);
            pictureBox2.MouseUp += new MouseEventHandler(pictureBox2_MouseUp);
            pictureBox2.MouseMove += new MouseEventHandler(pictureBox2_MouseMove);
            var sb = new StringBuilder();

            richTextBox1.Rtf = @"{" + content + "}";
        }
        
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
      
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.button_h;
        }
        void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.button_p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            updater1.CheckForUpdates();
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button4_Click(object sender, MouseEventArgs e)
        {
         
        }
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
