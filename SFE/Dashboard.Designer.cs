namespace SFE
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartConsommation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.yearOfConsommation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.appEauDataSet = new SFE.appEauDataSet();
            this.consommationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consommationTableAdapter = new SFE.appEauDataSetTableAdapters.consommationTableAdapter();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartConsommation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appEauDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consommationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartConsommation
            // 
            this.chartConsommation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chartConsommation.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea10.CursorX.Interval = 0D;
            chartArea10.Name = "ChartArea1";
            this.chartConsommation.ChartAreas.Add(chartArea10);
            this.chartConsommation.Location = new System.Drawing.Point(0, 0);
            this.chartConsommation.Name = "chartConsommation";
            series10.ChartArea = "ChartArea1";
            series10.CustomProperties = "PointWidth=0.65";
            series10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series10.MarkerStep = 2;
            series10.Name = "Consommation";
            series10.SmartLabelStyle.CalloutLineWidth = 0;
            this.chartConsommation.Series.Add(series10);
            this.chartConsommation.Size = new System.Drawing.Size(973, 853);
            this.chartConsommation.TabIndex = 0;
            title10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title10.ForeColor = System.Drawing.Color.DimGray;
            title10.Name = "consommation_chart";
            title10.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            title10.Text = "Diagramme de consommation";
            this.chartConsommation.Titles.Add(title10);
            // 
            // yearOfConsommation
            // 
            this.yearOfConsommation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearOfConsommation.BackColor = System.Drawing.Color.Transparent;
            this.yearOfConsommation.BorderRadius = 8;
            this.yearOfConsommation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.yearOfConsommation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearOfConsommation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yearOfConsommation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yearOfConsommation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.yearOfConsommation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.yearOfConsommation.ItemHeight = 24;
            this.yearOfConsommation.Location = new System.Drawing.Point(800, 18);
            this.yearOfConsommation.Name = "yearOfConsommation";
            this.yearOfConsommation.Size = new System.Drawing.Size(140, 30);
            this.yearOfConsommation.TabIndex = 0;
            this.yearOfConsommation.SelectedValueChanged += new System.EventHandler(this.yearOfConsommation_SelectedValueChanged);
            // 
            // appEauDataSet
            // 
            this.appEauDataSet.DataSetName = "appEauDataSet";
            this.appEauDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consommationBindingSource
            // 
            this.consommationBindingSource.DataMember = "consommation";
            this.consommationBindingSource.DataSource = this.appEauDataSet;
            // 
            // consommationTableAdapter
            // 
            this.consommationTableAdapter.ClearBeforeFill = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(85, 44);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(67, 30);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "tonne";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(973, 853);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.yearOfConsommation);
            this.Controls.Add(this.chartConsommation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartConsommation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appEauDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consommationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartConsommation;
        private Guna.UI2.WinForms.Guna2ComboBox yearOfConsommation;
        private appEauDataSet appEauDataSet;
        private System.Windows.Forms.BindingSource consommationBindingSource;
        private appEauDataSetTableAdapters.consommationTableAdapter consommationTableAdapter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}