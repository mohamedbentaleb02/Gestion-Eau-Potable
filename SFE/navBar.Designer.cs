namespace SFE
{
    partial class defaultForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(defaultForm));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panelSideMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonSituation = new Guna.UI2.WinForms.Guna2Button();
            this.panelLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonLogout = new Guna.UI2.WinForms.Guna2Button();
            this.buttonBoard = new Guna.UI2.WinForms.Guna2Button();
            this.buttonConsommation = new Guna.UI2.WinForms.Guna2Button();
            this.buttonClients = new Guna.UI2.WinForms.Guna2Button();
            this.buttonReglement = new Guna.UI2.WinForms.Guna2Button();
            panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelSideMenu.Controls.Add(this.buttonSituation);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Controls.Add(this.buttonLogout);
            this.panelSideMenu.Controls.Add(this.buttonBoard);
            this.panelSideMenu.Controls.Add(this.buttonConsommation);
            this.panelSideMenu.Controls.Add(this.buttonClients);
            this.panelSideMenu.Controls.Add(this.buttonReglement);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(309, 853);
            this.panelSideMenu.TabIndex = 9;
            // 
            // buttonSituation
            // 
            this.buttonSituation.BackColor = System.Drawing.Color.Transparent;
            this.buttonSituation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSituation.BorderRadius = 10;
            this.buttonSituation.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonSituation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSituation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSituation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSituation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSituation.FillColor = System.Drawing.Color.Empty;
            this.buttonSituation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSituation.ForeColor = System.Drawing.Color.DimGray;
            this.buttonSituation.Image = global::SFE.Properties.Resources.status;
            this.buttonSituation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonSituation.ImageOffset = new System.Drawing.Point(22, 0);
            this.buttonSituation.ImageSize = new System.Drawing.Size(37, 37);
            this.buttonSituation.Location = new System.Drawing.Point(0, 571);
            this.buttonSituation.Name = "buttonSituation";
            this.buttonSituation.Padding = new System.Windows.Forms.Padding(50, 8, 0, 8);
            this.buttonSituation.Size = new System.Drawing.Size(309, 57);
            this.buttonSituation.TabIndex = 9;
            this.buttonSituation.Text = "Situation";
            this.buttonSituation.TextOffset = new System.Drawing.Point(10, 0);
            this.buttonSituation.UseTransparentBackground = true;
            this.buttonSituation.Click += new System.EventHandler(this.buttonSituation_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(309, 207);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::SFE.Properties.Resources.en_tete_assosiation_tlilit_f_Copy2_auto_x2_denoised_sharpened_upscaled_x2_removebg_preview;
            this.pictureBoxLogo.ImageRotate = 0F;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(309, 207);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogout.BorderRadius = 10;
            this.buttonLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.FillColor = System.Drawing.Color.Empty;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonLogout.ForeColor = System.Drawing.Color.DimGray;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonLogout.ImageOffset = new System.Drawing.Point(22, 0);
            this.buttonLogout.ImageSize = new System.Drawing.Size(37, 37);
            this.buttonLogout.Location = new System.Drawing.Point(0, 791);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(80, 3, 20, 3);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(50, 8, 0, 8);
            this.buttonLogout.Size = new System.Drawing.Size(309, 62);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "Se déconnecter";
            this.buttonLogout.TextOffset = new System.Drawing.Point(10, 0);
            this.buttonLogout.UseTransparentBackground = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonBoard
            // 
            this.buttonBoard.BackColor = System.Drawing.Color.Transparent;
            this.buttonBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBoard.BorderRadius = 10;
            this.buttonBoard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonBoard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBoard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBoard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBoard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBoard.FillColor = System.Drawing.Color.Empty;
            this.buttonBoard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBoard.ForeColor = System.Drawing.Color.DimGray;
            this.buttonBoard.Image = ((System.Drawing.Image)(resources.GetObject("buttonBoard.Image")));
            this.buttonBoard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonBoard.ImageOffset = new System.Drawing.Point(22, 0);
            this.buttonBoard.ImageSize = new System.Drawing.Size(28, 28);
            this.buttonBoard.Location = new System.Drawing.Point(0, 278);
            this.buttonBoard.Name = "buttonBoard";
            this.buttonBoard.Padding = new System.Windows.Forms.Padding(50, 8, 0, 8);
            this.buttonBoard.Size = new System.Drawing.Size(309, 57);
            this.buttonBoard.TabIndex = 4;
            this.buttonBoard.Text = "Tableau de bord";
            this.buttonBoard.TextOffset = new System.Drawing.Point(10, 0);
            this.buttonBoard.UseTransparentBackground = true;
            this.buttonBoard.Click += new System.EventHandler(this.buttonBoard_Click);
            // 
            // buttonConsommation
            // 
            this.buttonConsommation.BackColor = System.Drawing.Color.Transparent;
            this.buttonConsommation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonConsommation.BorderRadius = 10;
            this.buttonConsommation.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonConsommation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonConsommation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonConsommation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonConsommation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonConsommation.FillColor = System.Drawing.Color.Empty;
            this.buttonConsommation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonConsommation.ForeColor = System.Drawing.Color.DimGray;
            this.buttonConsommation.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsommation.Image")));
            this.buttonConsommation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonConsommation.ImageOffset = new System.Drawing.Point(22, 0);
            this.buttonConsommation.ImageSize = new System.Drawing.Size(37, 37);
            this.buttonConsommation.Location = new System.Drawing.Point(0, 426);
            this.buttonConsommation.Name = "buttonConsommation";
            this.buttonConsommation.Padding = new System.Windows.Forms.Padding(50, 8, 0, 8);
            this.buttonConsommation.Size = new System.Drawing.Size(309, 57);
            this.buttonConsommation.TabIndex = 7;
            this.buttonConsommation.Text = "Consommation";
            this.buttonConsommation.TextOffset = new System.Drawing.Point(10, 0);
            this.buttonConsommation.UseTransparentBackground = true;
            this.buttonConsommation.Click += new System.EventHandler(this.buttonConsommation_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.Color.Transparent;
            this.buttonClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClients.BorderRadius = 10;
            this.buttonClients.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonClients.FillColor = System.Drawing.Color.Transparent;
            this.buttonClients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClients.ForeColor = System.Drawing.Color.DimGray;
            this.buttonClients.Image = ((System.Drawing.Image)(resources.GetObject("buttonClients.Image")));
            this.buttonClients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonClients.ImageOffset = new System.Drawing.Point(22, 0);
            this.buttonClients.ImageSize = new System.Drawing.Size(32, 32);
            this.buttonClients.Location = new System.Drawing.Point(0, 354);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Padding = new System.Windows.Forms.Padding(50, 8, 0, 8);
            this.buttonClients.Size = new System.Drawing.Size(309, 57);
            this.buttonClients.TabIndex = 5;
            this.buttonClients.Text = "Adherents";
            this.buttonClients.TextOffset = new System.Drawing.Point(10, 0);
            this.buttonClients.UseTransparentBackground = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonReglement
            // 
            this.buttonReglement.BackColor = System.Drawing.Color.Transparent;
            this.buttonReglement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReglement.BorderRadius = 10;
            this.buttonReglement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonReglement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonReglement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonReglement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonReglement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonReglement.FillColor = System.Drawing.Color.Empty;
            this.buttonReglement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReglement.ForeColor = System.Drawing.Color.DimGray;
            this.buttonReglement.Image = ((System.Drawing.Image)(resources.GetObject("buttonReglement.Image")));
            this.buttonReglement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonReglement.ImageOffset = new System.Drawing.Point(22, 0);
            this.buttonReglement.ImageSize = new System.Drawing.Size(37, 37);
            this.buttonReglement.Location = new System.Drawing.Point(-3, 498);
            this.buttonReglement.Name = "buttonReglement";
            this.buttonReglement.Padding = new System.Windows.Forms.Padding(50, 8, 0, 8);
            this.buttonReglement.Size = new System.Drawing.Size(309, 57);
            this.buttonReglement.TabIndex = 6;
            this.buttonReglement.Text = "Reglement";
            this.buttonReglement.TextOffset = new System.Drawing.Point(10, 0);
            this.buttonReglement.UseTransparentBackground = true;
            this.buttonReglement.Click += new System.EventHandler(this.buttonReglement_Click);
            // 
            // panelMain
            // 
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(309, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(973, 853);
            panelMain.TabIndex = 10;
            // 
            // defaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 853);
            this.Controls.Add(panelMain);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "defaultForm";
            this.Text = "Association Tililt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.defaultForm_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button buttonConsommation;
        private Guna.UI2.WinForms.Guna2Button buttonReglement;
        private Guna.UI2.WinForms.Guna2Button buttonClients;
        private Guna.UI2.WinForms.Guna2Button buttonBoard;
        private Guna.UI2.WinForms.Guna2Button buttonLogout;
        private Guna.UI2.WinForms.Guna2Panel panelSideMenu;
        private Guna.UI2.WinForms.Guna2Panel panelLogo;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxLogo;
        private Guna.UI2.WinForms.Guna2Button buttonSituation;
        private static Guna.UI2.WinForms.Guna2Panel panelMain;
    }
}

