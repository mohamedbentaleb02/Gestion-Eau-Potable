namespace SFE
{
    partial class ConsRegSitBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsRegSitBar));
            this.panelConRegSitBar = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonSituation = new Guna.UI2.WinForms.Guna2Button();
            this.buttonReglement = new Guna.UI2.WinForms.Guna2Button();
            this.buttonConsommation = new Guna.UI2.WinForms.Guna2Button();
            panelMainConRegSit = new Guna.UI2.WinForms.Guna2Panel();
            this.panelConRegSitBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConRegSitBar
            // 
            this.panelConRegSitBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelConRegSitBar.Controls.Add(this.buttonSituation);
            this.panelConRegSitBar.Controls.Add(this.buttonReglement);
            this.panelConRegSitBar.Controls.Add(this.buttonConsommation);
            this.panelConRegSitBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConRegSitBar.Location = new System.Drawing.Point(0, 0);
            this.panelConRegSitBar.Name = "panelConRegSitBar";
            this.panelConRegSitBar.Size = new System.Drawing.Size(973, 100);
            this.panelConRegSitBar.TabIndex = 0;
            // 
            // buttonSituation
            // 
            this.buttonSituation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.buttonSituation.Location = new System.Drawing.Point(632, 0);
            this.buttonSituation.Name = "buttonSituation";
            this.buttonSituation.Padding = new System.Windows.Forms.Padding(50, 8, 0, 8);
            this.buttonSituation.Size = new System.Drawing.Size(341, 100);
            this.buttonSituation.TabIndex = 9;
            this.buttonSituation.Text = "Situation";
            this.buttonSituation.TextOffset = new System.Drawing.Point(10, 0);
            this.buttonSituation.UseTransparentBackground = true;
            this.buttonSituation.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // buttonReglement
            // 
            this.buttonReglement.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.buttonReglement.Location = new System.Drawing.Point(284, 0);
            this.buttonReglement.Name = "buttonReglement";
            this.buttonReglement.Padding = new System.Windows.Forms.Padding(50, 8, 0, 8);
            this.buttonReglement.Size = new System.Drawing.Size(321, 100);
            this.buttonReglement.TabIndex = 8;
            this.buttonReglement.Text = "Reglement";
            this.buttonReglement.TextOffset = new System.Drawing.Point(10, 0);
            this.buttonReglement.UseTransparentBackground = true;
            this.buttonReglement.Click += new System.EventHandler(this.buttonReglement_Click);
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
            this.buttonConsommation.Location = new System.Drawing.Point(0, 0);
            this.buttonConsommation.Name = "buttonConsommation";
            this.buttonConsommation.Padding = new System.Windows.Forms.Padding(50, 8, 0, 8);
            this.buttonConsommation.Size = new System.Drawing.Size(274, 100);
            this.buttonConsommation.TabIndex = 9;
            this.buttonConsommation.Text = "Consommation";
            this.buttonConsommation.TextOffset = new System.Drawing.Point(10, 0);
            this.buttonConsommation.UseTransparentBackground = true;
            this.buttonConsommation.Click += new System.EventHandler(this.buttonConsommation_Click);
            // 
            // panelMainConRegSit
            // 
            panelMainConRegSit.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMainConRegSit.Location = new System.Drawing.Point(0, 100);
            panelMainConRegSit.Name = "panelMainConRegSit";
            panelMainConRegSit.Size = new System.Drawing.Size(973, 753);
            panelMainConRegSit.TabIndex = 1;
            // 
            // ConsRegSitBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(973, 853);
            this.Controls.Add(panelMainConRegSit);
            this.Controls.Add(this.panelConRegSitBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsRegSitBar";
            this.Text = "ConsRegSitBar";
            this.panelConRegSitBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelConRegSitBar;
        private Guna.UI2.WinForms.Guna2Button buttonReglement;
        private Guna.UI2.WinForms.Guna2Button buttonConsommation;
        private Guna.UI2.WinForms.Guna2Button buttonSituation;
        private static Guna.UI2.WinForms.Guna2Panel panelMainConRegSit;
    }
}