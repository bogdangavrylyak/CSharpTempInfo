using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWeatherProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Aqua;
            this.pictureBox1.Size = new Size(800, 600);
            pictureBox1.Hide();
            label1.Show();
            label2.Show();
        }
        Point lastPoint;
        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            string city = textBox1.Text.ToString();

            Secrets secrets = new Secrets();

            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(secrets.retReq(city));

                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string response;

                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    response = streamReader.ReadToEnd();
                }

                WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);

                loading();

                label3.Text = $"Tempereture in {weatherResponse.Name}: {weatherResponse.Main.Temp} C";
            }
            catch (Exception ex)
            {
                await Task.Delay(2000);
                MessageBox.Show($"Exception happened: {ex.Message}, maybe you entered wrong city name");
            }
        }
        private async void loading()
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Size = new Size(800, 600);
            pictureBox1.Show();
            label3.Hide();
            label4.Hide();
            textBox1.Hide();
            button1.Hide();
            buttonSignOut.Hide();
            await Task.Delay(2000);
            pictureBox1.Hide();
            label3.Show();
            label4.Show();
            textBox1.Show();
            button1.Show();
            buttonSignOut.Show();
            this.Size = new Size(width, height);
        }
        private async void buttonSignOut_Click(object sender, EventArgs e)
        {
            loading();
            await Task.Delay(2000);
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
