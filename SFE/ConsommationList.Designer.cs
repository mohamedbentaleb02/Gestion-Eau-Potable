namespace SFE
{
    partial class ConsommationList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewConsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adherent_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbr_quittance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripConsRegOptions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.découvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntur_avant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntur_apres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntt_consommee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ton_prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant_aPayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periode_consommation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consommationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelNom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBoxNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonAjouter = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsList)).BeginInit();
            this.contextMenuStripConsRegOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consommationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConsList
            // 
            this.dataGridViewConsList.AllowUserToAddRows = false;
            this.dataGridViewConsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dataGridViewConsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewConsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewConsList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewConsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewConsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewConsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewConsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewConsList.ColumnHeadersHeight = 45;
            this.dataGridViewConsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewConsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.adherent_id,
            this.nbr_quittance,
            this.operation_date,
            this.cntur_avant,
            this.cntur_apres,
            this.qntt_consommee,
            this.ton_prix,
            this.total_prix,
            this.taxe,
            this.montant_aPayer,
            this.periode_consommation});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewConsList.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewConsList.EnableHeadersVisualStyles = false;
            this.dataGridViewConsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewConsList.Location = new System.Drawing.Point(12, 98);
            this.dataGridViewConsList.Name = "dataGridViewConsList";
            this.dataGridViewConsList.ReadOnly = true;
            this.dataGridViewConsList.RowHeadersVisible = false;
            this.dataGridViewConsList.RowHeadersWidth = 51;
            this.dataGridViewConsList.RowTemplate.Height = 24;
            this.dataGridViewConsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConsList.Size = new System.Drawing.Size(949, 643);
            this.dataGridViewConsList.TabIndex = 0;
            this.dataGridViewConsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewConsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewConsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewConsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewConsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewConsList.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewConsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewConsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewConsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewConsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewConsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewConsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewConsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dataGridViewConsList.ThemeStyle.ReadOnly = true;
            this.dataGridViewConsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewConsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewConsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewConsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewConsList.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewConsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewConsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewConsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsList_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // adherent_id
            // 
            this.adherent_id.HeaderText = "Adherent ID";
            this.adherent_id.MinimumWidth = 6;
            this.adherent_id.Name = "adherent_id";
            this.adherent_id.ReadOnly = true;
            this.adherent_id.Visible = false;
            // 
            // nbr_quittance
            // 
            this.nbr_quittance.ContextMenuStrip = this.contextMenuStripConsRegOptions;
            this.nbr_quittance.HeaderText = "Num Quittance";
            this.nbr_quittance.MinimumWidth = 6;
            this.nbr_quittance.Name = "nbr_quittance";
            this.nbr_quittance.ReadOnly = true;
            // 
            // contextMenuStripConsRegOptions
            // 
            this.contextMenuStripConsRegOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripConsRegOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.découvrirToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStripConsRegOptions.Name = "contextMenuStripConsRegOptions";
            this.contextMenuStripConsRegOptions.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.contextMenuStripConsRegOptions.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.contextMenuStripConsRegOptions.RenderStyle.ColorTable = null;
            this.contextMenuStripConsRegOptions.RenderStyle.RoundedEdges = true;
            this.contextMenuStripConsRegOptions.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.contextMenuStripConsRegOptions.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.contextMenuStripConsRegOptions.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.contextMenuStripConsRegOptions.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.contextMenuStripConsRegOptions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.contextMenuStripConsRegOptions.Size = new System.Drawing.Size(148, 52);
            // 
            // découvrirToolStripMenuItem
            // 
            this.découvrirToolStripMenuItem.Name = "découvrirToolStripMenuItem";
            this.découvrirToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.découvrirToolStripMenuItem.Text = "Découvrir";
            this.découvrirToolStripMenuItem.Click += new System.EventHandler(this.découvrirToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // operation_date
            // 
            this.operation_date.ContextMenuStrip = this.contextMenuStripConsRegOptions;
            this.operation_date.HeaderText = "Date d\'Opération";
            this.operation_date.MinimumWidth = 6;
            this.operation_date.Name = "operation_date";
            this.operation_date.ReadOnly = true;
            // 
            // cntur_avant
            // 
            this.cntur_avant.HeaderText = "Compteur Avant";
            this.cntur_avant.MinimumWidth = 6;
            this.cntur_avant.Name = "cntur_avant";
            this.cntur_avant.ReadOnly = true;
            this.cntur_avant.Visible = false;
            // 
            // cntur_apres
            // 
            this.cntur_apres.HeaderText = "Compteur Aprés";
            this.cntur_apres.MinimumWidth = 6;
            this.cntur_apres.Name = "cntur_apres";
            this.cntur_apres.ReadOnly = true;
            this.cntur_apres.Visible = false;
            // 
            // qntt_consommee
            // 
            this.qntt_consommee.ContextMenuStrip = this.contextMenuStripConsRegOptions;
            this.qntt_consommee.HeaderText = "Qntt Consommée (t)";
            this.qntt_consommee.MinimumWidth = 6;
            this.qntt_consommee.Name = "qntt_consommee";
            this.qntt_consommee.ReadOnly = true;
            // 
            // ton_prix
            // 
            this.ton_prix.HeaderText = "Ton Prix";
            this.ton_prix.MinimumWidth = 6;
            this.ton_prix.Name = "ton_prix";
            this.ton_prix.ReadOnly = true;
            this.ton_prix.Visible = false;
            // 
            // total_prix
            // 
            this.total_prix.HeaderText = "Prix Total";
            this.total_prix.MinimumWidth = 6;
            this.total_prix.Name = "total_prix";
            this.total_prix.ReadOnly = true;
            this.total_prix.Visible = false;
            // 
            // taxe
            // 
            this.taxe.HeaderText = "Taxe";
            this.taxe.MinimumWidth = 6;
            this.taxe.Name = "taxe";
            this.taxe.ReadOnly = true;
            this.taxe.Visible = false;
            // 
            // montant_aPayer
            // 
            this.montant_aPayer.ContextMenuStrip = this.contextMenuStripConsRegOptions;
            this.montant_aPayer.HeaderText = "Montant (DH)";
            this.montant_aPayer.MinimumWidth = 6;
            this.montant_aPayer.Name = "montant_aPayer";
            this.montant_aPayer.ReadOnly = true;
            // 
            // periode_consommation
            // 
            this.periode_consommation.ContextMenuStrip = this.contextMenuStripConsRegOptions;
            this.periode_consommation.HeaderText = "Période";
            this.periode_consommation.MinimumWidth = 6;
            this.periode_consommation.Name = "periode_consommation";
            this.periode_consommation.ReadOnly = true;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = false;
            this.labelNom.BackColor = System.Drawing.Color.Transparent;
            this.labelNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(12, 33);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(184, 27);
            this.labelNom.TabIndex = 48;
            this.labelNom.Text = "Adherent:";
            // 
            // textBoxNom
            // 
            this.textBoxNom.BorderRadius = 14;
            this.textBoxNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNom.DefaultText = "";
            this.textBoxNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNom.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxNom.ForeColor = System.Drawing.Color.Black;
            this.textBoxNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNom.Location = new System.Drawing.Point(219, 23);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.PasswordChar = '\0';
            this.textBoxNom.PlaceholderText = "";
            this.textBoxNom.ReadOnly = true;
            this.textBoxNom.SelectedText = "";
            this.textBoxNom.Size = new System.Drawing.Size(248, 50);
            this.textBoxNom.TabIndex = 49;
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
            this.buttonAjouter.Location = new System.Drawing.Point(827, 23);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(134, 45);
            this.buttonAjouter.TabIndex = 63;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // ConsommationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(973, 753);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridViewConsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsommationList";
            this.Text = "ConsommationList";
            this.Load += new System.EventHandler(this.ConsommationList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsList)).EndInit();
            this.contextMenuStripConsRegOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.consommationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewConsList;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip contextMenuStripConsRegOptions;
        private System.Windows.Forms.ToolStripMenuItem découvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.BindingSource consommationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adherent_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbr_quittance;
        private System.Windows.Forms.DataGridViewTextBoxColumn operation_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntur_avant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntur_apres;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntt_consommee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ton_prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant_aPayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn periode_consommation;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelNom;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNom;
        private Guna.UI2.WinForms.Guna2Button buttonAjouter;
    }
}