namespace SFE
{
    partial class situationGlobale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewStituationGlobale = new Guna.UI2.WinForms.Guna2DataGridView();
            this.situation_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adherent_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbr_police = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_consommation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_reglement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.menuStripSituationGlobale = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.découvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStituationGlobale)).BeginInit();
            this.menuStripSituationGlobale.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStituationGlobale
            // 
            this.dataGridViewStituationGlobale.AllowUserToAddRows = false;
            this.dataGridViewStituationGlobale.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewStituationGlobale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStituationGlobale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStituationGlobale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStituationGlobale.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewStituationGlobale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStituationGlobale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewStituationGlobale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStituationGlobale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStituationGlobale.ColumnHeadersHeight = 58;
            this.dataGridViewStituationGlobale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.situation_id,
            this.adherent_id,
            this.nbr_police,
            this.nom,
            this.prenom,
            this.total_consommation,
            this.total_reglement,
            this.reste});
            this.dataGridViewStituationGlobale.ContextMenuStrip = this.menuStripSituationGlobale;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStituationGlobale.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStituationGlobale.EnableHeadersVisualStyles = false;
            this.dataGridViewStituationGlobale.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewStituationGlobale.Location = new System.Drawing.Point(12, 112);
            this.dataGridViewStituationGlobale.Name = "dataGridViewStituationGlobale";
            this.dataGridViewStituationGlobale.ReadOnly = true;
            this.dataGridViewStituationGlobale.RowHeadersVisible = false;
            this.dataGridViewStituationGlobale.RowHeadersWidth = 51;
            this.dataGridViewStituationGlobale.RowTemplate.Height = 24;
            this.dataGridViewStituationGlobale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStituationGlobale.Size = new System.Drawing.Size(949, 629);
            this.dataGridViewStituationGlobale.TabIndex = 0;
            this.dataGridViewStituationGlobale.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewStituationGlobale.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewStituationGlobale.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewStituationGlobale.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewStituationGlobale.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewStituationGlobale.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewStituationGlobale.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewStituationGlobale.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewStituationGlobale.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewStituationGlobale.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewStituationGlobale.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewStituationGlobale.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewStituationGlobale.ThemeStyle.HeaderStyle.Height = 58;
            this.dataGridViewStituationGlobale.ThemeStyle.ReadOnly = true;
            this.dataGridViewStituationGlobale.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewStituationGlobale.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewStituationGlobale.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewStituationGlobale.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewStituationGlobale.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewStituationGlobale.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewStituationGlobale.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewStituationGlobale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStituationGlobale_CellContentClick);
            // 
            // situation_id
            // 
            this.situation_id.HeaderText = "ID";
            this.situation_id.MinimumWidth = 6;
            this.situation_id.Name = "situation_id";
            this.situation_id.ReadOnly = true;
            this.situation_id.Visible = false;
            // 
            // adherent_id
            // 
            this.adherent_id.HeaderText = "Adherent ID";
            this.adherent_id.MinimumWidth = 6;
            this.adherent_id.Name = "adherent_id";
            this.adherent_id.ReadOnly = true;
            this.adherent_id.Visible = false;
            // 
            // nbr_police
            // 
            this.nbr_police.HeaderText = "N° Police";
            this.nbr_police.MinimumWidth = 6;
            this.nbr_police.Name = "nbr_police";
            this.nbr_police.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.MinimumWidth = 6;
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // total_consommation
            // 
            this.total_consommation.HeaderText = "Total Montant Due (DH)";
            this.total_consommation.MinimumWidth = 6;
            this.total_consommation.Name = "total_consommation";
            this.total_consommation.ReadOnly = true;
            // 
            // total_reglement
            // 
            this.total_reglement.HeaderText = "Total Montant Payé (DH)";
            this.total_reglement.MinimumWidth = 6;
            this.total_reglement.Name = "total_reglement";
            this.total_reglement.ReadOnly = true;
            // 
            // reste
            // 
            this.reste.HeaderText = "Reste (DH)";
            this.reste.MinimumWidth = 6;
            this.reste.Name = "reste";
            this.reste.ReadOnly = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BorderRadius = 14;
            this.buttonSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSearch.FillColor = System.Drawing.Color.Silver;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(569, 30);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(122, 38);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Rechercher";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchBar
            // 
            this.textBoxSearchBar.BorderRadius = 14;
            this.textBoxSearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearchBar.DefaultText = "";
            this.textBoxSearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearchBar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearchBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxSearchBar.ForeColor = System.Drawing.Color.Black;
            this.textBoxSearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearchBar.Location = new System.Drawing.Point(12, 24);
            this.textBoxSearchBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearchBar.Name = "textBoxSearchBar";
            this.textBoxSearchBar.PasswordChar = '\0';
            this.textBoxSearchBar.PlaceholderText = "";
            this.textBoxSearchBar.SelectedText = "";
            this.textBoxSearchBar.Size = new System.Drawing.Size(684, 51);
            this.textBoxSearchBar.TabIndex = 3;
            // 
            // menuStripSituationGlobale
            // 
            this.menuStripSituationGlobale.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripSituationGlobale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.découvrirToolStripMenuItem});
            this.menuStripSituationGlobale.Name = "menuStripClientsOptions";
            this.menuStripSituationGlobale.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.menuStripSituationGlobale.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.menuStripSituationGlobale.RenderStyle.ColorTable = null;
            this.menuStripSituationGlobale.RenderStyle.RoundedEdges = true;
            this.menuStripSituationGlobale.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.menuStripSituationGlobale.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menuStripSituationGlobale.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.menuStripSituationGlobale.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.menuStripSituationGlobale.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.menuStripSituationGlobale.Size = new System.Drawing.Size(143, 28);
            // 
            // découvrirToolStripMenuItem
            // 
            this.découvrirToolStripMenuItem.Name = "découvrirToolStripMenuItem";
            this.découvrirToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.découvrirToolStripMenuItem.Text = "Découvrir";
            this.découvrirToolStripMenuItem.Click += new System.EventHandler(this.découvrirToolStripMenuItem_Click);
            // 
            // situationGlobale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 753);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchBar);
            this.Controls.Add(this.dataGridViewStituationGlobale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "situationGlobale";
            this.Text = "situationGlobale";
            this.Load += new System.EventHandler(this.situationGlobale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStituationGlobale)).EndInit();
            this.menuStripSituationGlobale.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewStituationGlobale;
        private Guna.UI2.WinForms.Guna2Button buttonSearch;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearchBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn situation_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adherent_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbr_police;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_consommation;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_reglement;
        private System.Windows.Forms.DataGridViewTextBoxColumn reste;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip menuStripSituationGlobale;
        private System.Windows.Forms.ToolStripMenuItem découvrirToolStripMenuItem;
    }
}