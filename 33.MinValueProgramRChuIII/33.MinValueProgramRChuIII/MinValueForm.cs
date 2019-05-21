/*
 * Created by: Romy I. Chu III
 * Created on: 26-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Min Value
 * This program... creates a list of numbers and adds them to an array. It will determine the lowest number in that array.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33.MinValueProgramRChuIII
{
    public partial class frmMinValue : Form
    {
        //Declare a constant int for the size of the array.
        const int ARRAY_SIZE = 15;
        
        //Creating an array
        int[] arrayOfNumbers = new int[ARRAY_SIZE];

        public frmMinValue()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Declaring some local variables and constants
            const int MAX_RANDOM_NUMBER = 1000;
            int randomNumber;
            int counter;
            Random ranNumGen = new Random();

            //Clearing the list box
            lstNumbers.Items.Clear();

            //Creating random numbers and adding them to the array
            for (counter = 0; counter < ARRAY_SIZE; counter++)
            {
                //Generate the random number
                randomNumber = ranNumGen.Next(1, MAX_RANDOM_NUMBER + 1);

                //Assign the random number to the array at the index of counter
                arrayOfNumbers[counter] = randomNumber;

                //Add the random number to the list box
                this.lstNumbers.Items.Add(randomNumber);

                //Refresh the form to show the updated list box
                this.Refresh();
            }
        }

        private void btnMinValue_Click(object sender, EventArgs e)
        {
            int maxValue;
            //calling the function to find max value
            maxValue = GetMinValue(arrayOfNumbers);

            //showing the maxValue
            this.lblOutput.Text = "The highest value is : " + maxValue;
        }

        private int GetMinValue (int[] tmpArrayOfNumbers)
        {
            //declare local variables
            int tmpMinValue = 1000 + 1;
            int currentValue;
            int counter;

            for (counter = 0; counter < ARRAY_SIZE; counter++)
            {
                //getting the current number from array
                currentValue = tmpArrayOfNumbers[counter];
                if (tmpMinValue > currentValue)
                {
                    //setting the maxVAlue to be the higher number
                    tmpMinValue = currentValue;
                }
            }
            
            //Returns the value of tmpMinValue
            return tmpMinValue;
        }
    }
}
