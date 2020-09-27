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
    public partial class SignForm : Form
    {
        public SignForm()
        {
            InitializeComponent();
            this.BackColor = Color.CadetBlue;
            pictureBox1.Size = new Size(800, 600);
            pictureBox1.Hide();
        }

        private void SignForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Point lastPoint;
        private void SignForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SignForm_MouseMove(object sender, MouseEventArgs e)
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
        private async void buttonCreateAcc_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;

            string password = textBoxPassword.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("No data");
            }
            else
            {
                loading();

                using (MyDbContext context = new MyDbContext())
                {
                    try
                    {
                        await Task.Run(() =>
                        {
                            if (context.Database.Connection == null)
                            {
                                throw new Exception();
                            }

                            User user = new User()
                            {
                                Login = login,
                                Password = password
                            };

                            context.Users.Add(user);
                            context.SaveChanges();
                        });
                        await Task.Delay(3000);
                        MessageBox.Show("You have been successfully registered");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Exceptipon happened: {ex.Message}");
                    }
                }
            }

            
        }
        private async void buttonGoToLogin_Click(object sender, EventArgs e)
        {
            loading();
            await Task.Delay(2000);
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
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
            buttonGoToLogin.Hide();
            await Task.Delay(4000);
            pictureBox1.Hide();
            label3.Show();
            label4.Show();
            textBoxLogin.Show();
            textBoxPassword.Show();
            buttonCreateAcc.Show();
            buttonGoToLogin.Show();
            this.Size = new Size(width, height);
        }

        
    }
}
