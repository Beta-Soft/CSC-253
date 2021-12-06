namespace WinsUI
{
    partial class FormWordCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWordCount));
            this.wordBox = new System.Windows.Forms.ListBox();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.addWordButton = new System.Windows.Forms.Button();
            this.newWordButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.wordCountTitle = new System.Windows.Forms.Label();
            this.richWordCount = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // wordBox
            // 
            this.wordBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.wordBox.FormattingEnabled = true;
            this.wordBox.Location = new System.Drawing.Point(170, 172);
            this.wordBox.Name = "wordBox";
            this.wordBox.Size = new System.Drawing.Size(280, 147);
            this.wordBox.TabIndex = 16;
            this.wordBox.TabStop = false;
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.AutoSize = true;
            this.wordCountLabel.Location = new System.Drawing.Point(34, 55);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(114, 13);
            this.wordCountLabel.TabIndex = 18;
            this.wordCountLabel.Text = "Enter words for count: ";
            // 
            // addWordButton
            // 
            this.addWordButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addWordButton.Location = new System.Drawing.Point(37, 86);
            this.addWordButton.Name = "addWordButton";
            this.addWordButton.Size = new System.Drawing.Size(89, 26);
            this.addWordButton.TabIndex = 1;
            this.addWordButton.Text = "Add";
            this.addWordButton.UseVisualStyleBackColor = false;
            this.addWordButton.Click += new System.EventHandler(this.addWordButton_Click);
            // 
            // newWordButton
            // 
            this.newWordButton.BackColor = System.Drawing.Color.Lavender;
            this.newWordButton.Location = new System.Drawing.Point(36, 124);
            this.newWordButton.Name = "newWordButton";
            this.newWordButton.Size = new System.Drawing.Size(90, 26);
            this.newWordButton.TabIndex = 2;
            this.newWordButton.Text = "Add New Entry";
            this.newWordButton.UseVisualStyleBackColor = false;
            this.newWordButton.Click += new System.EventHandler(this.newWordButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Location = new System.Drawing.Point(170, 325);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 52);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear Form";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // wordCountTitle
            // 
            this.wordCountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordCountTitle.Location = new System.Drawing.Point(44, -6);
            this.wordCountTitle.Name = "wordCountTitle";
            this.wordCountTitle.Size = new System.Drawing.Size(327, 58);
            this.wordCountTitle.TabIndex = 22;
            this.wordCountTitle.Text = "WORD COUNT";
            this.wordCountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richWordCount
            // 
            this.richWordCount.Location = new System.Drawing.Point(170, 55);
            this.richWordCount.Name = "richWordCount";
            this.richWordCount.Size = new System.Drawing.Size(280, 95);
            this.richWordCount.TabIndex = 0;
            this.richWordCount.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // FormWordCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 389);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richWordCount);
            this.Controls.Add(this.wordCountTitle);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.newWordButton);
            this.Controls.Add(this.addWordButton);
            this.Controls.Add(this.wordCountLabel);
            this.Controls.Add(this.wordBox);
            this.Name = "FormWordCount";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wordBox;
        private System.Windows.Forms.Label wordCountLabel;
        private System.Windows.Forms.Button addWordButton;
        private System.Windows.Forms.Button newWordButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label wordCountTitle;
        private System.Windows.Forms.RichTextBox richWordCount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

