namespace WinUI
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
            this.entrObjMassLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.kineticEnergyLabel = new System.Windows.Forms.Label();
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.velocityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // entrObjMassLbl
            // 
            this.entrObjMassLbl.Location = new System.Drawing.Point(35, 33);
            this.entrObjMassLbl.Name = "entrObjMassLbl";
            this.entrObjMassLbl.Size = new System.Drawing.Size(122, 16);
            this.entrObjMassLbl.TabIndex = 0;
            this.entrObjMassLbl.Text = "Enter the object\'s mass:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the object\'s velocity:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(78, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kinetic Energy:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(55, 141);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(101, 46);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate Kinetic Energy";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(162, 141);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 46);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // kineticEnergyLabel
            // 
            this.kineticEnergyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kineticEnergyLabel.Location = new System.Drawing.Point(163, 106);
            this.kineticEnergyLabel.Name = "kineticEnergyLabel";
            this.kineticEnergyLabel.Size = new System.Drawing.Size(100, 16);
            this.kineticEnergyLabel.TabIndex = 5;
            // 
            // massTextBox
            // 
            this.massTextBox.Location = new System.Drawing.Point(162, 37);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(100, 20);
            this.massTextBox.TabIndex = 6;
            // 
            // velocityTextBox
            // 
            this.velocityTextBox.Location = new System.Drawing.Point(162, 70);
            this.velocityTextBox.Name = "velocityTextBox";
            this.velocityTextBox.Size = new System.Drawing.Size(100, 20);
            this.velocityTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 199);
            this.Controls.Add(this.velocityTextBox);
            this.Controls.Add(this.massTextBox);
            this.Controls.Add(this.kineticEnergyLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entrObjMassLbl);
            this.Name = "Form1";
            this.Text = "Kinetic Energy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label entrObjMassLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label kineticEnergyLabel;
        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.TextBox velocityTextBox;
    }
}

