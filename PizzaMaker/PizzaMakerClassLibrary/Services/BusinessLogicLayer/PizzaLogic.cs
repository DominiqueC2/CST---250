/*
 * Dominique Canada
 * CST - 250
 * 03/20/2026
 * Pizza Maker
 * Activity 4
 */
using PizzaMakerClassLibrary.Services.DataAccessLayer;
using PizzaMakerClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaMakerClassLibrary.Services.BusinessLogicLayer
{
    public class PizzaLogic
    {
        // Declare class level variables 
        private PizzaDAO _pizzaDAO;

        /// <summary>
        /// Default constructor forPizzaLogic
        /// </summary>
        public PizzaLogic()
        {
            // Initialize the pizza DAO object
            _pizzaDAO = new PizzaDAO();
        }

        /// <summary>
        /// Add a new pizza to the current order
        /// </summary>
        /// <param name="newPizza"></param>
        /// <returns></returns>
        public (bool isValidPizza, int pizzasInOrder) AddPizzaToOrder(PizzaModel newPizza)
        {
            // Declare & Initialize
            int pizzas = -1;

            // Validate pizza

            // Check name
            if (string.IsNullOrEmpty(newPizza.ClientName))
            {
                return (false, 0);
            }

            // Check crust
            if (string.IsNullOrEmpty(newPizza.Crust))
            {
                return (false, 0);
            }

            // Check ingredients
            if (newPizza.Ingredients == null || newPizza.Ingredients.Count == 0)
            {
                return (false, 0);
            }

            // Check cheese
            if (newPizza.CheeseQty <= 0)
            {
                return (false, 0);
            }

            // Check sauce
            if (newPizza.SauceQty <= 0)
            {
                return (false, 0);
            }

            // call the DAO AddpizzatoOrder
            pizzas = _pizzaDAO.AddPizzaToOrder(newPizza);
            // Return the pizzas variable
            return (true, pizzas);
        }

        /// <summary>
        /// Get the list of pizzas in the current order
        /// </summary>
        /// <returns></returns>
        public List<PizzaModel> GetPizzaOrder()
        {
            // Get and return the GetpizzaOrder form the the DAO
            return _pizzaDAO.GetPizzaOrder();
        }

        public bool WriteOrderToFile()
        {
            // Get and return WriteOrderTOFile from DAO
            return _pizzaDAO.WriteOrderToFile();
        }
    }
}
