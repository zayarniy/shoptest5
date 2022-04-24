
namespace ShopVik.Forms
{
    partial class Form7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.btnShowGraph = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.tbProfit = new System.Windows.Forms.TextBox();
            this.tbReceiptAvg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 13);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(486, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(49, 336);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 1;
            this.dtpStart.Value = new System.DateTime(2022, 4, 1, 0, 0, 0, 0);
            // 
            // dtpFinish
            // 
            this.dtpFinish.Location = new System.Drawing.Point(49, 362);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(200, 20);
            this.dtpFinish.TabIndex = 2;
            // 
            // btnShowGraph
            // 
            this.btnShowGraph.Location = new System.Drawing.Point(540, 149);
            this.btnShowGraph.Name = "btnShowGraph";
            this.btnShowGraph.Size = new System.Drawing.Size(75, 23);
            this.btnShowGraph.TabIndex = 3;
            this.btnShowGraph.Text = "Показать";
            this.btnShowGraph.UseVisualStyleBackColor = true;
            this.btnShowGraph.Click += new System.EventHandler(this.btnShowGraph_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(540, 178);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(540, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Самый популярный товар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Средний чек";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Прибыль";
            // 
            // tbItem
            // 
            this.tbItem.Location = new System.Drawing.Point(540, 45);
            this.tbItem.Name = "tbItem";
            this.tbItem.ReadOnly = true;
            this.tbItem.Size = new System.Drawing.Size(100, 20);
            this.tbItem.TabIndex = 9;
            // 
            // tbProfit
            // 
            this.tbProfit.Location = new System.Drawing.Point(540, 123);
            this.tbProfit.Name = "tbProfit";
            this.tbProfit.ReadOnly = true;
            this.tbProfit.Size = new System.Drawing.Size(100, 20);
            this.tbProfit.TabIndex = 10;
            // 
            // tbReceiptAvg
            // 
            this.tbReceiptAvg.Location = new System.Drawing.Point(540, 84);
            this.tbReceiptAvg.Name = "tbReceiptAvg";
            this.tbReceiptAvg.ReadOnly = true;
            this.tbReceiptAvg.Size = new System.Drawing.Size(100, 20);
            this.tbReceiptAvg.TabIndex = 11;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 391);
            this.Controls.Add(this.tbReceiptAvg);
            this.Controls.Add(this.tbProfit);
            this.Controls.Add(this.tbItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowGraph);
            this.Controls.Add(this.dtpFinish);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.chart1);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.Button btnShowGraph;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.TextBox tbProfit;
        private System.Windows.Forms.TextBox tbReceiptAvg;
    }
}