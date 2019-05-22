/*
 * Created by: Romy I. Chu III
 * Created on: 30-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - 2D Arrays
 * This program... Generates a 2D array of numbers and finds the average of those numbers.
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

namespace _34._2DArraysRChuIII
{
    public partial class frm2DArrays : Form {
        //Declaring some variables.
        int length, width, ranNum;
        float average;
        int currentTotal;

        //Making a random number generator
        Random ranNumGen = new Random();

        private void NudLength_ValueChanged(object sender, EventArgs e) {
            if (nudLength.Value >= 1 && nudWidth.Value >= 1) {
                GenerateArray();
            }
        }

        private void NudWidth_ValueChanged(object sender, EventArgs e) {
            if (nudLength.Value >= 1 && nudWidth.Value >= 1) {
                GenerateArray();
            }
        }

        public frm2DArrays() {
            InitializeComponent();
        }

        private void GenerateArray() {
            //Gets the values from the numeric up down boxes.
            length = Convert.ToInt32(nudLength.Value);
            width = Convert.ToInt32(nudWidth.Value);

            //Creates a 2D array.
            int[,] a2DArray = new int[width, length];

            string currentLine = null;

            //loop through the elements in the width
            for (int widthCounter = 0; widthCounter < width; widthCounter++)
            {
                //loop tyhrought the elements in the length
                for (int lengthCounter = 0; lengthCounter < length; lengthCounter++)
                {
                    //get a random number between 0 and 9
                    ranNum = ranNumGen.Next(0, 9 + 1);

                    //insert the number into the array at the current index
                    a2DArray[widthCounter, lengthCounter] = ranNum;

                    //add the random number to the array text
                    currentLine = currentLine + " " + ranNum;
                }

                //add the line break to show next width
                currentLine = currentLine + "\r" + "\n";

            }

            //insert the line into the list box
            this.txtArray.Text = currentLine;

            lblAverage.Text = "Average : " + GetAverageOfArray(ref a2DArray);
        }

        private float GetAverageOfArray(ref int[,] array) {
            currentTotal = 0;

            for (int i = 0; i < Convert.ToInt32(nudWidth.Value); i++) {
                for (int ii = 0;  ii < Convert.ToInt32(nudLength.Value);  ii++) {
                    currentTotal += array[i, ii];
                }
            }

            average = (float)Math.Round(((float)currentTotal / (float)array.Length), 2);

            return average; 
        }
    }
}
