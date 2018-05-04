namespace WindowsFormsApp1
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox_Parameters = new System.Windows.Forms.GroupBox();
            this.groupBox_Strategy = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox_CarParam = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_TrackParam = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chart_Laptimes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.strategy1 = new System.Windows.Forms.DataGridView();
            this.PitLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strategy2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strategy3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TireWearCurve = new System.Windows.Forms.DataGridView();
            this.Wear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LapFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelWeightCurve = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Parameters.SuspendLayout();
            this.groupBox_Strategy.SuspendLayout();
            this.groupBox_CarParam.SuspendLayout();
            this.groupBox_TrackParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Laptimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strategy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strategy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strategy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TireWearCurve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelWeightCurve)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Parameters
            // 
            this.groupBox_Parameters.Controls.Add(this.groupBox_Strategy);
            this.groupBox_Parameters.Controls.Add(this.groupBox_CarParam);
            this.groupBox_Parameters.Controls.Add(this.groupBox_TrackParam);
            this.groupBox_Parameters.Location = new System.Drawing.Point(24, 23);
            this.groupBox_Parameters.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_Parameters.Name = "groupBox_Parameters";
            this.groupBox_Parameters.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_Parameters.Size = new System.Drawing.Size(1821, 516);
            this.groupBox_Parameters.TabIndex = 1;
            this.groupBox_Parameters.TabStop = false;
            this.groupBox_Parameters.Text = "Parameters";
            this.groupBox_Parameters.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox_Strategy
            // 
            this.groupBox_Strategy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_Strategy.Controls.Add(this.strategy3);
            this.groupBox_Strategy.Controls.Add(this.strategy2);
            this.groupBox_Strategy.Controls.Add(this.strategy1);
            this.groupBox_Strategy.Controls.Add(this.textBox10);
            this.groupBox_Strategy.Controls.Add(this.textBox9);
            this.groupBox_Strategy.Controls.Add(this.textBox8);
            this.groupBox_Strategy.Controls.Add(this.label10);
            this.groupBox_Strategy.Controls.Add(this.label9);
            this.groupBox_Strategy.Controls.Add(this.label8);
            this.groupBox_Strategy.Controls.Add(this.label11);
            this.groupBox_Strategy.Location = new System.Drawing.Point(1217, 37);
            this.groupBox_Strategy.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_Strategy.Name = "groupBox_Strategy";
            this.groupBox_Strategy.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_Strategy.Size = new System.Drawing.Size(592, 467);
            this.groupBox_Strategy.TabIndex = 2;
            this.groupBox_Strategy.TabStop = false;
            this.groupBox_Strategy.Text = "Strategy";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(447, 424);
            this.textBox10.Margin = new System.Windows.Forms.Padding(6);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(104, 31);
            this.textBox10.TabIndex = 0;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(245, 424);
            this.textBox9.Margin = new System.Windows.Forms.Padding(6);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(104, 31);
            this.textBox9.TabIndex = 0;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(52, 424);
            this.textBox8.Margin = new System.Windows.Forms.Padding(6);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(104, 31);
            this.textBox8.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(476, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Strat 3";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Strat 2";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Strat 1";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 372);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total Race Time";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox_CarParam
            // 
            this.groupBox_CarParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_CarParam.Controls.Add(this.fuelWeightCurve);
            this.groupBox_CarParam.Controls.Add(this.TireWearCurve);
            this.groupBox_CarParam.Controls.Add(this.textBox7);
            this.groupBox_CarParam.Controls.Add(this.label7);
            this.groupBox_CarParam.Controls.Add(this.label6);
            this.groupBox_CarParam.Controls.Add(this.label5);
            this.groupBox_CarParam.Location = new System.Drawing.Point(350, 37);
            this.groupBox_CarParam.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_CarParam.Name = "groupBox_CarParam";
            this.groupBox_CarParam.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_CarParam.Size = new System.Drawing.Size(855, 467);
            this.groupBox_CarParam.TabIndex = 1;
            this.groupBox_CarParam.TabStop = false;
            this.groupBox_CarParam.Text = "Car param";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(675, 95);
            this.textBox7.Margin = new System.Windows.Forms.Padding(6);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(104, 31);
            this.textBox7.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fuel consumption";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fuel weight curve";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tire wear curve";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox_TrackParam
            // 
            this.groupBox_TrackParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_TrackParam.Controls.Add(this.label3);
            this.groupBox_TrackParam.Controls.Add(this.label2);
            this.groupBox_TrackParam.Controls.Add(this.label1);
            this.groupBox_TrackParam.Controls.Add(this.textBox3);
            this.groupBox_TrackParam.Controls.Add(this.textBox2);
            this.groupBox_TrackParam.Controls.Add(this.textBox1);
            this.groupBox_TrackParam.Location = new System.Drawing.Point(12, 37);
            this.groupBox_TrackParam.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_TrackParam.Name = "groupBox_TrackParam";
            this.groupBox_TrackParam.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_TrackParam.Size = new System.Drawing.Size(326, 467);
            this.groupBox_TrackParam.TabIndex = 0;
            this.groupBox_TrackParam.TabStop = false;
            this.groupBox_TrackParam.Text = "Track param";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Track length (m)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total laps";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(206, 154);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 31);
            this.textBox3.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 104);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 31);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 31);
            this.textBox1.TabIndex = 0;
            // 
            // chart_Laptimes
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Laptimes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Laptimes.Legends.Add(legend1);
            this.chart_Laptimes.Location = new System.Drawing.Point(24, 597);
            this.chart_Laptimes.Margin = new System.Windows.Forms.Padding(6);
            this.chart_Laptimes.Name = "chart_Laptimes";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Strategy 1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Strategy 2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Strategy 3";
            this.chart_Laptimes.Series.Add(series1);
            this.chart_Laptimes.Series.Add(series2);
            this.chart_Laptimes.Series.Add(series3);
            this.chart_Laptimes.Size = new System.Drawing.Size(1821, 467);
            this.chart_Laptimes.TabIndex = 2;
            this.chart_Laptimes.Text = "Laptimes";
            this.chart_Laptimes.Click += new System.EventHandler(this.chart_Laptimes_Click);
            // 
            // strategy1
            // 
            this.strategy1.AllowUserToResizeColumns = false;
            this.strategy1.AllowUserToResizeRows = false;
            this.strategy1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.strategy1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.strategy1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PitLap});
            this.strategy1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.strategy1.Location = new System.Drawing.Point(52, 71);
            this.strategy1.MultiSelect = false;
            this.strategy1.Name = "strategy1";
            this.strategy1.RowHeadersVisible = false;
            this.strategy1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.strategy1.RowTemplate.Height = 33;
            this.strategy1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.strategy1.Size = new System.Drawing.Size(120, 272);
            this.strategy1.TabIndex = 3;
            this.strategy1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PitLap
            // 
            this.PitLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PitLap.HeaderText = "Pit lap";
            this.PitLap.MaxInputLength = 3;
            this.PitLap.Name = "PitLap";
            this.PitLap.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PitLap.Width = 50;
            // 
            // strategy2
            // 
            this.strategy2.AllowUserToResizeColumns = false;
            this.strategy2.AllowUserToResizeRows = false;
            this.strategy2.BackgroundColor = System.Drawing.SystemColors.Info;
            this.strategy2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.strategy2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.strategy2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.strategy2.Location = new System.Drawing.Point(245, 71);
            this.strategy2.MultiSelect = false;
            this.strategy2.Name = "strategy2";
            this.strategy2.RowHeadersVisible = false;
            this.strategy2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.strategy2.RowTemplate.Height = 33;
            this.strategy2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.strategy2.Size = new System.Drawing.Size(118, 272);
            this.strategy2.TabIndex = 3;
            this.strategy2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Pit lap";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // strategy3
            // 
            this.strategy3.AllowUserToResizeColumns = false;
            this.strategy3.AllowUserToResizeRows = false;
            this.strategy3.BackgroundColor = System.Drawing.Color.Tomato;
            this.strategy3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.strategy3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.strategy3.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.strategy3.Location = new System.Drawing.Point(447, 71);
            this.strategy3.MultiSelect = false;
            this.strategy3.Name = "strategy3";
            this.strategy3.RowHeadersVisible = false;
            this.strategy3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.strategy3.RowTemplate.Height = 33;
            this.strategy3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.strategy3.Size = new System.Drawing.Size(114, 272);
            this.strategy3.TabIndex = 3;
            this.strategy3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Pit lap";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // TireWearCurve
            // 
            this.TireWearCurve.AllowUserToResizeColumns = false;
            this.TireWearCurve.AllowUserToResizeRows = false;
            this.TireWearCurve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TireWearCurve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Wear,
            this.LapFactor});
            this.TireWearCurve.Location = new System.Drawing.Point(24, 95);
            this.TireWearCurve.MultiSelect = false;
            this.TireWearCurve.Name = "TireWearCurve";
            this.TireWearCurve.RowHeadersVisible = false;
            this.TireWearCurve.RowHeadersWidth = 35;
            this.TireWearCurve.RowTemplate.Height = 33;
            this.TireWearCurve.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TireWearCurve.Size = new System.Drawing.Size(248, 360);
            this.TireWearCurve.TabIndex = 1;
            this.TireWearCurve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // Wear
            // 
            this.Wear.HeaderText = "Wear%";
            this.Wear.Name = "Wear";
            this.Wear.Width = 60;
            // 
            // LapFactor
            // 
            this.LapFactor.HeaderText = "LapFactor";
            this.LapFactor.Name = "LapFactor";
            // 
            // fuelWeightCurve
            // 
            this.fuelWeightCurve.AllowUserToResizeColumns = false;
            this.fuelWeightCurve.AllowUserToResizeRows = false;
            this.fuelWeightCurve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.fuelWeightCurve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.fuelWeightCurve.Location = new System.Drawing.Point(308, 95);
            this.fuelWeightCurve.MultiSelect = false;
            this.fuelWeightCurve.Name = "fuelWeightCurve";
            this.fuelWeightCurve.RowHeadersVisible = false;
            this.fuelWeightCurve.RowHeadersWidth = 35;
            this.fuelWeightCurve.RowTemplate.Height = 33;
            this.fuelWeightCurve.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fuelWeightCurve.Size = new System.Drawing.Size(248, 360);
            this.fuelWeightCurve.TabIndex = 1;
            this.fuelWeightCurve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fuel(Kg)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "LapTime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1926, 1079);
            this.Controls.Add(this.chart_Laptimes);
            this.Controls.Add(this.groupBox_Parameters);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1500, 1150);
            this.Name = "FormMain";
            this.Text = "Orion Strategy Planning Tool";
            this.groupBox_Parameters.ResumeLayout(false);
            this.groupBox_Strategy.ResumeLayout(false);
            this.groupBox_Strategy.PerformLayout();
            this.groupBox_CarParam.ResumeLayout(false);
            this.groupBox_CarParam.PerformLayout();
            this.groupBox_TrackParam.ResumeLayout(false);
            this.groupBox_TrackParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Laptimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strategy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strategy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strategy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TireWearCurve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelWeightCurve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Parameters;
        private System.Windows.Forms.GroupBox groupBox_Strategy;
        private System.Windows.Forms.GroupBox groupBox_CarParam;
        private System.Windows.Forms.GroupBox groupBox_TrackParam;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Laptimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DataGridView strategy1;
        private System.Windows.Forms.DataGridView strategy3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView strategy2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PitLap;
        private System.Windows.Forms.DataGridView TireWearCurve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wear;
        private System.Windows.Forms.DataGridViewTextBoxColumn LapFactor;
        private System.Windows.Forms.DataGridView fuelWeightCurve;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

