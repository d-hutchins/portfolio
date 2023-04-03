
namespace Prog3
{
    partial class Prog3
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
            this.cityLabel = new System.Windows.Forms.Label();
            this.entreeNumberLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.initialCostLabel = new System.Windows.Forms.Label();
            this.adjustedCostLabel = new System.Windows.Forms.Label();
            this.shipmentCostLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.entreeNumberTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.initialCostOutputLabel = new System.Windows.Forms.Label();
            this.adjustedCostOutputLabel = new System.Windows.Forms.Label();
            this.shipmentCostOutputLabel = new System.Windows.Forms.Label();
            this.totalPriceOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(308, 117);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(55, 25);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "City:";
            // 
            // entreeNumberLabel
            // 
            this.entreeNumberLabel.AutoSize = true;
            this.entreeNumberLabel.Location = new System.Drawing.Point(150, 194);
            this.entreeNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.entreeNumberLabel.Name = "entreeNumberLabel";
            this.entreeNumberLabel.Size = new System.Drawing.Size(208, 25);
            this.entreeNumberLabel.TabIndex = 1;
            this.entreeNumberLabel.Text = "Entree/Item Number:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(164, 271);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(202, 25);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity (Servings):";
            // 
            // initialCostLabel
            // 
            this.initialCostLabel.AutoSize = true;
            this.initialCostLabel.Location = new System.Drawing.Point(246, 408);
            this.initialCostLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.initialCostLabel.Name = "initialCostLabel";
            this.initialCostLabel.Size = new System.Drawing.Size(118, 25);
            this.initialCostLabel.TabIndex = 3;
            this.initialCostLabel.Text = "Initial Cost:";
            // 
            // adjustedCostLabel
            // 
            this.adjustedCostLabel.AutoSize = true;
            this.adjustedCostLabel.Location = new System.Drawing.Point(212, 479);
            this.adjustedCostLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.adjustedCostLabel.Name = "adjustedCostLabel";
            this.adjustedCostLabel.Size = new System.Drawing.Size(152, 25);
            this.adjustedCostLabel.TabIndex = 4;
            this.adjustedCostLabel.Text = "Adjusted Cost:";
            // 
            // shipmentCostLabel
            // 
            this.shipmentCostLabel.AutoSize = true;
            this.shipmentCostLabel.Location = new System.Drawing.Point(206, 548);
            this.shipmentCostLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.shipmentCostLabel.Name = "shipmentCostLabel";
            this.shipmentCostLabel.Size = new System.Drawing.Size(158, 25);
            this.shipmentCostLabel.TabIndex = 5;
            this.shipmentCostLabel.Text = "Shipment Cost:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(240, 621);
            this.totalPriceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(121, 25);
            this.totalPriceLabel.TabIndex = 6;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // cityComboBox
            // 
            this.cityComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(376, 117);
            this.cityComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(238, 33);
            this.cityComboBox.TabIndex = 7;
            // 
            // entreeNumberTextBox
            // 
            this.entreeNumberTextBox.Location = new System.Drawing.Point(376, 194);
            this.entreeNumberTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.entreeNumberTextBox.Name = "entreeNumberTextBox";
            this.entreeNumberTextBox.Size = new System.Drawing.Size(238, 31);
            this.entreeNumberTextBox.TabIndex = 8;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(376, 271);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(238, 31);
            this.quantityTextBox.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(426, 338);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 44);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // initialCostOutputLabel
            // 
            this.initialCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialCostOutputLabel.Location = new System.Drawing.Point(376, 408);
            this.initialCostOutputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.initialCostOutputLabel.Name = "initialCostOutputLabel";
            this.initialCostOutputLabel.Size = new System.Drawing.Size(240, 37);
            this.initialCostOutputLabel.TabIndex = 11;
            // 
            // adjustedCostOutputLabel
            // 
            this.adjustedCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adjustedCostOutputLabel.Location = new System.Drawing.Point(376, 479);
            this.adjustedCostOutputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.adjustedCostOutputLabel.Name = "adjustedCostOutputLabel";
            this.adjustedCostOutputLabel.Size = new System.Drawing.Size(240, 37);
            this.adjustedCostOutputLabel.TabIndex = 12;
            // 
            // shipmentCostOutputLabel
            // 
            this.shipmentCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shipmentCostOutputLabel.Location = new System.Drawing.Point(376, 548);
            this.shipmentCostOutputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.shipmentCostOutputLabel.Name = "shipmentCostOutputLabel";
            this.shipmentCostOutputLabel.Size = new System.Drawing.Size(240, 37);
            this.shipmentCostOutputLabel.TabIndex = 13;
            // 
            // totalPriceOutputLabel
            // 
            this.totalPriceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOutputLabel.Location = new System.Drawing.Point(376, 621);
            this.totalPriceOutputLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalPriceOutputLabel.Name = "totalPriceOutputLabel";
            this.totalPriceOutputLabel.Size = new System.Drawing.Size(240, 37);
            this.totalPriceOutputLabel.TabIndex = 14;
            // 
            // Prog3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 865);
            this.Controls.Add(this.totalPriceOutputLabel);
            this.Controls.Add(this.shipmentCostOutputLabel);
            this.Controls.Add(this.adjustedCostOutputLabel);
            this.Controls.Add(this.initialCostOutputLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.entreeNumberTextBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.shipmentCostLabel);
            this.Controls.Add(this.adjustedCostLabel);
            this.Controls.Add(this.initialCostLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.entreeNumberLabel);
            this.Controls.Add(this.cityLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Prog3";
            this.Text = "uThankItWeMakeIt Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label entreeNumberLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label initialCostLabel;
        private System.Windows.Forms.Label adjustedCostLabel;
        private System.Windows.Forms.Label shipmentCostLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.TextBox entreeNumberTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label initialCostOutputLabel;
        private System.Windows.Forms.Label adjustedCostOutputLabel;
        private System.Windows.Forms.Label shipmentCostOutputLabel;
        private System.Windows.Forms.Label totalPriceOutputLabel;
    }
}

