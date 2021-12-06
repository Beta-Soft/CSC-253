/**
* 05092021
* CSC 253
* Rebecca Garcia
* Word Count Assignment
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

namespace WinsUI
{
    public partial class FormWordCount : Form
    {
        public FormWordCount()
        {
            InitializeComponent();
        }

        WordCount wordcount;

        private void addWordButton_Click(object sender, EventArgs e)
        {
            string userTextInput = richWordCount.Text;
            int count, word;

            count = 0;
            word = 1;

            // loop till end of string //
            while (count < userTextInput.Length - 1)
            {
                // code to not count white space or new line into word count //
                if (userTextInput[count] == ' ' || userTextInput[count] == '\n')
                {
                    word++;
                }

                count++;
            }
            
            // messagebox letting user know nothing has been entered //
            if (!string.IsNullOrWhiteSpace(userTextInput))
            {
                wordcount = new WordCount(userTextInput);
            }
            else
                MessageBox.Show("Please input words for count!", "Invalid Input");


            // outputs user input and # of words to wordBox //
            try
            {                                      // replaces user newline as space for output of words entered //
                wordBox.Items.Add("Word Input: " + wordcount.usertext.Replace(System.Environment.NewLine, " "));
                wordBox.Items.Add("Word Count: \n" + word);
                wordBox.Items.Add("----------------------------------------");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Submit entry first!", "Invalid Input");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // clears text for new word entry to be stored in wordBox
        private void newWordButton_Click(object sender, EventArgs e)
        {
            richWordCount.Text = " ";
        }

        // clears form
        private void clearButton_Click(object sender, EventArgs e)
        {
            wordBox.Items.Clear();
            richWordCount.Text = " ";
        }
    }
}
