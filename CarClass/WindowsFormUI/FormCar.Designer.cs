
namespace WindowsFormUI
{
    partial class FormCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.carYearLabel = new System.Windows.Forms.Label();
            this.carMakeLabel = new System.Windows.Forms.Label();
            this.carClassLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.Label();
            this.accelerateButton = new System.Windows.Forms.Button();
            this.brakeButton = new System.Windows.Forms.Button();
            this.newCarButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.carBox = new System.Windows.Forms.ListBox();
            this.addCarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // carYearLabel
            // 
            this.carYearLabel.AutoSize = true;
            this.carYearLabel.Location = new System.Drawing.Point(93, 94);
            this.carYearLabel.Name = "carYearLabel";
            this.carYearLabel.Size = new System.Drawing.Size(51, 13);
            this.carYearLabel.TabIndex = 1;
            this.carYearLabel.Text = "Car Year:";
            // 
            // carMakeLabel
            // 
            this.carMakeLabel.AutoSize = true;
            this.carMakeLabel.Location = new System.Drawing.Point(93, 134);
            this.carMakeLabel.Name = "carMakeLabel";
            this.carMakeLabel.Size = new System.Drawing.Size(56, 13);
            this.carMakeLabel.TabIndex = 2;
            this.carMakeLabel.Text = "Car Make:";
            // 
            // carClassLabel
            // 
            this.carClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carClassLabel.Location = new System.Drawing.Point(89, 9);
            this.carClassLabel.Name = "carClassLabel";
            this.carClassLabel.Size = new System.Drawing.Size(287, 58);
            this.carClassLabel.TabIndex = 3;
            this.carClassLabel.Text = "CAR CLASS";
            this.carClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Car Speed:";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.Lavender;
            this.txtYear.Location = new System.Drawing.Point(170, 87);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(140, 20);
            this.txtYear.TabIndex = 5;
            // 
            // txtMake
            // 
            this.txtMake.BackColor = System.Drawing.Color.Lavender;
            this.txtMake.Location = new System.Drawing.Point(170, 131);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(140, 20);
            this.txtMake.TabIndex = 7;
            // 
            // txtSpeed
            // 
            this.txtSpeed.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtSpeed.Location = new System.Drawing.Point(170, 175);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(140, 20);
            this.txtSpeed.TabIndex = 8;
            this.txtSpeed.Text = "0.0";
            // 
            // accelerateButton
            // 
            this.accelerateButton.BackColor = System.Drawing.Color.AliceBlue;
            this.accelerateButton.Location = new System.Drawing.Point(31, 209);
            this.accelerateButton.Name = "accelerateButton";
            this.accelerateButton.Size = new System.Drawing.Size(89, 26);
            this.accelerateButton.TabIndex = 10;
            this.accelerateButton.Text = "Accelerate";
            this.accelerateButton.UseVisualStyleBackColor = false;
            this.accelerateButton.Click += new System.EventHandler(this.accelerateButton_Click);
            // 
            // brakeButton
            // 
            this.brakeButton.BackColor = System.Drawing.Color.AliceBlue;
            this.brakeButton.Location = new System.Drawing.Point(147, 209);
            this.brakeButton.Name = "brakeButton";
            this.brakeButton.Size = new System.Drawing.Size(89, 26);
            this.brakeButton.TabIndex = 11;
            this.brakeButton.Text = "Brake";
            this.brakeButton.UseVisualStyleBackColor = false;
            this.brakeButton.Click += new System.EventHandler(this.brakeButton_Click);
            // 
            // newCarButton
            // 
            this.newCarButton.BackColor = System.Drawing.Color.Lavender;
            this.newCarButton.Location = new System.Drawing.Point(359, 209);
            this.newCarButton.Name = "newCarButton";
            this.newCarButton.Size = new System.Drawing.Size(89, 26);
            this.newCarButton.TabIndex = 13;
            this.newCarButton.Text = "Add New Car";
            this.newCarButton.UseVisualStyleBackColor = false;
            this.newCarButton.Click += new System.EventHandler(this.newCarButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Location = new System.Drawing.Point(170, 449);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 52);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear Form";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // carBox
            // 
            this.carBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.carBox.FormattingEnabled = true;
            this.carBox.Location = new System.Drawing.Point(243, 244);
            this.carBox.Name = "carBox";
            this.carBox.Size = new System.Drawing.Size(205, 199);
            this.carBox.TabIndex = 15;
            this.carBox.TabStop = false;
            // 
            // addCarButton
            // 
            this.addCarButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addCarButton.Location = new System.Drawing.Point(243, 209);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(89, 26);
            this.addCarButton.TabIndex = 12;
            this.addCarButton.Text = "Add Car";
            this.addCarButton.UseVisualStyleBackColor = false;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // FormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 513);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.carBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.newCarButton);
            this.Controls.Add(this.brakeButton);
            this.Controls.Add(this.accelerateButton);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carClassLabel);
            this.Controls.Add(this.carMakeLabel);
            this.Controls.Add(this.carYearLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormCar";
            this.Text = "M1HW3_Garciar2566";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label carYearLabel;
        private System.Windows.Forms.Label carMakeLabel;
        private System.Windows.Forms.Label carClassLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label txtSpeed;
        private System.Windows.Forms.Button accelerateButton;
        private System.Windows.Forms.Button brakeButton;
        private System.Windows.Forms.Button newCarButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox carBox;
        private System.Windows.Forms.Button addCarButton;
    }
}

