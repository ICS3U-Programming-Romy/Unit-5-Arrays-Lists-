/*
 * Created by: Romy I. Chu III
 * Created on: 01-05-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #40 - Read/Write
 * This program... Reads a file then writes to it.
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

namespace ReadWriteRChuIII {
    public partial class frmReadWrite : Form {
        public frmReadWrite() {
            InitializeComponent();
        }

        //Function: String Equalizer
        //Input string str1, string str2
        //Output: bool
        //Desc: Compares strings inputted and sees if they're the same, caps excluded.
        private bool EqualizeStrings(string str1, string str2) {
            bool equal = false;
            //Checks if the lengths are the same.
            if (str1.Length == str2.Length) {
                //Converts both string to upper case.
                str1 = str1.ToUpper();
                str2 = str2.ToUpper();

                //If they are the same, set the bool to true.
                if (str1 == str2) {
                    equal = true;
                }
            }
            //Return the boolean.
            return equal;
        }

        private void btnCheck_Click(object sender, EventArgs e) {
            //Read the input file into a string array
            string[] file = System.IO.File.ReadAllLines(@"input.txt");

            //Array of chars that are going to be excluded.
            char[] excludeChars = new char[] { ' ', '\t' };

            //The output string.
            string output = "";

            foreach (string line in file) {
                //Split the lines of the file into two words.
                string[] words = line.Split(excludeChars, StringSplitOptions.RemoveEmptyEntries); 

                if (EqualizeStrings(words[0], words[1]) == true) {
                    //Output true, and add line break.
                    output += "true\r\n";
                }
                else {
                    //Output false, and add line break.
                    output += "false\r\n";
                }

                //Write the output to a new text file
                System.IO.File.WriteAllText(@"output.txt", output);
            }

        }
    }
}
