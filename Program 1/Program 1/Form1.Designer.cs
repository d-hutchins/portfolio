
namespace Program_1
{
    partial class Program1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.maxWidthTitleLabel = new System.Windows.Forms.Label();
            this.maxLengthTitleLabel = new System.Windows.Forms.Label();
            this.maxDepthTitleLabel = new System.Windows.Forms.Label();
            this.materialPriceTitleLabel = new System.Windows.Forms.Label();
            this.excavationTitleLabel = new System.Windows.Forms.Label();
            this.excavationNoteLabel = new System.Windows.Forms.Label();
            this.divingBoardTitleLabel = new System.Windows.Forms.Label();
            this.divingNoteLabel = new System.Windows.Forms.Label();
            this.cubicYardsTitleLabel = new System.Windows.Forms.Label();
            this.cubicYardsOutputLabel = new System.Windows.Forms.Label();
            this.materialCostTitleLabel = new System.Windows.Forms.Label();
            this.materialCostOutputLabel = new System.Windows.Forms.Label();
            this.excavationCostTitleLabel = new System.Windows.Forms.Label();
            this.excavationCostOutputLabel = new System.Windows.Forms.Label();
            this.laborCostTitleLabel = new System.Windows.Forms.Label();
            this.laborCostOutputLabel = new System.Windows.Forms.Label();
            this.totalCostTitleLabel = new System.Windows.Forms.Label();
            this.totalCostOutputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.userWidthTextBox = new System.Windows.Forms.TextBox();
            this.userLengthTextBox = new System.Windows.Forms.TextBox();
            this.userDepthTextBox = new System.Windows.Forms.TextBox();
            this.userMaterialPriceTextBox = new System.Windows.Forms.TextBox();
            this.excavationTextBox = new System.Windows.Forms.TextBox();
            this.divingBoardTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(124, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(125, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "EZ-Pools Costs Estimator";
            // 
            // maxWidthTitleLabel
            // 
            this.maxWidthTitleLabel.AutoSize = true;
            this.maxWidthTitleLabel.Location = new System.Drawing.Point(70, 57);
            this.maxWidthTitleLabel.Name = "maxWidthTitleLabel";
            this.maxWidthTitleLabel.Size = new System.Drawing.Size(112, 13);
            this.maxWidthTitleLabel.TabIndex = 1;
            this.maxWidthTitleLabel.Text = "Max Width of Pool (ft):";
            // 
            // maxLengthTitleLabel
            // 
            this.maxLengthTitleLabel.AutoSize = true;
            this.maxLengthTitleLabel.Location = new System.Drawing.Point(65, 89);
            this.maxLengthTitleLabel.Name = "maxLengthTitleLabel";
            this.maxLengthTitleLabel.Size = new System.Drawing.Size(117, 13);
            this.maxLengthTitleLabel.TabIndex = 3;
            this.maxLengthTitleLabel.Text = "Max Length of Pool (ft):";
            // 
            // maxDepthTitleLabel
            // 
            this.maxDepthTitleLabel.AutoSize = true;
            this.maxDepthTitleLabel.Location = new System.Drawing.Point(69, 122);
            this.maxDepthTitleLabel.Name = "maxDepthTitleLabel";
            this.maxDepthTitleLabel.Size = new System.Drawing.Size(113, 13);
            this.maxDepthTitleLabel.TabIndex = 5;
            this.maxDepthTitleLabel.Text = "Max Depth of Pool (ft):";
            // 
            // materialPriceTitleLabel
            // 
            this.materialPriceTitleLabel.AutoSize = true;
            this.materialPriceTitleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.materialPriceTitleLabel.Location = new System.Drawing.Point(54, 158);
            this.materialPriceTitleLabel.Name = "materialPriceTitleLabel";
            this.materialPriceTitleLabel.Size = new System.Drawing.Size(128, 13);
            this.materialPriceTitleLabel.TabIndex = 7;
            this.materialPriceTitleLabel.Text = "Materials Price (cubic yd):";
            // 
            // excavationTitleLabel
            // 
            this.excavationTitleLabel.AutoSize = true;
            this.excavationTitleLabel.Location = new System.Drawing.Point(72, 189);
            this.excavationTitleLabel.Name = "excavationTitleLabel";
            this.excavationTitleLabel.Size = new System.Drawing.Size(110, 13);
            this.excavationTitleLabel.TabIndex = 9;
            this.excavationTitleLabel.Text = "Excavation Needed?:";
            // 
            // excavationNoteLabel
            // 
            this.excavationNoteLabel.AutoSize = true;
            this.excavationNoteLabel.Location = new System.Drawing.Point(81, 202);
            this.excavationNoteLabel.Name = "excavationNoteLabel";
            this.excavationNoteLabel.Size = new System.Drawing.Size(92, 13);
            this.excavationNoteLabel.TabIndex = 11;
            this.excavationNoteLabel.Text = "(1 = YES, 0 = NO)";
            // 
            // divingBoardTitleLabel
            // 
            this.divingBoardTitleLabel.AutoSize = true;
            this.divingBoardTitleLabel.Location = new System.Drawing.Point(105, 233);
            this.divingBoardTitleLabel.Name = "divingBoardTitleLabel";
            this.divingBoardTitleLabel.Size = new System.Drawing.Size(77, 13);
            this.divingBoardTitleLabel.TabIndex = 12;
            this.divingBoardTitleLabel.Text = "Diving Board?:";
            // 
            // divingNoteLabel
            // 
            this.divingNoteLabel.AutoSize = true;
            this.divingNoteLabel.Location = new System.Drawing.Point(90, 255);
            this.divingNoteLabel.Name = "divingNoteLabel";
            this.divingNoteLabel.Size = new System.Drawing.Size(92, 13);
            this.divingNoteLabel.TabIndex = 14;
            this.divingNoteLabel.Text = "(1 = YES, 0 = NO)";
            // 
            // cubicYardsTitleLabel
            // 
            this.cubicYardsTitleLabel.AutoSize = true;
            this.cubicYardsTitleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.cubicYardsTitleLabel.Location = new System.Drawing.Point(115, 320);
            this.cubicYardsTitleLabel.Name = "cubicYardsTitleLabel";
            this.cubicYardsTitleLabel.Size = new System.Drawing.Size(67, 13);
            this.cubicYardsTitleLabel.TabIndex = 15;
            this.cubicYardsTitleLabel.Text = "Cubic Yards:";
            // 
            // cubicYardsOutputLabel
            // 
            this.cubicYardsOutputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cubicYardsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cubicYardsOutputLabel.Location = new System.Drawing.Point(188, 320);
            this.cubicYardsOutputLabel.Name = "cubicYardsOutputLabel";
            this.cubicYardsOutputLabel.Size = new System.Drawing.Size(100, 15);
            this.cubicYardsOutputLabel.TabIndex = 16;
            // 
            // materialCostTitleLabel
            // 
            this.materialCostTitleLabel.AutoSize = true;
            this.materialCostTitleLabel.Location = new System.Drawing.Point(106, 357);
            this.materialCostTitleLabel.Name = "materialCostTitleLabel";
            this.materialCostTitleLabel.Size = new System.Drawing.Size(76, 13);
            this.materialCostTitleLabel.TabIndex = 17;
            this.materialCostTitleLabel.Text = "Materials Cost:";
            // 
            // materialCostOutputLabel
            // 
            this.materialCostOutputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.materialCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.materialCostOutputLabel.Location = new System.Drawing.Point(188, 356);
            this.materialCostOutputLabel.Name = "materialCostOutputLabel";
            this.materialCostOutputLabel.Size = new System.Drawing.Size(100, 15);
            this.materialCostOutputLabel.TabIndex = 18;
            // 
            // excavationCostTitleLabel
            // 
            this.excavationCostTitleLabel.AutoSize = true;
            this.excavationCostTitleLabel.Location = new System.Drawing.Point(95, 391);
            this.excavationCostTitleLabel.Name = "excavationCostTitleLabel";
            this.excavationCostTitleLabel.Size = new System.Drawing.Size(87, 13);
            this.excavationCostTitleLabel.TabIndex = 19;
            this.excavationCostTitleLabel.Text = "Excavation Cost:";
            // 
            // excavationCostOutputLabel
            // 
            this.excavationCostOutputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.excavationCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.excavationCostOutputLabel.Location = new System.Drawing.Point(188, 391);
            this.excavationCostOutputLabel.Name = "excavationCostOutputLabel";
            this.excavationCostOutputLabel.Size = new System.Drawing.Size(100, 15);
            this.excavationCostOutputLabel.TabIndex = 20;
            // 
            // laborCostTitleLabel
            // 
            this.laborCostTitleLabel.AutoSize = true;
            this.laborCostTitleLabel.Location = new System.Drawing.Point(121, 426);
            this.laborCostTitleLabel.Name = "laborCostTitleLabel";
            this.laborCostTitleLabel.Size = new System.Drawing.Size(61, 13);
            this.laborCostTitleLabel.TabIndex = 21;
            this.laborCostTitleLabel.Text = "Labor Cost:";
            // 
            // laborCostOutputLabel
            // 
            this.laborCostOutputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.laborCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.laborCostOutputLabel.Location = new System.Drawing.Point(188, 424);
            this.laborCostOutputLabel.Name = "laborCostOutputLabel";
            this.laborCostOutputLabel.Size = new System.Drawing.Size(100, 15);
            this.laborCostOutputLabel.TabIndex = 22;
            // 
            // totalCostTitleLabel
            // 
            this.totalCostTitleLabel.AutoSize = true;
            this.totalCostTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostTitleLabel.Location = new System.Drawing.Point(113, 465);
            this.totalCostTitleLabel.Name = "totalCostTitleLabel";
            this.totalCostTitleLabel.Size = new System.Drawing.Size(69, 13);
            this.totalCostTitleLabel.TabIndex = 23;
            this.totalCostTitleLabel.Text = "Total Cost:";
            // 
            // totalCostOutputLabel
            // 
            this.totalCostOutputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCostOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostOutputLabel.Location = new System.Drawing.Point(188, 464);
            this.totalCostOutputLabel.Name = "totalCostOutputLabel";
            this.totalCostOutputLabel.Size = new System.Drawing.Size(100, 15);
            this.totalCostOutputLabel.TabIndex = 24;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(127, 493);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(128, 23);
            this.calculateButton.TabIndex = 25;
            this.calculateButton.Text = "Calculate Estimate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // userWidthTextBox
            // 
            this.userWidthTextBox.Location = new System.Drawing.Point(188, 54);
            this.userWidthTextBox.Name = "userWidthTextBox";
            this.userWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.userWidthTextBox.TabIndex = 26;
            // 
            // userLengthTextBox
            // 
            this.userLengthTextBox.Location = new System.Drawing.Point(188, 86);
            this.userLengthTextBox.Name = "userLengthTextBox";
            this.userLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.userLengthTextBox.TabIndex = 27;
            // 
            // userDepthTextBox
            // 
            this.userDepthTextBox.Location = new System.Drawing.Point(188, 119);
            this.userDepthTextBox.Name = "userDepthTextBox";
            this.userDepthTextBox.Size = new System.Drawing.Size(100, 20);
            this.userDepthTextBox.TabIndex = 28;
            // 
            // userMaterialPriceTextBox
            // 
            this.userMaterialPriceTextBox.Location = new System.Drawing.Point(188, 155);
            this.userMaterialPriceTextBox.Name = "userMaterialPriceTextBox";
            this.userMaterialPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.userMaterialPriceTextBox.TabIndex = 29;
            // 
            // excavationTextBox
            // 
            this.excavationTextBox.Location = new System.Drawing.Point(188, 189);
            this.excavationTextBox.Name = "excavationTextBox";
            this.excavationTextBox.Size = new System.Drawing.Size(100, 20);
            this.excavationTextBox.TabIndex = 30;
            // 
            // divingBoardTextBox
            // 
            this.divingBoardTextBox.Location = new System.Drawing.Point(188, 233);
            this.divingBoardTextBox.Name = "divingBoardTextBox";
            this.divingBoardTextBox.Size = new System.Drawing.Size(100, 20);
            this.divingBoardTextBox.TabIndex = 31;
            // 
            // Program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(384, 558);
            this.Controls.Add(this.divingBoardTextBox);
            this.Controls.Add(this.excavationTextBox);
            this.Controls.Add(this.userMaterialPriceTextBox);
            this.Controls.Add(this.userDepthTextBox);
            this.Controls.Add(this.userLengthTextBox);
            this.Controls.Add(this.userWidthTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalCostOutputLabel);
            this.Controls.Add(this.totalCostTitleLabel);
            this.Controls.Add(this.laborCostOutputLabel);
            this.Controls.Add(this.laborCostTitleLabel);
            this.Controls.Add(this.excavationCostOutputLabel);
            this.Controls.Add(this.excavationCostTitleLabel);
            this.Controls.Add(this.materialCostOutputLabel);
            this.Controls.Add(this.materialCostTitleLabel);
            this.Controls.Add(this.cubicYardsOutputLabel);
            this.Controls.Add(this.cubicYardsTitleLabel);
            this.Controls.Add(this.divingNoteLabel);
            this.Controls.Add(this.divingBoardTitleLabel);
            this.Controls.Add(this.excavationNoteLabel);
            this.Controls.Add(this.excavationTitleLabel);
            this.Controls.Add(this.materialPriceTitleLabel);
            this.Controls.Add(this.maxDepthTitleLabel);
            this.Controls.Add(this.maxLengthTitleLabel);
            this.Controls.Add(this.maxWidthTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Program1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label maxWidthTitleLabel;
        private System.Windows.Forms.Label maxLengthTitleLabel;
        private System.Windows.Forms.Label maxDepthTitleLabel;
        private System.Windows.Forms.Label materialPriceTitleLabel;
        private System.Windows.Forms.Label excavationTitleLabel;
        private System.Windows.Forms.Label excavationNoteLabel;
        private System.Windows.Forms.Label divingBoardTitleLabel;
        private System.Windows.Forms.Label divingNoteLabel;
        private System.Windows.Forms.Label cubicYardsTitleLabel;
        private System.Windows.Forms.Label cubicYardsOutputLabel;
        private System.Windows.Forms.Label materialCostTitleLabel;
        private System.Windows.Forms.Label materialCostOutputLabel;
        private System.Windows.Forms.Label excavationCostTitleLabel;
        private System.Windows.Forms.Label excavationCostOutputLabel;
        private System.Windows.Forms.Label laborCostTitleLabel;
        private System.Windows.Forms.Label laborCostOutputLabel;
        private System.Windows.Forms.Label totalCostTitleLabel;
        private System.Windows.Forms.Label totalCostOutputLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox userWidthTextBox;
        private System.Windows.Forms.TextBox userLengthTextBox;
        private System.Windows.Forms.TextBox userDepthTextBox;
        private System.Windows.Forms.TextBox userMaterialPriceTextBox;
        private System.Windows.Forms.TextBox excavationTextBox;
        private System.Windows.Forms.TextBox divingBoardTextBox;
    }
}

