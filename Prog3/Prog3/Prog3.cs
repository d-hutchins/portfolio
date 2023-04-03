//Grading ID: K6509
//CIS 199-01
//Due Date: 11/11/2021
//This program displays a form to the user, which asks for a selection of a city to ship to,
//the entree item number, and the number of servings/quantity requested.
//The program then outputs 4 costs to the user, the initial cost, adjusted cost, shipping total,
//and total cost overall. This program primarily uses for loops and arrays to search for corresponding data.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class Prog3 : Form
    {
        public Prog3()
        {
            InitializeComponent();
            //comboBox item declaration
            cityComboBox.Items.Add("Louisville"); //index 0
            cityComboBox.Items.Add("Lexington"); //index 1
            cityComboBox.Items.Add("Indianapolis"); //index 2
            cityComboBox.Items.Add("Nashville"); //index 3
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //declaring arrays for stored values
            double[] shipments = { 0.06, 0.0717, 0.07, 0.0874 }; //shipment fee percentages
            int[] entrees = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 }; //entree ID numbers
            double[] costs = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 }; //serving costs
            int[] servings = { 21, 11, 6, 1 }; //number of servings, ranges
            double[] fees = { 0, .05, .10, .15 }; //service fees

            //declaring variables for calculations
            int entreeNumberInput = Convert.ToInt32(entreeNumberTextBox.Text); //convert entree number to integer
            int quantityInput = Convert.ToInt32(quantityTextBox.Text); //convert serving quantity to integer
            double shipmentCost = 0; //initialize shipping cost
            double shippingTotal = 0; //intialize total shipping cost
            double servingCost = 0; //initialize serving cost
            double serviceFee = 0; //initialize service fee
            double totalCost = 0; //initialize total cost
            double initialCost = 0; //initialize initial cost
            double adjustedCost = 0; //initialize adjusted cost
            bool found = false; //declaring boolean value for the for loops

            if (cityComboBox.SelectedIndex > -1) //checking if user selected a city from drop down
            {
                shipmentCost = shipments[cityComboBox.SelectedIndex]; //setting shipment cost accordingly from shipments array
            }

            for(int i = 0; i <= entrees.Length-1 && !found; i++) //for loop to check entree number
            {
                if(entreeNumberInput == entrees[i]) //checking if user input matches a value in the entrees array
                {
                    servingCost = costs[i]; //setting serving cost accordingly from servings cost array
                    found = true; //flagging boolean value to exit the loop
                }
            }

            found = false; //reset the boolean value for next for loop
            
            for (int i = 0; i <= servings.Length - 1 && !found; i++) //for loop to check quantity/servings input
            {
                if(quantityInput >= servings[i]) //checking if user input matches a range in the servings array
                {
                    serviceFee = fees[i]; //setting service fee accoringly from fees array
                    found = true; //flagging boolean value to exit the loop
                }
            }
            
            if(servingCost > 0 && quantityInput > 0 && shipmentCost > 0) //validating user inputs
            {
                initialCost = servingCost * quantityInput; //calculating initial cost
                adjustedCost = (initialCost * serviceFee) + initialCost; //calculating adjusted cost
                shippingTotal = shipmentCost * adjustedCost; //calculating the total shipping cost
                totalCost = adjustedCost + shippingTotal; //calculating total value
            }
            else //else statement if user input is invalid
            {
                MessageBox.Show("Invalid input."); //Message Box to user to indicate an error
            }

            //Displaying values out to the user
            initialCostOutputLabel.Text = initialCost.ToString($"C"); //Outputting initial cost to the label
            adjustedCostOutputLabel.Text = adjustedCost.ToString($"C"); //Outputting adjusted cost to the label
            shipmentCostOutputLabel.Text = shippingTotal.ToString($"C"); //Outputting shipping total to the label
            totalPriceOutputLabel.Text = totalCost.ToString($"C"); //Outputting total cost to the label
        }
    }
}