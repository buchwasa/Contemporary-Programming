namespace InClass_1202
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
            this.tvDemo = new System.Windows.Forms.TreeView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnAddPlayerName = new System.Windows.Forms.Button();
            this.txtPlayerNumber = new System.Windows.Forms.TextBox();
            this.btnAddPlayerNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvDemo
            // 
            this.tvDemo.Location = new System.Drawing.Point(12, 12);
            this.tvDemo.Name = "tvDemo";
            this.tvDemo.Size = new System.Drawing.Size(264, 426);
            this.tvDemo.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(293, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 54);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(293, 89);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(124, 55);
            this.btnInit.TabIndex = 2;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(293, 174);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(222, 22);
            this.txtPlayerName.TabIndex = 3;
            // 
            // btnAddPlayerName
            // 
            this.btnAddPlayerName.Location = new System.Drawing.Point(534, 165);
            this.btnAddPlayerName.Name = "btnAddPlayerName";
            this.btnAddPlayerName.Size = new System.Drawing.Size(138, 40);
            this.btnAddPlayerName.TabIndex = 4;
            this.btnAddPlayerName.Text = "Add Player Name";
            this.btnAddPlayerName.UseVisualStyleBackColor = true;
            this.btnAddPlayerName.Click += new System.EventHandler(this.btnAddPlayerName_Click);
            // 
            // txtPlayerNumber
            // 
            this.txtPlayerNumber.Location = new System.Drawing.Point(293, 235);
            this.txtPlayerNumber.Name = "txtPlayerNumber";
            this.txtPlayerNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPlayerNumber.TabIndex = 5;
            // 
            // btnAddPlayerNumber
            // 
            this.btnAddPlayerNumber.Location = new System.Drawing.Point(419, 227);
            this.btnAddPlayerNumber.Name = "btnAddPlayerNumber";
            this.btnAddPlayerNumber.Size = new System.Drawing.Size(162, 38);
            this.btnAddPlayerNumber.TabIndex = 6;
            this.btnAddPlayerNumber.Text = "Add Player Number";
            this.btnAddPlayerNumber.UseVisualStyleBackColor = true;
            this.btnAddPlayerNumber.Click += new System.EventHandler(this.btnAddPlayerNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddPlayerNumber);
            this.Controls.Add(this.txtPlayerNumber);
            this.Controls.Add(this.btnAddPlayerName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tvDemo);
            this.Name = "Form1";
            this.Text = "Tree View 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvDemo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnAddPlayerName;
        private System.Windows.Forms.TextBox txtPlayerNumber;
        private System.Windows.Forms.Button btnAddPlayerNumber;
    }
}

