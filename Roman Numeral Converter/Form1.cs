using System.Collections.Generic;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Roman_Numeral_Converter
{
    public partial class frmRomanNumeralConverter : Form
    {
        public frmRomanNumeralConverter()
        {
            InitializeComponent();
        }

        private void convertToRoman_Click(object sender, EventArgs e)
        {
            // Parse the users input as an integer
            int number = int.Parse(romanNumeralValue.Text);

            // Create a string to hold the roman numeral
            string romanNumeral = "";

            if (number > 0)
            {
                // Create a dictionary to hold the roman numeral values
                Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

                // Add the roman numeral values to the dictionary
                keyValuePairs.Add(10, "X");
                keyValuePairs.Add(9, "IX");
                keyValuePairs.Add(8, "VIII");
                keyValuePairs.Add(7, "VII");
                keyValuePairs.Add(6, "VI");
                keyValuePairs.Add(5, "V");
                keyValuePairs.Add(4, "IV");
                keyValuePairs.Add(3, "III");
                keyValuePairs.Add(2, "II");
                keyValuePairs.Add(1, "I");

                // Loop through the dictionary
                foreach (int decimalValue in keyValuePairs.Keys.OrderByDescending(x => x))
                {
                    // While loop
                    while (number >= decimalValue)
                    {
                        romanNumeral += keyValuePairs[decimalValue];
                        number -= decimalValue;
                    }
                }
                // Display the roman numeral
                displayRomanNumeral.Text = romanNumeral;
            }
        }
    }
}
