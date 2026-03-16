using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

/*
 * Dominique Canada
 * CST - 250
 * 03/13/2026
 * Flood Fill Recursion
 * Activity 3
 */

namespace FloodFillRecursion.Models
{
    internal class BoardModel
    {
  
            // BoardModel Properties
            public int Size { get; set; }
            public  CellModel[,] Grid { get; set; }
            public int NumShapes { get; set; }

        /// <summary>
        /// Parameterized construtor for BoardModel
        /// </summary>
        /// <param name="size"></param>
        /// <param name="numShapes"></param>
        public BoardModel(int size, int numShapes)
        {
            Size = size;
            NumShapes = numShapes;
            Grid = new CellModel[Size, Size];
            //set up the grid
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    Grid[row, col] = new CellModel(row, col, "E");
                }
            }
            //Place random shapes on the board
            PlacesShapes();
        }

        public void PlacesShapes()
        {
            // Declare & Intialize
            // Random object to generate numbers
            Random random = new Random();
            int shapesSize= Size / 2, row = 0, col = 0;

            // Create three shapes
            for (int shapes = 0; shapes < NumShapes; shapes++)
            {
                //Generate the row and col for the
                //top left corner of the square
                row = random.Next(0, Size - shapesSize + 1);
                col = random.Next(0, Size - shapesSize + 1);
                for(int offset = 0; offset < shapesSize; offset++)
                {
                    //Top Wall
                    //Grid[row, col + offset].Contents = "W";
                    //Bottom Wall
                    //Grid[row + shapesSize - 1, col + offset].Contents = "W";
                    //Left Wall
                    //Grid[row + offset, col].Contents = "W";
                    //Right Wall
                    //Grid[row + offset, col + shapesSize - 1].Contents = "W";

                    //Triangles
                    Grid[row + offset, col].Contents = "W";
                    Grid[row + shapesSize - 1, col + offset].Contents = "W";
                    Grid[row + offset, col + offset].Contents = "W";
                }
            }
        }// End of PlacesShapes method

    }
}
