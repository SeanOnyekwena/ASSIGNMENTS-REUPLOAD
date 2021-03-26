namespace mean__median__mode_calculator
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.textSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textLower = new System.Windows.Forms.TextBox();
            this.textUpper = new System.Windows.Forms.TextBox();
            this.listRaw = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listSorted = new System.Windows.Forms.ListBox();
            this.textMean = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textMedian = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textMode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.infoGenerate = new System.Windows.Forms.Button();
            this.infoCalculate = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of elements";
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(161, 43);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(100, 20);
            this.textSize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lower limit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Upper limit";
            // 
            // textLower
            // 
            this.textLower.Location = new System.Drawing.Point(161, 94);
            this.textLower.Name = "textLower";
            this.textLower.Size = new System.Drawing.Size(100, 20);
            this.textLower.TabIndex = 4;
            // 
            // textUpper
            // 
            this.textUpper.Location = new System.Drawing.Point(161, 134);
            this.textUpper.Name = "textUpper";
            this.textUpper.Size = new System.Drawing.Size(100, 20);
            this.textUpper.TabIndex = 5;
            // 
            // listRaw
            // 
            this.listRaw.FormattingEnabled = true;
            this.listRaw.Location = new System.Drawing.Point(28, 235);
            this.listRaw.Name = "listRaw";
            this.listRaw.Size = new System.Drawing.Size(120, 95);
            this.listRaw.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dataset";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sorted Dataset";
            // 
            // listSorted
            // 
            this.listSorted.FormattingEnabled = true;
            this.listSorted.Location = new System.Drawing.Point(161, 235);
            this.listSorted.Name = "listSorted";
            this.listSorted.Size = new System.Drawing.Size(120, 95);
            this.listSorted.TabIndex = 8;
            // 
            // textMean
            // 
            this.textMean.Location = new System.Drawing.Point(161, 360);
            this.textMean.Name = "textMean";
            this.textMean.Size = new System.Drawing.Size(100, 20);
            this.textMean.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mean";
            // 
            // textMedian
            // 
            this.textMedian.Location = new System.Drawing.Point(161, 409);
            this.textMedian.Name = "textMedian";
            this.textMedian.Size = new System.Drawing.Size(100, 20);
            this.textMedian.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Median";
            // 
            // textMode
            // 
            this.textMode.Location = new System.Drawing.Point(161, 459);
            this.textMode.Name = "textMode";
            this.textMode.Size = new System.Drawing.Size(100, 20);
            this.textMode.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mode";
            // 
            // infoGenerate
            // 
            this.infoGenerate.Location = new System.Drawing.Point(28, 175);
            this.infoGenerate.Name = "infoGenerate";
            this.infoGenerate.Size = new System.Drawing.Size(75, 23);
            this.infoGenerate.TabIndex = 16;
            this.infoGenerate.Text = "Generate";
            this.infoGenerate.UseVisualStyleBackColor = true;
            this.infoGenerate.Click += new System.EventHandler(this.InfoGenerate_Click);
            // 
            // infoCalculate
            // 
            this.infoCalculate.Location = new System.Drawing.Point(161, 175);
            this.infoCalculate.Name = "infoCalculate";
            this.infoCalculate.Size = new System.Drawing.Size(75, 23);
            this.infoCalculate.TabIndex = 17;
            this.infoCalculate.Text = "Calculate";
            this.infoCalculate.UseVisualStyleBackColor = true;
            this.infoCalculate.Click += new System.EventHandler(this.InfoCalculate_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(298, 43);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series2.Label = "Value";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(477, 504);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "Histogram";
            title2.Name = "Title1";
            title2.Text = "Histogram";
            this.chart1.Titles.Add(title2);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.infoCalculate);
            this.Controls.Add(this.infoGenerate);
            this.Controls.Add(this.textMode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textMedian);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textMean);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listSorted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listRaw);
            this.Controls.Add(this.textUpper);
            this.Controls.Add(this.textLower);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSize);
            this.Controls.Add(this.label1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textLower;
        private System.Windows.Forms.TextBox textUpper;
        private System.Windows.Forms.ListBox listRaw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listSorted;
        private System.Windows.Forms.TextBox textMean;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textMedian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button infoGenerate;
        private System.Windows.Forms.Button infoCalculate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

