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
    }
}
