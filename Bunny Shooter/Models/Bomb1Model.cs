using Bunny_Shooter.Interfaces;
using System;
using System.IO;

namespace Bunny_Shooter.Models
{
    public class Bomb1Model : ElementModel, IElementMovement
    {
        private const string NAME = "Bomb1";
        private const string IMAGE_PATH = "Bomb1.png";
        public Bomb1Model(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate, NAME, Path.GetFullPath($@"Assets\{IMAGE_PATH}")) { }

        public void MoveElement()
        {
            
        }
    }
}