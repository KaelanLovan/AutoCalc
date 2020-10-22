namespace CarCostCalculator
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
            this.carNoteLabel = new System.Windows.Forms.Label();
            this.carNoteEntry = new System.Windows.Forms.TextBox();
            this.insuranceEntry = new System.Windows.Forms.TextBox();
            this.insuranceLabel = new System.Windows.Forms.Label();
            this.gasEntry = new System.Windows.Forms.TextBox();
            this.gasLabel = new System.Windows.Forms.Label();
            this.oilChangeEntry = new System.Windows.Forms.TextBox();
            this.oilChangeLabel = new System.Windows.Forms.Label();
            this.repairsEntry = new System.Windows.Forms.TextBox();
            this.repairsLabel = new System.Windows.Forms.Label();
            this.registrationEntry = new System.Windows.Forms.TextBox();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resultsOut = new System.Windows.Forms.TextBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carNoteLabel
            // 
            this.carNoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carNoteLabel.Location = new System.Drawing.Point(83, 53);
            this.carNoteLabel.Name = "carNoteLabel";
            this.carNoteLabel.Size = new System.Drawing.Size(104, 29);
            this.carNoteLabel.TabIndex = 0;
            this.carNoteLabel.Text = "Car Note:";
            // 
            // carNoteEntry
            // 
            this.carNoteEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carNoteEntry.Location = new System.Drawing.Point(193, 53);
            this.carNoteEntry.Name = "carNoteEntry";
            this.carNoteEntry.Size = new System.Drawing.Size(197, 29);
            this.carNoteEntry.TabIndex = 12;
            this.carNoteEntry.Text = "0";
            this.carNoteEntry.Click += new System.EventHandler(this.carNoteEntry_Click);
            this.carNoteEntry.TextChanged += new System.EventHandler(this.carNoteEntry_TextChanged);
            // 
            // insuranceEntry
            // 
            this.insuranceEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceEntry.Location = new System.Drawing.Point(193, 95);
            this.insuranceEntry.Name = "insuranceEntry";
            this.insuranceEntry.Size = new System.Drawing.Size(197, 29);
            this.insuranceEntry.TabIndex = 3;
            this.insuranceEntry.Text = "0";
            this.insuranceEntry.Click += new System.EventHandler(this.insuranceEntry_Click);
            this.insuranceEntry.TextChanged += new System.EventHandler(this.insuranceEntry_TextChanged);
            // 
            // insuranceLabel
            // 
            this.insuranceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insuranceLabel.Location = new System.Drawing.Point(41, 95);
            this.insuranceLabel.Name = "insuranceLabel";
            this.insuranceLabel.Size = new System.Drawing.Size(146, 29);
            this.insuranceLabel.TabIndex = 2;
            this.insuranceLabel.Text = "Car Insurance:";
            // 
            // gasEntry
            // 
            this.gasEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasEntry.Location = new System.Drawing.Point(193, 138);
            this.gasEntry.Name = "gasEntry";
            this.gasEntry.Size = new System.Drawing.Size(197, 29);
            this.gasEntry.TabIndex = 5;
            this.gasEntry.Text = "0";
            this.gasEntry.Click += new System.EventHandler(this.gasEntry_Click);
            // 
            // gasLabel
            // 
            this.gasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasLabel.Location = new System.Drawing.Point(124, 138);
            this.gasLabel.Name = "gasLabel";
            this.gasLabel.Size = new System.Drawing.Size(63, 29);
            this.gasLabel.TabIndex = 4;
            this.gasLabel.Text = "Gas:";
            // 
            // oilChangeEntry
            // 
            this.oilChangeEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilChangeEntry.Location = new System.Drawing.Point(193, 182);
            this.oilChangeEntry.Name = "oilChangeEntry";
            this.oilChangeEntry.Size = new System.Drawing.Size(197, 29);
            this.oilChangeEntry.TabIndex = 7;
            this.oilChangeEntry.Text = "0";
            this.oilChangeEntry.Click += new System.EventHandler(this.oilChangeEntry_Click);
            // 
            // oilChangeLabel
            // 
            this.oilChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilChangeLabel.Location = new System.Drawing.Point(58, 182);
            this.oilChangeLabel.Name = "oilChangeLabel";
            this.oilChangeLabel.Size = new System.Drawing.Size(129, 29);
            this.oilChangeLabel.TabIndex = 6;
            this.oilChangeLabel.Text = "Oil Changes:";
            // 
            // repairsEntry
            // 
            this.repairsEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairsEntry.Location = new System.Drawing.Point(193, 229);
            this.repairsEntry.Name = "repairsEntry";
            this.repairsEntry.Size = new System.Drawing.Size(197, 29);
            this.repairsEntry.TabIndex = 9;
            this.repairsEntry.Text = "0";
            this.repairsEntry.Click += new System.EventHandler(this.repairsEntry_Click);
            // 
            // repairsLabel
            // 
            this.repairsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairsLabel.Location = new System.Drawing.Point(49, 229);
            this.repairsLabel.Name = "repairsLabel";
            this.repairsLabel.Size = new System.Drawing.Size(138, 29);
            this.repairsLabel.TabIndex = 8;
            this.repairsLabel.Text = "Basic Repairs:";
            // 
            // registrationEntry
            // 
            this.registrationEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationEntry.Location = new System.Drawing.Point(193, 277);
            this.registrationEntry.Name = "registrationEntry";
            this.registrationEntry.Size = new System.Drawing.Size(197, 29);
            this.registrationEntry.TabIndex = 11;
            this.registrationEntry.Text = "0";
            this.registrationEntry.Click += new System.EventHandler(this.registrationEntry_Click);
            this.registrationEntry.TextChanged += new System.EventHandler(this.registrationEntry_TextChanged);
            // 
            // registrationLabel
            // 
            this.registrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationLabel.Location = new System.Drawing.Point(19, 277);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(168, 29);
            this.registrationLabel.TabIndex = 10;
            this.registrationLabel.Text = "Registration Fees:";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(297, 321);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(93, 35);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "$";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "$";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "$";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(179, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "$";
            // 
            // resultsOut
            // 
            this.resultsOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsOut.Location = new System.Drawing.Point(23, 384);
            this.resultsOut.Multiline = true;
            this.resultsOut.Name = "resultsOut";
            this.resultsOut.ReadOnly = true;
            this.resultsOut.Size = new System.Drawing.Size(377, 96);
            this.resultsOut.TabIndex = 13;
            this.resultsOut.Text = "***Final Results***\r\nTotal Monthly Cost: $\r\nTotal Annual Cost: $";
            // 
            // resultsLabel
            // 
            this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(23, 384);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(377, 96);
            this.resultsLabel.TabIndex = 22;
            this.resultsLabel.Text = "***Final Results***\r\nTotal Monthly Cost: $\r\nTotal Annual Cost: $\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 492);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultsOut);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.registrationEntry);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.repairsEntry);
            this.Controls.Add(this.repairsLabel);
            this.Controls.Add(this.oilChangeEntry);
            this.Controls.Add(this.oilChangeLabel);
            this.Controls.Add(this.gasEntry);
            this.Controls.Add(this.gasLabel);
            this.Controls.Add(this.insuranceEntry);
            this.Controls.Add(this.insuranceLabel);
            this.Controls.Add(this.carNoteEntry);
            this.Controls.Add(this.carNoteLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automobile Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carNoteLabel;
        private System.Windows.Forms.TextBox carNoteEntry;
        private System.Windows.Forms.TextBox insuranceEntry;
        private System.Windows.Forms.Label insuranceLabel;
        private System.Windows.Forms.TextBox gasEntry;
        private System.Windows.Forms.Label gasLabel;
        private System.Windows.Forms.TextBox oilChangeEntry;
        private System.Windows.Forms.Label oilChangeLabel;
        private System.Windows.Forms.TextBox repairsEntry;
        private System.Windows.Forms.Label repairsLabel;
        private System.Windows.Forms.TextBox registrationEntry;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resultsOut;
        private System.Windows.Forms.Label resultsLabel;
    }
}

