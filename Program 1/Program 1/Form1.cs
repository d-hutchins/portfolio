//CIS 199-01
//Grading ID: K6509
//Program 1
//Due Date: 9/30/2021
//This program takes in multiple user inputs for the dimensions of a proposed pool.
//Calculations are performed for cubic yards, materials cost, excavation cost, labor cost and total cost.
//A form is displayed to the user to improve user experience.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }
        //event handler for calculate button
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //establishing double and int variables for user input
            double poolWidth; //user input of width in feet
            double poolLength; //user input of length in feet
            double poolDepth; //user input of depth in feet
            double materialPrice; //user input of price per cubic yard
            int excavationNeeded; //user input indicating if excavation is needed
            int divingBoard; //user input indicating if a diving board is needed
            
            //establishing constant values for calculations
            const double wasteAddition = .10; //10% extra material
            const double excavationPrice = 15; //$15 per cubic yard

            //establishing variables for calculations
            double cubicYardOutput; //calculated cubic yards
            double materialCostsOutput; //calculated material costs
            double extraMaterials; //calculated extra material costs
            double excavationCostOutput = 0; //initializing a value for excavation, whether it is needed or not
            double laborCostOutput; //calculated labor costs
            double totalCostOutput; //calculated total cost of project
            double divingBoardCost = 50; //setting value for fixed cost of diving board

            //converting user inputs to compatible data types
            poolWidth = Convert.ToDouble(userWidthTextBox.Text); //double value for width
            poolLength = Convert.ToDouble(userLengthTextBox.Text); //double value for length
            poolDepth = Convert.ToDouble(userDepthTextBox.Text); //double value for depth
            materialPrice = Convert.ToDouble(userMaterialPriceTextBox.Text); //double value for price
            excavationNeeded = Convert.ToInt32(excavationTextBox.Text); //integer for excavation condition
            divingBoard = Convert.ToInt32(divingBoardTextBox.Text); //integer for diving board condition

            //calculating cubic yards, converting cubic feet to cubic yards
            double cubicYardConversion = (poolWidth * poolLength * poolDepth) / 27;

            //calculations for output to user
            cubicYardOutput = cubicYardConversion; //setting output as conversion value for extra material calculation
            extraMaterials = (cubicYardOutput * wasteAddition); //calculating extra materials for project (cubic yards)
            materialCostsOutput = (cubicYardOutput * materialPrice) + (extraMaterials * materialPrice); //calculating total material costs for project
            laborCostOutput = cubicYardOutput * 3.25; //calculating labor cost for project

            //if statement to meet condition if user needs excavation, else statement not needed in this case
            if(excavationNeeded == 1) //1 indicating excavation is needed
            {
                excavationCostOutput = cubicYardOutput * excavationPrice; //calculating excavation cost
            }

            //if statement to meet condition if user needs a diving board, else statement not needed in this case
            if(divingBoard == 1) //1 indicating diving baord is needed
            {
                laborCostOutput += divingBoardCost; //calculating diving board cost, adding to labor
            }
            
            //calculating total cost of project
            totalCostOutput = materialCostsOutput + excavationCostOutput + laborCostOutput;

            //outputting calculated values to user with different formatting depending on desired value
            cubicYardsOutputLabel.Text = cubicYardOutput.ToString("0.0"); //output for cubic yards of pool only, not including extra materials
            materialCostOutputLabel.Text = materialCostsOutput.ToString("C"); //output for total material cost
            excavationCostOutputLabel.Text = excavationCostOutput.ToString("C"); //output for excavation cost
            laborCostOutputLabel.Text = laborCostOutput.ToString("C"); //output for total labor cost
            totalCostOutputLabel.Text = totalCostOutput.ToString("C"); //output for total project cost
        }
    }
}
