namespace Roman_Numeral_Converter
{
    partial class frmRomanNumeralConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.romanNumeralValue = new System.Windows.Forms.TextBox();
            this.enterInteger = new System.Windows.Forms.Label();
            this.displayRomanNumeral = new System.Windows.Forms.Label();
            this.convertToRoman = new System.Windows.Forms.Button();
            this.exitForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // romanNumeralValue
            // 
            this.romanNumeralValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romanNumeralValue.Location = new System.Drawing.Point(219, 18);
            this.romanNumeralValue.Name = "romanNumeralValue";
            this.romanNumeralValue.Size = new System.Drawing.Size(138, 22);
            this.romanNumeralValue.TabIndex = 0;
            this.romanNumeralValue.Text = "Enter an integer here";
            this.romanNumeralValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enterInteger
            // 
            this.enterInteger.AutoSize = true;
            this.enterInteger.Location = new System.Drawing.Point(12, 23);
            this.enterInteger.Name = "enterInteger";
            this.enterInteger.Size = new System.Drawing.Size(171, 13);
            this.enterInteger.TabIndex = 1;
            this.enterInteger.Text = "Enter an integer between 1 and 10";
            // 
            // displayRomanNumeral
            // 
            this.displayRomanNumeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayRomanNumeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayRomanNumeral.Location = new System.Drawing.Point(219, 58);
            this.displayRomanNumeral.Name = "displayRomanNumeral";
            this.displayRomanNumeral.Size = new System.Drawing.Size(138, 26);
            this.displayRomanNumeral.TabIndex = 2;
            this.displayRomanNumeral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertToRoman
            // 
            this.convertToRoman.Location = new System.Drawing.Point(15, 192);
            this.convertToRoman.Name = "convertToRoman";
            this.convertToRoman.Size = new System.Drawing.Size(102, 45);
            this.convertToRoman.TabIndex = 3;
            this.convertToRoman.Text = "Convert";
            this.convertToRoman.UseVisualStyleBackColor = true;
            this.convertToRoman.Click += new System.EventHandler(this.convertToRoman_Click);
            // 
            // exitForm
            // 
            this.exitForm.Location = new System.Drawing.Point(255, 192);
            this.exitForm.Name = "exitForm";
            this.exitForm.Size = new System.Drawing.Size(102, 45);
            this.exitForm.TabIndex = 4;
            this.exitForm.Text = "E&xit";
            this.exitForm.UseVisualStyleBackColor = true;
            // 
            // frmRomanNumeralConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 249);
            this.Controls.Add(this.exitForm);
            this.Controls.Add(this.convertToRoman);
            this.Controls.Add(this.displayRomanNumeral);
            this.Controls.Add(this.enterInteger);
            this.Controls.Add(this.romanNumeralValue);
            this.Name = "frmRomanNumeralConverter";
            this.Text = "Roman Numeral Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox romanNumeralValue;
        private System.Windows.Forms.Label enterInteger;
        private System.Windows.Forms.Label displayRomanNumeral;
        private System.Windows.Forms.Button convertToRoman;
        private System.Windows.Forms.Button exitForm;
    }
}

