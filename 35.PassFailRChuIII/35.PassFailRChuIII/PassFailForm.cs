/*
 * Created by: Romy I. Chu III
 * Created on: 03-05-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #41 - Pass Fail
 * This program... Determines wether a student passes or fails, given some information (Number of students, weights for each mark, each mark, etc.).
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
using System.Threading;
using System.IO;

namespace _35.PassFailRChuIII
{
    public partial class frmPassFail : Form {
        //The file's path.
        string filePath = "DATA10.txt";
        string outputPath = "DATA10_Output.txt";
        string[] data;
        
        //Declare some variables
        float weightTests, weightAssign, weightProjects, weightQuizzes;
        float markTests, markAssign, markProjects, markQuizzes;
        int numStudents, numPassed = 0, counterA, counterB;
        float average;
        string[] studentMarks;

        public frmPassFail() {
            InitializeComponent();
        }

        private void BtnGetResult_Click(object sender, EventArgs e) {
            //Reads all the lines in the data file.
            data = System.IO.File.ReadAllLines(filePath);
            counterA = 0;

            //loop through each line of the array of lines
            using (StreamWriter file = new StreamWriter(outputPath)) {
                while (counterA < data.Length) {
                    numPassed = 0;                       //Set the number of students who passed to 0.
                    string line1 = data[counterA];       //Read the first line in the file.
                    string[] weights = line1.Split(' '); //Split the first line in the file.

                    //Get the weights for each thing.
                    weightTests = float.Parse(weights[0]);
                    weightAssign = float.Parse(weights[1]);
                    weightProjects = float.Parse(weights[2]);
                    weightQuizzes = float.Parse(weights[3]);

                    numStudents = int.Parse(data[counterA + 1]);         //Get the number of students.

                    //Loop through each student.
                    for (counterB = counterA + 2; counterB < counterA + 2 + numStudents; counterB++) {
                        studentMarks = data[counterB].Split(' '); //Splits the student marks.

                        //Get the mark for each thing.
                        markTests = float.Parse(studentMarks[0]);
                        markAssign = float.Parse(studentMarks[1]);
                        markProjects = float.Parse(studentMarks[2]);
                        markQuizzes = float.Parse(studentMarks[3]);

                        //calculate the average for the student
                        average = ((markTests * weightTests) + (markAssign * weightAssign) + (markProjects * weightProjects) + (markQuizzes * weightQuizzes)) / 100;

                        //if the average is over 50 add to the number of students passed
                        if (average >= 50) {
                            numPassed ++;
                        }
                    }
                    file.WriteLine("Number of Students passed is " + numPassed); //Writes the number of students that pass.
                    counterA = counterB;                                     //Restart the counter to start at the next group of students.

                }
            }
        }
    }
}
