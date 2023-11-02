
namespace Program1
{
    partial class Program1Form
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ExcavationLabel = new System.Windows.Forms.Label();
            this.DivingBoardLabel = new System.Windows.Forms.Label();
            this.CubicYardsLabel = new System.Windows.Forms.Label();
            this.MaterialsCostLabel = new System.Windows.Forms.Label();
            this.ExcavationCostLabel = new System.Windows.Forms.Label();
            this.LaborCostLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.LengthInput = new System.Windows.Forms.TextBox();
            this.DepthInput = new System.Windows.Forms.TextBox();
            this.MaterialsPriceInput = new System.Windows.Forms.TextBox();
            this.ExcavationInput = new System.Windows.Forms.TextBox();
            this.DivingInput = new System.Windows.Forms.TextBox();
            this.CubicYardsOutput = new System.Windows.Forms.Label();
            this.MaterialsCostOutput = new System.Windows.Forms.Label();
            this.EvacationCostOutput = new System.Windows.Forms.Label();
            this.LaborCostOutput = new System.Windows.Forms.Label();
            this.TotalCostOutput = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(98, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(125, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "EZ-Pools Costs Estimator";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(23, 38);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(112, 13);
            this.WidthLabel.TabIndex = 1;
            this.WidthLabel.Text = "Max Width of Pool (ft):";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(18, 67);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(117, 13);
            this.LengthLabel.TabIndex = 2;
            this.LengthLabel.Text = "Max Length of Pool (ft):";
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Location = new System.Drawing.Point(22, 96);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(113, 13);
            this.DepthLabel.TabIndex = 3;
            this.DepthLabel.Text = "Max Depth of Pool (ft):";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(7, 125);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(128, 13);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Materials Price (cubic yd):";
            // 
            // ExcavationLabel
            // 
            this.ExcavationLabel.AutoSize = true;
            this.ExcavationLabel.Location = new System.Drawing.Point(25, 154);
            this.ExcavationLabel.Name = "ExcavationLabel";
            this.ExcavationLabel.Size = new System.Drawing.Size(110, 26);
            this.ExcavationLabel.TabIndex = 5;
            this.ExcavationLabel.Text = "Excavation Needed?:\r\n(1 = YES, 0 = NO)\r\n";
            this.ExcavationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DivingBoardLabel
            // 
            this.DivingBoardLabel.AutoSize = true;
            this.DivingBoardLabel.Location = new System.Drawing.Point(43, 196);
            this.DivingBoardLabel.Name = "DivingBoardLabel";
            this.DivingBoardLabel.Size = new System.Drawing.Size(92, 26);
            this.DivingBoardLabel.TabIndex = 6;
            this.DivingBoardLabel.Text = "Diving Board?:\r\n(1 = YES, 0 = NO)\r\n";
            this.DivingBoardLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CubicYardsLabel
            // 
            this.CubicYardsLabel.AutoSize = true;
            this.CubicYardsLabel.Location = new System.Drawing.Point(68, 238);
            this.CubicYardsLabel.Name = "CubicYardsLabel";
            this.CubicYardsLabel.Size = new System.Drawing.Size(67, 13);
            this.CubicYardsLabel.TabIndex = 7;
            this.CubicYardsLabel.Text = "Cubic Yards:";
            // 
            // MaterialsCostLabel
            // 
            this.MaterialsCostLabel.AutoSize = true;
            this.MaterialsCostLabel.Location = new System.Drawing.Point(59, 267);
            this.MaterialsCostLabel.Name = "MaterialsCostLabel";
            this.MaterialsCostLabel.Size = new System.Drawing.Size(76, 13);
            this.MaterialsCostLabel.TabIndex = 8;
            this.MaterialsCostLabel.Text = "Materials Cost:";
            // 
            // ExcavationCostLabel
            // 
            this.ExcavationCostLabel.AutoSize = true;
            this.ExcavationCostLabel.Location = new System.Drawing.Point(48, 296);
            this.ExcavationCostLabel.Name = "ExcavationCostLabel";
            this.ExcavationCostLabel.Size = new System.Drawing.Size(87, 13);
            this.ExcavationCostLabel.TabIndex = 9;
            this.ExcavationCostLabel.Text = "Excavation Cost:";
            // 
            // LaborCostLabel
            // 
            this.LaborCostLabel.AutoSize = true;
            this.LaborCostLabel.Location = new System.Drawing.Point(74, 325);
            this.LaborCostLabel.Name = "LaborCostLabel";
            this.LaborCostLabel.Size = new System.Drawing.Size(61, 13);
            this.LaborCostLabel.TabIndex = 10;
            this.LaborCostLabel.Text = "Labor Cost:";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostLabel.Location = new System.Drawing.Point(66, 354);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(69, 13);
            this.TotalCostLabel.TabIndex = 11;
            this.TotalCostLabel.Text = "Total Cost:";
            // 
            // WidthInput
            // 
            this.WidthInput.Location = new System.Drawing.Point(141, 35);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(100, 20);
            this.WidthInput.TabIndex = 12;
            // 
            // LengthInput
            // 
            this.LengthInput.Location = new System.Drawing.Point(141, 64);
            this.LengthInput.Name = "LengthInput";
            this.LengthInput.Size = new System.Drawing.Size(100, 20);
            this.LengthInput.TabIndex = 13;
            // 
            // DepthInput
            // 
            this.DepthInput.Location = new System.Drawing.Point(141, 93);
            this.DepthInput.Name = "DepthInput";
            this.DepthInput.Size = new System.Drawing.Size(100, 20);
            this.DepthInput.TabIndex = 14;
            // 
            // MaterialsPriceInput
            // 
            this.MaterialsPriceInput.Location = new System.Drawing.Point(141, 122);
            this.MaterialsPriceInput.Name = "MaterialsPriceInput";
            this.MaterialsPriceInput.Size = new System.Drawing.Size(100, 20);
            this.MaterialsPriceInput.TabIndex = 15;
            // 
            // ExcavationInput
            // 
            this.ExcavationInput.Location = new System.Drawing.Point(141, 151);
            this.ExcavationInput.Name = "ExcavationInput";
            this.ExcavationInput.Size = new System.Drawing.Size(100, 20);
            this.ExcavationInput.TabIndex = 16;
            // 
            // DivingInput
            // 
            this.DivingInput.Location = new System.Drawing.Point(141, 193);
            this.DivingInput.Name = "DivingInput";
            this.DivingInput.Size = new System.Drawing.Size(100, 20);
            this.DivingInput.TabIndex = 17;
            // 
            // CubicYardsOutput
            // 
            this.CubicYardsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CubicYardsOutput.Location = new System.Drawing.Point(141, 237);
            this.CubicYardsOutput.Name = "CubicYardsOutput";
            this.CubicYardsOutput.Size = new System.Drawing.Size(100, 20);
            this.CubicYardsOutput.TabIndex = 18;
            // 
            // MaterialsCostOutput
            // 
            this.MaterialsCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaterialsCostOutput.Location = new System.Drawing.Point(141, 266);
            this.MaterialsCostOutput.Name = "MaterialsCostOutput";
            this.MaterialsCostOutput.Size = new System.Drawing.Size(100, 20);
            this.MaterialsCostOutput.TabIndex = 19;
            // 
            // EvacationCostOutput
            // 
            this.EvacationCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EvacationCostOutput.Location = new System.Drawing.Point(141, 295);
            this.EvacationCostOutput.Name = "EvacationCostOutput";
            this.EvacationCostOutput.Size = new System.Drawing.Size(100, 20);
            this.EvacationCostOutput.TabIndex = 20;
            // 
            // LaborCostOutput
            // 
            this.LaborCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LaborCostOutput.Location = new System.Drawing.Point(141, 324);
            this.LaborCostOutput.Name = "LaborCostOutput";
            this.LaborCostOutput.Size = new System.Drawing.Size(100, 20);
            this.LaborCostOutput.TabIndex = 21;
            // 
            // TotalCostOutput
            // 
            this.TotalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCostOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostOutput.Location = new System.Drawing.Point(141, 353);
            this.TotalCostOutput.Name = "TotalCostOutput";
            this.TotalCostOutput.Size = new System.Drawing.Size(100, 20);
            this.TotalCostOutput.TabIndex = 22;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(88, 393);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(144, 23);
            this.CalcButton.TabIndex = 23;
            this.CalcButton.Text = "Calculate Estimate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // Program1Form
            // 
            this.AcceptButton = this.CalcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.TotalCostOutput);
            this.Controls.Add(this.LaborCostOutput);
            this.Controls.Add(this.EvacationCostOutput);
            this.Controls.Add(this.MaterialsCostOutput);
            this.Controls.Add(this.CubicYardsOutput);
            this.Controls.Add(this.DivingInput);
            this.Controls.Add(this.ExcavationInput);
            this.Controls.Add(this.MaterialsPriceInput);
            this.Controls.Add(this.DepthInput);
            this.Controls.Add(this.LengthInput);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.LaborCostLabel);
            this.Controls.Add(this.ExcavationCostLabel);
            this.Controls.Add(this.MaterialsCostLabel);
            this.Controls.Add(this.CubicYardsLabel);
            this.Controls.Add(this.DivingBoardLabel);
            this.Controls.Add(this.ExcavationLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Program1Form";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ExcavationLabel;
        private System.Windows.Forms.Label DivingBoardLabel;
        private System.Windows.Forms.Label CubicYardsLabel;
        private System.Windows.Forms.Label MaterialsCostLabel;
        private System.Windows.Forms.Label ExcavationCostLabel;
        private System.Windows.Forms.Label LaborCostLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.TextBox WidthInput;
        private System.Windows.Forms.TextBox LengthInput;
        private System.Windows.Forms.TextBox DepthInput;
        private System.Windows.Forms.TextBox MaterialsPriceInput;
        private System.Windows.Forms.TextBox ExcavationInput;
        private System.Windows.Forms.TextBox DivingInput;
        private System.Windows.Forms.Label CubicYardsOutput;
        private System.Windows.Forms.Label MaterialsCostOutput;
        private System.Windows.Forms.Label EvacationCostOutput;
        private System.Windows.Forms.Label LaborCostOutput;
        private System.Windows.Forms.Label TotalCostOutput;
        private System.Windows.Forms.Button CalcButton;
    }
}

