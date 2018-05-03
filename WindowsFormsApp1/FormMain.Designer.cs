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
            this.groupBox_TrackParam = new System.Windows.Forms.GroupBox();
            this.chart_Laptimes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox_CarParam = new System.Windows.Forms.GroupBox();
            this.groupBox_Strategy = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.groupBox_Parameters.SuspendLayout();
            this.groupBox_TrackParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Laptimes)).BeginInit();
            this.groupBox_CarParam.SuspendLayout();
            this.groupBox_Strategy.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Parameters
            // 
            this.groupBox_Parameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Parameters.Controls.Add(this.groupBox_Strategy);
            this.groupBox_Parameters.Controls.Add(this.groupBox_CarParam);
            this.groupBox_Parameters.Controls.Add(this.groupBox_TrackParam);
            this.groupBox_Parameters.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Parameters.Name = "groupBox_Parameters";
            this.groupBox_Parameters.Size = new System.Drawing.Size(710, 291);
            this.groupBox_Parameters.TabIndex = 1;
            this.groupBox_Parameters.TabStop = false;
            this.groupBox_Parameters.Text = "Parameters";
            this.groupBox_Parameters.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.groupBox_TrackParam.Location = new System.Drawing.Point(6, 19);
            this.groupBox_TrackParam.Name = "groupBox_TrackParam";
            this.groupBox_TrackParam.Size = new System.Drawing.Size(163, 186);
            this.groupBox_TrackParam.TabIndex = 0;
            this.groupBox_TrackParam.TabStop = false;
            this.groupBox_TrackParam.Text = "Track param";
            // 
            // chart_Laptimes
            // 
            this.chart_Laptimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart_Laptimes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Laptimes.Legends.Add(legend1);
            this.chart_Laptimes.Location = new System.Drawing.Point(12, 309);
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
            this.chart_Laptimes.Size = new System.Drawing.Size(1455, 560);
            this.chart_Laptimes.TabIndex = 2;
            this.chart_Laptimes.Text = "Laptimes";
            this.chart_Laptimes.Click += new System.EventHandler(this.chart_Laptimes_Click);
            // 
            // groupBox_CarParam
            // 
            this.groupBox_CarParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_CarParam.Controls.Add(this.textBox7);
            this.groupBox_CarParam.Controls.Add(this.textBox6);
            this.groupBox_CarParam.Controls.Add(this.label7);
            this.groupBox_CarParam.Controls.Add(this.label6);
            this.groupBox_CarParam.Controls.Add(this.textBox5);
            this.groupBox_CarParam.Controls.Add(this.label5);
            this.groupBox_CarParam.Controls.Add(this.textBox4);
            this.groupBox_CarParam.Controls.Add(this.label4);
            this.groupBox_CarParam.Location = new System.Drawing.Point(175, 19);
            this.groupBox_CarParam.Name = "groupBox_CarParam";
            this.groupBox_CarParam.Size = new System.Drawing.Size(204, 186);
            this.groupBox_CarParam.TabIndex = 1;
            this.groupBox_CarParam.TabStop = false;
            this.groupBox_CarParam.Text = "Car param";
            // 
            // groupBox_Strategy
            // 
            this.groupBox_Strategy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_Strategy.Controls.Add(this.textBox10);
            this.groupBox_Strategy.Controls.Add(this.textBox9);
            this.groupBox_Strategy.Controls.Add(this.textBox8);
            this.groupBox_Strategy.Controls.Add(this.listBox3);
            this.groupBox_Strategy.Controls.Add(this.listBox2);
            this.groupBox_Strategy.Controls.Add(this.listBox1);
            this.groupBox_Strategy.Controls.Add(this.label10);
            this.groupBox_Strategy.Controls.Add(this.label9);
            this.groupBox_Strategy.Controls.Add(this.label8);
            this.groupBox_Strategy.Controls.Add(this.label11);
            this.groupBox_Strategy.Location = new System.Drawing.Point(385, 19);
            this.groupBox_Strategy.Name = "groupBox_Strategy";
            this.groupBox_Strategy.Size = new System.Drawing.Size(319, 186);
            this.groupBox_Strategy.TabIndex = 2;
            this.groupBox_Strategy.TabStop = false;
            this.groupBox_Strategy.Text = "Strategy";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 20);
            this.textBox3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total laps";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Track length (m)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(54, 20);
            this.textBox4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Wear fall off";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Wear/weight Factor";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(144, 54);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(54, 20);
            this.textBox5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fuel weight Factor";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(144, 76);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(54, 20);
            this.textBox6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fuel consumption";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(144, 99);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(54, 20);
            this.textBox7.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(60, 82);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Khaki;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(123, 37);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(60, 82);
            this.listBox2.TabIndex = 0;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.Red;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(225, 37);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(60, 82);
            this.listBox3.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Strat 1";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Strat 2";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Strat 3";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total Race Time";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(26, 144);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(54, 20);
            this.textBox8.TabIndex = 0;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(123, 144);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(54, 20);
            this.textBox9.TabIndex = 0;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(225, 144);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(54, 20);
            this.textBox10.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 881);
            this.Controls.Add(this.chart_Laptimes);
            this.Controls.Add(this.groupBox_Parameters);
            this.Name = "FormMain";
            this.Text = "Orion Strategy Planning Tool";
            this.groupBox_Parameters.ResumeLayout(false);
            this.groupBox_TrackParam.ResumeLayout(false);
            this.groupBox_TrackParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Laptimes)).EndInit();
            this.groupBox_CarParam.ResumeLayout(false);
            this.groupBox_CarParam.PerformLayout();
            this.groupBox_Strategy.ResumeLayout(false);
            this.groupBox_Strategy.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
    }
}

