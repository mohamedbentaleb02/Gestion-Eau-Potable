namespace SFE
{
    partial class signIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signIn));
            this.labelSignIn = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Separator = new Guna.UI2.WinForms.Guna2Separator();
            this.labelUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.password_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.show_password = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.labelShowPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.cancel_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // labelSignIn
            // 
            this.labelSignIn.BackColor = System.Drawing.Color.Transparent;
            this.labelSignIn.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignIn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSignIn.Location = new System.Drawing.Point(22, 19);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(183, 38);
            this.labelSignIn.TabIndex = 0;
            this.labelSignIn.Text = "Se Connecter";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Separator
            // 
            this.Separator.Location = new System.Drawing.Point(20, 81);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(340, 11);
            this.Separator.TabIndex = 2;
            // 
            // labelUsername
            // 
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.DimGray;
            this.labelUsername.Location = new System.Drawing.Point(33, 137);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(154, 26);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Nom d\'Utilisateur";
            this.labelUsername.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderRadius = 9;
            this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUsername.DefaultText = "";
            this.textBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.Location = new System.Drawing.Point(25, 169);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.PlaceholderText = "";
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.Size = new System.Drawing.Size(329, 46);
            this.textBoxUsername.TabIndex = 4;
            // 
            // password_label
            // 
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.DimGray;
            this.password_label.Location = new System.Drawing.Point(33, 248);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(116, 26);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "Mot de passe";
            this.password_label.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderRadius = 9;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Location = new System.Drawing.Point(25, 280);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '\0';
            this.textBoxPassword.PlaceholderText = "";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.Size = new System.Drawing.Size(329, 46);
            this.textBoxPassword.TabIndex = 6;
            // 
            // show_password
            // 
            this.show_password.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.show_password.CheckedState.BorderRadius = 2;
            this.show_password.CheckedState.BorderThickness = 1;
            this.show_password.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.show_password.Location = new System.Drawing.Point(35, 357);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(20, 20);
            this.show_password.TabIndex = 7;
            this.show_password.Text = "s";
            this.show_password.UncheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.show_password.UncheckedState.BorderRadius = 2;
            this.show_password.UncheckedState.BorderThickness = 1;
            this.show_password.UncheckedState.FillColor = System.Drawing.Color.White;
            this.show_password.Click += new System.EventHandler(this.show_password_Click);
            // 
            // labelShowPassword
            // 
            this.labelShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelShowPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowPassword.ForeColor = System.Drawing.Color.DimGray;
            this.labelShowPassword.Location = new System.Drawing.Point(63, 356);
            this.labelShowPassword.Name = "labelShowPassword";
            this.labelShowPassword.Size = new System.Drawing.Size(184, 21);
            this.labelShowPassword.TabIndex = 8;
            this.labelShowPassword.Text = "Afficher le mot de passe";
            this.labelShowPassword.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BorderRadius = 9;
            this.buttonSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSignIn.FillColor = System.Drawing.Color.Silver;
            this.buttonSignIn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonSignIn.ForeColor = System.Drawing.Color.Black;
            this.buttonSignIn.Location = new System.Drawing.Point(63, 412);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(251, 45);
            this.buttonSignIn.TabIndex = 9;
            this.buttonSignIn.Text = "Se Connecter";
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.cancel_button.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.cancel_button.Image = ((System.Drawing.Image)(resources.GetObject("cancel_button.Image")));
            this.cancel_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.cancel_button.ImageRotate = 0F;
            this.cancel_button.ImageSize = new System.Drawing.Size(32, 32);
            this.cancel_button.Location = new System.Drawing.Point(309, 9);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.cancel_button.Size = new System.Drawing.Size(64, 54);
            this.cancel_button.TabIndex = 10;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // signIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(376, 504);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.labelShowPassword);
            this.Controls.Add(this.show_password);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.labelSignIn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel labelSignIn;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button buttonSignIn;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelShowPassword;
        private Guna.UI2.WinForms.Guna2CustomCheckBox show_password;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel password_label;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUsername;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelUsername;
        private Guna.UI2.WinForms.Guna2Separator Separator;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ImageButton cancel_button;
    }
}