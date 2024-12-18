namespace WinFormsApp1
{
    partial class auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(auth));
            auth_btn = new Button();
            login = new TextBox();
            password = new TextBox();
            button1 = new Button();
            captcha_text = new TextBox();
            captcha = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // auth_btn
            // 
            auth_btn.Location = new Point(331, 338);
            auth_btn.Name = "auth_btn";
            auth_btn.Size = new Size(100, 23);
            auth_btn.TabIndex = 0;
            auth_btn.Text = "Auth";
            auth_btn.UseVisualStyleBackColor = true;
            auth_btn.Click += button1_Click;
            // 
            // login
            // 
            login.Location = new Point(331, 163);
            login.Name = "login";
            login.Size = new Size(100, 23);
            login.TabIndex = 1;
            login.TextChanged += login_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(331, 192);
            password.Name = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 2;
            password.TextChanged += password_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(331, 367);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // captcha_text
            // 
            captcha_text.Location = new Point(331, 309);
            captcha_text.Name = "captcha_text";
            captcha_text.Size = new Size(100, 23);
            captcha_text.TabIndex = 5;
            // 
            // captcha
            // 
            captcha.AutoSize = true;
            captcha.BackColor = SystemColors.Window;
            captcha.Font = new Font("Viner Hand ITC", 26.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout, GraphicsUnit.Point);
            captcha.Image = (Image)resources.GetObject("captcha.Image");
            captcha.Location = new Point(321, 227);
            captcha.Name = "captcha";
            captcha.Size = new Size(99, 57);
            captcha.TabIndex = 6;
            captcha.Text = "8721";
            captcha.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(321, 221);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 63);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // auth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(captcha);
            Controls.Add(captcha_text);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(auth_btn);
            Controls.Add(pictureBox1);
            Name = "auth";
            Text = "auth";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button auth_btn;
        private TextBox login;
        private TextBox password;
        private Button button1;
        private TextBox captcha_text;
        private Label captcha;
        private PictureBox pictureBox1;
    }
}