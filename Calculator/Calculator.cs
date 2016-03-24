using System;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Calculator : Form
	{
		string input = string.Empty;
		string operand1 = string.Empty;
		string operand2 = string.Empty;
		char operation;
		double result = 0;

		public Calculator()
		{
			InitializeComponent();
		}

		private void buttonOne_Click(object sender, EventArgs e)
		{
			input += buttonOne.Text;
			textBoxCalc.Text = input;
		}

		private void buttonTwo_Click(object sender, EventArgs e)
		{
			input += buttonTwo.Text;
			textBoxCalc.Text = input;
		}

		private void buttonThree_Click(object sender, EventArgs e)
		{
			input += buttonThree.Text;
			textBoxCalc.Text = input;
		}

		private void buttonFour_Click(object sender, EventArgs e)
		{
			input += buttonFour.Text;
			textBoxCalc.Text = input;
		}

		private void buttonFive_Click(object sender, EventArgs e)
		{
			input += buttonFive.Text;
			textBoxCalc.Text = input;
		}

		private void buttonSix_Click(object sender, EventArgs e)
		{
			input += buttonSix.Text;
			textBoxCalc.Text = input;
		}

		private void buttonSeven_Click(object sender, EventArgs e)
		{
			input += buttonSeven.Text;
			textBoxCalc.Text = input;
		}

		private void buttonEight_Click(object sender, EventArgs e)
		{
			input += buttonEight.Text;
			textBoxCalc.Text = input;
		}

		private void buttonNight_Click(object sender, EventArgs e)
		{
			input += buttonNight.Text;
			textBoxCalc.Text = input;
		}

		private void buttonDot_Click(object sender, EventArgs e)
		{
			input += ","; // Thread.CurrentThread.CurrentUICulture.NumberFormat.CurrencyDecimalDigits
			textBoxCalc.Text = input;
		}

		private void buttonZero_Click(object sender, EventArgs e)
		{
			input += buttonZero.Text;
			textBoxCalc.Text = input;
		}

		private void buttonSum_Click(object sender, EventArgs e)
		{
			operand1 = input;
			operation = '+';
			input = string.Empty;
		}


		private void buttonSubtraction_Click(object sender, EventArgs e)
		{
			operand1 = input;
			operation = '-';
			input = string.Empty;
		}

		private void buttonMultiplication_Click(object sender, EventArgs e)
		{
			operand1 = input;
			operation = '*';
			input = string.Empty;
		}

		private void buttonDivision_Click(object sender, EventArgs e)
		{
			operand1 = input;
			operation = '/';
			input = string.Empty;
		}

		private void buttonClearOne_Click(object sender, EventArgs e)
		{
			if (input == string.Empty)
			{
				textBoxCalc.Clear();
			}
			else
			{
				input = input.Substring(0, input.Length - 1);
				textBoxCalc.Text = input;
			}
		}

		private void buttonSqrt_Click(object sender, EventArgs e)
		{
			result = Math.Sqrt(double.Parse(input));
			textBoxCalc.Text = result.ToString();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			input = string.Empty;
			textBoxCalc.Clear();
		}

		private void buttonResult_Click(object sender, EventArgs e)
		{
			operand2 = textBoxCalc.Text;
			double number1 = double.Parse(operand1);
			double number2 = double.Parse(operand2);

			if (operation == '+')
			{
				result = number1 + number2;
				textBoxCalc.Text = result.ToString();
			}
			else if (operation == '-')
			{
				result = number1 - number2;
				textBoxCalc.Text = result.ToString();
			}
			else if (operation == '*')
			{
				result = number1 * number2;
				textBoxCalc.Text = result.ToString();
			}
			else if (operation == '/')
			{
				if (number2 == 0)
				{
					textBoxCalc.Text = "No division by zero";
				}
				else
				{
					result = number1 / number2;
					textBoxCalc.Text = result.ToString();
				}
			}
		}
	}
}
