using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_01_03_PigLatinGUI_LDM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string inputWord = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(inputWord))
            {
                MessageBox.Show("Please enter a word.", "Input Required", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Focus();
                return;
            }

            string pigLatinWord = ConvertToPigLatin(inputWord);
            lblOutput.Text = pigLatinWord;
        }

        private string ConvertToPigLatin(string word)
        {
            if (word.Length == 0)
                return word;

            // Get the first letter and the rest of the word
            char firstLetter = word[0];
            string restOfWord = word.Substring(1);

            // Create pig Latin: remove first letter, add it and "ay" at the end
            string pigLatin = restOfWord + firstLetter + "ay";

            return pigLatin;
        }
    }
}
