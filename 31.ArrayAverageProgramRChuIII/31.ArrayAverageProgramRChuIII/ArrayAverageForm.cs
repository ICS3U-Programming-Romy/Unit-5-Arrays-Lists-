/*
 * Created by: Romy I. Chu III
 * Created on: 23-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - Introduction to Arrays
 * This program... has two buttons, 'Generate' and 'average'. The 'Generate' button will generate a set of 10 
 *                 random numbers. The 'average' button will find the average of those 10 numbers.
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

namespace _31.ArrayAverageProgramRChuIII
{
    public partial class frmArrayAverage : Form
    {
        const int ARRAY_SIZE = 10;                   //This is a constant for the size of the array
        int[] arrayOfNumbers = new int[ARRAY_SIZE];  //This creates a new array

        public frmArrayAverage()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Declare some local variables
            int randomNumber, counter;
            Random ranNumGen = new Random();

            //Clears the list box
            lstNumbers.Items.Clear();

            //This for loop generates random numbers and adds it to the list box
            for (counter = 0; counter < ARRAY_SIZE; counter++)
            {
                //Generates a random number between 1 and ARRAY_SIZE (10)
                randomNumber = ranNumGen.Next(1, ARRAY_SIZE + 1);

                //Assign the random number to the array at the index of counter
                arrayOfNumbers[counter] = randomNumber;

                //Adds the random number to the list box
                this.lstNumbers.Items.Add(randomNumber);

                //Refresh the form to show the updated list box
                this.Refresh();
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            //Decalre some local variables
            double average = 0, sum = 0;
            int counter;

            //Adds up all of the numbers in the array
            for (counter = 0; counter < arrayOfNumbers.Length; counter++)
            {
                sum = sum + arrayOfNumbers[counter];
            }

            //Calculate the average
            average = sum / arrayOfNumbers.Length;

            //Display the average
            this.lblOutput.Text = "The average is : " + average;
        }
    }
}
