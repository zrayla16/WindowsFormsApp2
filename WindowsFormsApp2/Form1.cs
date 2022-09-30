using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        //global variables
        double slicePrice = 3.25;
        double pop = 1.50;
        double cheps = 2.00;
        double numOfPops = 0;
        double numOfSlices = 0;
        double nomOfCheps = 0;
        double subtotalForslice = 0;
        double subtotalForpop = 0;
        double subtotalForcheps = 0;
        double taxRate = 0.13;
        double taxAmout = 0;
        double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // inputs
                numOfSlices = Convert.ToDouble(slicesInput.Text);
                numOfPops = Convert.ToDouble(popInput.Text);
                nomOfCheps = Convert.ToDouble(chepsInput.Text);

                //calculations
                subtotalForslice = slicePrice * numOfSlices;
 
                subtotalForpop = pop * numOfPops;

                subtotalForcheps = cheps * nomOfCheps;


                taxAmout = subtotalForslice + subtotalForpop + subtotalForcheps * taxRate;



                total = subtotalForslice + subtotalForpop + subtotalForcheps + taxAmout;

                //output
               
            }
            catch
            {
              //  subtotalOutput.Text = "ERROR";
            }
        }
    }
}
