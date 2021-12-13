namespace buchwasa_Assignment03
{
    partial class PrimeNumberForm
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblIsPrime = new System.Windows.Forms.Label();
            this.nudPrimeInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(13, 13);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(218, 16);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Input a number to check if it is prime:";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(699, 406);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(89, 32);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblIsPrime
            // 
            this.lblIsPrime.AutoSize = true;
            this.lblIsPrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsPrime.Location = new System.Drawing.Point(16, 415);
            this.lblIsPrime.Name = "lblIsPrime";
            this.lblIsPrime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIsPrime.Size = new System.Drawing.Size(0, 23);
            this.lblIsPrime.TabIndex = 4;
            this.lblIsPrime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIsPrime.UseCompatibleTextRendering = true;
            // 
            // nudPrimeInput
            // 
            this.nudPrimeInput.Location = new System.Drawing.Point(16, 46);
            this.nudPrimeInput.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.nudPrimeInput.Name = "nudPrimeInput";
            this.nudPrimeInput.Size = new System.Drawing.Size(215, 22);
            this.nudPrimeInput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudPrimeInput);
            this.Controls.Add(this.lblIsPrime);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimeInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblIsPrime;
        private System.Windows.Forms.NumericUpDown nudPrimeInput;
    }
}

