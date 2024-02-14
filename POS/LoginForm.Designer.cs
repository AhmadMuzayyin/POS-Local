namespace POS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Email = new Guna.UI.WinForms.GunaTextBox();
            this.Password = new Guna.UI.WinForms.GunaTextBox();
            this.LoginButton = new Guna.UI.WinForms.GunaButton();
            this.Remember = new Guna.UI.WinForms.GunaCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.BackgroundImage")));
            this.gunaPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.InitialImage = null;
            this.gunaPictureBox1.Location = new System.Drawing.Point(-1, 37);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(292, 222);
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Turquoise;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(563, 40);
            this.gunaPanel1.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(309, 58);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(97, 37);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Log In";
            // 
            // Email
            // 
            this.Email.BaseColor = System.Drawing.Color.White;
            this.Email.BorderColor = System.Drawing.Color.Silver;
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.FocusedBaseColor = System.Drawing.Color.White;
            this.Email.FocusedBorderColor = System.Drawing.Color.Turquoise;
            this.Email.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Email.Location = new System.Drawing.Point(316, 115);
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.SelectedText = "";
            this.Email.Size = new System.Drawing.Size(208, 30);
            this.Email.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.BaseColor = System.Drawing.Color.White;
            this.Password.BorderColor = System.Drawing.Color.Silver;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.FocusedBaseColor = System.Drawing.Color.White;
            this.Password.FocusedBorderColor = System.Drawing.Color.Turquoise;
            this.Password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password.Location = new System.Drawing.Point(316, 161);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.SelectedText = "";
            this.Password.Size = new System.Drawing.Size(208, 30);
            this.Password.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.AnimationHoverSpeed = 0.07F;
            this.LoginButton.AnimationSpeed = 0.03F;
            this.LoginButton.BaseColor = System.Drawing.Color.Turquoise;
            this.LoginButton.BorderColor = System.Drawing.Color.Black;
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginButton.FocusedColor = System.Drawing.Color.Empty;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Image = null;
            this.LoginButton.ImageSize = new System.Drawing.Size(20, 20);
            this.LoginButton.Location = new System.Drawing.Point(438, 197);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen;
            this.LoginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginButton.OnHoverImage = null;
            this.LoginButton.OnPressedColor = System.Drawing.Color.Black;
            this.LoginButton.Size = new System.Drawing.Size(86, 27);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Log in";
            this.LoginButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Remember
            // 
            this.Remember.BaseColor = System.Drawing.Color.White;
            this.Remember.CheckedOffColor = System.Drawing.Color.Gray;
            this.Remember.CheckedOnColor = System.Drawing.Color.Turquoise;
            this.Remember.FillColor = System.Drawing.Color.White;
            this.Remember.Location = new System.Drawing.Point(316, 203);
            this.Remember.Name = "Remember";
            this.Remember.Size = new System.Drawing.Size(89, 20);
            this.Remember.TabIndex = 6;
            this.Remember.Text = "Stay signed";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(560, 258);
            this.Controls.Add(this.Remember);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(576, 297);
            this.MinimumSize = new System.Drawing.Size(576, 297);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox Email;
        private Guna.UI.WinForms.GunaTextBox Password;
        private Guna.UI.WinForms.GunaButton LoginButton;
        private Guna.UI.WinForms.GunaCheckBox Remember;
    }
}