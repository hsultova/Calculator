namespace Calculator
{
	partial class Calculator
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
			this.panelcalc = new System.Windows.Forms.Panel();
			this.buttonResult = new System.Windows.Forms.Button();
			this.buttonClearOne = new System.Windows.Forms.Button();
			this.buttonSqrt = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonSum = new System.Windows.Forms.Button();
			this.buttonSubtraction = new System.Windows.Forms.Button();
			this.buttonMultiplication = new System.Windows.Forms.Button();
			this.buttonDivision = new System.Windows.Forms.Button();
			this.buttonDot = new System.Windows.Forms.Button();
			this.buttonZero = new System.Windows.Forms.Button();
			this.buttonOne = new System.Windows.Forms.Button();
			this.buttonFour = new System.Windows.Forms.Button();
			this.buttonTwo = new System.Windows.Forms.Button();
			this.buttonFive = new System.Windows.Forms.Button();
			this.buttonThree = new System.Windows.Forms.Button();
			this.buttonSix = new System.Windows.Forms.Button();
			this.buttonNight = new System.Windows.Forms.Button();
			this.buttonEight = new System.Windows.Forms.Button();
			this.buttonSeven = new System.Windows.Forms.Button();
			this.textBoxCalc = new System.Windows.Forms.TextBox();
			this.panelcalc.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelcalc
			// 
			this.panelcalc.Controls.Add(this.buttonResult);
			this.panelcalc.Controls.Add(this.buttonClearOne);
			this.panelcalc.Controls.Add(this.buttonSqrt);
			this.panelcalc.Controls.Add(this.buttonClear);
			this.panelcalc.Controls.Add(this.buttonSum);
			this.panelcalc.Controls.Add(this.buttonSubtraction);
			this.panelcalc.Controls.Add(this.buttonMultiplication);
			this.panelcalc.Controls.Add(this.buttonDivision);
			this.panelcalc.Controls.Add(this.buttonDot);
			this.panelcalc.Controls.Add(this.buttonZero);
			this.panelcalc.Controls.Add(this.buttonOne);
			this.panelcalc.Controls.Add(this.buttonFour);
			this.panelcalc.Controls.Add(this.buttonTwo);
			this.panelcalc.Controls.Add(this.buttonFive);
			this.panelcalc.Controls.Add(this.buttonThree);
			this.panelcalc.Controls.Add(this.buttonSix);
			this.panelcalc.Controls.Add(this.buttonNight);
			this.panelcalc.Controls.Add(this.buttonEight);
			this.panelcalc.Controls.Add(this.buttonSeven);
			this.panelcalc.Controls.Add(this.textBoxCalc);
			this.panelcalc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelcalc.Location = new System.Drawing.Point(0, 0);
			this.panelcalc.Name = "panelcalc";
			this.panelcalc.Size = new System.Drawing.Size(273, 230);
			this.panelcalc.TabIndex = 0;
			// 
			// buttonResult
			// 
			this.buttonResult.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonResult.Location = new System.Drawing.Point(219, 181);
			this.buttonResult.Name = "buttonResult";
			this.buttonResult.Size = new System.Drawing.Size(42, 38);
			this.buttonResult.TabIndex = 37;
			this.buttonResult.Text = "=";
			this.buttonResult.UseVisualStyleBackColor = true;
			this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
			// 
			// buttonClearOne
			// 
			this.buttonClearOne.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonClearOne.Location = new System.Drawing.Point(219, 47);
			this.buttonClearOne.Name = "buttonClearOne";
			this.buttonClearOne.Size = new System.Drawing.Size(42, 38);
			this.buttonClearOne.TabIndex = 36;
			this.buttonClearOne.Text = "C";
			this.buttonClearOne.UseVisualStyleBackColor = true;
			this.buttonClearOne.Click += new System.EventHandler(this.buttonClearOne_Click);
			// 
			// buttonSqrt
			// 
			this.buttonSqrt.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSqrt.Location = new System.Drawing.Point(219, 138);
			this.buttonSqrt.Name = "buttonSqrt";
			this.buttonSqrt.Size = new System.Drawing.Size(42, 38);
			this.buttonSqrt.TabIndex = 35;
			this.buttonSqrt.Text = "√";
			this.buttonSqrt.UseVisualStyleBackColor = true;
			this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonClear.Location = new System.Drawing.Point(219, 91);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(42, 38);
			this.buttonClear.TabIndex = 34;
			this.buttonClear.Text = "CE";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonSum
			// 
			this.buttonSum.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSum.Location = new System.Drawing.Point(171, 182);
			this.buttonSum.Name = "buttonSum";
			this.buttonSum.Size = new System.Drawing.Size(42, 38);
			this.buttonSum.TabIndex = 33;
			this.buttonSum.Text = "+";
			this.buttonSum.UseVisualStyleBackColor = true;
			this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
			// 
			// buttonSubtraction
			// 
			this.buttonSubtraction.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSubtraction.Location = new System.Drawing.Point(171, 137);
			this.buttonSubtraction.Name = "buttonSubtraction";
			this.buttonSubtraction.Size = new System.Drawing.Size(42, 38);
			this.buttonSubtraction.TabIndex = 32;
			this.buttonSubtraction.Text = "-";
			this.buttonSubtraction.UseVisualStyleBackColor = true;
			this.buttonSubtraction.Click += new System.EventHandler(this.buttonSubtraction_Click);
			// 
			// buttonMultiplication
			// 
			this.buttonMultiplication.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonMultiplication.Location = new System.Drawing.Point(171, 93);
			this.buttonMultiplication.Name = "buttonMultiplication";
			this.buttonMultiplication.Size = new System.Drawing.Size(42, 38);
			this.buttonMultiplication.TabIndex = 31;
			this.buttonMultiplication.Text = "*";
			this.buttonMultiplication.UseVisualStyleBackColor = true;
			this.buttonMultiplication.Click += new System.EventHandler(this.buttonMultiplication_Click);
			// 
			// buttonDivision
			// 
			this.buttonDivision.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDivision.Location = new System.Drawing.Point(171, 49);
			this.buttonDivision.Name = "buttonDivision";
			this.buttonDivision.Size = new System.Drawing.Size(42, 38);
			this.buttonDivision.TabIndex = 30;
			this.buttonDivision.Text = "/";
			this.buttonDivision.UseVisualStyleBackColor = true;
			this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
			// 
			// buttonDot
			// 
			this.buttonDot.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDot.Location = new System.Drawing.Point(108, 179);
			this.buttonDot.Name = "buttonDot";
			this.buttonDot.Size = new System.Drawing.Size(42, 38);
			this.buttonDot.TabIndex = 29;
			this.buttonDot.Text = ".";
			this.buttonDot.UseVisualStyleBackColor = true;
			this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
			// 
			// buttonZero
			// 
			this.buttonZero.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonZero.Location = new System.Drawing.Point(12, 181);
			this.buttonZero.Name = "buttonZero";
			this.buttonZero.Size = new System.Drawing.Size(90, 38);
			this.buttonZero.TabIndex = 28;
			this.buttonZero.Text = "0";
			this.buttonZero.UseVisualStyleBackColor = true;
			this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
			// 
			// buttonOne
			// 
			this.buttonOne.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonOne.Location = new System.Drawing.Point(12, 135);
			this.buttonOne.Name = "buttonOne";
			this.buttonOne.Size = new System.Drawing.Size(42, 38);
			this.buttonOne.TabIndex = 27;
			this.buttonOne.Text = "1";
			this.buttonOne.UseVisualStyleBackColor = true;
			this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
			// 
			// buttonFour
			// 
			this.buttonFour.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonFour.Location = new System.Drawing.Point(12, 93);
			this.buttonFour.Name = "buttonFour";
			this.buttonFour.Size = new System.Drawing.Size(42, 38);
			this.buttonFour.TabIndex = 26;
			this.buttonFour.Text = "4";
			this.buttonFour.UseVisualStyleBackColor = true;
			this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
			// 
			// buttonTwo
			// 
			this.buttonTwo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonTwo.Location = new System.Drawing.Point(60, 135);
			this.buttonTwo.Name = "buttonTwo";
			this.buttonTwo.Size = new System.Drawing.Size(42, 38);
			this.buttonTwo.TabIndex = 25;
			this.buttonTwo.Text = "2";
			this.buttonTwo.UseVisualStyleBackColor = true;
			this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
			// 
			// buttonFive
			// 
			this.buttonFive.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonFive.Location = new System.Drawing.Point(60, 93);
			this.buttonFive.Name = "buttonFive";
			this.buttonFive.Size = new System.Drawing.Size(42, 38);
			this.buttonFive.TabIndex = 24;
			this.buttonFive.Text = "5";
			this.buttonFive.UseVisualStyleBackColor = true;
			this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
			// 
			// buttonThree
			// 
			this.buttonThree.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonThree.Location = new System.Drawing.Point(108, 135);
			this.buttonThree.Name = "buttonThree";
			this.buttonThree.Size = new System.Drawing.Size(42, 38);
			this.buttonThree.TabIndex = 23;
			this.buttonThree.Text = "3";
			this.buttonThree.UseVisualStyleBackColor = true;
			this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
			// 
			// buttonSix
			// 
			this.buttonSix.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSix.Location = new System.Drawing.Point(108, 91);
			this.buttonSix.Name = "buttonSix";
			this.buttonSix.Size = new System.Drawing.Size(42, 38);
			this.buttonSix.TabIndex = 22;
			this.buttonSix.Text = "6";
			this.buttonSix.UseVisualStyleBackColor = true;
			this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
			// 
			// buttonNight
			// 
			this.buttonNight.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonNight.Location = new System.Drawing.Point(108, 49);
			this.buttonNight.Name = "buttonNight";
			this.buttonNight.Size = new System.Drawing.Size(42, 38);
			this.buttonNight.TabIndex = 21;
			this.buttonNight.Text = "9";
			this.buttonNight.UseVisualStyleBackColor = true;
			this.buttonNight.Click += new System.EventHandler(this.buttonNight_Click);
			// 
			// buttonEight
			// 
			this.buttonEight.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonEight.Location = new System.Drawing.Point(60, 49);
			this.buttonEight.Name = "buttonEight";
			this.buttonEight.Size = new System.Drawing.Size(42, 38);
			this.buttonEight.TabIndex = 20;
			this.buttonEight.Text = "8";
			this.buttonEight.UseVisualStyleBackColor = true;
			this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
			// 
			// buttonSeven
			// 
			this.buttonSeven.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSeven.Location = new System.Drawing.Point(12, 49);
			this.buttonSeven.Name = "buttonSeven";
			this.buttonSeven.Size = new System.Drawing.Size(42, 38);
			this.buttonSeven.TabIndex = 1;
			this.buttonSeven.Text = "7";
			this.buttonSeven.UseVisualStyleBackColor = true;
			this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
			// 
			// textBoxCalc
			// 
			this.textBoxCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCalc.Location = new System.Drawing.Point(12, 12);
			this.textBoxCalc.Name = "textBoxCalc";
			this.textBoxCalc.ReadOnly = true;
			this.textBoxCalc.Size = new System.Drawing.Size(256, 23);
			this.textBoxCalc.TabIndex = 0;
			this.textBoxCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(273, 230);
			this.Controls.Add(this.panelcalc);
			this.Name = "Calculator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculator";
			this.TransparencyKey = System.Drawing.Color.LavenderBlush;
			this.panelcalc.ResumeLayout(false);
			this.panelcalc.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelcalc;
		private System.Windows.Forms.Button buttonResult;
		private System.Windows.Forms.Button buttonClearOne;
		private System.Windows.Forms.Button buttonSqrt;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonSum;
		private System.Windows.Forms.Button buttonSubtraction;
		private System.Windows.Forms.Button buttonMultiplication;
		private System.Windows.Forms.Button buttonDivision;
		private System.Windows.Forms.Button buttonDot;
		private System.Windows.Forms.Button buttonZero;
		private System.Windows.Forms.Button buttonOne;
		private System.Windows.Forms.Button buttonFour;
		private System.Windows.Forms.Button buttonTwo;
		private System.Windows.Forms.Button buttonFive;
		private System.Windows.Forms.Button buttonThree;
		private System.Windows.Forms.Button buttonSix;
		private System.Windows.Forms.Button buttonNight;
		private System.Windows.Forms.Button buttonEight;
		private System.Windows.Forms.Button buttonSeven;
		private System.Windows.Forms.TextBox textBoxCalc;
	}
}

