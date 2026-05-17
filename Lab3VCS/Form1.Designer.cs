namespace Lab3VCS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartGases = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtGasResult = new System.Windows.Forms.TextBox();
            this.btnExportChart = new System.Windows.Forms.Button();
            this.numForecastYears = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numMovingAverage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuildGasChart = new System.Windows.Forms.Button();
            this.dataGridGases = new System.Windows.Forms.DataGridView();
            this.btnLoadGasFile = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForecastYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMovingAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGases)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(30, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1368, 705);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1360, 679);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ВВП и ВНП";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartGases);
            this.tabPage2.Controls.Add(this.txtGasResult);
            this.tabPage2.Controls.Add(this.btnExportChart);
            this.tabPage2.Controls.Add(this.numForecastYears);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numMovingAverage);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnBuildGasChart);
            this.tabPage2.Controls.Add(this.dataGridGases);
            this.tabPage2.Controls.Add(this.btnLoadGasFile);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1360, 679);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Парниковые газы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartGases
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGases.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGases.Legends.Add(legend1);
            this.chartGases.Location = new System.Drawing.Point(455, 108);
            this.chartGases.Name = "chartGases";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGases.Series.Add(series1);
            this.chartGases.Size = new System.Drawing.Size(560, 400);
            this.chartGases.TabIndex = 9;
            this.chartGases.Text = "chart1";
            // 
            // txtGasResult
            // 
            this.txtGasResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGasResult.Location = new System.Drawing.Point(25, 528);
            this.txtGasResult.Multiline = true;
            this.txtGasResult.Name = "txtGasResult";
            this.txtGasResult.ReadOnly = true;
            this.txtGasResult.Size = new System.Drawing.Size(990, 72);
            this.txtGasResult.TabIndex = 8;
            // 
            // btnExportChart
            // 
            this.btnExportChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportChart.Location = new System.Drawing.Point(847, 21);
            this.btnExportChart.Name = "btnExportChart";
            this.btnExportChart.Size = new System.Drawing.Size(168, 50);
            this.btnExportChart.TabIndex = 7;
            this.btnExportChart.Text = "Экспорт графика";
            this.btnExportChart.UseVisualStyleBackColor = true;
            // 
            // numForecastYears
            // 
            this.numForecastYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numForecastYears.Location = new System.Drawing.Point(455, 47);
            this.numForecastYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numForecastYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numForecastYears.Name = "numForecastYears";
            this.numForecastYears.Size = new System.Drawing.Size(189, 24);
            this.numForecastYears.TabIndex = 6;
            this.numForecastYears.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(452, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество лет прогноза:";
            // 
            // numMovingAverage
            // 
            this.numMovingAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMovingAverage.Location = new System.Drawing.Point(220, 47);
            this.numMovingAverage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMovingAverage.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numMovingAverage.Name = "numMovingAverage";
            this.numMovingAverage.Size = new System.Drawing.Size(212, 24);
            this.numMovingAverage.TabIndex = 4;
            this.numMovingAverage.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(217, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Период скользящей средней:";
            // 
            // btnBuildGasChart
            // 
            this.btnBuildGasChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuildGasChart.Location = new System.Drawing.Point(663, 21);
            this.btnBuildGasChart.Name = "btnBuildGasChart";
            this.btnBuildGasChart.Size = new System.Drawing.Size(168, 50);
            this.btnBuildGasChart.TabIndex = 2;
            this.btnBuildGasChart.Text = "Построить график";
            this.btnBuildGasChart.UseVisualStyleBackColor = true;
            // 
            // dataGridGases
            // 
            this.dataGridGases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGases.Location = new System.Drawing.Point(25, 108);
            this.dataGridGases.Name = "dataGridGases";
            this.dataGridGases.Size = new System.Drawing.Size(407, 400);
            this.dataGridGases.TabIndex = 1;
            // 
            // btnLoadGasFile
            // 
            this.btnLoadGasFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadGasFile.Location = new System.Drawing.Point(25, 21);
            this.btnLoadGasFile.Name = "btnLoadGasFile";
            this.btnLoadGasFile.Size = new System.Drawing.Size(168, 46);
            this.btnLoadGasFile.TabIndex = 0;
            this.btnLoadGasFile.Text = "Загрузить файл";
            this.btnLoadGasFile.UseVisualStyleBackColor = true;
            this.btnLoadGasFile.Click += new System.EventHandler(this.btnLoadGasFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 750);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Lab3VCS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForecastYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMovingAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExportChart;
        private System.Windows.Forms.NumericUpDown numForecastYears;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMovingAverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuildGasChart;
        private System.Windows.Forms.DataGridView dataGridGases;
        private System.Windows.Forms.Button btnLoadGasFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGases;
        private System.Windows.Forms.TextBox txtGasResult;
    }
}

