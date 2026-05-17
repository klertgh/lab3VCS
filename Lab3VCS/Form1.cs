using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3VCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadGasFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = new DataTable();
                string[] lines = File.ReadAllLines(ofd.FileName);

                if (lines.Length > 0)
                {
                    string[] headers = lines[0].Split(';');

                    foreach(string header in headers)
                    {
                        dt.Columns.Add(header);
                    }

                    for (int i = 1; i<lines.Length; i++)
                    {
                        string[] data = lines[i].Split(';');
                        dt.Rows.Add(data);
                    }
                    dataGridGases.DataSource = dt;
                }
            }

        }

        private void btnBuildGasChart_Click(object sender, EventArgs e)
        {
            if (dataGridGases.Rows.Count == 0)
            {
                MessageBox.Show("Сначала загрузите файл с данными.");
                return;
            }

            chartGases.Series.Clear();
            chartGases.ChartAreas[0].AxisX.Title = "Год";
            chartGases.ChartAreas[0].AxisY.Title = "Выбросы, млн тонн CO2-экв.";
            chartGases.ChartAreas[0].AxisX.Interval = 1;

            string[] gases = { "CO2", "CH4", "N2O" };

            foreach (string gas in gases)
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series(gas);
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series.BorderWidth = 3;

                foreach (DataGridViewRow row in dataGridGases.Rows)
                {
                    if (row.IsNewRow) continue;

                    int year = Convert.ToInt32(row.Cells["Year"].Value);
                    double value = Convert.ToDouble(row.Cells[gas].Value);

                    series.Points.AddXY(year, value);
                }

                chartGases.Series.Add(series);
            }

            txtGasResult.Text = "График выбросов парниковых газов построен.";
        }
    }
}
