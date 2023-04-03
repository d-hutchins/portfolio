
namespace Program2
{
    partial class Program2
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
            this.passengerInputTextBox = new System.Windows.Forms.TextBox();
            this.passengerLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.distanceInputTextBox = new System.Windows.Forms.TextBox();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.carTypeComboBox = new System.Windows.Forms.ComboBox();
            this.calculateCostButton = new System.Windows.Forms.Button();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.lowestCostOutputLabel = new System.Windows.Forms.Label();
            this.thirdCompanyOutputLabel = new System.Windows.Forms.Label();
            this.secondCompanyOutputLabel = new System.Windows.Forms.Label();
            this.firstCompanyOutputLabel = new System.Windows.Forms.Label();
            this.thirdCompanyTitleLabel = new System.Windows.Forms.Label();
            this.secondCompanyTitleLabel = new System.Windows.Forms.Label();
            this.firstCompanyTitleLabel = new System.Windows.Forms.Label();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // passengerInputTextBox
            // 
            this.passengerInputTextBox.Location = new System.Drawing.Point(275, 146);
            this.passengerInputTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.passengerInputTextBox.Name = "passengerInputTextBox";
            this.passengerInputTextBox.Size = new System.Drawing.Size(196, 31);
            this.passengerInputTextBox.TabIndex = 0;
            // 
            // passengerLabel
            // 
            this.passengerLabel.AutoSize = true;
            this.passengerLabel.Location = new System.Drawing.Point(64, 146);
            this.passengerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passengerLabel.Name = "passengerLabel";
            this.passengerLabel.Size = new System.Drawing.Size(189, 25);
            this.passengerLabel.TabIndex = 1;
            this.passengerLabel.Text = "Passengers (1-12)";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(86, 232);
            this.distanceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(167, 25);
            this.distanceLabel.TabIndex = 2;
            this.distanceLabel.Text = "Distance (Miles)";
            // 
            // distanceInputTextBox
            // 
            this.distanceInputTextBox.Location = new System.Drawing.Point(275, 232);
            this.distanceInputTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.distanceInputTextBox.Name = "distanceInputTextBox";
            this.distanceInputTextBox.Size = new System.Drawing.Size(196, 31);
            this.distanceInputTextBox.TabIndex = 3;
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Location = new System.Drawing.Point(147, 315);
            this.carTypeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(106, 25);
            this.carTypeLabel.TabIndex = 4;
            this.carTypeLabel.Text = "Car Type:";
            // 
            // carTypeComboBox
            // 
            this.carTypeComboBox.Location = new System.Drawing.Point(275, 315);
            this.carTypeComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.carTypeComboBox.Name = "carTypeComboBox";
            this.carTypeComboBox.Size = new System.Drawing.Size(238, 33);
            this.carTypeComboBox.TabIndex = 9;
            // 
            // calculateCostButton
            // 
            this.calculateCostButton.Location = new System.Drawing.Point(173, 403);
            this.calculateCostButton.Margin = new System.Windows.Forms.Padding(6);
            this.calculateCostButton.Name = "calculateCostButton";
            this.calculateCostButton.Size = new System.Drawing.Size(212, 44);
            this.calculateCostButton.TabIndex = 6;
            this.calculateCostButton.Text = "Calculate Cost";
            this.calculateCostButton.UseVisualStyleBackColor = true;
            this.calculateCostButton.Click += new System.EventHandler(this.CalculateCostButton_Click);
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.lowestCostOutputLabel);
            this.resultsGroupBox.Controls.Add(this.thirdCompanyOutputLabel);
            this.resultsGroupBox.Controls.Add(this.secondCompanyOutputLabel);
            this.resultsGroupBox.Controls.Add(this.firstCompanyOutputLabel);
            this.resultsGroupBox.Controls.Add(this.thirdCompanyTitleLabel);
            this.resultsGroupBox.Controls.Add(this.secondCompanyTitleLabel);
            this.resultsGroupBox.Controls.Add(this.firstCompanyTitleLabel);
            this.resultsGroupBox.Location = new System.Drawing.Point(542, 49);
            this.resultsGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.resultsGroupBox.Size = new System.Drawing.Size(573, 552);
            this.resultsGroupBox.TabIndex = 8;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // lowestCostOutputLabel
            // 
            this.lowestCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestCostOutputLabel.Location = new System.Drawing.Point(53, 425);
            this.lowestCostOutputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lowestCostOutputLabel.Name = "lowestCostOutputLabel";
            this.lowestCostOutputLabel.Size = new System.Drawing.Size(481, 42);
            this.lowestCostOutputLabel.TabIndex = 6;
            this.lowestCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirdCompanyOutputLabel
            // 
            this.thirdCompanyOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thirdCompanyOutputLabel.Location = new System.Drawing.Point(336, 318);
            this.thirdCompanyOutputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.thirdCompanyOutputLabel.Name = "thirdCompanyOutputLabel";
            this.thirdCompanyOutputLabel.Size = new System.Drawing.Size(198, 42);
            this.thirdCompanyOutputLabel.TabIndex = 5;
            this.thirdCompanyOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondCompanyOutputLabel
            // 
            this.secondCompanyOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondCompanyOutputLabel.Location = new System.Drawing.Point(336, 210);
            this.secondCompanyOutputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.secondCompanyOutputLabel.Name = "secondCompanyOutputLabel";
            this.secondCompanyOutputLabel.Size = new System.Drawing.Size(198, 42);
            this.secondCompanyOutputLabel.TabIndex = 4;
            this.secondCompanyOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstCompanyOutputLabel
            // 
            this.firstCompanyOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstCompanyOutputLabel.Location = new System.Drawing.Point(336, 102);
            this.firstCompanyOutputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstCompanyOutputLabel.Name = "firstCompanyOutputLabel";
            this.firstCompanyOutputLabel.Size = new System.Drawing.Size(198, 42);
            this.firstCompanyOutputLabel.TabIndex = 3;
            this.firstCompanyOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirdCompanyTitleLabel
            // 
            this.thirdCompanyTitleLabel.AutoSize = true;
            this.thirdCompanyTitleLabel.Location = new System.Drawing.Point(112, 318);
            this.thirdCompanyTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.thirdCompanyTitleLabel.Name = "thirdCompanyTitleLabel";
            this.thirdCompanyTitleLabel.Size = new System.Drawing.Size(174, 25);
            this.thirdCompanyTitleLabel.TabIndex = 2;
            this.thirdCompanyTitleLabel.Text = "Company C Cost";
            // 
            // secondCompanyTitleLabel
            // 
            this.secondCompanyTitleLabel.AutoSize = true;
            this.secondCompanyTitleLabel.Location = new System.Drawing.Point(112, 210);
            this.secondCompanyTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.secondCompanyTitleLabel.Name = "secondCompanyTitleLabel";
            this.secondCompanyTitleLabel.Size = new System.Drawing.Size(173, 25);
            this.secondCompanyTitleLabel.TabIndex = 1;
            this.secondCompanyTitleLabel.Text = "Company B Cost";
            // 
            // firstCompanyTitleLabel
            // 
            this.firstCompanyTitleLabel.AutoSize = true;
            this.firstCompanyTitleLabel.Location = new System.Drawing.Point(112, 102);
            this.firstCompanyTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstCompanyTitleLabel.Name = "firstCompanyTitleLabel";
            this.firstCompanyTitleLabel.Size = new System.Drawing.Size(173, 25);
            this.firstCompanyTitleLabel.TabIndex = 0;
            this.firstCompanyTitleLabel.Text = "Company A Cost";
            // 
            // Program2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.calculateCostButton);
            this.Controls.Add(this.carTypeComboBox);
            this.Controls.Add(this.carTypeLabel);
            this.Controls.Add(this.distanceInputTextBox);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.passengerLabel);
            this.Controls.Add(this.passengerInputTextBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Program2";
            this.Text = "iRydeShare Cost Calculation";
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passengerInputTextBox;
        private System.Windows.Forms.Label passengerLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.TextBox distanceInputTextBox;
        private System.Windows.Forms.Label carTypeLabel;
        private System.Windows.Forms.ComboBox carTypeComboBox;
        private System.Windows.Forms.Button calculateCostButton;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.Label lowestCostOutputLabel;
        private System.Windows.Forms.Label thirdCompanyOutputLabel;
        private System.Windows.Forms.Label secondCompanyOutputLabel;
        private System.Windows.Forms.Label firstCompanyOutputLabel;
        private System.Windows.Forms.Label thirdCompanyTitleLabel;
        private System.Windows.Forms.Label secondCompanyTitleLabel;
        private System.Windows.Forms.Label firstCompanyTitleLabel;
    }
}

