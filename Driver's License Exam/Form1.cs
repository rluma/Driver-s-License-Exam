using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Driver_s_License_Exam
{
    public partial class driversLicenseForm : Form
    {
        public driversLicenseForm()
        {
            InitializeComponent();
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            // Array of correct answers
            string [] answerArray = {"B", "D", "A", "A", 
                "C", "A", "B", "A", "C", "D", "B", "C", 
                "D", "A", "D", "C", "C", "B", "D", "A" };

            // Array of student's answers
            string[] studentAnsArray = new string[20];

            // Create list for incorrect question numbers
            List<string> incorrectList = new List<string>();

            // Create variables to hold correct count and index
            int count = 0, index = 0, qnumber = 0;

            try
            {

                // Open file if it exists
                string filename = txtFileName.Text;
                StreamReader inputFile = File.OpenText(filename);
                while (!inputFile.EndOfStream)
                {

                    // Read line and put it into student answer array
                    studentAnsArray[index] = inputFile.ReadLine();

                    // Compare student answer array to answer array
                    if (studentAnsArray[index] == answerArray[index])
                        count++;
                    else
                    {
                        qnumber = index + 1;  //add 1 to index to get the question number since they start at 1 and not at 0
                        incorrectList.Add(qnumber.ToString());
                    }
                    // Increment index by 1
                    index++;
                }// Close loop
                // Close file
                inputFile.Close();
                // Calculate results
                if (count >= 15)
                {
                    lblResult.Text = "You passed the test!";
                }
                else
                {
                    lblResult.Text = "You failed the test.";
                }
                // Display incorrect answer numbers
                foreach (string str in incorrectList)
                {
                   lboxInc.Items.Add(str);
                }
            }

            catch (Exception)
            {
                // Display error message
                MessageBox.Show("File not found.");
            }
                }

        private void clearButton_Click(object sender, EventArgs e)
        {
            txtFileName.Text = "";
            lblResult.Text = "";
            lboxInc.Items.Clear();
        }
    }
}
