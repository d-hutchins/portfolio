//Program 2
//Grading ID: K6509
//CIS 199-01
//Due Date: 10/21/2021
//This program prompts for the user to input a number of passengers and mileage for a ride share rental.
//It also utilizes a combo box to give the user options on what tier of ride they want.
//Then the program calculates three different costs for three companies, outputs them to the user.
//It has a final message showing which company has the lowest cost.
//If the user inputs invalid data, there are multiple validation messages that are displayed.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
            //Creating list of Combo Box Items
            carTypeComboBox.Items.Add("Limousine"); //index 0
            carTypeComboBox.Items.Add("Luxury"); //index 1
            carTypeComboBox.Items.Add("Mid-Tier"); //index 2
            carTypeComboBox.Items.Add("Green"); //index 3
            carTypeComboBox.Items.Add("Economy"); //index 4
        }

        //event handler for calculate button
        private void CalculateCostButton_Click(object sender, EventArgs e)
        {
            //initializing variables for calculations
            int passengerInput = 0; //integer value for passenger count
            double distanceInput = 0; //double value for distance input
            double companyOneTotalCost = 0; //double Company A total calculated cost
            double companyTwoTotalCost = 0; //double Company B total calculated cost
            double companyThreeTotalCost = 0; //double Company C total calculated cost

            int passengerCostOne = 0; //integer value for passenger cost of Company A
            int passengerCostTwo = 0; //integer value for passenger cost of Company B
            double passengerCostThree = 0; //double  value for passenger cost of Company C

            double mileageOneCost = 0; //double value for mileage cost of Company A
            double mileageTwoCost = 0; //double value for mileage cost of Company B
            double mileageThreeCost = 0; //double value for mileage cost of Company C

            int carTypeOne = 0; //integer value for cost of selected car type with Company A
            int carTypeTwo = 0; //integer value for cost of selected car type with Company B
            const int carTypeThree = 20; //constant integer value for selected car type with Company C

            //main if statement for entire function of program
            if (int.TryParse(passengerInputTextBox.Text, out passengerInput) && double.TryParse(distanceInputTextBox.Text, out distanceInput) && passengerInput < 13 && passengerInput > 0 && distanceInput > 0)
            {
                passengerCostOne = 2 * passengerInput; //calculating Company A passenger cost
                passengerCostThree = .25 * passengerInput; //calculating Company C passenger cost

                mileageOneCost = .02 * distanceInput; //calculating Company A distance cost
                mileageTwoCost = .10 * distanceInput; //calculating Company B distance cost

                //nested if, else if statements for passenger count checks
                if (passengerInput <= 2) //passenger count 2 or less
                {
                    passengerCostTwo = 20 * passengerInput; //calculate Company B passenger cost
                }
                else if (passengerInput >= 3 && passengerInput <= 6) //passenger count between 3 and 6
                {
                    passengerCostTwo = 15 * passengerInput; //calculate Company B passenger cost
                }
                else //passenger count between 7 and 12
                {
                    passengerCostTwo = 5 * passengerInput; //calculate Company B passenger cost
                }
                
                //nested if, else if statements for distance input checks
                if (distanceInput > 200) //distance greater than 200
                {
                    mileageThreeCost = 40; //setting mileage cost for Company C
                }
                else if (distanceInput >= 100 && distanceInput <= 199) //distance between 100 and 199
                {
                    mileageThreeCost = 35; //setting mileage cost for Company C
                }
                else if (distanceInput >= 50 && distanceInput <= 99) //distance between 50 and 99
                {
                    mileageThreeCost = 25; //setting mileage cost for Company C
                }
                else if (distanceInput >= 10 && distanceInput <= 49) //distance between 10 and 49
                {
                    mileageThreeCost = 15; //setting mileage cost for Company C
                }
                else //distance between 1 and 9
                {
                    mileageThreeCost = 5; //setting mileage cost for Company C
                }

                //switch cases depending on selected car type in combo box
                switch (carTypeComboBox.SelectedIndex)
                {
                    //Limosuine selected
                    case 0:
                        carTypeOne = 50; //setting car cost for Company A
                        carTypeTwo = 40; //setting car cost for Company B
                        break;

                    //Luxury selected
                    case 1:
                        carTypeOne = 40; //setting car cost for Company A
                        carTypeTwo = 40; //setting car cost for Company B
                        break;

                    //Mid-Tier selected
                    case 2:
                        carTypeOne = 25; //setting car cost for Company A
                        carTypeTwo = 25; //setting car cost for Company B
                        break;

                    //Green selected
                    case 3:
                        carTypeOne = 15; //setting car cost for Company A
                        carTypeTwo = 15; //setting car cost for Company B
                        break;

                    //Economy selected
                    case 4:
                        carTypeOne = 7; //setting car cost for Company A
                        carTypeTwo = 15; //setting car cost for Company B
                        break;

                    //if user types into combo box or does not select a car type
                    default:
                        MessageBox.Show("Car type not valid."); //Error message to user
                        break;
                }
                //Calculating total costs for the three companies
                companyOneTotalCost = carTypeOne + mileageOneCost + passengerCostOne; //total cost calculation for Company A
                companyTwoTotalCost = carTypeTwo + mileageTwoCost + passengerCostTwo; //total cost calculation for Company B
                companyThreeTotalCost = carTypeThree + mileageThreeCost + passengerCostThree; //total cost calculation for Company C
                
                //Outputting calculations to labels in form with currency formatting
                firstCompanyOutputLabel.Text = companyOneTotalCost.ToString($"C"); //outputting total for Company A
                secondCompanyOutputLabel.Text = companyTwoTotalCost.ToString($"C"); //outputting total for Company B
                thirdCompanyOutputLabel.Text = companyThreeTotalCost.ToString($"C"); //outputting total for Company C
                
                //validating if totals are lower than one another or equivalent to each other
                if (companyOneTotalCost < companyTwoTotalCost && companyOneTotalCost < companyThreeTotalCost) //Company A lowest cost
                {
                    lowestCostOutputLabel.Text = $"Lowest cost company is: A."; //output message in bottom label for Company A
                }
                else if (companyTwoTotalCost < companyOneTotalCost && companyTwoTotalCost < companyThreeTotalCost) //Company B lowest cost
                {
                    lowestCostOutputLabel.Text = $"Lowest cost company is: B."; //output message in bottom label for Company B
                }
                else if (companyThreeTotalCost < companyOneTotalCost && companyThreeTotalCost < companyTwoTotalCost) //Company C lowest cost
                {
                    lowestCostOutputLabel.Text = $"Lowest cost company is: C."; //output message in bottom label for Company C
                }
                else if (companyOneTotalCost == companyTwoTotalCost) //checking for tie between Companies A and B
                {
                    lowestCostOutputLabel.Text = $"There is a tie between companies A and B."; //output message to bottom label for tie with A and B
                }
                else if (companyOneTotalCost == companyThreeTotalCost) //checking for tie between Companies A and C
                {
                    lowestCostOutputLabel.Text = $"There is a tie between companies A and C."; //output message in bottom label for tie between A and C
                }
                else if (companyTwoTotalCost == companyThreeTotalCost) //checking for tie between Companies B and C
                {
                    lowestCostOutputLabel.Text = $"There is a tie between companies B and C."; //output message to bottom label for tie between B and C
                }
            }
            else if(!int.TryParse(passengerInputTextBox.Text, out passengerInput)) //checking for invalid passenger input
            {
                MessageBox.Show("Invalid input. Please enter an integer value between 1 and 12."); //error message to user
            }
            else if(passengerInput > 12) //checking if passenger count is greater than 12
            {
                MessageBox.Show("Total passengers cannot be greater than 12."); //error message to user
            }
            else if (passengerInput < 1) //checking if passenger count is less than 1 (negative)
            {
                MessageBox.Show("Total passengers must be greater than 0."); //error message to user
            }
            else if(!double.TryParse(distanceInputTextBox.Text, out distanceInput) || distanceInput < 1) //checking if distance input is invalid or less than 1 (negative)
            {
                MessageBox.Show("Invalid input. Please enter a distance value greater than 1 mile."); //error message to user
            }
        }
    }
}
