namespace UI_Donaciones
{
    partial class frmGraficaDonaciones
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gBoxFiltro = new System.Windows.Forms.GroupBox();
            this.cbTipoDonador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpAlafecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDelaFecha = new System.Windows.Forms.DateTimePicker();
            this.chartDonaciones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbTipoGrafico = new System.Windows.Forms.ComboBox();
            this.gBoxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDonaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxFiltro
            // 
            this.gBoxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gBoxFiltro.Controls.Add(this.cbTipoGrafico);
            this.gBoxFiltro.Controls.Add(this.cbTipoDonador);
            this.gBoxFiltro.Controls.Add(this.label3);
            this.gBoxFiltro.Controls.Add(this.dtpAlafecha);
            this.gBoxFiltro.Controls.Add(this.label2);
            this.gBoxFiltro.Controls.Add(this.label1);
            this.gBoxFiltro.Controls.Add(this.dtpDelaFecha);
            this.gBoxFiltro.Location = new System.Drawing.Point(12, 12);
            this.gBoxFiltro.Name = "gBoxFiltro";
            this.gBoxFiltro.Size = new System.Drawing.Size(178, 321);
            this.gBoxFiltro.TabIndex = 0;
            this.gBoxFiltro.TabStop = false;
            this.gBoxFiltro.Text = "Filtro";
            // 
            // cbTipoDonador
            // 
            this.cbTipoDonador.DisplayMember = "text";
            this.cbTipoDonador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDonador.FormattingEnabled = true;
            this.cbTipoDonador.Location = new System.Drawing.Point(10, 179);
            this.cbTipoDonador.Name = "cbTipoDonador";
            this.cbTipoDonador.Size = new System.Drawing.Size(144, 21);
            this.cbTipoDonador.TabIndex = 5;
            this.cbTipoDonador.ValueMember = "value";
            this.cbTipoDonador.SelectedIndexChanged += new System.EventHandler(this.cbTipoDonador_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mostrar por";
            // 
            // dtpAlafecha
            // 
            this.dtpAlafecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAlafecha.Location = new System.Drawing.Point(10, 109);
            this.dtpAlafecha.Name = "dtpAlafecha";
            this.dtpAlafecha.Size = new System.Drawing.Size(103, 20);
            this.dtpAlafecha.TabIndex = 3;
            this.dtpAlafecha.ValueChanged += new System.EventHandler(this.dtpAlafecha_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "A la fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "De la fecha";
            // 
            // dtpDelaFecha
            // 
            this.dtpDelaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDelaFecha.Location = new System.Drawing.Point(10, 52);
            this.dtpDelaFecha.Name = "dtpDelaFecha";
            this.dtpDelaFecha.Size = new System.Drawing.Size(103, 20);
            this.dtpDelaFecha.TabIndex = 1;
            this.dtpDelaFecha.ValueChanged += new System.EventHandler(this.dtpDelaFecha_ValueChanged);
            // 
            // chartDonaciones
            // 
            this.chartDonaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartDonaciones.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDonaciones.Legends.Add(legend4);
            this.chartDonaciones.Location = new System.Drawing.Point(196, 12);
            this.chartDonaciones.Name = "chartDonaciones";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDonaciones.Series.Add(series4);
            this.chartDonaciones.Size = new System.Drawing.Size(592, 321);
            this.chartDonaciones.TabIndex = 1;
            this.chartDonaciones.Text = "chart1";
            // 
            // cbTipoGrafico
            // 
            this.cbTipoGrafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoGrafico.FormattingEnabled = true;
            this.cbTipoGrafico.Items.AddRange(new object[] {
            "Area ",
            "Bar ",
            "BoxPlot ",
            "Bubble ",
            "Candlestick ",
            "Column ",
            "Doughnut ",
            "ErrorBar ",
            "FastLine ",
            "FastPoint ",
            "Funnel ",
            "Kagi ",
            "Line ",
            "Pie ",
            "Point ",
            "PointAndFigure ",
            "Polar ",
            "Pyramid ",
            "Radar ",
            "Range ",
            "RangeBar ",
            "RangeColumn ",
            "Renko ",
            "Spline ",
            "SplineArea ",
            "SplineRange ",
            "StackedArea ",
            "StackedArea100 ",
            "StackedBar ",
            "StackedBar100 ",
            "StackedColumn ",
            "StackedColumn100 ",
            "StepLine ",
            "Stock ",
            "ThreeLineBreak"});
            this.cbTipoGrafico.Location = new System.Drawing.Point(10, 265);
            this.cbTipoGrafico.Name = "cbTipoGrafico";
            this.cbTipoGrafico.Size = new System.Drawing.Size(144, 21);
            this.cbTipoGrafico.TabIndex = 6;
            this.cbTipoGrafico.SelectedIndexChanged += new System.EventHandler(this.cbTipoGrafico_SelectedIndexChanged);
            // 
            // frmGraficaDonaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.chartDonaciones);
            this.Controls.Add(this.gBoxFiltro);
            this.Name = "frmGraficaDonaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadísticas de donaciones por rango de fechas";
            this.Load += new System.EventHandler(this.frmGraficaDonaciones_Load);
            this.gBoxFiltro.ResumeLayout(false);
            this.gBoxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDonaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxFiltro;
        private System.Windows.Forms.DateTimePicker dtpDelaFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAlafecha;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDonaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoDonador;
        private System.Windows.Forms.ComboBox cbTipoGrafico;
    }
}