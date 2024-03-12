namespace Calculator
{
    partial class Form1
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
            this.Screen = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.XtoPower = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.Squareroot = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.Color.DarkGray;
            this.Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Screen.Location = new System.Drawing.Point(12, 9);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(217, 73);
            this.Screen.TabIndex = 0;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Clear.Location = new System.Drawing.Point(12, 86);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(50, 50);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Backspace
            // 
            this.Backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Backspace.Location = new System.Drawing.Point(68, 86);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(50, 50);
            this.Backspace.TabIndex = 2;
            this.Backspace.Text = "⌫";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // XtoPower
            // 
            this.XtoPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XtoPower.Location = new System.Drawing.Point(124, 86);
            this.XtoPower.Name = "XtoPower";
            this.XtoPower.Size = new System.Drawing.Size(50, 50);
            this.XtoPower.TabIndex = 3;
            this.XtoPower.Text = "x²";
            this.XtoPower.UseVisualStyleBackColor = true;
            this.XtoPower.Click += new System.EventHandler(this.XtoPower_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Divide.Location = new System.Drawing.Point(180, 86);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(50, 50);
            this.Divide.TabIndex = 4;
            this.Divide.Text = "÷";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Seven.Location = new System.Drawing.Point(12, 142);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(50, 50);
            this.Seven.TabIndex = 5;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Eight.Location = new System.Drawing.Point(68, 142);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(50, 50);
            this.Eight.TabIndex = 6;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nine.Location = new System.Drawing.Point(124, 142);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(50, 50);
            this.Nine.TabIndex = 7;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Multiply.Location = new System.Drawing.Point(180, 142);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(50, 50);
            this.Multiply.TabIndex = 8;
            this.Multiply.Text = "×";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Four.Location = new System.Drawing.Point(12, 198);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(50, 50);
            this.Four.TabIndex = 9;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Five.Location = new System.Drawing.Point(68, 198);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(50, 50);
            this.Five.TabIndex = 10;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Six.Location = new System.Drawing.Point(124, 198);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(50, 50);
            this.Six.TabIndex = 11;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Subtract.Location = new System.Drawing.Point(178, 198);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(50, 50);
            this.Subtract.TabIndex = 12;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.One.Location = new System.Drawing.Point(12, 254);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(50, 50);
            this.One.TabIndex = 13;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Two.Location = new System.Drawing.Point(68, 254);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(50, 50);
            this.Two.TabIndex = 14;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Three.Location = new System.Drawing.Point(124, 254);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(50, 50);
            this.Three.TabIndex = 15;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Sum
            // 
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sum.Location = new System.Drawing.Point(178, 254);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(50, 50);
            this.Sum.TabIndex = 16;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Squareroot
            // 
            this.Squareroot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Squareroot.Location = new System.Drawing.Point(12, 310);
            this.Squareroot.Name = "Squareroot";
            this.Squareroot.Size = new System.Drawing.Size(50, 50);
            this.Squareroot.TabIndex = 17;
            this.Squareroot.Text = "√";
            this.Squareroot.UseVisualStyleBackColor = true;
            this.Squareroot.Click += new System.EventHandler(this.Squareroot_Click);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zero.Location = new System.Drawing.Point(68, 310);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(50, 50);
            this.Zero.TabIndex = 18;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Dot
            // 
            this.Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dot.Location = new System.Drawing.Point(124, 310);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(50, 50);
            this.Dot.TabIndex = 19;
            this.Dot.Text = ",";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.BackColor = System.Drawing.Color.Gainsboro;
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EqualsButton.Location = new System.Drawing.Point(178, 310);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(50, 50);
            this.EqualsButton.TabIndex = 20;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = false;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(240, 368);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Squareroot);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.XtoPower);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Screen);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button XtoPower;
        private System.Windows.Forms.Button Divide;
        public System.Windows.Forms.Label Screen;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Squareroot;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button EqualsButton;
    }
}

