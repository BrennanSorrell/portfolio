// Grading ID: S5040
// Program 1
// Due Sept 30th
// CIS 199-50-4218
// This program computes any situation a pool company that builds pools the price of said pool.
using System;
using System.Windows.Forms;

namespace Program1
{
    public partial class Program1Form : Form
    {
        private const double wastePercentage = 1.10; // providing a constant for the waste percentage to avoid magic numbers
        private const int cubicConversion = 27; // providing a constant for the cubic conversion to avoid magic numbers
        private const int divingFee = 50; // providing a constant for the diving fee to avoid magic numbers
        private const int excavationCharge = 15; // providing a constant for the excavation charge to avoid magic numbers
        private const double laborFee = 3.25; // providing a constant for the labor fee to avoid magic numbers


        public Program1Form()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e) // this event handler is when the button CalcButton is clicked it runs the code below
        {
            double width, length, depth, volume, price, materialCost, excavationCost, laborCosts, totalCosts; // declaring the double variables used in the form
            int diving; // declaring the int variables used in the form

            width = Convert.ToDouble(WidthInput.Text); // gathering the string that the user puts into the width box and turns it into the double width
            length = Convert.ToDouble(LengthInput.Text); // gathering the string that the user puts into the legnth box and turns it into the double legnth
            depth = Convert.ToDouble(DepthInput.Text); // gathering the string that the user puts into the depth box and turns it into the double depth

            volume = width * length * depth / cubicConversion; // calculates the volume of the pool in cubic yards

            CubicYardsOutput.Text = $"{volume:F1}"; // displays the volume of the pool in cubic yards into the cubicyards output on the form

            price = Convert.ToDouble(MaterialsPriceInput.Text); // gathers the material price that the user inputs and converts it into the price double

            materialCost = price * volume * wastePercentage; // calculating the total cost of materials for the pool + the 10% waste percentage

            MaterialsCostOutput.Text = $"{materialCost:C}"; // displays the total price of materials for the pool on the form in currency

            excavationCost = Convert.ToInt32(ExcavationInput.Text); // gathers the integer that the user put under excavation option in the form and turns it into a integer

            if (excavationCost == 1) // if 1 is entered then it runs the code on line 47
                excavationCost = excavationCharge * volume; // calculates the excavation cost of the pool
            if (excavationCost == 0) // if 0 is selected then it runs the code on line 49
                excavationCost = 0; // if there is no excavation needed then the total amnount would just equal 0 which is shown here.

            EvacationCostOutput.Text = $"{excavationCost:C}"; // displays the excavation cost on the form in currency

            diving = Convert.ToInt32(DivingInput.Text); // gathers the integer that the user put under the diving option in the form and turns it into a integer

            if (diving == 1) // if 1 is entered then it runs the code on line 56
                diving = divingFee; // since the diving fee is 50$ this allocates 50 to the diving double
            if (diving == 0) // if 0 is entered then it runs the code on line 58
                diving = 0; // if there is no diving board needed then the total amnount would just equal 0 which is shown here

            laborCosts = laborFee * volume + diving; // calcuates the labor costs by using the labor fee constant times the volume and if diving board needed plus the 50

            LaborCostOutput.Text = $"{laborCosts:C}"; // displays the calcuated labor costs on the form in currency

            totalCosts = materialCost + excavationCost + laborCosts; // calculating the total costs of the entire price of the company building the pool using the material costs + excavation price + labor costs

            TotalCostOutput.Text = $"{totalCosts:C}"; // displays the total costs under the total cost output on the form in currency









        }
    }
}
