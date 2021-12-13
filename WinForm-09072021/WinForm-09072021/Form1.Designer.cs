
namespace WinForm_09072021
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
            this.lblHello = new System.Windows.Forms.Label();
            this.cmdOk = new System.Windows.Forms.Button();
            this.txtnput = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(42, 37);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(78, 16);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Hello World";
            // 
            // cmdOk
            // 
            this.cmdOk.BackColor = System.Drawing.Color.Red;
            this.cmdOk.ForeColor = System.Drawing.Color.White;
            this.cmdOk.Location = new System.Drawing.Point(718, 403);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 1;
            this.cmdOk.Text = "Ok";
            this.cmdOk.UseVisualStyleBackColor = false;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // txtnput
            // 
            this.txtnput.Location = new System.Drawing.Point(594, 31);
            this.txtnput.Name = "txtnput";
            this.txtnput.Size = new System.Drawing.Size(148, 22);
            this.txtnput.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 438);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtnput);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.lblHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.TextBox txtnput;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

