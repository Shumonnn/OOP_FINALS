using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_FINALS_DEMO
{
    public partial class Form6 : Form
    {
        private string firstColumnData;
        private string secondColumnData;

        public Form6(string firstColumnData, string secondColumnData)
        {
            InitializeComponent();
            this.firstColumnData = firstColumnData;
            this.secondColumnData = secondColumnData;
        }

        private void form6_Load(object sender, EventArgs e)
        {
            label10.Text = firstColumnData;
            label11.Text = secondColumnData;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
