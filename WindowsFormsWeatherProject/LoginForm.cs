using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWeatherProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.BackColor = Color.BlueViolet;
            pictureBox1.Size = new System.Drawing.Size(800, 600);
            pictureBox1.Hide();
        }
        private void label2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }



        Point lastPoint;
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
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

        private async void buttonEnter_Click_1(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;

            string password = textBoxPassword.Text;
            
            using (MyDbContext context = new MyDbContext())
            {
                try
                {
                    if (context.Database.Connection == null)
                    {
                        throw new Exception();
                    }
                    User usrToFind = new User();
                    loading();
                    await Task.Run(() => { usrToFind = context.Users.Where(usr => usr.Login == login).FirstOrDefault(); });


                    if (usrToFind != null)
                    {
                        if (usrToFind.Password == password)
                        {
                            // MessageBox.Show("you have successfully entered your account");
                            //MessageBox.Show($"userlogin: {usrToFind.Login} userpassword: {usrToFind.Password}");
                            await Task.Delay(2000);
                            this.Hide();
                            Form1 form1 = new Form1();
                            form1.Show();
                        }
                        else
                        {
                            await Task.Delay(3000);
                            MessageBox.Show("wrong password");
                        }
                    }
                    else
                    {
                        await Task.Delay(3000);
                        MessageBox.Show("No user called " + login + " was found");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show($"Exceptipon happened: {ex.Message}");
                }
            }
        }

        private async void buttonCreateAcc_Click(object sender, EventArgs e)
        {
            loading();
            await Task.Delay(2000);
            this.Hide();
            SignForm signform = new SignForm();
            signform.Show();
        }

        private async void loading()
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            
            this.Size = new Size(800, 600);
            pictureBox1.Show();
            label3.Hide();
            label4.Hide();
            textBoxLogin.Hide();
            textBoxPassword.Hide();
            buttonCreateAcc.Hide();
            buttonEnter.Hide();
            await Task.Delay(4000);
            pictureBox1.Hide();
            label3.Show();
            label4.Show();
            textBoxLogin.Show();
            textBoxPassword.Show();
            buttonCreateAcc.Show();
            buttonEnter.Show();
            this.Size = new Size(width, height);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       


        /*private void label1_Click(object sender, EventArgs e)
{

}
private void label2_Click(object sender, EventArgs e)
{

}*/
        /*private void buttonEnter_Click(object sender, EventArgs e)
{

}
private void buttonCreateAcc_Click(object sender, EventArgs e)
{

}*/


    }
}
