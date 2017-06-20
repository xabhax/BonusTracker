namespace BonusTracker
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hourstwo = new System.Windows.Forms.TextBox();
            this.hoursone = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hoursthree = new System.Windows.Forms.TextBox();
            this.hoursfour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calculatedbonus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Week #1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Week #2";
            // 
            // hourstwo
            // 
            this.hourstwo.Location = new System.Drawing.Point(148, 87);
            this.hourstwo.Name = "hourstwo";
            this.hourstwo.Size = new System.Drawing.Size(100, 20);
            this.hourstwo.TabIndex = 4;
            // 
            // hoursone
            // 
            this.hoursone.Location = new System.Drawing.Point(148, 54);
            this.hoursone.Name = "hoursone";
            this.hoursone.Size = new System.Drawing.Size(100, 20);
            this.hoursone.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(157, 309);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateGross);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Quit);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Earnings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Week #3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Week #4";
            // 
            // hoursthree
            // 
            this.hoursthree.Location = new System.Drawing.Point(148, 120);
            this.hoursthree.Name = "hoursthree";
            this.hoursthree.Size = new System.Drawing.Size(100, 20);
            this.hoursthree.TabIndex = 25;
            // 
            // hoursfour
            // 
            this.hoursfour.Location = new System.Drawing.Point(148, 153);
            this.hoursfour.Name = "hoursfour";
            this.hoursfour.Size = new System.Drawing.Size(100, 20);
            this.hoursfour.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Calculated Bonus";
            // 
            // calculatedbonus
            // 
            this.calculatedbonus.AutoSize = true;
            this.calculatedbonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatedbonus.Location = new System.Drawing.Point(33, 230);
            this.calculatedbonus.Name = "calculatedbonus";
            this.calculatedbonus.Size = new System.Drawing.Size(36, 16);
            this.calculatedbonus.TabIndex = 28;
            this.calculatedbonus.Text = "0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 344);
            this.Controls.Add(this.calculatedbonus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hoursfour);
            this.Controls.Add(this.hoursthree);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.hoursone);
            this.Controls.Add(this.hourstwo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Bonus Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox hoursone;
        private System.Windows.Forms.TextBox hourstwo;
        private System.Windows.Forms.TextBox hoursthree;
        private System.Windows.Forms.TextBox hoursfour;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label calculatedbonus;
    }
}

