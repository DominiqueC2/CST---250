/*
 * Dominique Canada
 * CST - 250
 * 03/20/2026
 * Pizza Maker
 * Activity 4
 */
using PizzaMakerClassLibrary.Models;
using PizzaMakerClassLibrary.Services.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PizzaMaker
{
    public partial class FrmOrderDetails : Form
    {
        // Declare class level variables
        private List<PizzaModel> _pizzaOrder;
        private PizzaLogic _pizzaLogic;

        /// <summary>
        /// Parameterized constructor for FrmOrderDetails
        /// </summary>
        /// <param name="pizzaOrderList"></param>
        /// <param name="pizzaBusinessLogic"></param>
        public FrmOrderDetails(List<PizzaModel> pizzaOrderList, PizzaLogic pizzaBusinessLogic)
        {
            // Initialize the form
            InitializeComponent();
            // Initialize the class level variables
            _pizzaOrder = pizzaOrderList;
            _pizzaLogic = pizzaBusinessLogic;
        }

        public void DisplayPizzas()
        {
            //Clear the label 
            lblOrderDetails.Text = "";

            // Loop through the pizza order list
            foreach (PizzaModel pizza in _pizzaOrder)
            {
                lblOrderDetails.Text +=
                    $"Name: {pizza.ClientName}\n" +
                $"Ingredients: {string.Join(", ", pizza.Ingredients)}\n" +
                $"Strange Add Ons: {string.Join(", ", pizza.StrangeAddOns)}\n" +
                $"Crust: {pizza.Crust}\n" +
                $"Sauce: {pizza.SauceQty}\n" +
                $"Cheese: {pizza.CheeseQty}\n" +
                $"Delivery Time: {pizza.DeliveryTime}\n" +
                $"Pizza Box Color: {pizza.PizzaBoxColor}\n" +
                $"Price: {pizza.Price}\n\n";
            }
        }

        /// <summary>
        /// Click event Handler for btnsaveorder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveOrderClickEH(object sender, EventArgs e)
        {
            // Declare & Initialize
            bool isSaveSuccess = false;

            // Write the order to the file  
            isSaveSuccess = _pizzaLogic.WriteOrderToFile();

            // Check if the save was successfull
            if (isSaveSuccess)
            {
                // Show a success message to the user 
                MessageBox.Show("The Pizza order was saved.");
            }
            else
            {
                // Show a failure message to the user 
                MessageBox.Show("An error occurred while trying to save your order. Please try again later.");
            }
        }

        private void BtnBackClickEH(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
