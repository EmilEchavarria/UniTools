using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniTools
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////////////////////
        // CLICK EVENTS OF THE BUTTONS (EXIT, MAXIMIZE,  RESTORE AND MINIMIZE)
        /////////////////////////////////////////////////////////////////////
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

       


        /////////////////////////////////////////////////////////////////////
        /// This method allows the user to move the form by clicking on the panel.
        //////////////////////////////////////////////////////////////////////


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    
        private void LblHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //VAR DECLARATIONS

        private double Number1 = 0;
        private double Number2 = 0;
        private double currentOperation = 0;


        //BUTTOMS OF THE NUMBERS

        private void Btn0_Click(object sender, EventArgs e) // When the 0 button is clicked
        {
            LblResult.Text += "0"; // Add 0 to the text
        }

        private void Btn1_Click(object sender, EventArgs e) // When the 1 button is clicked
        {
            LblResult.Text += "1"; // Add 1 to the text

        }

        private void Btn2_Click(object sender, EventArgs e) // When the 2 button is clicked
        {
            LblResult.Text += "2"; // Add 2 to the text 

        }

        private void Btn3_Click(object sender, EventArgs e) // When the 3 button is clicked
        {
            LblResult.Text += "3"; // Add 3 to the text

        }

        private void Btn4_Click(object sender, EventArgs e) // When the 4 button is clicked
        {
            LblResult.Text += "4"; // Add 4 to the text

        }

        private void Btn5_Click(object sender, EventArgs e) // When the 5 button is clicked
        {
            LblResult.Text += "5"; // Add 5 to the text

        }

        private void Btn6_Click(object sender, EventArgs e) // When the 6 button is clicked
        {
            LblResult.Text += "6"; // Add 6 to the text
        }

        private void Btn7_Click(object sender, EventArgs e) // When the 7 button is clicked
        {
            LblResult.Text += "7"; // Add 7 to the text
        }

        private void Btn8_Click(object sender, EventArgs e) // When the 8 button is clicked
        {
            LblResult.Text += "8"; // Add 8 to the text
        }

        private void Btn9_Click(object sender, EventArgs e) // When the 9 button is clicked
        {
            LblResult.Text += "9"; // Add 9 to the text
        }


        //ARITMETIC OPERATIONS



        private void BtnAddition_Click(object sender, EventArgs e) // When the addition button is clicked
        {
            if (double.TryParse(LblResult.Text, out double number1)) // Try to parse the text to a number
            {
                Number1 = number1; 
                currentOperation = '+';
                LblResult.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }


        private void BtnSubtraction_Click(object sender, EventArgs e) // When the subtraction button is clicked
        {
            if (double.TryParse(LblResult.Text, out double number1)) // Try to parse the text to a number
            { 
                Number1 = number1;
                currentOperation = '-';
                LblResult.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a valid number."); 
            }
        }

        private void BtnMultiplication_Click(object sender, EventArgs e) // When the multiplication button is clicked
        {
            if (double.TryParse(LblResult.Text, out double number1)) // Try to parse the text to a number
            {
                Number1 = number1;
                currentOperation = '*';
                LblResult.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void BtnDivision_Click(object sender, EventArgs e) // When the division button is clicked
        {
            if (double.TryParse(LblResult.Text, out double number1)) // Try to parse the text to a number
            { 
                Number1 = number1;
                currentOperation = '÷';
                LblResult.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
           
        }

        private void BtnPercentage_Click(object sender, EventArgs e) // When the percentage button is clicked
        {
            if (double.TryParse(LblResult.Text, out double number1)) // Try to parse the text to a number
            {
                Number1 = number1;
                currentOperation = '%';
                LblResult.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void BtnReciprocal_Click(object sender, EventArgs e) // When the reciprocal button is clicked
        {

            double number; // Declare a variable to store the number
            if (double.TryParse(LblResult.Text, out number)) // Try to parse the text to a number
            {
                if (number != 0) 
                {
                    LblResult.Text = (1 / number).ToString();
                }
                else
                {
                    LblResult.Text = "Error"; // division by zero
                }
            }
        }

        private void BtnSquare_Click(object sender, EventArgs e) // When the square button is clicked
        {
            double square; // Declare a variable to store the square of the number

            if (double.TryParse(LblResult.Text,out square)) // Try to parse the text to a number

            {
                LblResult.Text = (square * square).ToString(); // Show the square of the number

            }
        }

        private void BtnSquareRoot_Click(object sender, EventArgs e) // When the square root button is clicked
        {
            double SquareRoot;

            if (Double.TryParse(LblResult.Text, out SquareRoot)) // Try to parse the text to a number

            {
                LblResult.Text = Math.Sqrt(SquareRoot).ToString(); // Show the square root of the number
            }
        }










        private void BtnClear_Click(object sender, EventArgs e) // When the clear button is clicked
        {
            LblResult.Text = ""; // Clear the text
        }




        private void BtnDecimalPoint_Click(object sender, EventArgs e)  // When the decimal point button is clicked
        {
            if (!LblResult.Text.Contains(".")) // If the text does not contain a decimal point
            {
                LblResult.Text += "."; // Add a decimal point
            }
        }



        private void BtnEqual_Click(object sender, EventArgs e) // When the equal button is clicked
        {
            if (string.IsNullOrEmpty(LblResult.Text) || !double.TryParse(LblResult.Text, out Number2)) // If the text is empty or it is not a number
            {
                MessageBox.Show("Por favor ingrese un número válido."); // Please enter a valid number
                return;
            }

            LblResult.Text = ""; // Clear the text
             
            switch (currentOperation) // Check the current operation
            {
                case '+':
                    LblResult.Text = (Number1 + Number2).ToString(); 
                    break;

                case '-':
                    LblResult.Text = (Number1 - Number2).ToString();
                    break;

                case '*':
                    LblResult.Text = (Number1 * Number2).ToString();
                    break;

                case '÷': 
                    if (Number2 == 0) // If the second number is 0
                    {
                        LblResult.Text = "Math Error"; // Show an error message
                    }
                    else
                    {
                        LblResult.Text = (Number1 / Number2).ToString(); // Show the result
                    } 
                    break; 

                case '%':
                    LblResult.Text = ((Number1 * Number2) / 100).ToString(); // Calculate the percentage
                    break;

                default:
                    LblResult.Text = "Error";
                    break;
            }
        }


        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (LblResult.Text.Length > 0) // If the text has more than 0 characters
            {
                LblResult.Text = LblResult.Text.Substring(0, LblResult.Text.Length - 1); // Remove the last character
            }
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            LblResult.Text = " "; // Clear the text
        }

        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LblResult.Text) && LblResult.Text != "0") // If the text is not empty and it is not 0
            {
                double number = double.Parse(LblResult.Text); // Parse the text to a number
                number = -number; // Change the sign of the number
                LblResult.Text = number.ToString(); // Show the number with the new sign
            }
        }

        
    }
}
