/*
 * Created by: Romy I. Chu III
 * Created on: 29/04/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - Lists
 * This program... Has a list with numbers that the user inputs. It will then calculate the average of those numbers.
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

namespace ListsRChuIII {
    public partial class frmLists : Form {
        List<int> listMarks = new List<int>();

        public frmLists() {
            InitializeComponent();
			lblAverage.Text = "Average : N/A";
        }

        private void btnEnter_Click(object sender, EventArgs e) {
            //Some of them nice variables.
            int userMark = -1;

            //Tries to convert the text from the text box to an integer. 
            try {
                userMark = int.Parse(txtMarks.Text);
            }
			//If it fails... it will say that an error occurred.
            catch (Exception parseError) {
                Console.WriteLine("An error occurred", parseError);
                txtMarks.Clear();
                return;
            }

            //Checks if the user put in a number between 0 and 100.
            if ( userMark >= 0 && userMark <= 100) {
                //Adds the mark to the list.
                lstMarks.Items.Add(userMark);
                listMarks.Add(userMark);
				
				//Updates the label.
                lblAverage.Text = "Average : " + ListAverage(ref listMarks);
            }
            //Clears the text field after the button has been pressed.
            txtMarks.Clear();
        }

        //Function: List Average
        //Input: ref list
        //Output: int
        //Returns the average number of a integers in the list.
        float ListAverage(ref List<int> listyMan) {
            //More Variables. 
            float listAverage = 0;

            //For every integer in the list... Add them up.
            for (int averageCount = 0; averageCount < listyMan.Count(); averageCount++) {
                listAverage += listyMan[averageCount];
            }

            listAverage /= (float)listyMan.Count(); //Get the average.
            Math.Round(listAverage, 2);     //Rounds the given average.
            return listAverage;              //Return the average.
        }
    }
}
