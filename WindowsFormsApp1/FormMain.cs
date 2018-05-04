using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SimParameters param = new SimParameters();
            param.LoadSavedParams();

            for(int i=0; i< param.paramWeightCurve.Count(); ++i)
            {
                this.fuelWeightCurve.Rows.Add(param.paramWeightCurve[i], param.paramWeightLaptime[i]);
            }

            for (int i = 0; i < param.paramTireWearCurve.Count(); ++i)
            {
                this.TireWearCurve.Rows.Add(param.paramTireWearCurve[i], param.paramTireLapFactor[i]);
            }

            for (int i = 0; i < param.pitStrategy1.Count(); ++i)
            {
                this.strategy1.Rows.Add(param.pitStrategy1[i]);
            }

            for (int i = 0; i < param.pitStrategy2.Count(); ++i)
            {
                this.strategy2.Rows.Add(param.pitStrategy2[i]);
            }

            for (int i = 0; i < param.pitStrategy3.Count(); ++i)
            {
                this.strategy3.Rows.Add(param.pitStrategy3[i]);
            }




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart_Laptimes_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
