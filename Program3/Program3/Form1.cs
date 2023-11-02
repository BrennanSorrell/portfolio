// Grading ID: S5040
// Program 3
// Due Nov 11th
// CIS 199-50-4218
// This program computes the prices for a company who sells food.
using System;
using System.Windows.Forms;

namespace Program3
{
    public partial class Program3 : Form
    {
        public Program3()
        {
            InitializeComponent();
        }

        private void Program3_Load(object sender, EventArgs e)
        {

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            if (CityComboBox.SelectedIndex < 0) // checking to see if city was picked in the combo box
            {
                MessageBox.Show("Please Select A City!"); // message to tell them to pick a city
            }
            int itemNum, servings = 0; // declaring int to = 0, to use in statements if the wrong/no number is entered
            string item = EntreeItemNumberInput.Text; // setting item to a string and getting the item number from what the user entered
            bool successItem = Int32.TryParse(item, out itemNum); // setting successItem to a bool and parseing item to get the int itemNum
            string quantity = QuantityInput.Text; // setting quantity to a string and getting the input from the user
            bool successQuantity = Int32.TryParse(quantity, out servings); // setting successQuantity to a bool and parseing quantity to get the int servings
            double inititalCost, servingNum; // declaring doubles
            if (successItem) // seeing if the successItem variable to know if they entered a number
            {
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Entree/Item Number! (Numbers Only)"); // shows if there is nothing entered / letters entered
            }
            if (successQuantity) // seeing if the successQuantity variable to know if they entered a number
            {
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Quantity! (Mumbers Only)"); // shows if there is nothing entered / lettered entered
            }
            if (itemNum < 10001 || itemNum > 10007) // ensures the number is acceptable on the menu
            {
                MessageBox.Show("Please Enter A Number 10001-10007!"); // shows if number is not accepetable
            }
            if (servings <= 0) // ensures the number of servings is acceptable
            {
                MessageBox.Show("Please Enter A Number Above 0!"); // shows if number is not acceptable
            }
            servingNum = Convert.ToDouble(QuantityInput.Text); // gathering the servings from input
            int[] entreeNum = new int[7] { 10001, 10002, 10003, 10004, 10005, 10006, 10007 }; // parralel array for the entree num
            double[] entreePrice = new double[7] { 7.87, 9.51, 10.73, 9.99, 11.99, 5, 4.58 }; // parralel array for the entree price
            int itemOrdered; // delcaring int
            double itemPrice = 0; // declaring itemPrice = 0
            bool isValidItem = false; // setting a bool up to make sure item is valid
            double adjustedCost; // declaring double
            const double serviceFee5 = 0.15; // setting const for the service fees
            const double serviceFee10 = 0.10; // setting const for the service fees
            const double serviceFee20 = 0.05; // setting const for the service fees
            itemOrdered = Convert.ToInt32(EntreeItemNumberInput.Text); // getting entree num from input from user
            for (int x = 0; x < entreeNum.Length; x++) // matching what was entered in the array
            {
                if (itemOrdered == entreeNum[x]) // matching what was entered in the array
                {
                    isValidItem = true; // setting the bool to true
                    itemPrice = entreePrice[x]; // turning the matched quantity into a variable i can use
                }
            }
            if (isValidItem) // since they valid item is true
            {
                inititalCost = itemPrice * servingNum; // we get the initialCost from multiplying item price by the serving number
                InititalCostOutput.Text = $"{inititalCost:C}"; // we display the initial cost as currency in the output label
                if (servingNum >= 0 && servingNum <= 5) // determing the serving size for the fees
                {
                    adjustedCost = inititalCost * serviceFee5; // finding the adjusted cost for 0-5 servings
                    double a = adjustedCost + inititalCost; // doubling a to display the adjusted cost
                    AdjustedCostOutput.Text = $"{a:C}"; // diplaying the adjustedcost into the output label
                    string[] city = new string[4] { "Louisville", "Lexington", "Indianapolis", "Nashville" }; // making arrays for the combo box input city
                    double[] shipmentFee = new double[4] { .06, 0.0717, 0.07, 0.0874 }; // making the array for the city shipment fees
                    double shipmentFeeTotal; // declaring double
                    string statePicked; // declaring string
                    double shipmentFees, totalCost; // declaring double
                    bool isValidState = false; // setting the bool isValidState to false
                    statePicked = CityComboBox.Text; // getting the string statePicked from the combo box
                    for (int i = 0; i < city.Length; i++) // finding the inputed city to match the array and get the shipment fees
                    {
                        if (statePicked == city[i]) // matching the city picked
                        {
                            isValidState = true; // setting valid state to true
                            shipmentFees = shipmentFee[i]; // setting shipmentfee to the double shipment fees which i can use
                            shipmentFeeTotal = a * shipmentFees; // getting the shipment fee total from adjusted cost * the shipment fees
                            ShipmentCostOutput.Text = $"{shipmentFeeTotal:C}"; // displaying the shipment fee total into the label output box
                            totalCost = a + shipmentFeeTotal; // calculating total cost
                            TotalPriceOutput.Text = $"{totalCost:C}"; // displaying the total cost into the output label box
                        }
                    }
                }
                else if (servingNum >= 6 && servingNum <= 10) // determing the serving size for the fees
                {
                    adjustedCost = inititalCost * serviceFee10; // finding the adjusted cost for 6-10 servings
                    double a = adjustedCost + inititalCost; // doubling a to display the adjusted cost
                    AdjustedCostOutput.Text = $"{a:C}"; // diplaying the adjustedcost into the output label
                    string[] city = new string[4] { "Louisville", "Lexington", "Indianapolis", "Nashville" }; // making arrays for the combo box input city
                    double[] shipmentFee = new double[4] { .06, 0.0717, 0.07, 0.0874 }; // making the array for the city shipment fees
                    double shipmentFeeTotal; // declaring double
                    string statePicked; // declaring string
                    double shipmentFees, totalCost; // declaring double
                    bool isValidState = false; // setting the bool isValidState to false
                    statePicked = CityComboBox.Text; // getting the string statePicked from the combo box
                    for (int i = 0; i < city.Length; i++) // finding the inputed city to match the array and get the shipment fees
                    {
                        if (statePicked == city[i]) // matching the city picked
                        {
                            isValidState = true; // setting valid state to true
                            shipmentFees = shipmentFee[i]; // setting shipmentfee to the double shipment fees which i can use
                            shipmentFeeTotal = a * shipmentFees; // getting the shipment fee total from adjusted cost * the shipment fees
                            ShipmentCostOutput.Text = $"{shipmentFeeTotal:C}"; // displaying the shipment fee total into the label output box
                            totalCost = a + shipmentFeeTotal; // calculating total cost
                            TotalPriceOutput.Text = $"{totalCost:C}"; // displaying the total cost into the output label box
                        }
                    }
                }
                else if (servingNum >= 11 && servingNum <= 20) // determing the serving size for the fees
                {
                    adjustedCost = inititalCost * serviceFee20; // finding the adjusted cost for 11-20 servings
                    double a = adjustedCost + inititalCost; // doubling a to display the adjusted cost
                    AdjustedCostOutput.Text = $"{a:C}"; // diplaying the adjustedcost into the output label
                    string[] city = new string[4] { "Louisville", "Lexington", "Indianapolis", "Nashville" }; // making arrays for the combo box input city
                    double[] shipmentFee = new double[4] { .06, 0.0717, 0.07, 0.0874 }; // making the array for the city shipment fees
                    double shipmentFeeTotal; // declaring double
                    string statePicked; // declaring string
                    double shipmentFees, totalCost; // declaring double
                    bool isValidState = false; // setting the bool isValidState to false
                    statePicked = CityComboBox.Text; // getting the string statePicked from the combo box
                    for (int i = 0; i < city.Length; i++) // finding the inputed city to match the array and get the shipment fees
                    {
                        if (statePicked == city[i]) // matching the city picked
                        {
                            isValidState = true; // setting valid state to true
                            shipmentFees = shipmentFee[i]; // setting shipmentfee to the double shipment fees which i can use
                            shipmentFeeTotal = a * shipmentFees; // getting the shipment fee total from adjusted cost * the shipment fees
                            ShipmentCostOutput.Text = $"{shipmentFeeTotal:C}"; // displaying the shipment fee total into the label output box
                            totalCost = a + shipmentFeeTotal; // calculating total cost
                            TotalPriceOutput.Text = $"{totalCost:C}"; // displaying the total cost into the output label box
                        }
                    }
                }
                else if (servingNum >= 21) // determing the serving size for the fees
                {
                    AdjustedCostOutput.Text = $"{inititalCost:C}"; // diplaying the adjustedcost into the output label
                    string[] city = new string[4] { "Louisville", "Lexington", "Indianapolis", "Nashville" }; // making arrays for the combo box input city
                    double[] shipmentFee = new double[4] { .06, 0.0717, 0.07, 0.0874 }; // making the array for the city shipment fees
                    double shipmentFeeTotal; // declaring double
                    string statePicked; // declaring string
                    double shipmentFees, totalCost; // declaring double
                    bool isValidState = false; // setting the bool isValidState to false
                    statePicked = CityComboBox.Text; // getting the string statePicked from the combo box
                    for (int i = 0; i < city.Length; i++) // finding the inputed city to match the array and get the shipment fees
                    {
                        if (statePicked == city[i]) // matching the city picked
                        {
                            isValidState = true; // setting valid state to true
                            shipmentFees = shipmentFee[i]; // setting shipmentfee to the double shipment fees which i can use
                            shipmentFeeTotal = inititalCost * shipmentFees; // getting the shipment fee total from adjusted cost * the shipment fees
                            ShipmentCostOutput.Text = $"{shipmentFeeTotal:C}"; // displaying the shipment fee total into the label output box
                            totalCost = inititalCost + shipmentFeeTotal; // calculating total cost
                            TotalPriceOutput.Text = $"{totalCost:C}"; // displaying the total cost into the output label box
                        }
                    }
                }
            }
        }
    }
}