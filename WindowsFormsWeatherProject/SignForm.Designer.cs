namespace WindowsFormsWeatherProject
{
    partial class SignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreateAcc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGoToLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(728, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(765, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "X";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(392, 127);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(314, 38);
            this.textBoxPassword.TabIndex = 28;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(392, 64);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(314, 35);
            this.textBoxLogin.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(68, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Enter your Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(70, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Enter your Login";
            // 
            // buttonCreateAcc
            // 
            this.buttonCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateAcc.Location = new System.Drawing.Point(430, 259);
            this.buttonCreateAcc.Name = "buttonCreateAcc";
            this.buttonCreateAcc.Size = new System.Drawing.Size(197, 87);
            this.buttonCreateAcc.TabIndex = 29;
            this.buttonCreateAcc.Text = "Create account";
            this.buttonCreateAcc.UseVisualStyleBackColor = true;
            this.buttonCreateAcc.Click += new System.EventHandler(this.buttonCreateAcc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsWeatherProject.Properties.Resources.loading1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // buttonGoToLogin
            // 
            this.buttonGoToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoToLogin.Location = new System.Drawing.Point(129, 263);
            this.buttonGoToLogin.Name = "buttonGoToLogin";
            this.buttonGoToLogin.Size = new System.Drawing.Size(180, 83);
            this.buttonGoToLogin.TabIndex = 31;
            this.buttonGoToLogin.Text = "GoToLogin";
            this.buttonGoToLogin.UseVisualStyleBackColor = true;
            this.buttonGoToLogin.Click += new System.EventHandler(this.buttonGoToLogin_Click);
            // 
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGoToLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCreateAcc);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignForm";
            this.Text = "SignForm";
            this.Load += new System.EventHandler(this.SignForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SignForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SignForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreateAcc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGoToLogin;
    }
}