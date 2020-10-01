using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIcalculator
{
    public partial class Form1  :Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBerekenen_Click(object sender, EventArgs e)
        {
            {
                float gewicht = float.Parse(txtGewicht.Text);
                float lengte = float.Parse(txtLengte.Text);
                float leeftijd = float.Parse(txtLeeftijd.Text);

                float BMI = gewicht / (lengte * lengte); ;
                string advies = "";

                if (BMI < 18.5)
                {
                    advies = "Je hebt ondergewicht.";
                }
                else if (BMI > 18.5 && BMI < 25)
                {
                    advies = "je hebt een normaal gewicht.";
                }
                else if (BMI > 25)
                {
                    advies = "je hebt overgewicht.";
                }
                

                lblBMI.Text = BMI.ToString();
                lblAdvies.Text = advies;
            }
        }
    }
}
