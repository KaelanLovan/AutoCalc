using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCostCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            carNoteEntry.BringToFront();
            insuranceEntry.BringToFront();
            gasEntry.BringToFront();
            oilChangeEntry.BringToFront();
            repairsEntry.BringToFront();
            registrationEntry.BringToFront();
        }

        

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (carNoteEntry.Text == "")
            {
                carNoteEntry.Text = "0";
            }
            if (insuranceEntry.Text == "")
            {
                insuranceEntry.Text = "0";
            }
            if (gasEntry.Text == "")
            {
                gasEntry.Text = "0";
            }
            if (oilChangeEntry.Text == "")
            {
                oilChangeEntry.Text = "0";
            }
            if (repairsEntry.Text == "")
            {
                repairsEntry.Text = "0";
            }
            if (registrationEntry.Text == "")
            {
                registrationEntry.Text = "0";
            }

            string carNoteCost = carNoteEntry.Text;
            string insuranceCost = insuranceEntry.Text;
            string gasCost = gasEntry.Text;
            string oilChangeCost = oilChangeEntry.Text;
            string repairsCost = repairsEntry.Text;
            string registrationCost = registrationEntry.Text;

            double carNoteCostdbl = 0;
            double insuranceCostdbl = 0;
            double gasCostdbl = 0;
            double oilChangeCostdbl = 0;
            double repairsCostdbl = 0;
            double registrationCostdbl = 0;

            if (Double.TryParse(carNoteCost, out carNoteCostdbl) && 
                Double.TryParse(insuranceCost, out insuranceCostdbl) && 
                Double.TryParse(gasCost, out gasCostdbl) && 
                Double.TryParse(oilChangeCost, out oilChangeCostdbl) && 
                Double.TryParse(repairsCost, out repairsCostdbl) && 
                Double.TryParse(registrationCost, out registrationCostdbl))
            {
                double monthlyCost = carNoteCostdbl + insuranceCostdbl + gasCostdbl + oilChangeCostdbl + repairsCostdbl + registrationCostdbl;
                double yearlyCost = monthlyCost * 12;

                resultsOut.Text = "";
                resultsOut.Text = "**Final Results**" + Environment.NewLine;
                resultsOut.AppendText("Total Monthly Cost: " + monthlyCost.ToString("C") + Environment.NewLine);
                resultsOut.AppendText("Total Annual Cost: " + yearlyCost.ToString("C") + Environment.NewLine);

                resultsLabel.Text = resultsOut.Text;
                resultsLabel.Text = resultsOut.Text;
            } else
            {
                MessageBox.Show("You must enter only numbers!", "Error");
            }

            /*double carNoteCostdbl = Convert.ToDouble(carNoteCost);
            double insuranceCostdbl = Convert.ToDouble(insuranceCost);
            double gasCostdbl = Convert.ToDouble(gasCost);
            double oilChangeCostdbl = Convert.ToDouble(oilChangeCost);
            double repairsCostdbl = Convert.ToDouble(repairsCost);
            double registrationCostdbl = Convert.ToDouble(registrationCost);*/

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void carNoteEntry_TextChanged(object sender, EventArgs e)
        {         
            
        }

        private void carNoteEntry_Click(object sender, EventArgs e)
        {
            if (carNoteEntry.Text == "0")
            {
                carNoteEntry.Text = "";
            }           
            if (insuranceEntry.Text == "")
            {
                insuranceEntry.Text = "0";
            }
            if (gasEntry.Text == "")
            {
                gasEntry.Text = "0";
            }
            if (oilChangeEntry.Text == "")
            {
                oilChangeEntry.Text = "0";
            }
            if (repairsEntry.Text == "")
            {
                repairsEntry.Text = "0";
            }
            if (registrationEntry.Text == "")
            {
                registrationEntry.Text = "0";
            }

            if (!carNoteEntry.Text.All(char.IsDigit))
            {
                carNoteEntry.Text = "";
            }

        }

        private void insuranceEntry_Click(object sender, EventArgs e)
        {
            if (carNoteEntry.Text == "")
            {
                carNoteEntry.Text = "0";
            }
            if (insuranceEntry.Text == "0")
            {
                insuranceEntry.Text = "";
            }
            if (gasEntry.Text == "")
            {
                gasEntry.Text = "0";
            }
            if (oilChangeEntry.Text == "")
            {
                oilChangeEntry.Text = "0";
            }
            if (repairsEntry.Text == "")
            {
                repairsEntry.Text = "0";
            }
            if (registrationEntry.Text == "")
            {
                registrationEntry.Text = "0";
            }

            if (!insuranceEntry.Text.All(char.IsDigit))
            {
                insuranceEntry.Text = "";
            }
        }

        private void gasEntry_Click(object sender, EventArgs e)
        {
            if (carNoteEntry.Text == "")
            {
                carNoteEntry.Text = "0";
            }
            if (insuranceEntry.Text == "")
            {
                insuranceEntry.Text = "0";
            }
            if (gasEntry.Text == "0")
            {
                gasEntry.Text = "";
            }
            if (oilChangeEntry.Text == "")
            {
                oilChangeEntry.Text = "0";
            }
            if (repairsEntry.Text == "")
            {
                repairsEntry.Text = "0";
            }
            if (registrationEntry.Text == "")
            {
                registrationEntry.Text = "0";
            }

            if (!gasEntry.Text.All(char.IsDigit))
            {
                gasEntry.Text = "";
            }
        }

        private void oilChangeEntry_Click(object sender, EventArgs e)
        {
            if (carNoteEntry.Text == "")
            {
                carNoteEntry.Text = "0";
            }
            if (insuranceEntry.Text == "")
            {
                insuranceEntry.Text = "0";
            }
            if (gasEntry.Text == "")
            {
                gasEntry.Text = "0";
            }
            if (oilChangeEntry.Text == "0")
            {
                oilChangeEntry.Text = "";
            }
            if (repairsEntry.Text == "")
            {
                repairsEntry.Text = "0";
            }
            if (registrationEntry.Text == "")
            {
                registrationEntry.Text = "0";
            }

            if (!oilChangeEntry.Text.All(char.IsDigit))
            {
                oilChangeEntry.Text = "";
            }
        }

        private void repairsEntry_Click(object sender, EventArgs e)
        {
            if (carNoteEntry.Text == "")
            {
                carNoteEntry.Text = "0";
            }
            if (insuranceEntry.Text == "")
            {
                insuranceEntry.Text = "0";
            }
            if (gasEntry.Text == "")
            {
                gasEntry.Text = "0";
            }
            if (oilChangeEntry.Text == "")
            {
                oilChangeEntry.Text = "0";
            }
            if (repairsEntry.Text == "0")
            {
                repairsEntry.Text = "";
            }
            if (registrationEntry.Text == "")
            {
                registrationEntry.Text = "0";
            }

            if (!repairsEntry.Text.All(char.IsDigit))
            {
                repairsEntry.Text = "";
            }
        }

        private void registrationEntry_Click(object sender, EventArgs e)
        {
            if (carNoteEntry.Text == "")
            {
                carNoteEntry.Text = "0";
            }
            if (insuranceEntry.Text == "")
            {
                insuranceEntry.Text = "0";
            }
            if (gasEntry.Text == "")
            {
                gasEntry.Text = "0";
            }
            if (oilChangeEntry.Text == "")
            {
                oilChangeEntry.Text = "0";
            }
            if (repairsEntry.Text == "")
            {
                repairsEntry.Text = "0";
            }
            if (registrationEntry.Text == "0")
            {
                registrationEntry.Text = "";
            }

            if (!registrationEntry.Text.All(char.IsDigit))
            {
                registrationEntry.Text = "";                
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void registrationEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void insuranceEntry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}