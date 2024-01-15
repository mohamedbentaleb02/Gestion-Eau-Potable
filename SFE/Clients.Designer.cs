namespace SFE
{
    partial class Clients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewClientsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripClientsOptions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.voirConsommationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histoireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUneFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirRéglementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histoireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnPaiementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirSituationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_police = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Télephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouter = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientsList)).BeginInit();
            this.menuStripClientsOptions.SuspendLayout();
            this.SuspendLayout();
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
            this.textBoxSearchBar.Location = new System.Drawing.Point(12, 22);
            this.textBoxSearchBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearchBar.Name = "textBoxSearchBar";
            this.textBoxSearchBar.PasswordChar = '\0';
            this.textBoxSearchBar.PlaceholderText = "";
            this.textBoxSearchBar.SelectedText = "";
            this.textBoxSearchBar.Size = new System.Drawing.Size(684, 51);
            this.textBoxSearchBar.TabIndex = 1;
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
            this.buttonSearch.Location = new System.Drawing.Point(565, 28);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(122, 38);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Rechercher";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewClientsList
            // 
            this.dataGridViewClientsList.AllowUserToAddRows = false;
            this.dataGridViewClientsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewClientsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClientsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClientsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClientsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewClientsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClientsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewClientsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClientsList.ColumnHeadersHeight = 45;
            this.dataGridViewClientsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nom,
            this.Prénom,
            this.CIN,
            this.num_police,
            this.Télephone});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClientsList.EnableHeadersVisualStyles = false;
            this.dataGridViewClientsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewClientsList.Location = new System.Drawing.Point(12, 113);
            this.dataGridViewClientsList.Name = "dataGridViewClientsList";
            this.dataGridViewClientsList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewClientsList.RowHeadersVisible = false;
            this.dataGridViewClientsList.RowHeadersWidth = 51;
            this.dataGridViewClientsList.RowTemplate.Height = 24;
            this.dataGridViewClientsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientsList.Size = new System.Drawing.Size(949, 628);
            this.dataGridViewClientsList.TabIndex = 3;
            this.dataGridViewClientsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewClientsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewClientsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewClientsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewClientsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewClientsList.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewClientsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewClientsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewClientsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewClientsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewClientsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewClientsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewClientsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dataGridViewClientsList.ThemeStyle.ReadOnly = true;
            this.dataGridViewClientsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewClientsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewClientsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewClientsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewClientsList.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewClientsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewClientsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewClientsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientsList_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Nom
            // 
            this.Nom.ContextMenuStrip = this.menuStripClientsOptions;
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // menuStripClientsOptions
            // 
            this.menuStripClientsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripClientsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirConsommationToolStripMenuItem,
            this.voirRéglementToolStripMenuItem,
            this.voirSituationToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.menuStripClientsOptions.Name = "menuStripClientsOptions";
            this.menuStripClientsOptions.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.menuStripClientsOptions.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.menuStripClientsOptions.RenderStyle.ColorTable = null;
            this.menuStripClientsOptions.RenderStyle.RoundedEdges = true;
            this.menuStripClientsOptions.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.menuStripClientsOptions.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menuStripClientsOptions.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.menuStripClientsOptions.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.menuStripClientsOptions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.menuStripClientsOptions.Size = new System.Drawing.Size(211, 152);
            // 
            // voirConsommationToolStripMenuItem
            // 
            this.voirConsommationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histoireToolStripMenuItem,
            this.créerUneFactureToolStripMenuItem});
            this.voirConsommationToolStripMenuItem.Name = "voirConsommationToolStripMenuItem";
            this.voirConsommationToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.voirConsommationToolStripMenuItem.Text = "Consommation";
            // 
            // histoireToolStripMenuItem
            // 
            this.histoireToolStripMenuItem.Name = "histoireToolStripMenuItem";
            this.histoireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.histoireToolStripMenuItem.Text = "Histoire";
            this.histoireToolStripMenuItem.Click += new System.EventHandler(this.histoireToolStripMenuItem_Click);
            // 
            // créerUneFactureToolStripMenuItem
            // 
            this.créerUneFactureToolStripMenuItem.Name = "créerUneFactureToolStripMenuItem";
            this.créerUneFactureToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.créerUneFactureToolStripMenuItem.Text = "Créer une Facture";
            this.créerUneFactureToolStripMenuItem.Click += new System.EventHandler(this.créerUneFactureToolStripMenuItem_Click);
            // 
            // voirRéglementToolStripMenuItem
            // 
            this.voirRéglementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histoireToolStripMenuItem1,
            this.ajouterUnPaiementToolStripMenuItem});
            this.voirRéglementToolStripMenuItem.Name = "voirRéglementToolStripMenuItem";
            this.voirRéglementToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.voirRéglementToolStripMenuItem.Text = "Réglement";
            // 
            // histoireToolStripMenuItem1
            // 
            this.histoireToolStripMenuItem1.Name = "histoireToolStripMenuItem1";
            this.histoireToolStripMenuItem1.Size = new System.Drawing.Size(226, 26);
            this.histoireToolStripMenuItem1.Text = "Histoire";
            this.histoireToolStripMenuItem1.Click += new System.EventHandler(this.histoireToolStripMenuItem1_Click);
            // 
            // ajouterUnPaiementToolStripMenuItem
            // 
            this.ajouterUnPaiementToolStripMenuItem.Name = "ajouterUnPaiementToolStripMenuItem";
            this.ajouterUnPaiementToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.ajouterUnPaiementToolStripMenuItem.Text = "Ajouter un Paiement";
            this.ajouterUnPaiementToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnPaiementToolStripMenuItem_Click);
            // 
            // voirSituationToolStripMenuItem
            // 
            this.voirSituationToolStripMenuItem.Name = "voirSituationToolStripMenuItem";
            this.voirSituationToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.voirSituationToolStripMenuItem.Text = "Situation";
            this.voirSituationToolStripMenuItem.Click += new System.EventHandler(this.voirSituationToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // Prénom
            // 
            this.Prénom.ContextMenuStrip = this.menuStripClientsOptions;
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.MinimumWidth = 6;
            this.Prénom.Name = "Prénom";
            this.Prénom.ReadOnly = true;
            // 
            // CIN
            // 
            this.CIN.ContextMenuStrip = this.menuStripClientsOptions;
            this.CIN.HeaderText = "CIN";
            this.CIN.MinimumWidth = 6;
            this.CIN.Name = "CIN";
            this.CIN.ReadOnly = true;
            // 
            // num_police
            // 
            this.num_police.ContextMenuStrip = this.menuStripClientsOptions;
            this.num_police.HeaderText = "Num police";
            this.num_police.MinimumWidth = 6;
            this.num_police.Name = "num_police";
            this.num_police.ReadOnly = true;
            // 
            // Télephone
            // 
            this.Télephone.ContextMenuStrip = this.menuStripClientsOptions;
            this.Télephone.HeaderText = "Télephone";
            this.Télephone.MinimumWidth = 6;
            this.Télephone.Name = "Télephone";
            this.Télephone.ReadOnly = true;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouter.BorderRadius = 14;
            this.buttonAjouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAjouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAjouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAjouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAjouter.FillColor = System.Drawing.Color.Silver;
            this.buttonAjouter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonAjouter.ForeColor = System.Drawing.Color.Black;
            this.buttonAjouter.Location = new System.Drawing.Point(827, 28);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(134, 45);
            this.buttonAjouter.TabIndex = 62;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(973, 753);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.dataGridViewClientsList);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(973, 753);
            this.Name = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientsList)).EndInit();
            this.menuStripClientsOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearchBar;
        private Guna.UI2.WinForms.Guna2Button buttonSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewClientsList;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip menuStripClientsOptions;
        private System.Windows.Forms.ToolStripMenuItem voirConsommationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirRéglementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirSituationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button buttonAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_police;
        private System.Windows.Forms.DataGridViewTextBoxColumn Télephone;
        private System.Windows.Forms.ToolStripMenuItem histoireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUneFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histoireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnPaiementToolStripMenuItem;
    }
}