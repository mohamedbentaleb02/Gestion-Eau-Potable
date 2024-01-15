namespace SFE
{
    partial class ReglementList
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
            this.dataGridViewRegList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adherent_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbr_recu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripConsRegOptions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.découvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paiement_mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelNom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonAjouter = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegList)).BeginInit();
            this.contextMenuStripConsRegOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRegList
            // 
            this.dataGridViewRegList.AllowUserToAddRows = false;
            this.dataGridViewRegList.AllowUserToDeleteRows = false;
            this.dataGridViewRegList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewRegList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRegList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRegList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRegList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRegList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRegList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRegList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRegList.ColumnHeadersHeight = 45;
            this.dataGridViewRegList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRegList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.adherent_id,
            this.nbr_recu,
            this.operation_date,
            this.montant,
            this.paiement_mode,
            this.observation,
            this.recu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRegList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRegList.EnableHeadersVisualStyles = false;
            this.dataGridViewRegList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRegList.Location = new System.Drawing.Point(12, 98);
            this.dataGridViewRegList.Name = "dataGridViewRegList";
            this.dataGridViewRegList.ReadOnly = true;
            this.dataGridViewRegList.RowHeadersVisible = false;
            this.dataGridViewRegList.RowHeadersWidth = 51;
            this.dataGridViewRegList.RowTemplate.Height = 24;
            this.dataGridViewRegList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRegList.Size = new System.Drawing.Size(949, 643);
            this.dataGridViewRegList.TabIndex = 2;
            this.dataGridViewRegList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRegList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewRegList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewRegList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewRegList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewRegList.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRegList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRegList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewRegList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewRegList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewRegList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewRegList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRegList.ThemeStyle.HeaderStyle.Height = 45;
            this.dataGridViewRegList.ThemeStyle.ReadOnly = true;
            this.dataGridViewRegList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRegList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRegList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridViewRegList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewRegList.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewRegList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRegList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewRegList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRegList_CellContentClick);
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
            // nbr_recu
            // 
            this.nbr_recu.ContextMenuStrip = this.contextMenuStripConsRegOptions;
            this.nbr_recu.HeaderText = "Num Reçu";
            this.nbr_recu.MinimumWidth = 6;
            this.nbr_recu.Name = "nbr_recu";
            this.nbr_recu.ReadOnly = true;
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
            // montant
            // 
            this.montant.ContextMenuStrip = this.contextMenuStripConsRegOptions;
            this.montant.HeaderText = "Montant (DH)";
            this.montant.MinimumWidth = 6;
            this.montant.Name = "montant";
            this.montant.ReadOnly = true;
            // 
            // paiement_mode
            // 
            this.paiement_mode.ContextMenuStrip = this.contextMenuStripConsRegOptions;
            this.paiement_mode.HeaderText = "Mode de Paiement";
            this.paiement_mode.MinimumWidth = 6;
            this.paiement_mode.Name = "paiement_mode";
            this.paiement_mode.ReadOnly = true;
            // 
            // observation
            // 
            this.observation.HeaderText = "Observation";
            this.observation.MinimumWidth = 6;
            this.observation.Name = "observation";
            this.observation.ReadOnly = true;
            this.observation.Visible = false;
            // 
            // recu
            // 
            this.recu.HeaderText = "Recu";
            this.recu.MinimumWidth = 6;
            this.recu.Name = "recu";
            this.recu.ReadOnly = true;
            this.recu.Visible = false;
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
            this.textBoxNom.TabIndex = 51;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = false;
            this.labelNom.BackColor = System.Drawing.Color.Transparent;
            this.labelNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(12, 33);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(184, 27);
            this.labelNom.TabIndex = 50;
            this.labelNom.Text = "Adherent:";
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
            // ReglementList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(973, 753);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dataGridViewRegList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReglementList";
            this.Text = "ReglementList";
            this.Load += new System.EventHandler(this.ReglementList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegList)).EndInit();
            this.contextMenuStripConsRegOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewRegList;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip contextMenuStripConsRegOptions;
        private System.Windows.Forms.ToolStripMenuItem découvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adherent_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbr_recu;
        private System.Windows.Forms.DataGridViewTextBoxColumn operation_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn paiement_mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn observation;
        private System.Windows.Forms.DataGridViewTextBoxColumn recu;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNom;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelNom;
        private Guna.UI2.WinForms.Guna2Button buttonAjouter;
    }
}