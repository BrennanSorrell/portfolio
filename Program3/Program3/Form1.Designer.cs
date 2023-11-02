
namespace Program3
{
    partial class Program3
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
            this.CityLbl = new System.Windows.Forms.Label();
            this.EntreeItemNumberLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.InititalCostLbl = new System.Windows.Forms.Label();
            this.AdjustedCostLbl = new System.Windows.Forms.Label();
            this.ShipmentCostLbl = new System.Windows.Forms.Label();
            this.TotalPriceLbl = new System.Windows.Forms.Label();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.EntreeItemNumberInput = new System.Windows.Forms.TextBox();
            this.QuantityInput = new System.Windows.Forms.TextBox();
            this.InititalCostOutput = new System.Windows.Forms.Label();
            this.AdjustedCostOutput = new System.Windows.Forms.Label();
            this.ShipmentCostOutput = new System.Windows.Forms.Label();
            this.TotalPriceOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CityLbl
            // 
            this.CityLbl.AutoSize = true;
            this.CityLbl.Location = new System.Drawing.Point(86, 15);
            this.CityLbl.Name = "CityLbl";
            this.CityLbl.Size = new System.Drawing.Size(27, 13);
            this.CityLbl.TabIndex = 0;
            this.CityLbl.Text = "City:";
            // 
            // EntreeItemNumberLbl
            // 
            this.EntreeItemNumberLbl.AutoSize = true;
            this.EntreeItemNumberLbl.Location = new System.Drawing.Point(7, 45);
            this.EntreeItemNumberLbl.Name = "EntreeItemNumberLbl";
            this.EntreeItemNumberLbl.Size = new System.Drawing.Size(106, 13);
            this.EntreeItemNumberLbl.TabIndex = 1;
            this.EntreeItemNumberLbl.Text = "Entree/Item Number:";
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Location = new System.Drawing.Point(14, 77);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(99, 13);
            this.QuantityLbl.TabIndex = 2;
            this.QuantityLbl.Text = "Quantity (Servings):";
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(139, 100);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 3;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // InititalCostLbl
            // 
            this.InititalCostLbl.AutoSize = true;
            this.InititalCostLbl.Location = new System.Drawing.Point(52, 171);
            this.InititalCostLbl.Name = "InititalCostLbl";
            this.InititalCostLbl.Size = new System.Drawing.Size(61, 13);
            this.InititalCostLbl.TabIndex = 4;
            this.InititalCostLbl.Text = "Initital Cost:";
            // 
            // AdjustedCostLbl
            // 
            this.AdjustedCostLbl.AutoSize = true;
            this.AdjustedCostLbl.Location = new System.Drawing.Point(38, 208);
            this.AdjustedCostLbl.Name = "AdjustedCostLbl";
            this.AdjustedCostLbl.Size = new System.Drawing.Size(75, 13);
            this.AdjustedCostLbl.TabIndex = 5;
            this.AdjustedCostLbl.Text = "Adjusted Cost:";
            // 
            // ShipmentCostLbl
            // 
            this.ShipmentCostLbl.AutoSize = true;
            this.ShipmentCostLbl.Location = new System.Drawing.Point(35, 245);
            this.ShipmentCostLbl.Name = "ShipmentCostLbl";
            this.ShipmentCostLbl.Size = new System.Drawing.Size(78, 13);
            this.ShipmentCostLbl.TabIndex = 6;
            this.ShipmentCostLbl.Text = "Shipment Cost:";
            // 
            // TotalPriceLbl
            // 
            this.TotalPriceLbl.AutoSize = true;
            this.TotalPriceLbl.Location = new System.Drawing.Point(52, 282);
            this.TotalPriceLbl.Name = "TotalPriceLbl";
            this.TotalPriceLbl.Size = new System.Drawing.Size(61, 13);
            this.TotalPriceLbl.TabIndex = 7;
            this.TotalPriceLbl.Text = "Total Price:";
            // 
            // CityComboBox
            // 
            this.CityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Items.AddRange(new object[] {
            "Louisville",
            "Lexington",
            "Indianapolis",
            "Nashville"});
            this.CityComboBox.Location = new System.Drawing.Point(119, 12);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(121, 21);
            this.CityComboBox.TabIndex = 8;
            // 
            // EntreeItemNumberInput
            // 
            this.EntreeItemNumberInput.Location = new System.Drawing.Point(119, 42);
            this.EntreeItemNumberInput.Name = "EntreeItemNumberInput";
            this.EntreeItemNumberInput.Size = new System.Drawing.Size(121, 20);
            this.EntreeItemNumberInput.TabIndex = 9;
            // 
            // QuantityInput
            // 
            this.QuantityInput.Location = new System.Drawing.Point(119, 74);
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(121, 20);
            this.QuantityInput.TabIndex = 10;
            // 
            // InititalCostOutput
            // 
            this.InititalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InititalCostOutput.Location = new System.Drawing.Point(119, 170);
            this.InititalCostOutput.Name = "InititalCostOutput";
            this.InititalCostOutput.Size = new System.Drawing.Size(121, 20);
            this.InititalCostOutput.TabIndex = 11;
            // 
            // AdjustedCostOutput
            // 
            this.AdjustedCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdjustedCostOutput.Location = new System.Drawing.Point(119, 207);
            this.AdjustedCostOutput.Name = "AdjustedCostOutput";
            this.AdjustedCostOutput.Size = new System.Drawing.Size(121, 20);
            this.AdjustedCostOutput.TabIndex = 12;
            // 
            // ShipmentCostOutput
            // 
            this.ShipmentCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShipmentCostOutput.Location = new System.Drawing.Point(119, 244);
            this.ShipmentCostOutput.Name = "ShipmentCostOutput";
            this.ShipmentCostOutput.Size = new System.Drawing.Size(121, 20);
            this.ShipmentCostOutput.TabIndex = 13;
            // 
            // TotalPriceOutput
            // 
            this.TotalPriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPriceOutput.Location = new System.Drawing.Point(119, 281);
            this.TotalPriceOutput.Name = "TotalPriceOutput";
            this.TotalPriceOutput.Size = new System.Drawing.Size(121, 20);
            this.TotalPriceOutput.TabIndex = 14;
            // 
            // Program3
            // 
            this.AcceptButton = this.CalcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 320);
            this.Controls.Add(this.TotalPriceOutput);
            this.Controls.Add(this.ShipmentCostOutput);
            this.Controls.Add(this.AdjustedCostOutput);
            this.Controls.Add(this.InititalCostOutput);
            this.Controls.Add(this.QuantityInput);
            this.Controls.Add(this.EntreeItemNumberInput);
            this.Controls.Add(this.CityComboBox);
            this.Controls.Add(this.TotalPriceLbl);
            this.Controls.Add(this.ShipmentCostLbl);
            this.Controls.Add(this.AdjustedCostLbl);
            this.Controls.Add(this.InititalCostLbl);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.EntreeItemNumberLbl);
            this.Controls.Add(this.CityLbl);
            this.Name = "Program3";
            this.Text = "uThankItWeMakeIt Cost Calculator";
            this.Load += new System.EventHandler(this.Program3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CityLbl;
        private System.Windows.Forms.Label EntreeItemNumberLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label InititalCostLbl;
        private System.Windows.Forms.Label AdjustedCostLbl;
        private System.Windows.Forms.Label ShipmentCostLbl;
        private System.Windows.Forms.Label TotalPriceLbl;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.TextBox EntreeItemNumberInput;
        private System.Windows.Forms.TextBox QuantityInput;
        private System.Windows.Forms.Label InititalCostOutput;
        private System.Windows.Forms.Label AdjustedCostOutput;
        private System.Windows.Forms.Label ShipmentCostOutput;
        private System.Windows.Forms.Label TotalPriceOutput;
    }
}

